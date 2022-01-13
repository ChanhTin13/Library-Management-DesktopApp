using DevExpress.ClipboardSource.SpreadsheetML;
using QuanLyThuVien_KeKao.DAO;
using QuanLyThuVien_KeKao.Form_Report;
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
    public partial class Form_Doc_Gia : Form
    {
        public Form_Doc_Gia()
        {
            InitializeComponent();
            ShowData();
        }
        private string dgDan;

        private void ShowData()
        {

            dtgvDoc_Gia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDoc_Gia.DataSource = QL_Doc_Gia.Thuc_Thi.ShowData();
        }

        private void btnLoadDanhSach_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        //Thêm
            #region Thêm
        private void checkBox_Them_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Them.Checked == true)
            {
                btnThem.Enabled = true;
                button_Them_Vao_DS_Den.Enabled = false;
                btnSua.Enabled = false;

                txtMaDG.Enabled = false;
                txtMaDG.Text = "";

            }
            else
            {
                btnHuy_Click(sender, e);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime ngaySinh = dateTimePicker1.Value;

            int gt = rabtnNam.Checked ? 1 : 0;

            dtgvDoc_Gia.DataSource = QL_Doc_Gia.Thuc_Thi.Them_Doc_Gia(new object[]
            {  txtTenDG.Text , gt , ngaySinh , txtSDT.Text , txtDiaChi.Text , txt_GhiChu.Text });

            ShowData();
            MessageBox.Show("Thêm thành công");
        }
        #endregion

        // Sua_Doc_Gia  @maDG , @TenDG , @gt ,  @NgaySinh , @SDT , @DiaChi , @GhiChu
        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime ngaySinh = dateTimePicker1.Value; 

            int gt = rabtnNam.Checked ? 1 : 0;
            dtgvDoc_Gia.DataSource = QL_Doc_Gia.Thuc_Thi.Sua_Doc_Gia(new object[]
            { txtMaDG.Text , txtTenDG.Text , gt , ngaySinh , txtSDT.Text , txtDiaChi.Text , txt_GhiChu.Text });

            ShowData();
            MessageBox.Show("Sửa thành công");
        }

        // Thêm vào danh sách đen
        private void button_Them_Vao_DS_Den_Click(object sender, EventArgs e)
        {
            dtgvDoc_Gia.DataSource = QL_Doc_Gia.Thuc_Thi.Them_Vao_Danh_Sach_Den(new object[] { txtMaDG.Text  });

            ShowData();
        }

        
        // Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            //btnLuuHinh.Enabled = true;
            btnSuaHinh.Enabled = true;
            dgDan = null;

            checkBox_Them.Checked = false;
            btnThem.Enabled = false;
            button_Them_Vao_DS_Den.Enabled = true;
            btnSua.Enabled = true;
            txtMaDG.Enabled = true;

            txtMaDG.Text = "";
            txtTenDG.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dtp_NgayHetHan.Value = DateTime.Today;
            dtp_NgayLapThe.Value = DateTime.Today;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txt_GhiChu.Text = "";
            numericUpDown_SachCoTheMuon.Value = 2;
        }
        
        //Sửa Hình
        private void btnSuaHinh_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "")
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

        //Lưu Hình
        private void btnLuuHinh_Click(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(" update DOCGIA set IMG = @hinh where MA_DOCGIA= @ma ", new object[] { dgDan, txtMaDG.Text });
            dgDan = null;
            MessageBox.Show("Sửa hình thành công");
            btnLuuHinh.Enabled = false; 
        }
        //Show content cell
        private void dtgvDoc_Gia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBox_Them.Checked == true)
            {
                txtMaDG.Text = "";
            }
            else
            {
                txtMaDG.Text = dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["Mã Đọc Giả"].Value.ToString();
            }
            rabtnNam.Checked = bool.Parse(dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["Giới Tính"].Value.ToString()) == true ? true : false;
            rabtnNu.Checked = bool.Parse(dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["Giới Tính"].Value.ToString()) == false ? true : false;

            txtTenDG.Text = dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["Tên Đọc Giả"].Value.ToString();
            txtDiaChi.Text = dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["Địa Chỉ"].Value.ToString();
            txtSDT.Text = dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["SĐT"].Value.ToString();
            txt_GhiChu.Text = dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["Ghi Chú"].Value.ToString();
            numericUpDown_SachCoTheMuon.Value = (int)dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["Số sách có thể mượn"].Value;

            dateTimePicker1.Value = (DateTime)dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["Ngày Sinh"].Value;
            dtp_NgayLapThe.Value = (DateTime)dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["Ngày Lập Thẻ"].Value;
            dtp_NgayHetHan.Value = (DateTime)dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["Ngày Hết Hạn"].Value;

            string hinh = dtgvDoc_Gia.SelectedCells[0].OwningRow.Cells["IMG"].Value.ToString();
            if(hinh == "" || hinh == null)
            {
                pictureBox1.BackgroundImage = null;

            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile(hinh);
            }
            
        }

        private void btnTimDG_Click(object sender, EventArgs e)
        {
            if(rabtnMDG.Checked==true)
            {
                dtgvDoc_Gia.DataSource = QL_Doc_Gia.Thuc_Thi.Tim_Doc_Gia_Theo_MaDG(txtSearch.Text);
                ShowData();

            }   
            else if(rabtnTDG.Checked==true)
            {
                dtgvDoc_Gia.DataSource = QL_Doc_Gia.Thuc_Thi.Tim_Doc_Gia_Theo_Ten(txtSearch.Text);
                ShowData();
            }    
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            var r = new In_The_Thu_Vien();
            Get_Info_To_Print();
            r.DataSource= QL_Doc_Gia.Thuc_Thi.ShowData();
            r.ShowDesigner();
        }

        private void Get_Info_To_Print()
        {
            Get_Info_Doc_Gia.Thuc_Thi.Set_Ten_MDG(txtMaDG.Text);
            Get_Info_Doc_Gia.Thuc_Thi.Set_Ten_TDG(txtTenDG.Text);
            Get_Info_Doc_Gia.Thuc_Thi.Set_Ten_NS(dateTimePicker1.Value.ToString());
            if(rabtnNam.Checked==true)
            {
                Get_Info_Doc_Gia.Thuc_Thi.Set_Ten_MDG("Nam");

            }   
            else
            {
                Get_Info_Doc_Gia.Thuc_Thi.Set_Ten_MDG("Nữ");

            }
            Get_Info_Doc_Gia.Thuc_Thi.Set_Ten_NLT(dtp_NgayLapThe.Value.ToString());

        }
    }
}
