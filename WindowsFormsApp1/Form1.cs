using LotusAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, EventArgs e) {
            try {
                //setup data table
                DataTable dt = new DataTable();

                dt.Columns.AddRange(new DataColumn[] {
                    new DataColumn("X",typeof(double)),
                    new DataColumn("Y",typeof(double)),
                    new DataColumn("Type",typeof(string)),
                });

                Random rng = new Random();
                for(int i = 0; i < 10; i++) {
                    var row = dt.NewRow();
                    row[0] = i;
                    row[1] = Math.Sin(i * 0.01);
                    row[2] = (new string[] {"A","B","C","D","E" })[rng.Next() % 5];
                    dt.Rows.Add(row);
                }


                lv.ColorMaps = new List<Abeo.Controls.ColorMap> {
                    new Abeo.Controls.ColorMap{
                        ColumnName = "Y",
                        Condition = Abeo.Controls.ColorMap.ConditionType.Greater,
                        Value = "0.8",
                        BackColor = Color.Red,
                        ForeColor = Color.White
                    },

                    new Abeo.Controls.ColorMap{
                        ColumnName = "Y",
                        Condition = Abeo.Controls.ColorMap.ConditionType.Less,
                        Value = "0.2",
                        BackColor = Color.Lime
                    },
                    new Abeo.Controls.ColorMap{
                        ColumnName = "Y",
                        Condition = Abeo.Controls.ColorMap.ConditionType.Between,
                        Value = "0.4;0.5",
                        BackColor = Color.Yellow
                    }
                };

                lv.DataSource = dt;
                lv.UpdateColor();

                chart.BindData(dt, "X");
                // A  B  C  D  E
                // 10 20 30 40 54
                pie.BindData(dt);
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        private void lv_ItemDoubleClickEvent(Abeo.Controls.FlatListView sender,
            Abeo.Controls.FlatListView.ItemDoubleClickEventArgs e) {
            DialogUtils.ShowInfoMsg($"Y={e.SelectedRow["Y"]}");
        }
    }
}
