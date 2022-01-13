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
    public partial class Form_Dang_Ky : Form
    {
        public Form_Dang_Ky()
        {
            InitializeComponent();
        }
        

        private void button_Dang_Ky_Click(object sender, EventArgs e)
        {
            DataTable data;
            try
            {
                data = QL_Dang_Ky_TK.Thuc_Thi.Dang_Ky(new object[] { textEdit_MNV.Text, textEdit_TK.Text, textEdit_Mat_Khau.Text, textEdit_NLMK.Text });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ;
            }

            if(data ==null)
            {
                return;
            } 
            else
            {
                this.Hide();
            }    

        }

        private void pictureBox_MK_Click(object sender, EventArgs e)
        {
            bool is_Clicked = textEdit_Mat_Khau.Properties.UseSystemPasswordChar;
            if (is_Clicked == true)
            {
                pictureBox_MK.BackgroundImage = Properties.Resources.eye_Open;
                textEdit_Mat_Khau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_MK.BackgroundImage = Properties.Resources.Eye_Close;
                textEdit_Mat_Khau.Properties.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox_NLMK_Click(object sender, EventArgs e)
        {
            bool is_Clicked_NLMK = textEdit_NLMK.Properties.UseSystemPasswordChar;
            if (is_Clicked_NLMK == true)
            {
                pictureBox_NLMK.BackgroundImage = Properties.Resources.eye_Open;
                textEdit_NLMK.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_NLMK.BackgroundImage = Properties.Resources.Eye_Close;
                textEdit_NLMK.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}
