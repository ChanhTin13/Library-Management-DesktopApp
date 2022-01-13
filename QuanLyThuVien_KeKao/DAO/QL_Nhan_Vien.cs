using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DAO
{
    public class QL_Nhan_Vien
    {
        private static QL_Nhan_Vien thuc_Thi;

        public static QL_Nhan_Vien Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Nhan_Vien();
                }
                return thuc_Thi;
            }
        }

        //Show
        public DataTable Load_NV()
        {
            string query = "SHOW_NHAN_VIEN"; 
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
        //Thêm
        public bool Check_Nhan_Vien(string ma_NV)
        {
            int x;
            x= (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from NHAN_VIEN where MA_NV like N'"+ma_NV+"'");
            return x > 0;
        } 
        public DataTable Them_Nhan_Vien(object[] parameter = null)
        {
            string query = " THEM_NHAN_VIEN @maNV , @TenNV , @gt ,  @NgaySinh , @SDT , @DiaChi ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, parameter);
            return data;
        }
        // Sửa
        public DataTable Sua_Nhan_Vien(object[] parameter = null)
        {
            string query = " SUA_NHAN_VIEN  @maNV , @TenNV , @gt ,  @NgaySinh , @SDT , @DiaChi ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, parameter);
            return data;
        }
        // Xóa
        public DataTable Xoa_Nhan_Vien(object[] parameter = null)
        {
            string query = " XOA_NHAN_VIEN  @maNV  ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, parameter);
            return data;
        }

    }
}
