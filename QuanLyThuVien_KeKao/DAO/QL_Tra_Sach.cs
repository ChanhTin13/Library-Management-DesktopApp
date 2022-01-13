using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DAO
{ 
    public class QL_Tra_Sach
    {
        private static QL_Tra_Sach thuc_Thi;

        public static QL_Tra_Sach Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Tra_Sach();
                }
                return thuc_Thi;
            }
        }

        //
        public DataTable ShowDaTa()
        {
            string query = " LOAD_DS_TraSach ";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
        public DataTable Tim_Theo_MAPhieu(string x)
        {
            string query = " select * from ShowFor_TraSach() where [Mã Phiếu] like N'" + x + "'";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
        public DataTable Tim_Theo_MaSach(string x)
        {
            string query = " select * from ShowFor_TraSach() where [Mã Sách] like N'" + x + "'";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
            return data;
        }
        public DataTable Tim_Theo_MaDocGia(string x)
        {
            string query = " select * from ShowFor_TraSach() where [Mã Đọc Giả] like N'" + x + "'";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
            return data;
        }
        public DataTable Tra_Sach(object[] para = null)
        {
            string q = "Tra_Sach @mp , @mdg , @ms ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q, para);
            return data;
        }
        public DataTable Phat(object[] para)
        {
            string q = " LAP_PHIEU_PHAT  @MA_PHIEU_MUON , @MA_SACH  ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q, para);
            return data;
        }
        public DataTable Gia_Han(string x)
        {
            string q = " GIA_HAN N'" + x + "'";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q);
            return data;
        }
    }
}
