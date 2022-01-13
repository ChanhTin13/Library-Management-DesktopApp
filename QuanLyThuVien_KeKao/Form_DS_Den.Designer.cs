
namespace QuanLyThuVien_KeKao
{
    partial class Form_DS_Den
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDS_Den = new System.Windows.Forms.DataGridView();
            this.btnLoadDanhSach = new System.Windows.Forms.Button();
            this.btn_Loai_Bo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rabtnNu = new System.Windows.Forms.RadioButton();
            this.rabtnNam = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Xoa_DS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS_Den)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDS_Den);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 282);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Đen";
            // 
            // dtgvDS_Den
            // 
            this.dtgvDS_Den.AllowUserToAddRows = false;
            this.dtgvDS_Den.AllowUserToDeleteRows = false;
            this.dtgvDS_Den.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvDS_Den.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS_Den.Location = new System.Drawing.Point(15, 21);
            this.dtgvDS_Den.Name = "dtgvDS_Den";
            this.dtgvDS_Den.ReadOnly = true;
            this.dtgvDS_Den.RowHeadersWidth = 51;
            this.dtgvDS_Den.RowTemplate.Height = 24;
            this.dtgvDS_Den.Size = new System.Drawing.Size(1002, 246);
            this.dtgvDS_Den.TabIndex = 0;
            this.dtgvDS_Den.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDS_Den_CellContentClick);
            // 
            // btnLoadDanhSach
            // 
            this.btnLoadDanhSach.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLoadDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDanhSach.Image = global::QuanLyThuVien_KeKao.Properties.Resources.Button_Refresh_icon;
            this.btnLoadDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDanhSach.Location = new System.Drawing.Point(250, 216);
            this.btnLoadDanhSach.Name = "btnLoadDanhSach";
            this.btnLoadDanhSach.Size = new System.Drawing.Size(106, 40);
            this.btnLoadDanhSach.TabIndex = 37;
            this.btnLoadDanhSach.Text = "Làm Mới";
            this.btnLoadDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadDanhSach.UseVisualStyleBackColor = false;
            this.btnLoadDanhSach.Click += new System.EventHandler(this.btnLoadDanhSach_Click);
            // 
            // btn_Loai_Bo
            // 
            this.btn_Loai_Bo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Loai_Bo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Loai_Bo.Image = global::QuanLyThuVien_KeKao.Properties.Resources.trash_icon;
            this.btn_Loai_Bo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Loai_Bo.Location = new System.Drawing.Point(499, 215);
            this.btn_Loai_Bo.Name = "btn_Loai_Bo";
            this.btn_Loai_Bo.Size = new System.Drawing.Size(105, 40);
            this.btn_Loai_Bo.TabIndex = 36;
            this.btn_Loai_Bo.Text = "Loại bỏ";
            this.btn_Loai_Bo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Loai_Bo.UseVisualStyleBackColor = false;
            this.btn_Loai_Bo.Click += new System.EventHandler(this.btn_Loai_Bo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txt_GhiChu);
            this.groupBox2.Controls.Add(this.txtTenDG);
            this.groupBox2.Controls.Add(this.txtMaDG);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rabtnNu);
            this.groupBox2.Controls.Add(this.rabtnNam);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 208);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Đọc Giả";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(685, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 28);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txt_GhiChu.Location = new System.Drawing.Point(339, 136);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(523, 28);
            this.txt_GhiChu.TabIndex = 50;
            this.txt_GhiChu.TextChanged += new System.EventHandler(this.txt_GhiChu_TextChanged);
            // 
            // txtTenDG
            // 
            this.txtTenDG.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtTenDG.Location = new System.Drawing.Point(339, 88);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(177, 28);
            this.txtTenDG.TabIndex = 49;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtMaDG.Location = new System.Drawing.Point(339, 39);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(177, 28);
            this.txtMaDG.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(245, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 47;
            this.label6.Text = "Ghi Chú :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(591, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "Giới Tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(591, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ngày Sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(245, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên ĐG :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(245, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã ĐG :";
            // 
            // rabtnNu
            // 
            this.rabtnNu.AutoSize = true;
            this.rabtnNu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rabtnNu.Location = new System.Drawing.Point(813, 91);
            this.rabtnNu.Name = "rabtnNu";
            this.rabtnNu.Size = new System.Drawing.Size(49, 21);
            this.rabtnNu.TabIndex = 41;
            this.rabtnNu.Text = "Nữ";
            this.rabtnNu.UseVisualStyleBackColor = true;
            this.rabtnNu.CheckedChanged += new System.EventHandler(this.rabtnNu_CheckedChanged);
            // 
            // rabtnNam
            // 
            this.rabtnNam.AutoSize = true;
            this.rabtnNam.Checked = true;
            this.rabtnNam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rabtnNam.Location = new System.Drawing.Point(707, 91);
            this.rabtnNam.Name = "rabtnNam";
            this.rabtnNam.Size = new System.Drawing.Size(61, 21);
            this.rabtnNam.TabIndex = 40;
            this.rabtnNam.TabStop = true;
            this.rabtnNam.Text = "Nam";
            this.rabtnNam.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(49, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 181);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 163);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Xoa_DS
            // 
            this.btn_Xoa_DS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Xoa_DS.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_DS.Image = global::QuanLyThuVien_KeKao.Properties.Resources.Button_Close_icon;
            this.btn_Xoa_DS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa_DS.Location = new System.Drawing.Point(735, 216);
            this.btn_Xoa_DS.Name = "btn_Xoa_DS";
            this.btn_Xoa_DS.Size = new System.Drawing.Size(195, 40);
            this.btn_Xoa_DS.TabIndex = 40;
            this.btn_Xoa_DS.Text = "Xóa Danh Sách";
            this.btn_Xoa_DS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa_DS.UseVisualStyleBackColor = false;
            this.btn_Xoa_DS.Click += new System.EventHandler(this.btn_Xoa_DS_Click);
            // 
            // Form_DS_Den
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1043, 537);
            this.Controls.Add(this.btn_Xoa_DS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLoadDanhSach);
            this.Controls.Add(this.btn_Loai_Bo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_DS_Den";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đen";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS_Den)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDS_Den;
        private System.Windows.Forms.Button btnLoadDanhSach;
        private System.Windows.Forms.Button btn_Loai_Bo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rabtnNu;
        private System.Windows.Forms.RadioButton rabtnNam;
        private System.Windows.Forms.Button btn_Xoa_DS;
    }
}