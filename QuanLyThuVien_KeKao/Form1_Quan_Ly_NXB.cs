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
    public partial class Form1_Quan_Ly_NXB : Form
    {
        public Form1_Quan_Ly_NXB()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataGridView_DS_NCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DS_NCC.DataSource = QL_NXB.Thuc_Thi.ShowData();
        }
        private void dataGridView_DS_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textEdit_Ma_NCC.Text = dataGridView_DS_NCC.SelectedCells[0].OwningRow.Cells["Mã Nhà Xuất Bản"].Value.ToString();
            textEdit_Ten_NCC.Text = dataGridView_DS_NCC.SelectedCells[0].OwningRow.Cells["Tên Nhà Xuất Bản"].Value.ToString();
            textEdit_SDT_NCC.Text = dataGridView_DS_NCC.SelectedCells[0].OwningRow.Cells["Số Điện Thoại"].Value.ToString();
            textEdit_DiaChi_NCC.Text = dataGridView_DS_NCC.SelectedCells[0].OwningRow.Cells["Địa Chỉ"].Value.ToString();
        }

        private void btnLoadDanhSach_Click(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            dataGridView_DS_NCC.DataSource = QL_NXB.Thuc_Thi.Luu_NXB(new object[] { textEdit_Ma_NCC.Text , textEdit_Ten_NCC.Text , textEdit_SDT_NCC.Text , textEdit_DiaChi_NCC.Text });
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dataGridView_DS_NCC.DataSource = QL_NXB.Thuc_Thi.Xoa_NXB(new object[] { textEdit_Ma_NCC.Text });
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
            textEdit_Ma_NCC.Text = "";
            textEdit_Ten_NCC.Text = "";
            textEdit_SDT_NCC.Text = "";
            textEdit_DiaChi_NCC.Text = "";
        }
    }
}
