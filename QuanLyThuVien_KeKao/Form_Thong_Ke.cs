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
    public partial class Form_Thong_Ke : Form
    {
        public Form_Thong_Ke()
        {
            InitializeComponent();
            int SLDS = (int)DataProvider.Thuc_Thi.ExcuteScalar("DEM_SO_LUONG_DAU_SACH");
            textBoxSLDS.Text = SLDS.ToString();

            int SLS = (int)DataProvider.Thuc_Thi.ExcuteScalar("DEM_SO_LUONG_SACH");
            textBox_SLS.Text = SLS.ToString();

            int SLSDCM = (int)DataProvider.Thuc_Thi.ExcuteScalar(" DEM_SO_LUONG_SACH_DANG_CHO_MUON ");
            textBox_SSDCM.Text = SLSDCM.ToString();

            int SLSCL = SLS - SLSDCM;
            textBoxSLSCL.Text = SLSCL.ToString();

            textBox_SLSQH.Text = DataProvider.Thuc_Thi.ExcuteScalar("DEM_SO_LUONG_SACH_QUA_HAN").ToString();

            txtso_luong_doc_gia.Text = DataProvider.Thuc_Thi.ExcuteScalar("DEM_SO_LUONG_DOC_GIA").ToString();

            txtDG_dang_muon_sach.Text = DataProvider.Thuc_Thi.ExcuteScalar("DEM_SO_LUONG_DOC_GIA_DANG_MUON_SACH").ToString();
            txtDG_muon_sach_qua_han.Text = DataProvider.Thuc_Thi.ExcuteScalar("DEM_SO_LUONG_DOC_GIA_MUON_SACH_QUA_HAN").ToString();

            dgvDG_muon_sach_qua_han.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("DANH_SACH_DOC_GIA_MUON_SACH_QUA_HAN");
            dgvsach_qua_han.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("DANH_SACH_SACH_QUA_HAN");
        }

        private void Form_Thong_Ke_Load(object sender, EventArgs e)
        {

        }
    }
}
