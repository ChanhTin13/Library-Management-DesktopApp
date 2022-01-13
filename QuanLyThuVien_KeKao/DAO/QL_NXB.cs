using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_KeKao.DAO
{
    public class QL_NXB
    {
        private static QL_NXB thuc_Thi;

        public static QL_NXB Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_NXB();
                }
                return thuc_Thi;
            }
        }

        public DataTable ShowData()
        {
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(" LOAD_NXB ");
        }
        private int Check_MaNXB(object parameter)
        {
            string q = " SELECT COUNT(*) FROM NXB WHERE MA_NXB LIKE N'" + parameter + "'"; // kt co Ma NXB co ton tai khong
            return (int)DataProvider.Thuc_Thi.ExcuteScalar(q);
        }
        public DataTable Luu_NXB(object[] parameter = null) // @MA_NXB , @TEN_NXB , @SDT , @Dia_Chi
        {
            if (Check_MaNXB(parameter[0]) == 0) // Thêm-- Insert
            {
                string q = " INSERT INTO NXB VALUES ( @MA_NXB , @TEN_NXB , @SDT , @Dia_Chi )";
                MessageBox.Show( "Thêm thành công","Thông báo", MessageBoxButtons.OK);
                return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q, parameter);
                
            }
            else // Sửa--Update
            {
                string q = " SUA_NXB @MA_NXB , @TEN_NXB , @SDT , @Dia_Chi "; // update query
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q, new object[] { parameter[0] , parameter[1] , parameter[2] , parameter[3] });
            } 
        }
        public bool Co_the_Xoa(object parameter)
        {
            int a;
            string q = " SELECT COUNT(*) FROM SACH WHERE MA_NXB LIKE N'" + parameter + "'"; //
            a= (int)DataProvider.Thuc_Thi.ExcuteScalar(q);
            return a > 0;
        }
        public DataTable Xoa_NXB(object[] parameter = null)
        {
            
            if ( Co_the_Xoa(parameter[0]) == true) // Thêm-- Insert
            {
                MessageBox.Show("Không thể xóa", "Còn Sách", MessageBoxButtons.OK);
                return null;

            }
            string q = " DELETE NXB WHERE MA_NXB= @MA_NXB "; // delete query
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q, parameter);
        }



    }
}
