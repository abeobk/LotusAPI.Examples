namespace WindowsFormsApp1 {
    partial class Form1 {
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
            this.lv = new Abeo.Controls.FlatListView();
            this.flatButton1 = new Abeo.Controls.FlatButton();
            this.chart = new Abeo.Controls.DataVisualization.BarChart();
            this.pie = new Abeo.Controls.DataVisualization.PieChart();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv.ColumnNameMap = null;
            this.lv.DataSource = null;
            this.lv.EnableSelection = false;
            this.lv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lv.FullRowSelect = true;
            this.lv.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.lv.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.lv.HideSelection = false;
            this.lv.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.lv.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lv.Location = new System.Drawing.Point(13, 50);
            this.lv.Name = "lv";
            this.lv.OwnerDraw = true;
            this.lv.RowColorEven = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.lv.RowColorOdd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.lv.ShowItemBorder = false;
            this.lv.Size = new System.Drawing.Size(334, 733);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.ItemDoubleClickEvent += new Abeo.Controls.FlatListView.ItemDoubleClickEventHandler(this.lv_ItemDoubleClickEvent);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatButton1.BorderColor = System.Drawing.Color.Empty;
            this.flatButton1.BorderSize = 0;
            this.flatButton1.FlatAppearance.BorderSize = 0;
            this.flatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.flatButton1.Location = new System.Drawing.Point(13, 14);
            this.flatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flatButton1.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatButton1.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(108, 28);
            this.flatButton1.TabIndex = 1;
            this.flatButton1.Text = "Fill Data";
            this.flatButton1.UseVisualStyleBackColor = false;
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // chart
            // 
            this.chart.AxisTitleX = "X axis";
            this.chart.AxisTitleY = "Y axis";
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.chart.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.chart.BorderRadius = 3;
            this.chart.BorderThickness = 0;
            this.chart.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.chart.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.chart.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.chart.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.chart.DebugMode = false;
            this.chart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.chart.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.chart.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.chart.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.chart.Icon = null;
            this.chart.IconPortion = 0.3F;
            this.chart.IconSize = 24;
            this.chart.IconVisible = false;
            this.chart.Image = null;
            this.chart.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.chart.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.chart.Location = new System.Drawing.Point(353, 32);
            this.chart.Name = "chart";
            this.chart.Padding = new System.Windows.Forms.Padding(10);
            this.chart.Size = new System.Drawing.Size(365, 286);
            this.chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.chart.TabIndex = 2;
            this.chart.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.chart.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.chart.TagOffset = 5;
            this.chart.TagVisible = false;
            this.chart.TagWidth = 5;
            this.chart.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.chart.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chart.Title = "Chart title";
            // 
            // pie
            // 
            this.pie.AxisTitleX = "X axis";
            this.pie.AxisTitleY = "Y axis";
            this.pie.BackColor = System.Drawing.Color.Transparent;
            this.pie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.pie.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.pie.BorderRadius = 3;
            this.pie.BorderThickness = 0;
            this.pie.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pie.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.pie.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pie.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.pie.DebugMode = false;
            this.pie.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.pie.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pie.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.pie.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.pie.Icon = null;
            this.pie.IconPortion = 0.3F;
            this.pie.IconSize = 24;
            this.pie.IconVisible = false;
            this.pie.Image = null;
            this.pie.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.pie.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.pie.Location = new System.Drawing.Point(724, 32);
            this.pie.Name = "pie";
            this.pie.Padding = new System.Windows.Forms.Padding(10);
            this.pie.Size = new System.Drawing.Size(347, 286);
            this.pie.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pie.TabIndex = 3;
            this.pie.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.pie.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.pie.TagOffset = 5;
            this.pie.TagVisible = false;
            this.pie.TagWidth = 5;
            this.pie.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pie.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pie.Title = "Chart title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1083, 795);
            this.Controls.Add(this.pie);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.lv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Abeo.Controls.FlatListView lv;
        private Abeo.Controls.FlatButton flatButton1;
        private Abeo.Controls.DataVisualization.BarChart chart;
        private Abeo.Controls.DataVisualization.PieChart pie;
    }
}

