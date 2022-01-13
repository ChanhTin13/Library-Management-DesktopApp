using QuanLyThuVien_KeKao.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyThuVien_KeKao.DAO
{
    public class QL_Dang_Nhap
    {
        private static QL_Dang_Nhap thuc_Thi;

        public static QL_Dang_Nhap Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Dang_Nhap();
                }
                return thuc_Thi;
            }
        }

        private QL_Dang_Nhap() { }



        public bool DangNhap(string u, string pw)
        {
            string query = " select * from ACCOUNT where TK_ACC =  '" + u + "' and PASS = '" + pw + "' "; // Kiểm tra tài khoản

            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);

            return data.Rows.Count > 0;
        }
        public int Get_type_ACC(string u)
        {
            string query = " SELECT count(*) FROM ACCOUNT where TK_ACC =  N'" + u + "' and TYPE_ACC=1 ";
            int a;
            a = (int)DataProvider.Thuc_Thi.ExcuteScalar(query);
            Get_Type_Acc.Thuc_Thi.Get_Type(a);
            return a;
        }



        // Đoạn code dưới tạm thời không dùng
        public Account_DTO Tim_TK_Bang_TenTK(string TenTK)
        {
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from ACCOUNT where TK_ACC = '" + TenTK + "'");// Tìm tên Đăng Nhập
            foreach (DataRow item in data.Rows)
            {
                return new Account_DTO(item);
            }


            return null;
        }
    }
}



