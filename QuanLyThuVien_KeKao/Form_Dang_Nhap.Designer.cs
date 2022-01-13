
namespace QuanLyThuVien_KeKao
{
    partial class Form_Dang_Nhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dang_Nhap));
            this.textEdit_TK = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Mat_Khau = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Dang_Nhap = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControl_Dang_ky = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Mat_Khau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit_TK
            // 
            this.textEdit_TK.Location = new System.Drawing.Point(475, 213);
            this.textEdit_TK.Name = "textEdit_TK";
            this.textEdit_TK.Size = new System.Drawing.Size(261, 22);
            this.textEdit_TK.TabIndex = 0;
            // 
            // textEdit_Mat_Khau
            // 
            this.textEdit_Mat_Khau.Location = new System.Drawing.Point(475, 269);
            this.textEdit_Mat_Khau.Name = "textEdit_Mat_Khau";
            this.textEdit_Mat_Khau.Properties.UseSystemPasswordChar = true;
            this.textEdit_Mat_Khau.Size = new System.Drawing.Size(261, 22);
            this.textEdit_Mat_Khau.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox3);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.button_Dang_Nhap);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.hyperlinkLabelControl_Dang_ky);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.textEdit_Mat_Khau);
            this.panelControl1.Controls.Add(this.textEdit_TK);
            this.panelControl1.Controls.Add(this.pictureBox2);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Location = new System.Drawing.Point(-3, -1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1045, 561);
            this.panelControl1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::QuanLyThuVien_KeKao.Properties.Resources.Eye_Close;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(742, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(413, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 46);
            this.label3.TabIndex = 17;
            this.label3.Text = "KeKao Library";
            // 
            // button_Dang_Nhap
            // 
            this.button_Dang_Nhap.Location = new System.Drawing.Point(607, 301);
            this.button_Dang_Nhap.Name = "button_Dang_Nhap";
            this.button_Dang_Nhap.Size = new System.Drawing.Size(129, 40);
            this.button_Dang_Nhap.TabIndex = 16;
            this.button_Dang_Nhap.Text = "Đăng Nhập";
            this.button_Dang_Nhap.UseVisualStyleBackColor = true;
            this.button_Dang_Nhap.Click += new System.EventHandler(this.button_Dang_Nhap_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(325, 310);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 17);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Bạn đã có tài khoản ?";
            // 
            // hyperlinkLabelControl_Dang_ky
            // 
            this.hyperlinkLabelControl_Dang_ky.Location = new System.Drawing.Point(475, 310);
            this.hyperlinkLabelControl_Dang_ky.Name = "hyperlinkLabelControl_Dang_ky";
            this.hyperlinkLabelControl_Dang_ky.Size = new System.Drawing.Size(46, 16);
            this.hyperlinkLabelControl_Dang_ky.TabIndex = 14;
            this.hyperlinkLabelControl_Dang_ky.Text = "Đăng ký";
            this.hyperlinkLabelControl_Dang_ky.Click += new System.EventHandler(this.hyperlinkLabelControl_Dang_ky_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật Khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tài Khoản:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(300, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(486, 199);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 556);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Dang_Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 562);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form_Dang_Nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Mat_Khau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit_TK;
        private DevExpress.XtraEditors.TextEdit textEdit_Mat_Khau;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl_Dang_ky;
        private System.Windows.Forms.Button button_Dang_Nhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

