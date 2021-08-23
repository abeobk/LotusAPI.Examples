using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Img = LotusAPI.MV.Image;

namespace WindowsFormsApp1 {
    public partial class Form2 : Form {

        Img _img = new Img();

        public Form2() {
            InitializeComponent();

            Registry.SetApplicationName("Abeosystem\\Example\\Vision2D");

            //setup logger
            Logger.Add(new LogViewLogger(logView1));

            Library.Initialize();


        }

        private void roundButton1_Click(object sender, EventArgs e) {
            try {
                _img = DialogUtils.OpenImage();
                if(_img == null)
                    throw new Exception("Empty image");

                //convert to gray scale image
                //var gimg = _img.ToGray();

                ////smooth 
                //var simg = gimg.Smooth(LotusAPI.MV.SmoothMethod.Gaussian, 3);

                ////edge detection
                //var eimg = simg.Canny(50, 100);

                ////split original image to 3 chanels

                ////var ch_imgs = _img.Split(); //B G R
                ////ch_imgs[1] = ch_imgs[1]*0.5 +_img  eimg;

                ////merge back
                ////var cimg = Img.Merge(ch_imgs);



                ////and display
                //gimgview.SetImage(gimg);
                //eimgview.SetImage(eimg);
                //imgview.SetImage(_img);
                //cimgview.SetImage(cimg);

                //smooth  image
                _img = _img.Smooth(LotusAPI.MV.SmoothMethod.Gaussian, 2);

                //change RGB to HSV

                var hsv = _img.ToHSV();
                var chs = hsv.Split();

                var hue = chs[0];
                //threshold
                var red_img = hue < 10;
                //morphology
                var dimg = red_img.Dilate(LotusAPI.MV.MorphShape.Rect, 10);
                dimg = dimg.Erode(LotusAPI.MV.MorphShape.Rect, 10);

                //find contours
                var contours = dimg.FindContour(100);

                foreach(var contour in contours) {

                    _img.DrawPoly(contour.ToList().Select(x => (Point2i)x).ToArray(),
                        Color.Lime, 2, true);

                    var sumx = contour.Sum(x => x.X);
                    var sumy = contour.Sum(x => x.Y);
                    var cx = sumx / contour.Length;
                    var cy = sumy / contour.Length;
                    _img.DrawSymbol(LotusAPI.MV.SymbolShape.Cross, new Point2f(cx, cy), 10, Color.Lime);
                    var minx = contour.Min(x => x.X);
                    var maxx = contour.Max(x => x.X);
                    var miny = contour.Min(x => x.Y);
                    var maxy = contour.Max(x => x.Y);
                    var rect = new RectangleF(minx, miny, maxx - minx, maxy - miny);
                    _img.DrawRectangle(rect, Color.Magenta);
                }


                imgview.SetImage(_img);
                gimgview.SetImage(chs[0]);
                eimgview.SetImage(chs[1]);
                cimgview.SetImage(chs[2]);
                iv1.SetImage(red_img);
                iv2.SetImage(dimg);

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }
    }
}
