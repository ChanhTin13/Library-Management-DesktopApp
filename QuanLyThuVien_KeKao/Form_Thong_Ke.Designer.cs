
namespace QuanLyThuVien_KeKao
{
    partial class Form_Thong_Ke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.TextAnnotation textAnnotation1 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.SeriesPointAnchorPoint seriesPointAnchorPoint1 = new DevExpress.XtraCharts.SeriesPointAnchorPoint();
            DevExpress.XtraCharts.RelativePosition relativePosition1 = new DevExpress.XtraCharts.RelativePosition();
            DevExpress.XtraCharts.TextAnnotation textAnnotation2 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint1 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition1 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Số Sách Mượn", new object[] {
            ((object)(1D))}, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("Số Sách Còn", new object[] {
            ((object)(49D))}, 2);
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textBox_SLSQH = new System.Windows.Forms.TextBox();
            this.textBoxSLSCL = new System.Windows.Forms.TextBox();
            this.textBoxSLDS = new System.Windows.Forms.TextBox();
            this.textBox_SLS = new System.Windows.Forms.TextBox();
            this.textBox_SSDCM = new System.Windows.Forms.TextBox();
            this.grDG_muon_sach_qua_han = new DevExpress.XtraEditors.GroupControl();
            this.dgvDG_muon_sach_qua_han = new System.Windows.Forms.DataGridView();
            this.grSach_qua_han = new DevExpress.XtraEditors.GroupControl();
            this.dgvsach_qua_han = new System.Windows.Forms.DataGridView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.grThong_ke_doc_gia = new DevExpress.XtraEditors.GroupControl();
            this.lblso_luong_doc_gia = new DevExpress.XtraEditors.LabelControl();
            this.lblDG_muon_sach = new DevExpress.XtraEditors.LabelControl();
            this.lblDG_muon_sach_qua_han = new DevExpress.XtraEditors.LabelControl();
            this.txtDG_muon_sach_qua_han = new System.Windows.Forms.TextBox();
            this.txtDG_dang_muon_sach = new System.Windows.Forms.TextBox();
            this.txtso_luong_doc_gia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDG_muon_sach_qua_han)).BeginInit();
            this.grDG_muon_sach_qua_han.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDG_muon_sach_qua_han)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grSach_qua_han)).BeginInit();
            this.grSach_qua_han.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach_qua_han)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(seriesPointAnchorPoint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThong_ke_doc_gia)).BeginInit();
            this.grThong_ke_doc_gia.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textBox_SLSQH);
            this.groupControl1.Controls.Add(this.textBoxSLSCL);
            this.groupControl1.Controls.Add(this.textBoxSLDS);
            this.groupControl1.Controls.Add(this.textBox_SLS);
            this.groupControl1.Controls.Add(this.textBox_SSDCM);
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1039, 267);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Thống Kê Sách";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(602, 138);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(198, 25);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Số lượng sách quá hạn";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(602, 68);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(189, 25);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Số lượng sách còn lại";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(35, 215);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(264, 25);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Số lượng sách đang cho mượn";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(35, 145);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(124, 25);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Số lượng sách";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(35, 68);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(162, 25);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Số lượng đầu sách";
            // 
            // textBox_SLSQH
            // 
            this.textBox_SLSQH.Location = new System.Drawing.Point(847, 149);
            this.textBox_SLSQH.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_SLSQH.Name = "textBox_SLSQH";
            this.textBox_SLSQH.Size = new System.Drawing.Size(154, 23);
            this.textBox_SLSQH.TabIndex = 8;
            // 
            // textBoxSLSCL
            // 
            this.textBoxSLSCL.Location = new System.Drawing.Point(847, 73);
            this.textBoxSLSCL.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSLSCL.Name = "textBoxSLSCL";
            this.textBoxSLSCL.Size = new System.Drawing.Size(154, 23);
            this.textBoxSLSCL.TabIndex = 6;
            // 
            // textBoxSLDS
            // 
            this.textBoxSLDS.Location = new System.Drawing.Point(355, 73);
            this.textBoxSLDS.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSLDS.Name = "textBoxSLDS";
            this.textBoxSLDS.Size = new System.Drawing.Size(154, 23);
            this.textBoxSLDS.TabIndex = 5;
            // 
            // textBox_SLS
            // 
            this.textBox_SLS.Location = new System.Drawing.Point(355, 150);
            this.textBox_SLS.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_SLS.Name = "textBox_SLS";
            this.textBox_SLS.Size = new System.Drawing.Size(154, 23);
            this.textBox_SLS.TabIndex = 4;
            // 
            // textBox_SSDCM
            // 
            this.textBox_SSDCM.Location = new System.Drawing.Point(355, 220);
            this.textBox_SSDCM.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_SSDCM.Name = "textBox_SSDCM";
            this.textBox_SSDCM.Size = new System.Drawing.Size(154, 23);
            this.textBox_SSDCM.TabIndex = 3;
            // 
            // grDG_muon_sach_qua_han
            // 
            this.grDG_muon_sach_qua_han.Controls.Add(this.dgvDG_muon_sach_qua_han);
            this.grDG_muon_sach_qua_han.Location = new System.Drawing.Point(534, 282);
            this.grDG_muon_sach_qua_han.Margin = new System.Windows.Forms.Padding(5);
            this.grDG_muon_sach_qua_han.Name = "grDG_muon_sach_qua_han";
            this.grDG_muon_sach_qua_han.Size = new System.Drawing.Size(510, 275);
            this.grDG_muon_sach_qua_han.TabIndex = 13;
            this.grDG_muon_sach_qua_han.Text = "Danh Sách Đọc Giả Mượn Sách Quá Hạn";
            // 
            // dgvDG_muon_sach_qua_han
            // 
            this.dgvDG_muon_sach_qua_han.AllowUserToAddRows = false;
            this.dgvDG_muon_sach_qua_han.AllowUserToDeleteRows = false;
            this.dgvDG_muon_sach_qua_han.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDG_muon_sach_qua_han.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDG_muon_sach_qua_han.Location = new System.Drawing.Point(8, 40);
            this.dgvDG_muon_sach_qua_han.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDG_muon_sach_qua_han.Name = "dgvDG_muon_sach_qua_han";
            this.dgvDG_muon_sach_qua_han.ReadOnly = true;
            this.dgvDG_muon_sach_qua_han.RowHeadersWidth = 51;
            this.dgvDG_muon_sach_qua_han.Size = new System.Drawing.Size(495, 228);
            this.dgvDG_muon_sach_qua_han.TabIndex = 0;
            // 
            // grSach_qua_han
            // 
            this.grSach_qua_han.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.grSach_qua_han.Appearance.Options.UseBackColor = true;
            this.grSach_qua_han.Controls.Add(this.dgvsach_qua_han);
            this.grSach_qua_han.Location = new System.Drawing.Point(5, 282);
            this.grSach_qua_han.Margin = new System.Windows.Forms.Padding(5);
            this.grSach_qua_han.Name = "grSach_qua_han";
            this.grSach_qua_han.Size = new System.Drawing.Size(519, 275);
            this.grSach_qua_han.TabIndex = 14;
            this.grSach_qua_han.Text = "Danh Sách Sách Mượn Quá Hạn";
            // 
            // dgvsach_qua_han
            // 
            this.dgvsach_qua_han.AllowUserToAddRows = false;
            this.dgvsach_qua_han.AllowUserToDeleteRows = false;
            this.dgvsach_qua_han.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvsach_qua_han.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsach_qua_han.Location = new System.Drawing.Point(8, 40);
            this.dgvsach_qua_han.Margin = new System.Windows.Forms.Padding(5);
            this.dgvsach_qua_han.Name = "dgvsach_qua_han";
            this.dgvsach_qua_han.ReadOnly = true;
            this.dgvsach_qua_han.RowHeadersWidth = 51;
            this.dgvsach_qua_han.Size = new System.Drawing.Size(501, 228);
            this.dgvsach_qua_han.TabIndex = 0;
            // 
            // chartControl1
            // 
            seriesPointAnchorPoint1.SeriesID = 0;
            seriesPointAnchorPoint1.SeriesPointID = 1;
            textAnnotation1.AnchorPoint = seriesPointAnchorPoint1;
            textAnnotation1.AutoHeight = true;
            textAnnotation1.AutoWidth = true;
            textAnnotation1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient;
            textAnnotation1.Name = "ssc";
            textAnnotation1.ShapePosition = relativePosition1;
            textAnnotation1.Text = "Sách Mượn";
            chartAnchorPoint1.X = 113;
            chartAnchorPoint1.Y = 89;
            textAnnotation2.AnchorPoint = chartAnchorPoint1;
            textAnnotation2.AutoHeight = true;
            textAnnotation2.AutoWidth = true;
            textAnnotation2.Name = "Text Annotation 1";
            freePosition1.InnerIndents.Left = 0;
            freePosition1.InnerIndents.Top = 0;
            textAnnotation2.ShapePosition = freePosition1;
            textAnnotation2.Text = "Sách Còn";
            this.chartControl1.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation1,
            textAnnotation2});
            this.chartControl1.Location = new System.Drawing.Point(1055, 283);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            seriesPoint1.ColorSerializable = "#FFFF00";
            seriesPoint2.ColorSerializable = "#92D050";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2});
            series1.SeriesID = 0;
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(480, 264);
            this.chartControl1.TabIndex = 15;
            // 
            // grThong_ke_doc_gia
            // 
            this.grThong_ke_doc_gia.Controls.Add(this.lblso_luong_doc_gia);
            this.grThong_ke_doc_gia.Controls.Add(this.lblDG_muon_sach);
            this.grThong_ke_doc_gia.Controls.Add(this.lblDG_muon_sach_qua_han);
            this.grThong_ke_doc_gia.Controls.Add(this.txtDG_muon_sach_qua_han);
            this.grThong_ke_doc_gia.Controls.Add(this.txtDG_dang_muon_sach);
            this.grThong_ke_doc_gia.Controls.Add(this.txtso_luong_doc_gia);
            this.grThong_ke_doc_gia.Location = new System.Drawing.Point(1054, 5);
            this.grThong_ke_doc_gia.Margin = new System.Windows.Forms.Padding(5);
            this.grThong_ke_doc_gia.Name = "grThong_ke_doc_gia";
            this.grThong_ke_doc_gia.Size = new System.Drawing.Size(481, 267);
            this.grThong_ke_doc_gia.TabIndex = 16;
            this.grThong_ke_doc_gia.Text = "Thống Kê Đọc Giả ";
            // 
            // lblso_luong_doc_gia
            // 
            this.lblso_luong_doc_gia.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblso_luong_doc_gia.Appearance.Options.UseFont = true;
            this.lblso_luong_doc_gia.Location = new System.Drawing.Point(38, 75);
            this.lblso_luong_doc_gia.Margin = new System.Windows.Forms.Padding(5);
            this.lblso_luong_doc_gia.Name = "lblso_luong_doc_gia";
            this.lblso_luong_doc_gia.Size = new System.Drawing.Size(149, 25);
            this.lblso_luong_doc_gia.TabIndex = 15;
            this.lblso_luong_doc_gia.Text = "Số lượng đọc giả";
            // 
            // lblDG_muon_sach
            // 
            this.lblDG_muon_sach.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDG_muon_sach.Appearance.Options.UseFont = true;
            this.lblDG_muon_sach.Location = new System.Drawing.Point(38, 138);
            this.lblDG_muon_sach.Margin = new System.Windows.Forms.Padding(5);
            this.lblDG_muon_sach.Name = "lblDG_muon_sach";
            this.lblDG_muon_sach.Size = new System.Drawing.Size(217, 25);
            this.lblDG_muon_sach.TabIndex = 16;
            this.lblDG_muon_sach.Text = "Đọc giả đang mượn sách";
            // 
            // lblDG_muon_sach_qua_han
            // 
            this.lblDG_muon_sach_qua_han.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDG_muon_sach_qua_han.Appearance.Options.UseFont = true;
            this.lblDG_muon_sach_qua_han.Location = new System.Drawing.Point(38, 220);
            this.lblDG_muon_sach_qua_han.Margin = new System.Windows.Forms.Padding(5);
            this.lblDG_muon_sach_qua_han.Name = "lblDG_muon_sach_qua_han";
            this.lblDG_muon_sach_qua_han.Size = new System.Drawing.Size(244, 25);
            this.lblDG_muon_sach_qua_han.TabIndex = 17;
            this.lblDG_muon_sach_qua_han.Text = "Đọc giả mượn sách quá hạn";
            // 
            // txtDG_muon_sach_qua_han
            // 
            this.txtDG_muon_sach_qua_han.Location = new System.Drawing.Point(307, 215);
            this.txtDG_muon_sach_qua_han.Margin = new System.Windows.Forms.Padding(5);
            this.txtDG_muon_sach_qua_han.Name = "txtDG_muon_sach_qua_han";
            this.txtDG_muon_sach_qua_han.Size = new System.Drawing.Size(154, 23);
            this.txtDG_muon_sach_qua_han.TabIndex = 2;
            // 
            // txtDG_dang_muon_sach
            // 
            this.txtDG_dang_muon_sach.Location = new System.Drawing.Point(307, 136);
            this.txtDG_dang_muon_sach.Margin = new System.Windows.Forms.Padding(5);
            this.txtDG_dang_muon_sach.Name = "txtDG_dang_muon_sach";
            this.txtDG_dang_muon_sach.Size = new System.Drawing.Size(154, 23);
            this.txtDG_dang_muon_sach.TabIndex = 1;
            // 
            // txtso_luong_doc_gia
            // 
            this.txtso_luong_doc_gia.Location = new System.Drawing.Point(307, 73);
            this.txtso_luong_doc_gia.Margin = new System.Windows.Forms.Padding(5);
            this.txtso_luong_doc_gia.Name = "txtso_luong_doc_gia";
            this.txtso_luong_doc_gia.Size = new System.Drawing.Size(154, 23);
            this.txtso_luong_doc_gia.TabIndex = 0;
            // 
            // Form_Thong_Ke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1677, 615);
            this.Controls.Add(this.grThong_ke_doc_gia);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.grSach_qua_han);
            this.Controls.Add(this.grDG_muon_sach_qua_han);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form_Thong_Ke";
            this.Text = "Form_Thong_Ke";
            this.Load += new System.EventHandler(this.Form_Thong_Ke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDG_muon_sach_qua_han)).EndInit();
            this.grDG_muon_sach_qua_han.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDG_muon_sach_qua_han)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grSach_qua_han)).EndInit();
            this.grSach_qua_han.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach_qua_han)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(seriesPointAnchorPoint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThong_ke_doc_gia)).EndInit();
            this.grThong_ke_doc_gia.ResumeLayout(false);
            this.grThong_ke_doc_gia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox textBox_SLSQH;
        private System.Windows.Forms.TextBox textBoxSLSCL;
        private System.Windows.Forms.TextBox textBoxSLDS;
        private System.Windows.Forms.TextBox textBox_SLS;
        private System.Windows.Forms.TextBox textBox_SSDCM;
        private DevExpress.XtraEditors.GroupControl grDG_muon_sach_qua_han;
        private System.Windows.Forms.DataGridView dgvDG_muon_sach_qua_han;
        private DevExpress.XtraEditors.GroupControl grSach_qua_han;
        private System.Windows.Forms.DataGridView dgvsach_qua_han;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.GroupControl grThong_ke_doc_gia;
        private DevExpress.XtraEditors.LabelControl lblso_luong_doc_gia;
        private DevExpress.XtraEditors.LabelControl lblDG_muon_sach;
        private DevExpress.XtraEditors.LabelControl lblDG_muon_sach_qua_han;
        private System.Windows.Forms.TextBox txtDG_muon_sach_qua_han;
        private System.Windows.Forms.TextBox txtDG_dang_muon_sach;
        private System.Windows.Forms.TextBox txtso_luong_doc_gia;
    }
}