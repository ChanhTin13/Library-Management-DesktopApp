using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using QuanLyThuVien_KeKao;
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
    public partial class Main_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main_Form()
        {
            InitializeComponent();
            dPanel_TienIch.Options.ShowCloseButton = false;
            Form f = new Form_Trang_Chu();
            f.MdiParent = this;
            f.Show();
        }
        private bool da_Co_Form(Form f)
        {
            foreach(var child in MdiChildren)
            {
                if(child.Name == f.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void barButton_Home_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new Form_Trang_Chu();

            f.MdiParent = this;
            f.Show();  



        }

        private void barButtonItem_Doc_Gia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Doc_Gia f = new Form_Doc_Gia();
            if (da_Co_Form(f))
                return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem_Doi_MK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Doi_MK f = new Form_Doi_MK();
            
            if (da_Co_Form(f))
                return;
            f.MdiParent = this;
            f.Show();

        }

        private void barButtonItem_Sach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Quan_Ly_Sach f = new Form_Quan_Ly_Sach();
            if (da_Co_Form(f))
                return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem_NCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form1_Quan_Ly_NXB f = new Form1_Quan_Ly_NXB();
            if (da_Co_Form(f))
                return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem_Thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem_Danh_sach_den_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_DS_Den f = new Form_DS_Den();
            if (da_Co_Form(f))
                return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem_Muon_Sach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Muon_Sach f = new Form_Muon_Sach();
            if (da_Co_Form(f))
                return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem_Tra_Sach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_QL_Tra_Sach f = new Form_QL_Tra_Sach();
            if (da_Co_Form(f))
                return;
            f.MdiParent = this;
            f.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {  
            //object type_acc = (sender as Form_Dang_Nhap).Tag;
            //object x = 1;
            int type = Get_Type_Acc.Thuc_Thi.Set_Type();
            if (type==1)
            {
                ribbonPageGroup_Nhan_vien.Visible = false;
                ribbonPage_Bao_Cao_Thong_Ke.Visible = false;
            }
        }

        private void barButtonItem_Nhan_vien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Nhan_Vien f = new Form_Nhan_Vien();
            if (da_Co_Form(f))
                return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem_Thong_ke_Sach_va_Doc_gia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Thong_Ke f = new Form_Thong_Ke();
            if (da_Co_Form(f))
                return;
            f.MdiParent = this;
            f.Show();
        }
    }
}