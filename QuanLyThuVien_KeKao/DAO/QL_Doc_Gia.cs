using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_KeKao.DAO
{
    public class QL_Doc_Gia
    {

        private static QL_Doc_Gia thuc_Thi;

        public static QL_Doc_Gia Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Doc_Gia();
                }
                return thuc_Thi;
            }
        }

        //Show
        public DataTable ShowData()
        {
            string query = "SHOW_INFO_DOC_GIA";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
        //Tìm
        public DataTable Tim_Doc_Gia_Theo_MaDG(string x)
        {
            string query = " Tim_Doc_Gia_Theo_MaDG ('" + x + "') ";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
        public DataTable Tim_Doc_Gia_Theo_Ten(string x)
        {
            string query = " Tim_Doc_Gia_Theo_Ten ('" + x + "') ";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }

        //Thêm
        public DataTable Them_Doc_Gia(object[] parameter = null)
        {
            string query = " Them_Doc_Gia  @TenDG , @gt ,  @NgaySinh , @SDT , @DiaChi , @GhiChu ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, parameter);
            return data;
        }

        //Sửa
        public DataTable Sua_Doc_Gia(object[] parameter = null)
        {
            string query = " Sua_Doc_Gia  @maDG , @TenDG , @gt ,  @NgaySinh , @SDT , @DiaChi , @GhiChu ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, parameter);
            return data;
        }

        //Thêm DS Đen
        public DataTable Them_Vao_Danh_Sach_Den(object[] parameter = null)
        {
            string query = " Them_Vao_Danh_Sach_Den  @maDG  ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, parameter);
            return data;
        }


    }
}
