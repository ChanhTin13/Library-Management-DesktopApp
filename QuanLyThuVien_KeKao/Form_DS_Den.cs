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
    public partial class Form_DS_Den : Form
    {
        public Form_DS_Den()
        {
            InitializeComponent();
            Load_Danh_Sach();
        }

        private void Form_DS_Den_SizeChanged(object sender, EventArgs e)
        {
            this.Size= new Size(1012, 559);
        }

        private void txt_GhiChu_TextChanged(object sender, EventArgs e)
        {

        }
        private void Load_Danh_Sach()
        {

            dtgvDS_Den.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDS_Den.DataSource = QL_Danh_Sach_Den.Thuc_Thi.ShowData();
        }
        private void btnLoadDanhSach_Click(object sender, EventArgs e)
        {
            
            Load_Danh_Sach();
        }

        private void rabtnNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Loai_Bo_Click(object sender, EventArgs e)
        {
            if(txtMaDG.Text== "" || txtMaDG.Text == null)
            {
                MessageBox.Show("Bạn muốn Loại ai khỏi Danh Sách Đen ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dtgvDS_Den.DataSource = QL_Danh_Sach_Den.Thuc_Thi.Loai_Khoi_Danh_Sach_Den(  txtMaDG.Text  );
            Load_Danh_Sach();
        }

        private void btn_Xoa_DS_Click(object sender, EventArgs e)
        {
            dtgvDS_Den.DataSource = QL_Danh_Sach_Den.Thuc_Thi.Xoa_Het_DS_Den();
            Load_Danh_Sach();
        }

        private void dtgvDS_Den_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDG.Text = dtgvDS_Den.SelectedCells[0].OwningRow.Cells["Mã Đọc Giả"].Value.ToString();
            txtTenDG.Text = dtgvDS_Den.SelectedCells[0].OwningRow.Cells["Tên Đọc Giả"].Value.ToString();
            txt_GhiChu.Text = dtgvDS_Den.SelectedCells[0].OwningRow.Cells["Ghi Chú"].Value.ToString();

            rabtnNam.Checked = bool.Parse(dtgvDS_Den.SelectedCells[0].OwningRow.Cells["Giới Tính"].Value.ToString()) == true ? true : false;
            rabtnNu.Checked = bool.Parse(dtgvDS_Den.SelectedCells[0].OwningRow.Cells["Giới Tính"].Value.ToString()) == false ? true : false;

            string hinh = dtgvDS_Den.SelectedCells[0].OwningRow.Cells["IMG"].Value.ToString();
            if (hinh == "" || hinh == null)
            {
                pictureBox1.BackgroundImage = null;

            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile(hinh);
            } 
        }
    }
}
