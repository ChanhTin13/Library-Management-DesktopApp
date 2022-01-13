using Microsoft.Win32;
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
    public partial class Form_QL_Tra_Sach : Form
    {
        public Form_QL_Tra_Sach()
        {
            InitializeComponent();
            ShowData();

        }
        private void ShowData()
        {

            dtgvTS_DSPM.DataSource = QL_Tra_Sach.Thuc_Thi.ShowDaTa();
            //dtpk_TS_NgayLapPhieu.Value = dtpkNgayMuon.Value.AddDays(14);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DateTimePicker a = new DateTimePicker();
            txtTS_MP.Text = "";
            txtTS_MS.Text = "";
            txtTS_MDG.Text = "";

            dtpk_TS_NgayLapPhieu.Value = a.Value;
            dtpkTS_NgayHetHan.Value = a.Value;

            txtTS_TS.Text = "";
            txtTS_TDG.Text = "";
            btnPhat.Enabled = false;
            //btnPhat.BackColor = Color.LightGray;
            ShowData();
        }

        private void dtgvTS_DSPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //255, 128, 128
            txtTS_MP.Text = dtgvTS_DSPM.SelectedCells[0].OwningRow.Cells["Mã Phiếu"].Value.ToString();
            txtTS_MS.Text = dtgvTS_DSPM.SelectedCells[0].OwningRow.Cells["Mã Sách"].Value.ToString();
            txtTS_MDG.Text = dtgvTS_DSPM.SelectedCells[0].OwningRow.Cells["Mã Đọc Giả"].Value.ToString();

            dtpk_TS_NgayLapPhieu.Value = (DateTime)dtgvTS_DSPM.SelectedCells[0].OwningRow.Cells["Ngày Lập Phiếu"].Value;
            dtpkTS_NgayHetHan.Value = (DateTime)dtgvTS_DSPM.SelectedCells[0].OwningRow.Cells["Hạn Trả"].Value;

            txtTS_TS.Text = dtgvTS_DSPM.SelectedCells[0].OwningRow.Cells["Tên Sách"].Value.ToString();
            txtTS_TDG.Text = dtgvTS_DSPM.SelectedCells[0].OwningRow.Cells["Tên Đọc Giả"].Value.ToString();
            

            DateTimePicker a = new DateTimePicker();
            if (dtpkTS_NgayHetHan.Value < a.Value)
            {
                btnPhat.Enabled = true;
                btnPhat.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                btnPhat.Enabled = false;
                btnPhat.BackColor = Color.LightGray;
            }
        }

        private void btnTimDG_Click(object sender, EventArgs e)
        {
            if (rabtnTS_MP.Checked == true)
            {
                dtgvTS_DSPM.DataSource = QL_Tra_Sach.Thuc_Thi.Tim_Theo_MAPhieu(txtTS_Search.Text);
            }
            else if( rabtnTS_MDG.Checked==true)
            {
                dtgvTS_DSPM.DataSource = QL_Tra_Sach.Thuc_Thi.Tim_Theo_MaDocGia(txtTS_Search.Text);
            }   
            else if(rabtnTS_MS.Checked==true)
            {
                dtgvTS_DSPM.DataSource = QL_Tra_Sach.Thuc_Thi.Tim_Theo_MaSach(txtTS_Search.Text);
            }
            
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if(txtTS_MP.Text=="")
            {
                MessageBox.Show("Mã phiếu trống");
            }
            else
            {
                dtgvTS_DSPM.DataSource = QL_Tra_Sach.Thuc_Thi.Gia_Han(txtTS_MP.Text);
                ShowData();
            }
            

            
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (dtpkTS_NgayHetHan.Value < DateTime.Today || btnPhat.Enabled == true )
            {
                btnPhat.Enabled = true;
                MessageBox.Show("Cần lập phiếu phạt", "Thông báo");
                
            }
            if(btnPhat.Enabled== false)
            {
                txtTS_MP.Text = dtgvTS_DSPM.SelectedCells[0].OwningRow.Cells["Mã phiếu"].Value.ToString();
                QL_Tra_Sach.Thuc_Thi.Tra_Sach(new object[] { txtTS_MP.Text, txtTS_MDG.Text, txtTS_MS.Text });
                ShowData();

                MessageBox.Show("Trả sách thành công", "Thông báo");
                btnReload_Click(sender, e);
            }    
            
            
        }

        private void btnPhat_Click(object sender, EventArgs e)
        {
            btnPhat.Enabled = false;
        }
    }
}
