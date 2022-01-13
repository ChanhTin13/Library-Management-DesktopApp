
namespace QuanLyThuVien_KeKao
{
    partial class Form_QL_Tra_Sach
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
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnTimDG = new System.Windows.Forms.Button();
            this.txtTS_Search = new System.Windows.Forms.TextBox();
            this.rabtnTS_MS = new System.Windows.Forms.RadioButton();
            this.rabtnTS_MDG = new System.Windows.Forms.RadioButton();
            this.rabtnTS_MP = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.txtTS_TDG = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTS_TS = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnPhat = new System.Windows.Forms.Button();
            this.txtTS_MS = new System.Windows.Forms.TextBox();
            this.txtTS_MDG = new System.Windows.Forms.TextBox();
            this.txtTS_MP = new System.Windows.Forms.TextBox();
            this.dtpkTS_NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dtpk_TS_NgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownTS_SL = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvTS_DSPM = new System.Windows.Forms.DataGridView();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTS_SL)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTS_DSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.LightGreen;
            this.btnReload.Location = new System.Drawing.Point(643, 150);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(111, 27);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox7.Controls.Add(this.btnTimDG);
            this.groupBox7.Controls.Add(this.txtTS_Search);
            this.groupBox7.Controls.Add(this.rabtnTS_MS);
            this.groupBox7.Controls.Add(this.rabtnTS_MDG);
            this.groupBox7.Controls.Add(this.rabtnTS_MP);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(400, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(594, 135);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tìm Phiếu Mượn";
            // 
            // btnTimDG
            // 
            this.btnTimDG.Location = new System.Drawing.Point(259, 97);
            this.btnTimDG.Name = "btnTimDG";
            this.btnTimDG.Size = new System.Drawing.Size(69, 28);
            this.btnTimDG.TabIndex = 26;
            this.btnTimDG.Text = "Tìm";
            this.btnTimDG.UseVisualStyleBackColor = true;
            this.btnTimDG.Click += new System.EventHandler(this.btnTimDG_Click);
            // 
            // txtTS_Search
            // 
            this.txtTS_Search.Location = new System.Drawing.Point(166, 67);
            this.txtTS_Search.Name = "txtTS_Search";
            this.txtTS_Search.Size = new System.Drawing.Size(305, 24);
            this.txtTS_Search.TabIndex = 3;
            // 
            // rabtnTS_MS
            // 
            this.rabtnTS_MS.AutoSize = true;
            this.rabtnTS_MS.Location = new System.Drawing.Point(243, 39);
            this.rabtnTS_MS.Name = "rabtnTS_MS";
            this.rabtnTS_MS.Size = new System.Drawing.Size(95, 22);
            this.rabtnTS_MS.TabIndex = 2;
            this.rabtnTS_MS.Text = "Mã Sách";
            this.rabtnTS_MS.UseVisualStyleBackColor = true;
            // 
            // rabtnTS_MDG
            // 
            this.rabtnTS_MDG.AutoSize = true;
            this.rabtnTS_MDG.Location = new System.Drawing.Point(436, 39);
            this.rabtnTS_MDG.Name = "rabtnTS_MDG";
            this.rabtnTS_MDG.Size = new System.Drawing.Size(119, 22);
            this.rabtnTS_MDG.TabIndex = 1;
            this.rabtnTS_MDG.Text = "Mã Đọc Giả";
            this.rabtnTS_MDG.UseVisualStyleBackColor = true;
            // 
            // rabtnTS_MP
            // 
            this.rabtnTS_MP.AutoSize = true;
            this.rabtnTS_MP.Checked = true;
            this.rabtnTS_MP.Location = new System.Drawing.Point(35, 39);
            this.rabtnTS_MP.Name = "rabtnTS_MP";
            this.rabtnTS_MP.Size = new System.Drawing.Size(99, 22);
            this.rabtnTS_MP.TabIndex = 0;
            this.rabtnTS_MP.TabStop = true;
            this.rabtnTS_MP.Text = "Mã Phiếu";
            this.rabtnTS_MP.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox6.Controls.Add(this.btnGiaHan);
            this.groupBox6.Controls.Add(this.txtTS_TDG);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.txtTS_TS);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.btnTraSach);
            this.groupBox6.Controls.Add(this.btnPhat);
            this.groupBox6.Controls.Add(this.txtTS_MS);
            this.groupBox6.Controls.Add(this.txtTS_MDG);
            this.groupBox6.Controls.Add(this.txtTS_MP);
            this.groupBox6.Controls.Add(this.dtpkTS_NgayHetHan);
            this.groupBox6.Controls.Add(this.dtpk_TS_NgayLapPhieu);
            this.groupBox6.Controls.Add(this.numericUpDownTS_SL);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(75, 183);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1174, 166);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin phiếu mượn";
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGiaHan.Location = new System.Drawing.Point(939, 27);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(75, 33);
            this.btnGiaHan.TabIndex = 39;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // txtTS_TDG
            // 
            this.txtTS_TDG.BackColor = System.Drawing.SystemColors.Window;
            this.txtTS_TDG.Enabled = false;
            this.txtTS_TDG.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTS_TDG.Location = new System.Drawing.Point(427, 116);
            this.txtTS_TDG.Name = "txtTS_TDG";
            this.txtTS_TDG.Size = new System.Drawing.Size(190, 28);
            this.txtTS_TDG.TabIndex = 36;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(297, 119);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(102, 21);
            this.label25.TabIndex = 35;
            this.label25.Text = "Tên Đọc Giả :";
            // 
            // txtTS_TS
            // 
            this.txtTS_TS.BackColor = System.Drawing.SystemColors.Window;
            this.txtTS_TS.Enabled = false;
            this.txtTS_TS.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTS_TS.Location = new System.Drawing.Point(427, 75);
            this.txtTS_TS.Name = "txtTS_TS";
            this.txtTS_TS.Size = new System.Drawing.Size(190, 28);
            this.txtTS_TS.TabIndex = 34;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(295, 78);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 21);
            this.label24.TabIndex = 32;
            this.label24.Text = "Tên sách :";
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTraSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTraSach.ImageIndex = 3;
            this.btnTraSach.Location = new System.Drawing.Point(1060, 98);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(96, 47);
            this.btnTraSach.TabIndex = 31;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnPhat
            // 
            this.btnPhat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPhat.Enabled = false;
            this.btnPhat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPhat.Location = new System.Drawing.Point(1060, 23);
            this.btnPhat.Name = "btnPhat";
            this.btnPhat.Size = new System.Drawing.Size(96, 40);
            this.btnPhat.TabIndex = 30;
            this.btnPhat.Text = "Phạt";
            this.btnPhat.UseVisualStyleBackColor = false;
            this.btnPhat.Click += new System.EventHandler(this.btnPhat_Click);
            // 
            // txtTS_MS
            // 
            this.txtTS_MS.BackColor = System.Drawing.SystemColors.Window;
            this.txtTS_MS.Enabled = false;
            this.txtTS_MS.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTS_MS.Location = new System.Drawing.Point(98, 75);
            this.txtTS_MS.Name = "txtTS_MS";
            this.txtTS_MS.Size = new System.Drawing.Size(179, 28);
            this.txtTS_MS.TabIndex = 29;
            // 
            // txtTS_MDG
            // 
            this.txtTS_MDG.BackColor = System.Drawing.SystemColors.Window;
            this.txtTS_MDG.Enabled = false;
            this.txtTS_MDG.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTS_MDG.Location = new System.Drawing.Point(98, 117);
            this.txtTS_MDG.Name = "txtTS_MDG";
            this.txtTS_MDG.Size = new System.Drawing.Size(179, 28);
            this.txtTS_MDG.TabIndex = 28;
            // 
            // txtTS_MP
            // 
            this.txtTS_MP.BackColor = System.Drawing.SystemColors.Window;
            this.txtTS_MP.Enabled = false;
            this.txtTS_MP.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTS_MP.Location = new System.Drawing.Point(98, 32);
            this.txtTS_MP.Name = "txtTS_MP";
            this.txtTS_MP.Size = new System.Drawing.Size(179, 28);
            this.txtTS_MP.TabIndex = 27;
            // 
            // dtpkTS_NgayHetHan
            // 
            this.dtpkTS_NgayHetHan.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtpkTS_NgayHetHan.CustomFormat = "dd / MM / yyyy";
            this.dtpkTS_NgayHetHan.Enabled = false;
            this.dtpkTS_NgayHetHan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkTS_NgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTS_NgayHetHan.Location = new System.Drawing.Point(745, 30);
            this.dtpkTS_NgayHetHan.Name = "dtpkTS_NgayHetHan";
            this.dtpkTS_NgayHetHan.Size = new System.Drawing.Size(179, 28);
            this.dtpkTS_NgayHetHan.TabIndex = 26;
            // 
            // dtpk_TS_NgayLapPhieu
            // 
            this.dtpk_TS_NgayLapPhieu.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtpk_TS_NgayLapPhieu.CustomFormat = "dd / MM / yyyy";
            this.dtpk_TS_NgayLapPhieu.Enabled = false;
            this.dtpk_TS_NgayLapPhieu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_TS_NgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_TS_NgayLapPhieu.Location = new System.Drawing.Point(427, 30);
            this.dtpk_TS_NgayLapPhieu.Name = "dtpk_TS_NgayLapPhieu";
            this.dtpk_TS_NgayLapPhieu.Size = new System.Drawing.Size(190, 28);
            this.dtpk_TS_NgayLapPhieu.TabIndex = 25;
            // 
            // numericUpDownTS_SL
            // 
            this.numericUpDownTS_SL.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownTS_SL.Location = new System.Drawing.Point(745, 75);
            this.numericUpDownTS_SL.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTS_SL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTS_SL.Name = "numericUpDownTS_SL";
            this.numericUpDownTS_SL.ReadOnly = true;
            this.numericUpDownTS_SL.Size = new System.Drawing.Size(51, 28);
            this.numericUpDownTS_SL.TabIndex = 8;
            this.numericUpDownTS_SL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTS_SL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(630, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 21);
            this.label18.TabIndex = 7;
            this.label18.Text = "Số Lượng :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(630, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 21);
            this.label19.TabIndex = 6;
            this.label19.Text = "Ngày Hết Hạn :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 21);
            this.label20.TabIndex = 5;
            this.label20.Text = "Mã sách :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 119);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 21);
            this.label21.TabIndex = 4;
            this.label21.Text = "Mã ĐG :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(295, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 21);
            this.label22.TabIndex = 1;
            this.label22.Text = "Ngày Lập Phiếu :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 35);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 21);
            this.label23.TabIndex = 0;
            this.label23.Text = "Mã Phiếu :";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox5.Controls.Add(this.dtgvTS_DSPM);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(75, 355);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1174, 256);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách Phiếu Mượn";
            // 
            // dtgvTS_DSPM
            // 
            this.dtgvTS_DSPM.AllowUserToAddRows = false;
            this.dtgvTS_DSPM.AllowUserToDeleteRows = false;
            this.dtgvTS_DSPM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvTS_DSPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTS_DSPM.Location = new System.Drawing.Point(19, 23);
            this.dtgvTS_DSPM.Name = "dtgvTS_DSPM";
            this.dtgvTS_DSPM.ReadOnly = true;
            this.dtgvTS_DSPM.RowHeadersWidth = 51;
            this.dtgvTS_DSPM.RowTemplate.Height = 24;
            this.dtgvTS_DSPM.Size = new System.Drawing.Size(1137, 217);
            this.dtgvTS_DSPM.TabIndex = 7;
            this.dtgvTS_DSPM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTS_DSPM_CellContentClick);
            // 
            // Form_QL_Tra_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1308, 612);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form_QL_Tra_Sach";
            this.Text = "Quản lý Trả Sách";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTS_SL)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTS_DSPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtTS_Search;
        private System.Windows.Forms.RadioButton rabtnTS_MS;
        private System.Windows.Forms.RadioButton rabtnTS_MDG;
        private System.Windows.Forms.RadioButton rabtnTS_MP;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.TextBox txtTS_TDG;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtTS_TS;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnPhat;
        private System.Windows.Forms.TextBox txtTS_MS;
        private System.Windows.Forms.TextBox txtTS_MDG;
        private System.Windows.Forms.TextBox txtTS_MP;
        private System.Windows.Forms.DateTimePicker dtpkTS_NgayHetHan;
        private System.Windows.Forms.DateTimePicker dtpk_TS_NgayLapPhieu;
        private System.Windows.Forms.NumericUpDown numericUpDownTS_SL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvTS_DSPM;
        private System.Windows.Forms.Button btnTimDG;
    }
}