using DevExpress.XtraReports.UI;
using QuanLyThuVien_KeKao.DAO;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyThuVien_KeKao.Form_Report
{
    public partial class In_The_Thu_Vien : DevExpress.XtraReports.UI.XtraReport
    {
        public In_The_Thu_Vien()
        {
            InitializeComponent();
            
            lb_MDG.Text = Get_Info_Doc_Gia.Thuc_Thi.MDG;
            lb_TDG.Text = Get_Info_Doc_Gia.Thuc_Thi.TDG;
            lb_GT.Text = Get_Info_Doc_Gia.Thuc_Thi.GT;
            lb_NS.Text = Get_Info_Doc_Gia.Thuc_Thi.NS;
            lb_NLT.Text = Get_Info_Doc_Gia.Thuc_Thi.NLT;
        }
        public void ShowPreView()
        {
            this.ShowPreviewDialog();
        }

        public void ShowDesigner()
        {
            this.ShowDesignerDialog();
        }
    }
}
