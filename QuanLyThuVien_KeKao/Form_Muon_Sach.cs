using QuanLyThuVien_KeKao.DAO;
using QuanLyThuVien_KeKao.DTO;
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
    public partial class Form_Muon_Sach : Form
    {
        public Form_Muon_Sach()
        {
            InitializeComponent();
            ShowData();
        }

        

        

      
        //Cho Mượn Sách
        #region Cho Mượn Sách
        private void ShowData()
        {

            dtgv_DS_Muon.DataSource = QL_Muon_Sach.Thuc_Thi.ShowDaTa();
            dtpkNgayTra.Value = dtpkNgayMuon.Value.AddDays(14);
        }
        private void Huy()
        {

            pictureBox_DocGia.BackgroundImage = null;
            pictureBox_Sach_IMG.BackgroundImage = null;
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            dtp_NgayHetHan.Value = DateTime.Today;
            numericUpDown_SachCoTheMuon.Value = 0;
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTheLoai.Text = "";
            txtTG.Text = "";
            txtGia.Text = "";
            numericUpDown_SoSachCon.Value = 0;
            txt_MaDG_MS.Text = "";
            txt_MS_MuonSach.Text = "";
        }

        private void btn_ChoMuon_Click_1(object sender, EventArgs e)
        {
            if (txtMaDG.Text == txtMaSach.Text)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Không thể cho mượn", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (numericUpDown_SachCoTheMuon.Value == 0)
            {

                MessageBox.Show("Đọc giả chưa trả 2 quyển sách trước đó", "Không thể cho mượn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (numericUpDown_SoSachCon.Value == 0)
            {
                MessageBox.Show("Hết sách", "Không thể cho mượn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                QL_Muon_Sach.Thuc_Thi.Cho_Muon_Sach(new object[] { txt_MaDG_MS.Text , txt_MS_MuonSach.Text , txt_MaPhieu.Text });
                btnTimDG_Click(sender, e);
                btnTimMS_Click(sender, e);
                Huy();
                ShowData();
            }
        }
        #endregion

        private void btn_In_Click_1(object sender, EventArgs e)
        {

        }

        private void dtgv_DS_Muon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimMS_Click(object sender, EventArgs e)
        {
            List<DTO_Sach> a = QL_Muon_Sach.Thuc_Thi.GetList_Info_Sach(txtMaSach.Text);
            if (a.Count == 0)
            {
                //pictureBox_Sach_IMG.BackgroundImage = Do_an.Properties.Resources.Dau_cham_hoi1;
                MessageBox.Show("Không tìm thấy", "Thông báo");

            }
            else
            {

                txtMaSach.Text = a[0].MaSach;
                txtTenSach.Text = a[0].TenSach;
                txtTheLoai.Text = a[0].TheLoai;
                txtTG.Text = a[0].TacGia;
                txtGia.Text = a[0].Gia.ToString();

                txt_MS_MuonSach.Text = a[0].MaSach;
                numericUpDown_SoSachCon.Value = a[0].SoLuongCon;

                string hinh =  a[0].HinhAnh;
                if(hinh == "" || hinh == null)
                {
                    pictureBox_Sach_IMG.BackgroundImage = null;
                }
                else
                {
                    pictureBox_Sach_IMG.BackgroundImage = Image.FromFile(hinh); 
                }

            }
        }

        private void btnTimDG_Click(object sender, EventArgs e)
        {
            List<DTO_Doc_Gia> a = QL_Muon_Sach.Thuc_Thi.GetList_Info_DG(txtMaDG.Text);
            if (a.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");

            }
            else
            {
                int id = (int)DataProvider.Thuc_Thi.ExcuteScalar(" select count(*) +1 from PHIEU_MUON ");
                string b = Convert.ToString(id);
                string maPhieu = "PHIEU_MUON_" + b ;
                txt_MaPhieu.Text = maPhieu;
                foreach (DTO_Doc_Gia item in a)
                {
                    txtTenDG.Text = item.TenDG;
                    if (item.Gt)
                        rabtnNam.Checked = true;
                    else
                        rabtnNu.Checked = true;
                    dtp_NgayHetHan.Value = item.NgayHetHan;
                    numericUpDown_SachCoTheMuon.Value = item.Soluong;


                    txt_MaDG_MS.Text = txtMaDG.Text;

                    string hinh = a[0].HinhAnh;
                    if (hinh == "" || hinh == null)
                    {
                        pictureBox_Sach_IMG.BackgroundImage = null;
                    }
                    else
                    {
                        pictureBox_Sach_IMG.BackgroundImage = Image.FromFile(hinh);
                    }
                }

            }
        }
    }
}
