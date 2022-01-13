
namespace QuanLyThuVien_KeKao
{
    partial class Form_Nhan_Vien
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLoadDanhSach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_NV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuHinh = new System.Windows.Forms.Button();
            this.btnSuaHinh = new System.Windows.Forms.Button();
            this.dateTimePicker_NV = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMa_NV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rabtnNu = new System.Windows.Forms.RadioButton();
            this.rabtnNam = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 13F);
            this.btnHuy.Image = global::QuanLyThuVien_KeKao.Properties.Resources.Button_Close_icon;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHuy.Location = new System.Drawing.Point(1042, 316);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 47);
            this.btnHuy.TabIndex = 49;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLoadDanhSach
            // 
            this.btnLoadDanhSach.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLoadDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnLoadDanhSach.Image = global::QuanLyThuVien_KeKao.Properties.Resources.Button_Refresh_icon;
            this.btnLoadDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDanhSach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoadDanhSach.Location = new System.Drawing.Point(627, 319);
            this.btnLoadDanhSach.Name = "btnLoadDanhSach";
            this.btnLoadDanhSach.Size = new System.Drawing.Size(106, 44);
            this.btnLoadDanhSach.TabIndex = 50;
            this.btnLoadDanhSach.Text = "Làm Mới";
            this.btnLoadDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadDanhSach.UseVisualStyleBackColor = false;
            this.btnLoadDanhSach.Click += new System.EventHandler(this.btnLoadDanhSach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(99, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 208);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(93, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 232);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_NV);
            this.groupBox1.Location = new System.Drawing.Point(55, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 262);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Nhân Viên";
            // 
            // dtgv_NV
            // 
            this.dtgv_NV.AllowUserToAddRows = false;
            this.dtgv_NV.AllowUserToDeleteRows = false;
            this.dtgv_NV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_NV.Location = new System.Drawing.Point(18, 21);
            this.dtgv_NV.Name = "dtgv_NV";
            this.dtgv_NV.ReadOnly = true;
            this.dtgv_NV.RowHeadersWidth = 51;
            this.dtgv_NV.RowTemplate.Height = 24;
            this.dtgv_NV.Size = new System.Drawing.Size(1074, 224);
            this.dtgv_NV.TabIndex = 0;
            this.dtgv_NV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_NV_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnLuuHinh);
            this.groupBox2.Controls.Add(this.btnSuaHinh);
            this.groupBox2.Controls.Add(this.dateTimePicker_NV);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.txtMa_NV);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rabtnNu);
            this.groupBox2.Controls.Add(this.rabtnNam);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(55, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1109, 302);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Nhân Viên";
            // 
            // btnLuuHinh
            // 
            this.btnLuuHinh.Enabled = false;
            this.btnLuuHinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLuuHinh.Location = new System.Drawing.Point(112, 266);
            this.btnLuuHinh.Name = "btnLuuHinh";
            this.btnLuuHinh.Size = new System.Drawing.Size(65, 30);
            this.btnLuuHinh.TabIndex = 26;
            this.btnLuuHinh.Text = "Lưu";
            this.btnLuuHinh.UseVisualStyleBackColor = true;
            this.btnLuuHinh.Click += new System.EventHandler(this.btnLuuHinh_Click);
            // 
            // btnSuaHinh
            // 
            this.btnSuaHinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSuaHinh.Location = new System.Drawing.Point(193, 266);
            this.btnSuaHinh.Name = "btnSuaHinh";
            this.btnSuaHinh.Size = new System.Drawing.Size(88, 30);
            this.btnSuaHinh.TabIndex = 25;
            this.btnSuaHinh.Text = "Sửa Ảnh";
            this.btnSuaHinh.UseVisualStyleBackColor = true;
            this.btnSuaHinh.Click += new System.EventHandler(this.btnSuaHinh_Click);
            // 
            // dateTimePicker_NV
            // 
            this.dateTimePicker_NV.CustomFormat = "dd MM yyyy";
            this.dateTimePicker_NV.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.dateTimePicker_NV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NV.Location = new System.Drawing.Point(462, 140);
            this.dateTimePicker_NV.Name = "dateTimePicker_NV";
            this.dateTimePicker_NV.Size = new System.Drawing.Size(177, 28);
            this.dateTimePicker_NV.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtDiaChi.Location = new System.Drawing.Point(789, 147);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(177, 28);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtTenNV.Location = new System.Drawing.Point(462, 87);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(177, 28);
            this.txtTenNV.TabIndex = 16;
            // 
            // txtMa_NV
            // 
            this.txtMa_NV.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtMa_NV.Location = new System.Drawing.Point(462, 38);
            this.txtMa_NV.Name = "txtMa_NV";
            this.txtMa_NV.Size = new System.Drawing.Size(177, 28);
            this.txtMa_NV.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtSDT.Location = new System.Drawing.Point(789, 98);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(177, 28);
            this.txtSDT.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(695, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Địa Chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(697, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới Tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(368, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(697, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "SĐT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(368, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên NV :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(368, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã NV :";
            // 
            // rabtnNu
            // 
            this.rabtnNu.AutoSize = true;
            this.rabtnNu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rabtnNu.Location = new System.Drawing.Point(929, 45);
            this.rabtnNu.Name = "rabtnNu";
            this.rabtnNu.Size = new System.Drawing.Size(53, 25);
            this.rabtnNu.TabIndex = 2;
            this.rabtnNu.Text = "Nữ";
            this.rabtnNu.UseVisualStyleBackColor = true;
            // 
            // rabtnNam
            // 
            this.rabtnNam.AutoSize = true;
            this.rabtnNam.Checked = true;
            this.rabtnNam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rabtnNam.Location = new System.Drawing.Point(813, 45);
            this.rabtnNam.Name = "rabtnNam";
            this.rabtnNam.Size = new System.Drawing.Size(64, 25);
            this.rabtnNam.TabIndex = 1;
            this.rabtnNam.TabStop = true;
            this.rabtnNam.Text = "Nam";
            this.rabtnNam.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnThem.Image = global::QuanLyThuVien_KeKao.Properties.Resources.yellow_plus_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(776, 320);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 43);
            this.btnThem.TabIndex = 47;
            this.btnThem.Text = "Lưu";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyThuVien_KeKao.Properties.Resources.trash_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(906, 321);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 42);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form_Nhan_Vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1258, 643);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLoadDanhSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThem);
            this.Name = "Form_Nhan_Vien";
            this.Text = "Form_Nhan_Vien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLoadDanhSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_NV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuuHinh;
        private System.Windows.Forms.Button btnSuaHinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMa_NV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rabtnNu;
        private System.Windows.Forms.RadioButton rabtnNam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}