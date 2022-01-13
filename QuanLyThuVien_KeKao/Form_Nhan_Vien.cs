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
    public partial class Form_Nhan_Vien : Form
    {
        string dgDan;
        public Form_Nhan_Vien()
        {
            InitializeComponent();
            Load_NV();
        }

        //Sửa hình
        private void btnSuaHinh_Click(object sender, EventArgs e)
        {
            if (txtMa_NV.Text == "")
            {
                MessageBox.Show("Không có ai để sửa");
            }
            else
            {
                OpenFileDialog a = new OpenFileDialog();
                a.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                a.InitialDirectory = @"C:\Users\";
                a.Title = "Open";
                if (a.ShowDialog() == DialogResult.OK)
                {
                    dgDan = a.FileName;
                }
                btnLuuHinh.Enabled = true;
            }
        }

        private void btnLuuHinh_Click(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(" update NHAN_VIEN set IMG = @hinh where MA_NV= @ma ", new object[] { dgDan, txtMa_NV.Text });
            dgDan = null;
            MessageBox.Show("Sửa hình thành công");
            btnLuuHinh.Enabled = false;
        }


        private void Load_NV()
        {
            dtgv_NV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_NV.DataSource = QL_Nhan_Vien.Thuc_Thi.Load_NV();
        }
        private void btnLoadDanhSach_Click(object sender, EventArgs e)
        {
            Load_NV();
        }
        // Them_NHAN_VIEN @maNV , @TenNV , @gt ,  @NgaySinh , @SDT , @DiaChi
        private void btnThem_Click(object sender, EventArgs e)
        {
            int gt = rabtnNam.Checked == true ? 1 : 0;
            bool check;
            check = QL_Nhan_Vien.Thuc_Thi.Check_Nhan_Vien(txtMa_NV.Text);
            if (check == true)
            {
                dtgv_NV.DataSource = QL_Nhan_Vien.Thuc_Thi.Sua_Nhan_Vien(new object[]
                { txtMa_NV.Text , txtTenNV.Text , gt , dateTimePicker_NV.Value , txtSDT.Text , txtDiaChi.Text });
                MessageBox.Show("Sửa thành công");
                Load_NV();
            }
            else
            {
                dtgv_NV.DataSource = QL_Nhan_Vien.Thuc_Thi.Them_Nhan_Vien(new object[]
                { txtMa_NV.Text , txtTenNV.Text , gt , dateTimePicker_NV.Value , txtSDT.Text , txtDiaChi.Text });
                MessageBox.Show("Thêm thành công");
                Load_NV();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dtgv_NV.DataSource = QL_Nhan_Vien.Thuc_Thi.Xoa_Nhan_Vien(new object[]
                { txtMa_NV.Text  });
            MessageBox.Show("Xóa thành công");
            Load_NV();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMa_NV.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            dateTimePicker_NV.Value = DateTime.Today;
            btnLuuHinh.Enabled = false;
            dgDan = null;
            //Load_NV();
        }

        private void dtgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa_NV.Text = dtgv_NV.SelectedCells[0].OwningRow.Cells["Mã Nhân Viên"].Value.ToString();
            txtTenNV.Text = dtgv_NV.SelectedCells[0].OwningRow.Cells["Tên Nhân Viên"].Value.ToString();

            dateTimePicker_NV.Value = (DateTime)dtgv_NV.SelectedCells[0].OwningRow.Cells["Ngày Sinh"].Value;
            rabtnNam.Checked = bool.Parse(dtgv_NV.SelectedCells[0].OwningRow.Cells["Giới Tính"].Value.ToString()) == true ? true : false;
            rabtnNu.Checked = bool.Parse(dtgv_NV.SelectedCells[0].OwningRow.Cells["Giới Tính"].Value.ToString()) == false ? true : false;

            txtSDT.Text = dtgv_NV.SelectedCells[0].OwningRow.Cells["SĐT"].Value.ToString();
            txtDiaChi.Text = dtgv_NV.SelectedCells[0].OwningRow.Cells["Địa Chỉ"].Value.ToString();
            string hinh = dtgv_NV.SelectedCells[0].OwningRow.Cells["IMG"].Value.ToString();
            if (hinh == "")
            {
                pictureBox1.BackgroundImage = null;
            }
            else if (hinh == null)
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
