namespace GUIExample {
    partial class FormMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.flatTitlePanel1 = new Abeo.Controls.ZeroCode.FlatTitlePanel();
            this.btDASHBOARD = new Abeo.Controls.FlatExclusiveCheckedButton();
            this.panelDASHBOARD = new Abeo.Controls.FlatPanel();
            this.simpleDashboardView1 = new LotusAPI.Data.SimpleDashboardView();
            this.btDB = new Abeo.Controls.FlatExclusiveCheckedButton();
            this.panelDB = new Abeo.Controls.FlatPanel();
            this.simpleDatabaseView1 = new LotusAPI.Data.SimpleDatabaseView();
            this.btHOME = new Abeo.Controls.FlatExclusiveCheckedButton();
            this.panelHOME = new Abeo.Controls.FlatPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flatLabel10 = new Abeo.Controls.FlatLabel();
            this.flatLabel11 = new Abeo.Controls.FlatLabel();
            this.flatLabel12 = new Abeo.Controls.FlatLabel();
            this.flatLabel13 = new Abeo.Controls.FlatLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.advancedImageView1 = new Abeo.Controls.AdvancedImageView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flatLabel2 = new Abeo.Controls.FlatLabel();
            this.flatLabel1 = new Abeo.Controls.FlatLabel();
            this.flatLabel4 = new Abeo.Controls.FlatLabel();
            this.flatLabel3 = new Abeo.Controls.FlatLabel();
            this.flatLabel5 = new Abeo.Controls.FlatLabel();
            this.flatLabel6 = new Abeo.Controls.FlatLabel();
            this.flatLabel7 = new Abeo.Controls.FlatLabel();
            this.flatLabel8 = new Abeo.Controls.FlatLabel();
            this.flatLabel9 = new Abeo.Controls.FlatLabel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.logview1 = new LotusAPI.Controls.LogView();
            this.ioPinmapView1 = new LotusAPI.HW.UI.IOPinmapView();
            this.flatListView1 = new Abeo.Controls.FlatListView();
            this.roundBlinkLabel1 = new Abeo.Controls.Roundable.RoundBlinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flatFormButtonsHorizontal1 = new Abeo.Controls.ZeroCode.FlatFormButtonsHorizontal();
            this.flatStatusBar1 = new Abeo.Controls.ZeroCode.FlatStatusBar();
            this.logFileWatcher1 = new LotusAPI.Utils.LogFileWatcher(this.components);
            this.advancedImageView3 = new Abeo.Controls.AdvancedImageView();
            this.pointcloudView1 = new LotusAPI.Controls.PointcloudView();
            this.flatTitlePanel1.SuspendLayout();
            this.panelDASHBOARD.SuspendLayout();
            this.panelDB.SuspendLayout();
            this.panelHOME.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointcloudView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flatTitlePanel1
            // 
            this.flatTitlePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatTitlePanel1.Controls.Add(this.btDASHBOARD);
            this.flatTitlePanel1.Controls.Add(this.btDB);
            this.flatTitlePanel1.Controls.Add(this.btHOME);
            this.flatTitlePanel1.Controls.Add(this.roundBlinkLabel1);
            this.flatTitlePanel1.Controls.Add(this.pictureBox1);
            this.flatTitlePanel1.Controls.Add(this.flatFormButtonsHorizontal1);
            this.flatTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTitlePanel1.FixedHeight = 32;
            this.flatTitlePanel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatTitlePanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatTitlePanel1.Location = new System.Drawing.Point(0, 0);
            this.flatTitlePanel1.Name = "flatTitlePanel1";
            this.flatTitlePanel1.Size = new System.Drawing.Size(1090, 32);
            this.flatTitlePanel1.TabIndex = 0;
            // 
            // btDASHBOARD
            // 
            this.btDASHBOARD.Appearance = System.Windows.Forms.Appearance.Button;
            this.btDASHBOARD.BackColor = System.Drawing.Color.Transparent;
            this.btDASHBOARD.BorderColor = System.Drawing.Color.Empty;
            this.btDASHBOARD.BorderSize = 0;
            this.btDASHBOARD.Checked = true;
            this.btDASHBOARD.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btDASHBOARD.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btDASHBOARD.ControlToBringToFront = this.panelDASHBOARD;
            this.btDASHBOARD.Dock = System.Windows.Forms.DockStyle.Left;
            this.btDASHBOARD.FlatAppearance.BorderSize = 0;
            this.btDASHBOARD.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btDASHBOARD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btDASHBOARD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btDASHBOARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDASHBOARD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btDASHBOARD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.btDASHBOARD.Location = new System.Drawing.Point(196, 0);
            this.btDASHBOARD.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btDASHBOARD.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btDASHBOARD.Name = "btDASHBOARD";
            this.btDASHBOARD.Size = new System.Drawing.Size(120, 32);
            this.btDASHBOARD.TabIndex = 5;
            this.btDASHBOARD.TabStop = true;
            this.btDASHBOARD.Text = "DASHBOARD";
            this.btDASHBOARD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btDASHBOARD.UseVisualStyleBackColor = false;
            // 
            // panelDASHBOARD
            // 
            this.panelDASHBOARD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelDASHBOARD.Controls.Add(this.simpleDashboardView1);
            this.panelDASHBOARD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDASHBOARD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelDASHBOARD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.panelDASHBOARD.Location = new System.Drawing.Point(0, 32);
            this.panelDASHBOARD.Name = "panelDASHBOARD";
            this.panelDASHBOARD.Size = new System.Drawing.Size(1090, 635);
            this.panelDASHBOARD.TabIndex = 4;
            // 
            // simpleDashboardView1
            // 
            this.simpleDashboardView1.BackColor = System.Drawing.Color.Transparent;
            this.simpleDashboardView1.ChartColorMap = ((System.Collections.Generic.Dictionary<string, System.Drawing.Color>)(resources.GetObject("simpleDashboardView1.ChartColorMap")));
            this.simpleDashboardView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleDashboardView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleDashboardView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.simpleDashboardView1.Location = new System.Drawing.Point(0, 0);
            this.simpleDashboardView1.Name = "simpleDashboardView1";
            this.simpleDashboardView1.Query = null;
            this.simpleDashboardView1.Size = new System.Drawing.Size(1090, 635);
            this.simpleDashboardView1.TabIndex = 0;
            // 
            // btDB
            // 
            this.btDB.Appearance = System.Windows.Forms.Appearance.Button;
            this.btDB.BackColor = System.Drawing.Color.Transparent;
            this.btDB.BorderColor = System.Drawing.Color.Empty;
            this.btDB.BorderSize = 0;
            this.btDB.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btDB.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btDB.ControlToBringToFront = this.panelDB;
            this.btDB.Dock = System.Windows.Forms.DockStyle.Left;
            this.btDB.FlatAppearance.BorderSize = 0;
            this.btDB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.btDB.Location = new System.Drawing.Point(130, 0);
            this.btDB.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btDB.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btDB.Name = "btDB";
            this.btDB.Size = new System.Drawing.Size(66, 32);
            this.btDB.TabIndex = 4;
            this.btDB.Text = "DB";
            this.btDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btDB.UseVisualStyleBackColor = false;
            // 
            // panelDB
            // 
            this.panelDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.panelDB.Controls.Add(this.simpleDatabaseView1);
            this.panelDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.panelDB.Location = new System.Drawing.Point(0, 32);
            this.panelDB.Name = "panelDB";
            this.panelDB.Size = new System.Drawing.Size(1090, 635);
            this.panelDB.TabIndex = 3;
            // 
            // simpleDatabaseView1
            // 
            this.simpleDatabaseView1.BackColor = System.Drawing.Color.Transparent;
            this.simpleDatabaseView1.ColumnNameMap = null;
            this.simpleDatabaseView1.DisplayColumns = null;
            this.simpleDatabaseView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleDatabaseView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleDatabaseView1.Location = new System.Drawing.Point(0, 0);
            this.simpleDatabaseView1.ModelColumnName = "Model";
            this.simpleDatabaseView1.Name = "simpleDatabaseView1";
            this.simpleDatabaseView1.Query = null;
            this.simpleDatabaseView1.ResultColumnName = "Result";
            this.simpleDatabaseView1.Size = new System.Drawing.Size(1090, 635);
            this.simpleDatabaseView1.TabIndex = 0;
            // 
            // btHOME
            // 
            this.btHOME.Appearance = System.Windows.Forms.Appearance.Button;
            this.btHOME.BackColor = System.Drawing.Color.Transparent;
            this.btHOME.BorderColor = System.Drawing.Color.Empty;
            this.btHOME.BorderSize = 0;
            this.btHOME.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btHOME.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btHOME.ControlToBringToFront = this.panelHOME;
            this.btHOME.Dock = System.Windows.Forms.DockStyle.Left;
            this.btHOME.FlatAppearance.BorderSize = 0;
            this.btHOME.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btHOME.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btHOME.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHOME.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btHOME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.btHOME.Location = new System.Drawing.Point(64, 0);
            this.btHOME.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btHOME.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btHOME.Name = "btHOME";
            this.btHOME.Size = new System.Drawing.Size(66, 32);
            this.btHOME.TabIndex = 3;
            this.btHOME.Text = "HOME";
            this.btHOME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btHOME.UseVisualStyleBackColor = false;
            // 
            // panelHOME
            // 
            this.panelHOME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.panelHOME.Controls.Add(this.tableLayoutPanel1);
            this.panelHOME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHOME.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelHOME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.panelHOME.Location = new System.Drawing.Point(0, 32);
            this.panelHOME.Margin = new System.Windows.Forms.Padding(0);
            this.panelHOME.Name = "panelHOME";
            this.panelHOME.Size = new System.Drawing.Size(1022, 649);
            this.panelHOME.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.09385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.90615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 649);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flatLabel10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flatLabel11, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.flatLabel12, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flatLabel13, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1022, 61);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flatLabel10
            // 
            this.flatLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.flatLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatLabel10.Location = new System.Drawing.Point(0, 0);
            this.flatLabel10.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel10.Name = "flatLabel10";
            this.flatLabel10.Size = new System.Drawing.Size(154, 61);
            this.flatLabel10.TabIndex = 0;
            this.flatLabel10.Text = "SEQNO";
            this.flatLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel11
            // 
            this.flatLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.flatLabel11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatLabel11.Location = new System.Drawing.Point(507, 0);
            this.flatLabel11.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel11.Name = "flatLabel11";
            this.flatLabel11.Size = new System.Drawing.Size(161, 61);
            this.flatLabel11.TabIndex = 1;
            this.flatLabel11.Text = "BODYNO";
            this.flatLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel12
            // 
            this.flatLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.flatLabel12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatLabel12.Location = new System.Drawing.Point(154, 0);
            this.flatLabel12.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel12.Name = "flatLabel12";
            this.flatLabel12.Size = new System.Drawing.Size(353, 61);
            this.flatLabel12.TabIndex = 0;
            this.flatLabel12.Text = "SEQNO";
            this.flatLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel13
            // 
            this.flatLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.flatLabel13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel13.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatLabel13.Location = new System.Drawing.Point(668, 0);
            this.flatLabel13.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel13.Name = "flatLabel13";
            this.flatLabel13.Size = new System.Drawing.Size(354, 61);
            this.flatLabel13.TabIndex = 0;
            this.flatLabel13.Text = "SEQNO";
            this.flatLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.advancedImageView1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.advancedImageView3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.pointcloudView1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1022, 258);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // advancedImageView1
            // 
            this.advancedImageView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedImageView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.advancedImageView1.DefaultInterpolation = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.advancedImageView1.EnableZoomPan = true;
            this.advancedImageView1.Font = new System.Drawing.Font("Consolas", 9F);
            this.advancedImageView1.ForeColor = System.Drawing.Color.Lime;
            this.advancedImageView1.Location = new System.Drawing.Point(0, 0);
            this.advancedImageView1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.advancedImageView1.Name = "advancedImageView1";
            this.advancedImageView1.ShowPixelColor = true;
            this.advancedImageView1.Size = new System.Drawing.Size(339, 258);
            this.advancedImageView1.TabIndex = 0;
            this.advancedImageView1.ZoomPanModifierKey = System.Windows.Forms.Keys.None;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.flatLabel2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.flatLabel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flatLabel4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.flatLabel3, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.flatLabel5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.flatLabel6, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.flatLabel7, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.flatLabel8, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.flatLabel9, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 319);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1022, 78);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // flatLabel2
            // 
            this.flatLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.flatLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.flatLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatLabel2.Location = new System.Drawing.Point(128, 0);
            this.flatLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(128, 24);
            this.flatLabel2.TabIndex = 4;
            this.flatLabel2.Text = "NG";
            this.flatLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel1
            // 
            this.flatLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.flatLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.flatLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatLabel1.Location = new System.Drawing.Point(0, 0);
            this.flatLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(128, 24);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "OK";
            this.flatLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel4
            // 
            this.flatLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.flatLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatLabel4.Location = new System.Drawing.Point(0, 24);
            this.flatLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(128, 54);
            this.flatLabel4.TabIndex = 3;
            this.flatLabel4.Text = "9999";
            this.flatLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel3
            // 
            this.flatLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.flatLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatLabel3.Location = new System.Drawing.Point(128, 24);
            this.flatLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(128, 54);
            this.flatLabel3.TabIndex = 5;
            this.flatLabel3.Text = "9999";
            this.flatLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel5
            // 
            this.flatLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.flatLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.flatLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatLabel5.Location = new System.Drawing.Point(256, 0);
            this.flatLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(128, 24);
            this.flatLabel5.TabIndex = 4;
            this.flatLabel5.Text = "TOTAL";
            this.flatLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel6
            // 
            this.flatLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.flatLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatLabel6.Location = new System.Drawing.Point(256, 24);
            this.flatLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(128, 54);
            this.flatLabel6.TabIndex = 5;
            this.flatLabel6.Text = "9999";
            this.flatLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel7
            // 
            this.flatLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.flatLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatLabel7.Location = new System.Drawing.Point(384, 24);
            this.flatLabel7.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel7.Name = "flatLabel7";
            this.flatLabel7.Size = new System.Drawing.Size(128, 54);
            this.flatLabel7.TabIndex = 5;
            this.flatLabel7.Text = "N/A";
            this.flatLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel8
            // 
            this.flatLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.flatLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.flatLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatLabel8.Location = new System.Drawing.Point(384, 0);
            this.flatLabel8.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel8.Name = "flatLabel8";
            this.flatLabel8.Size = new System.Drawing.Size(128, 24);
            this.flatLabel8.TabIndex = 4;
            this.flatLabel8.Text = "MODEL";
            this.flatLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel9
            // 
            this.flatLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.flatLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatLabel9.Location = new System.Drawing.Point(512, 0);
            this.flatLabel9.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel9.Name = "flatLabel9";
            this.tableLayoutPanel4.SetRowSpan(this.flatLabel9, 2);
            this.flatLabel9.Size = new System.Drawing.Size(510, 78);
            this.flatLabel9.TabIndex = 6;
            this.flatLabel9.Text = "Waiting for signals...";
            this.flatLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.logview1, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.ioPinmapView1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.flatListView1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 397);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1022, 252);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // logview1
            // 
            this.logview1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.logview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logview1.ColorDateTime = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.logview1.ColorDebug = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.logview1.ColorError = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.logview1.ColorFatal = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.logview1.ColorInfo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.logview1.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.logview1.ColorTrace = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.logview1.ColorWarning = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.logview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logview1.Font = new System.Drawing.Font("Consolas", 9F);
            this.logview1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.logview1.LineBuffer = 1000;
            this.logview1.Location = new System.Drawing.Point(585, 0);
            this.logview1.Margin = new System.Windows.Forms.Padding(0);
            this.logview1.Name = "logview1";
            this.logview1.ReadOnly = true;
            this.logview1.ShowDateTime = true;
            this.logview1.Size = new System.Drawing.Size(437, 252);
            this.logview1.TabIndex = 0;
            this.logview1.Text = "";
            this.logview1.UpdateInterval = 100;
            // 
            // ioPinmapView1
            // 
            this.ioPinmapView1.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ioPinmapView1.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ioPinmapView1.BackColor = System.Drawing.Color.Transparent;
            this.ioPinmapView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ioPinmapView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ioPinmapView1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.ioPinmapView1.HeaderFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ioPinmapView1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.ioPinmapView1.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ioPinmapView1.ItemFont = new System.Drawing.Font("Segoe UI", 12F);
            this.ioPinmapView1.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.ioPinmapView1.LabelDI = "INPUT";
            this.ioPinmapView1.LabelDO = "OUTPUT";
            this.ioPinmapView1.Location = new System.Drawing.Point(321, 0);
            this.ioPinmapView1.Margin = new System.Windows.Forms.Padding(0);
            this.ioPinmapView1.Name = "ioPinmapView1";
            this.ioPinmapView1.RWBackColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ioPinmapView1.RWBackColorInactive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.ioPinmapView1.RWForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.ioPinmapView1.ShowHeader = false;
            this.ioPinmapView1.Size = new System.Drawing.Size(264, 252);
            this.ioPinmapView1.TabIndex = 1;
            this.ioPinmapView1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.ioPinmapView1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(211)))));
            // 
            // flatListView1
            // 
            this.flatListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flatListView1.ColumnNameMap = null;
            this.flatListView1.DataSource = null;
            this.flatListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatListView1.EnableSelection = false;
            this.flatListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatListView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.flatListView1.FullRowSelect = true;
            this.flatListView1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.flatListView1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.flatListView1.HideSelection = false;
            this.flatListView1.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatListView1.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.flatListView1.Location = new System.Drawing.Point(0, 0);
            this.flatListView1.Margin = new System.Windows.Forms.Padding(0);
            this.flatListView1.Name = "flatListView1";
            this.flatListView1.OwnerDraw = true;
            this.flatListView1.RowColorEven = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatListView1.RowColorOdd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.flatListView1.ShowItemBorder = false;
            this.flatListView1.Size = new System.Drawing.Size(321, 252);
            this.flatListView1.TabIndex = 2;
            this.flatListView1.UseCompatibleStateImageBehavior = false;
            this.flatListView1.View = System.Windows.Forms.View.Details;
            // 
            // roundBlinkLabel1
            // 
            this.roundBlinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.roundBlinkLabel1.BlinkEnable = false;
            this.roundBlinkLabel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.roundBlinkLabel1.BorderCorners = Abeo.Controls.Roundable.Corners.None;
            this.roundBlinkLabel1.BorderRadius = 0;
            this.roundBlinkLabel1.BorderThickness = 0;
            this.roundBlinkLabel1.Checked = false;
            this.roundBlinkLabel1.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundBlinkLabel1.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.roundBlinkLabel1.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundBlinkLabel1.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.roundBlinkLabel1.DebugMode = false;
            this.roundBlinkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.roundBlinkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roundBlinkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundBlinkLabel1.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundBlinkLabel1.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundBlinkLabel1.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundBlinkLabel1.Icon = null;
            this.roundBlinkLabel1.IconPortion = 0.3F;
            this.roundBlinkLabel1.IconSize = 24;
            this.roundBlinkLabel1.IconVisible = false;
            this.roundBlinkLabel1.Image = null;
            this.roundBlinkLabel1.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.roundBlinkLabel1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.roundBlinkLabel1.Location = new System.Drawing.Point(889, 0);
            this.roundBlinkLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundBlinkLabel1.Name = "roundBlinkLabel1";
            this.roundBlinkLabel1.Size = new System.Drawing.Size(87, 32);
            this.roundBlinkLabel1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.roundBlinkLabel1.TabIndex = 2;
            this.roundBlinkLabel1.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.roundBlinkLabel1.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.roundBlinkLabel1.TagOffset = 5;
            this.roundBlinkLabel1.TagVisible = false;
            this.roundBlinkLabel1.TagWidth = 5;
            this.roundBlinkLabel1.Text = "MANUAL";
            this.roundBlinkLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundBlinkLabel1.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::GUIExample.Properties.Resources.lotus_32;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flatFormButtonsHorizontal1
            // 
            this.flatFormButtonsHorizontal1.BackColor = System.Drawing.Color.Transparent;
            this.flatFormButtonsHorizontal1.CloseConfirmType = Abeo.Controls.ZeroCode.FlatCloseButton.CloseConfirmTypeEnum.PasswordBox;
            this.flatFormButtonsHorizontal1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flatFormButtonsHorizontal1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatFormButtonsHorizontal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatFormButtonsHorizontal1.Location = new System.Drawing.Point(976, 0);
            this.flatFormButtonsHorizontal1.Name = "flatFormButtonsHorizontal1";
            this.flatFormButtonsHorizontal1.Size = new System.Drawing.Size(114, 32);
            this.flatFormButtonsHorizontal1.TabIndex = 0;
            // 
            // flatStatusBar1
            // 
            this.flatStatusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatStatusBar1.ClockColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(211)))));
            this.flatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatStatusBar1.FixedHeight = 24;
            this.flatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatStatusBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.flatStatusBar1.FreeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.flatStatusBar1.HighUseColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.flatStatusBar1.Location = new System.Drawing.Point(0, 667);
            this.flatStatusBar1.LowUseColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.flatStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flatStatusBar1.MediumUseColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.flatStatusBar1.Name = "flatStatusBar1";
            this.flatStatusBar1.Size = new System.Drawing.Size(1090, 24);
            // 
            // 
            // 
            this.flatStatusBar1.StatusItems.BackColor = System.Drawing.Color.Transparent;
            this.flatStatusBar1.StatusItems.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.flatStatusBar1.StatusItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatStatusBar1.StatusItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatStatusBar1.StatusItems.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStatusBar1.StatusItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.flatStatusBar1.StatusItems.ForeColorON = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatStatusBar1.StatusItems.Items = "";
            this.flatStatusBar1.StatusItems.Location = new System.Drawing.Point(60, 0);
            this.flatStatusBar1.StatusItems.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flatStatusBar1.StatusItems.Name = "statusItems";
            this.flatStatusBar1.StatusItems.ShowBorder = true;
            this.flatStatusBar1.StatusItems.Size = new System.Drawing.Size(0, 24);
            this.flatStatusBar1.StatusItems.TabIndex = 8;
            this.flatStatusBar1.TabIndex = 1;
            // 
            // logFileWatcher1
            // 
            this.logFileWatcher1.Interval = 3600000;
            this.logFileWatcher1.LogDirectory = "./Logs/";
            // 
            // advancedImageView3
            // 
            this.advancedImageView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedImageView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.advancedImageView3.DefaultInterpolation = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.advancedImageView3.EnableZoomPan = true;
            this.advancedImageView3.Font = new System.Drawing.Font("Consolas", 9F);
            this.advancedImageView3.ForeColor = System.Drawing.Color.Lime;
            this.advancedImageView3.Location = new System.Drawing.Point(680, 0);
            this.advancedImageView3.Margin = new System.Windows.Forms.Padding(0);
            this.advancedImageView3.Name = "advancedImageView3";
            this.advancedImageView3.ShowPixelColor = true;
            this.advancedImageView3.Size = new System.Drawing.Size(342, 258);
            this.advancedImageView3.TabIndex = 2;
            this.advancedImageView3.ZoomPanModifierKey = System.Windows.Forms.Keys.None;
            // 
            // pointcloudView1
            // 
            this.pointcloudView1.DrawFPS = false;
            this.pointcloudView1.Location = new System.Drawing.Point(344, 5);
            this.pointcloudView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pointcloudView1.Name = "pointcloudView1";
            this.pointcloudView1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.pointcloudView1.RenderContextType = SharpGL.RenderContextType.FBO;
            this.pointcloudView1.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.pointcloudView1.Size = new System.Drawing.Size(332, 237);
            this.pointcloudView1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1090, 691);
            this.Controls.Add(this.panelDASHBOARD);
            this.Controls.Add(this.panelHOME);
            this.Controls.Add(this.panelDB);
            this.Controls.Add(this.flatStatusBar1);
            this.Controls.Add(this.flatTitlePanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.flatTitlePanel1.ResumeLayout(false);
            this.panelDASHBOARD.ResumeLayout(false);
            this.panelDB.ResumeLayout(false);
            this.panelHOME.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointcloudView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Abeo.Controls.ZeroCode.FlatTitlePanel flatTitlePanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Abeo.Controls.ZeroCode.FlatFormButtonsHorizontal flatFormButtonsHorizontal1;
        private Abeo.Controls.ZeroCode.FlatStatusBar flatStatusBar1;
        private Abeo.Controls.FlatExclusiveCheckedButton btDASHBOARD;
        private Abeo.Controls.FlatPanel panelDASHBOARD;
        private Abeo.Controls.FlatExclusiveCheckedButton btDB;
        private Abeo.Controls.FlatPanel panelDB;
        private Abeo.Controls.FlatExclusiveCheckedButton btHOME;
        private Abeo.Controls.FlatPanel panelHOME;
        private Abeo.Controls.Roundable.RoundBlinkLabel roundBlinkLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Abeo.Controls.FlatLabel flatLabel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Abeo.Controls.AdvancedImageView advancedImageView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Abeo.Controls.FlatLabel flatLabel2;
        private Abeo.Controls.FlatLabel flatLabel1;
        private Abeo.Controls.FlatLabel flatLabel4;
        private Abeo.Controls.FlatLabel flatLabel3;
        private Abeo.Controls.FlatLabel flatLabel5;
        private Abeo.Controls.FlatLabel flatLabel6;
        private Abeo.Controls.FlatLabel flatLabel7;
        private Abeo.Controls.FlatLabel flatLabel8;
        private Abeo.Controls.FlatLabel flatLabel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Abeo.Controls.FlatLabel flatLabel11;
        private Abeo.Controls.FlatLabel flatLabel12;
        private Abeo.Controls.FlatLabel flatLabel13;
        private LotusAPI.Controls.LogView logview1;
        private LotusAPI.HW.UI.IOPinmapView ioPinmapView1;
        private Abeo.Controls.FlatListView flatListView1;
        private LotusAPI.Data.SimpleDashboardView simpleDashboardView1;
        private LotusAPI.Data.SimpleDatabaseView simpleDatabaseView1;
        private LotusAPI.Utils.LogFileWatcher logFileWatcher1;
        private Abeo.Controls.AdvancedImageView advancedImageView3;
        private LotusAPI.Controls.PointcloudView pointcloudView1;
    }
}