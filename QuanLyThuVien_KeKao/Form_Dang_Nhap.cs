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
    public partial class Form_Dang_Nhap : Form
    {
        public Form_Dang_Nhap()
        {
            InitializeComponent(); 
            
        }

      

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bool is_Clicked = textEdit_Mat_Khau.Properties.UseSystemPasswordChar;
            if(is_Clicked == true)
            {
                pictureBox3.BackgroundImage = Properties.Resources.eye_Open;
                textEdit_Mat_Khau.Properties.UseSystemPasswordChar = false;
            }    
            else
            {
                pictureBox3.BackgroundImage = Properties.Resources.Eye_Close;
                textEdit_Mat_Khau.Properties.UseSystemPasswordChar = true;
            }

        }
         

        private void hyperlinkLabelControl_Dang_ky_Click(object sender, EventArgs e)
        {
            Form_Dang_Ky f = new Form_Dang_Ky();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        bool DangNhap(string u, string pw)
        {
            try
            {
                return QL_Dang_Nhap.Thuc_Thi.DangNhap(u, pw);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }

        private void button_Dang_Nhap_Click(object sender, EventArgs e)
        {
            string u = textEdit_TK.Text;
            string p = textEdit_Mat_Khau.Text;

            if (DangNhap(u, p) == true)
            {
                int type_acc = QL_Dang_Nhap.Thuc_Thi.Get_type_ACC(u);

                //this.Tag = type_acc;

                Main_Form f = new Main_Form();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    }
}
