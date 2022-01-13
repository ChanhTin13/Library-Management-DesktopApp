using QuanLyThuVien_KeKao.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_KeKao
{
    public partial class Form_Doi_MK : Form
    {
        public Form_Doi_MK()
        {
            InitializeComponent();
        }

        private void pictureBox_MK_Click(object sender, EventArgs e)
        {
            bool is_Clicked = textEdit_Mk.Properties.UseSystemPasswordChar;
            if (is_Clicked == true)
            {
                pictureBox_MK.BackgroundImage = Properties.Resources.eye_Open;
                textEdit_Mk.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_MK.BackgroundImage = Properties.Resources.Eye_Close;
                textEdit_Mk.Properties.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox_MKM_Click(object sender, EventArgs e)
        {
            bool is_Clicked = textEdit_Mat_Khau_Moi.Properties.UseSystemPasswordChar;
            if (is_Clicked == true)
            {
                pictureBox_MKM.BackgroundImage = Properties.Resources.eye_Open;
                textEdit_Mat_Khau_Moi.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_MKM.BackgroundImage = Properties.Resources.Eye_Close;
                textEdit_Mat_Khau_Moi.Properties.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox_NLMK_Click(object sender, EventArgs e)
        {
            bool is_Clicked = textEdit_NLMKM.Properties.UseSystemPasswordChar;
            if (is_Clicked == true)
            {
                pictureBox_NLMK.BackgroundImage = Properties.Resources.eye_Open;
                textEdit_NLMKM.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_NLMK.BackgroundImage = Properties.Resources.Eye_Close;
                textEdit_NLMKM.Properties.UseSystemPasswordChar = true;
            }
        }

        private void Form_Doi_MK_SizeChanged(object sender, EventArgs e)
        {
            //this.Size = new Size(1012, 559);
        }

        bool DangNhap(string u, string pw)
        {
            return QL_Dang_Nhap.Thuc_Thi.DangNhap(u, pw);
        }
        

        private void button_Doi_MK_Click(object sender, EventArgs e)
        {
            if (!DangNhap(textEdit_TK.Text, textEdit_Mk.Text))
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (textEdit_Mat_Khau_Moi.Text != textEdit_NLMKM.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại đéo khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                string q = " update ACCOUNT set PASS= @x where TK_ACC= @tk ";
                DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q, new object[] { textEdit_NLMKM.Text, textEdit_TK.Text });
                MessageBox.Show("Đổi Mật Khẩu Thành Công");
                this.Close();
                //return;
            }
        }
    }
}
