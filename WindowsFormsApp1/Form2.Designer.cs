namespace WindowsFormsApp1 {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.imgview = new LotusAPI.Controls.FastImageView();
            this.logView1 = new LotusAPI.Controls.LogView();
            this.flatPanel1 = new Abeo.Controls.FlatPanel();
            this.roundButton1 = new Abeo.Controls.Roundable.RoundButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eimgview = new LotusAPI.Controls.FastImageView();
            this.cimgview = new LotusAPI.Controls.FastImageView();
            this.gimgview = new LotusAPI.Controls.FastImageView();
            this.iv1 = new LotusAPI.Controls.FastImageView();
            this.iv2 = new LotusAPI.Controls.FastImageView();
            ((System.ComponentModel.ISupportInitialize)(this.imgview)).BeginInit();
            this.flatPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eimgview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cimgview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimgview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iv2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgview
            // 
            this.imgview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgview.DrawFPS = false;
            this.imgview.EnablePanZoom = true;
            this.imgview.FrameRate = 60;
            this.imgview.Location = new System.Drawing.Point(4, 5);
            this.imgview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgview.Name = "imgview";
            this.imgview.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.imgview.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.imgview.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.imgview.ShowCrossHair = false;
            this.imgview.ShowDebugInfo = false;
            this.imgview.ShowImageBorder = true;
            this.imgview.ShowPixelInfo = false;
            this.imgview.Size = new System.Drawing.Size(341, 256);
            this.imgview.TabIndex = 0;
            this.imgview.UseCustomMouseEvent = false;
            this.imgview.ZoomPanModifierKey = System.Windows.Forms.Keys.None;
            // 
            // logView1
            // 
            this.logView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.logView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logView1.ColorDateTime = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.logView1.ColorDebug = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.logView1.ColorError = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.logView1.ColorFatal = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.logView1.ColorInfo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.logView1.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.logView1.ColorTrace = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.logView1.ColorWarning = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.logView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logView1.Font = new System.Drawing.Font("Consolas", 9F);
            this.logView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.logView1.LineBuffer = 1000;
            this.logView1.Location = new System.Drawing.Point(0, 586);
            this.logView1.Name = "logView1";
            this.logView1.ReadOnly = true;
            this.logView1.ShowDateTime = true;
            this.logView1.Size = new System.Drawing.Size(1050, 156);
            this.logView1.TabIndex = 1;
            this.logView1.Text = "";
            this.logView1.UpdateInterval = 100;
            // 
            // flatPanel1
            // 
            this.flatPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flatPanel1.Controls.Add(this.roundButton1);
            this.flatPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatPanel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatPanel1.Location = new System.Drawing.Point(0, 0);
            this.flatPanel1.Name = "flatPanel1";
            this.flatPanel1.Size = new System.Drawing.Size(1050, 53);
            this.flatPanel1.TabIndex = 2;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.roundButton1.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.roundButton1.BorderRadius = 3;
            this.roundButton1.BorderThickness = 0;
            this.roundButton1.Checked = false;
            this.roundButton1.CheckEnable = false;
            this.roundButton1.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundButton1.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.roundButton1.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundButton1.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.roundButton1.ControlToBringToFront = null;
            this.roundButton1.DebugMode = false;
            this.roundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roundButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundButton1.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundButton1.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundButton1.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundButton1.Icon = null;
            this.roundButton1.IconPortion = 0.3F;
            this.roundButton1.IconSize = 24;
            this.roundButton1.IconVisible = false;
            this.roundButton1.Image = null;
            this.roundButton1.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.roundButton1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.roundButton1.IsExclusive = false;
            this.roundButton1.Location = new System.Drawing.Point(3, 3);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(110, 47);
            this.roundButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.roundButton1.TabIndex = 0;
            this.roundButton1.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.roundButton1.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.roundButton1.TagOffset = 5;
            this.roundButton1.TagVisible = false;
            this.roundButton1.TagWidth = 5;
            this.roundButton1.Text = "LoadImage";
            this.roundButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundButton1.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.imgview, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gimgview, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.eimgview, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cimgview, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.iv1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.iv2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 533);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // eimgview
            // 
            this.eimgview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eimgview.DrawFPS = false;
            this.eimgview.EnablePanZoom = true;
            this.eimgview.FrameRate = 60;
            this.eimgview.Location = new System.Drawing.Point(4, 271);
            this.eimgview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eimgview.Name = "eimgview";
            this.eimgview.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.eimgview.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.eimgview.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.eimgview.ShowCrossHair = false;
            this.eimgview.ShowDebugInfo = false;
            this.eimgview.ShowImageBorder = true;
            this.eimgview.ShowPixelInfo = false;
            this.eimgview.Size = new System.Drawing.Size(341, 257);
            this.eimgview.TabIndex = 0;
            this.eimgview.UseCustomMouseEvent = false;
            this.eimgview.ZoomPanModifierKey = System.Windows.Forms.Keys.None;
            // 
            // cimgview
            // 
            this.cimgview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cimgview.DrawFPS = false;
            this.cimgview.EnablePanZoom = true;
            this.cimgview.FrameRate = 60;
            this.cimgview.Location = new System.Drawing.Point(353, 271);
            this.cimgview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cimgview.Name = "cimgview";
            this.cimgview.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.cimgview.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.cimgview.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.cimgview.ShowCrossHair = false;
            this.cimgview.ShowDebugInfo = false;
            this.cimgview.ShowImageBorder = true;
            this.cimgview.ShowPixelInfo = false;
            this.cimgview.Size = new System.Drawing.Size(341, 257);
            this.cimgview.TabIndex = 0;
            this.cimgview.UseCustomMouseEvent = false;
            this.cimgview.ZoomPanModifierKey = System.Windows.Forms.Keys.None;
            // 
            // gimgview
            // 
            this.gimgview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gimgview.DrawFPS = false;
            this.gimgview.EnablePanZoom = true;
            this.gimgview.FrameRate = 60;
            this.gimgview.Location = new System.Drawing.Point(353, 5);
            this.gimgview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gimgview.Name = "gimgview";
            this.gimgview.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.gimgview.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.gimgview.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.gimgview.ShowCrossHair = false;
            this.gimgview.ShowDebugInfo = false;
            this.gimgview.ShowImageBorder = true;
            this.gimgview.ShowPixelInfo = false;
            this.gimgview.Size = new System.Drawing.Size(341, 256);
            this.gimgview.TabIndex = 0;
            this.gimgview.UseCustomMouseEvent = false;
            this.gimgview.ZoomPanModifierKey = System.Windows.Forms.Keys.None;
            // 
            // iv1
            // 
            this.iv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iv1.DrawFPS = false;
            this.iv1.EnablePanZoom = true;
            this.iv1.FrameRate = 60;
            this.iv1.Location = new System.Drawing.Point(702, 5);
            this.iv1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iv1.Name = "iv1";
            this.iv1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.iv1.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.iv1.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.iv1.ShowCrossHair = false;
            this.iv1.ShowDebugInfo = false;
            this.iv1.ShowImageBorder = true;
            this.iv1.ShowPixelInfo = false;
            this.iv1.Size = new System.Drawing.Size(344, 256);
            this.iv1.TabIndex = 0;
            this.iv1.UseCustomMouseEvent = false;
            this.iv1.ZoomPanModifierKey = System.Windows.Forms.Keys.None;
            // 
            // iv2
            // 
            this.iv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iv2.DrawFPS = false;
            this.iv2.EnablePanZoom = true;
            this.iv2.FrameRate = 60;
            this.iv2.Location = new System.Drawing.Point(702, 271);
            this.iv2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iv2.Name = "iv2";
            this.iv2.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.iv2.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.iv2.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.iv2.ShowCrossHair = false;
            this.iv2.ShowDebugInfo = false;
            this.iv2.ShowImageBorder = true;
            this.iv2.ShowPixelInfo = false;
            this.iv2.Size = new System.Drawing.Size(344, 257);
            this.iv2.TabIndex = 0;
            this.iv2.UseCustomMouseEvent = false;
            this.iv2.ZoomPanModifierKey = System.Windows.Forms.Keys.None;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1050, 742);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flatPanel1);
            this.Controls.Add(this.logView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.imgview)).EndInit();
            this.flatPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eimgview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cimgview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimgview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LotusAPI.Controls.FastImageView imgview;
        private LotusAPI.Controls.LogView logView1;
        private Abeo.Controls.FlatPanel flatPanel1;
        private Abeo.Controls.Roundable.RoundButton roundButton1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LotusAPI.Controls.FastImageView eimgview;
        private LotusAPI.Controls.FastImageView gimgview;
        private LotusAPI.Controls.FastImageView cimgview;
        private LotusAPI.Controls.FastImageView iv1;
        private LotusAPI.Controls.FastImageView iv2;
    }
}