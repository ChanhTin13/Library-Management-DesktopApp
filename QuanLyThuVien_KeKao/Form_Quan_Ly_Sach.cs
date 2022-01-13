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
    public partial class Form_Quan_Ly_Sach : Form
    {
        public Form_Quan_Ly_Sach()
        {
            InitializeComponent();
            ShowData();
        }
        private string dgDan;
        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtMaSach.Text == " ")
            {
                MessageBox.Show("Mã Sách Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaSach.Text == "")
            {
                MessageBox.Show("Mã Sách Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dtgvDS_Sach.DataSource = QL_Sach.Thuc_Thi.Them_Sach(new object[]
                { txtMaSach.Text  , txtTenSach.Text  , txtTheLoai.Text  , txtTG.Text  , txtNXB.Text  , txtNamXB.Text  , txtSLN.Text   , txtGia.Text   });

                ShowData();
            }

        }



        private void ShowData()
        {
            dtgvDS_Sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDS_Sach.DataSource = QL_Sach.Thuc_Thi.Load_Sach();
        }
        private void btnLoadDanhSach_Click(object sender, EventArgs e)
        {
            ShowData();
            btnHuy_Click(sender, e);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

            dtgvDS_Sach.DataSource = QL_Sach.Thuc_Thi.Sua_Sach(new object[]
            { txtMaSach.Text  , txtTenSach.Text  , txtTheLoai.Text  , txtTG.Text  , txtNXB.Text  , txtNamXB.Text  , txtSLN.Text ,txtSLC.Text , txtGia.Text   });

            ShowData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dtgvDS_Sach.DataSource = QL_Sach.Thuc_Thi.Xoa_Sach(new object[] { txtMaSach.Text });
            ShowData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTheLoai.Text = "";
            txtTG.Text = "";
            txtNXB.Text = "";
            txtNamXB.Text = ""; txtSLN.Text = ""; txtSLC.Text = ""; txtGia.Text = "";
            pictureBox_IMG.BackgroundImage = null;
            dgDan = null;
            btnLuuHinh.Enabled = false;

        }

        private void btnTim_Sach_Click(object sender, EventArgs e)
        {
            if (rabtnMaSach.Checked == true)
            {
                dtgvDS_Sach.DataSource = QL_Sach.Thuc_Thi.Tim_Sach_Theo_MaSach(txtMaSach.Text);
                ShowData();
            }
            else if (rabtnTenSach.Checked == true)
            {
                dtgvDS_Sach.DataSource = QL_Sach.Thuc_Thi.Tim_Sach_Theo_TenSach(txtTenSach.Text);
                ShowData();
            }
            else if (rabtnTenTG.Checked == true)
            {
                dtgvDS_Sach.DataSource = QL_Sach.Thuc_Thi.Tim_Sach_Theo_TenTacGia(txtTG.Text);
                ShowData();
            }
            else if (rabtnTheLoai.Checked == true)
            {
                dtgvDS_Sach.DataSource = QL_Sach.Thuc_Thi.Tim_Sach_Theo_ChuDe(txtTheLoai.Text);
                ShowData();
            }
        }

        private void dtgvDS_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dtgvDS_Sach.SelectedCells[0].OwningRow.Cells["Mã Sách"].Value.ToString();
            txtTenSach.Text = dtgvDS_Sach.SelectedCells[0].OwningRow.Cells["Tên Sách"].Value.ToString();
            txtTG.Text = dtgvDS_Sach.SelectedCells[0].OwningRow.Cells["Tên Tác Giả"].Value.ToString();

            txtTheLoai.Text = dtgvDS_Sach.SelectedCells[0].OwningRow.Cells["Thể Loại"].Value.ToString();
            txtSLN.Text = dtgvDS_Sach.SelectedCells[0].OwningRow.Cells["Số Lượng"].Value.ToString();
            txtSLC.Text = dtgvDS_Sach.SelectedCells[0].OwningRow.Cells["Số Lượng Còn"].Value.ToString();

            txtNXB.Text = dtgvDS_Sach.SelectedCells[0].OwningRow.Cells["Nhà Xuất Bản"].Value.ToString();
            txtNamXB.Text = dtgvDS_Sach.SelectedCells[0].OwningRow.Cells["Năm Xuất Bản"].Value.ToString();

            txtGia.Text = dtgvDS_Sach.SelectedCells[0].OwningRow.Cells["Giá"].Value.ToString();

            string hinh = dtgvDS_Sach.SelectedCells[0].OwningRow.Cells["IMG"].Value.ToString();
            if (hinh == "" )
            {
                pictureBox_IMG.BackgroundImage = null;
            }
            else if (hinh == null)
            {
                pictureBox_IMG.BackgroundImage = null;
            }
            else
            {
                pictureBox_IMG.BackgroundImage = Image.FromFile(hinh);
            }

        }
        //Sửa hình
        private void btnSuaHinh_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
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
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(" update SACH set IMG = @hinh where MA_SACH= @ma ", new object[] { dgDan, txtMaSach.Text });
            dgDan = null;
            MessageBox.Show("Sửa hình thành công");
            btnLuuHinh.Enabled = false;
        }
    }
}
