using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_KeKao.DAO
{
    public class QL_Sach
    {
        private static QL_Sach thuc_Thi;

        public static QL_Sach Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Sach();
                }
                return thuc_Thi;
            }
        }
        bool check_Ma_Sach(object ma_Sach)
        {
            string kiem_tra_Ma_Sach = " select count(*) from SACH where MA_SACH like N'" + ma_Sach + "'";
            int x = (int)DataProvider.Thuc_Thi.ExcuteScalar(kiem_tra_Ma_Sach);
            return x > 0;
        }
        bool check_Ma_NXB(object TEN_NXB)
        {
            string kiem_tra_TEN_NXB = " select count(*) from NXB where TEN_NXB like N'" + TEN_NXB + "'";
            int x = (int)DataProvider.Thuc_Thi.ExcuteScalar(kiem_tra_TEN_NXB);
            return x > 0;
        }

        public DataTable Them_Sach(object[] parameter = null)
        {
            
            if( check_Ma_Sach( parameter[0] ) == true )
            {
                MessageBox.Show("Mã sách bị trùng", "Không thể thêm sách mới", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }    
            else if(check_Ma_NXB(parameter[4]) ==true )
            {
                string query = " THEM_SACH @MA_SACH , @TEN_SACH , @THE_LOAI , " +
                    " @TAC_GIA , @NXB , @NAM_XB , @SO_LUONG  , @GIA  ";
                DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, parameter);
                return data;
            }
            else
            {
                MessageBox.Show("Tên Nhà Xuất Bản không tồn tại", "Không thể thêm sách mới", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable Sua_Sach(object[] parameter = null)
        {
            if (check_Ma_Sach(parameter[0]) == false)
            {
                MessageBox.Show("Mã Sách không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            



            string query = " SUA_SACH  @MA_SACH , @TEN_SACH , @THE_LOAI , @TAC_GIA , @NXB , @NAM_XB , @SO_LUONG , @slc , @GIA  ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, parameter);
            return data;


        }

        public DataTable Xoa_Sach(object[] parameter = null)
        {
            string co_The_Xoa = "select count(*) from CT_PHIEU_MUON where MA_SACH like N'" + parameter[0] + "'";
            int x = (int)DataProvider.Thuc_Thi.ExcuteScalar(co_The_Xoa);

            if (x > 0)
            {
                MessageBox.Show("Sách chưa được thu hồi hết", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            else
            {
                string query = "delete SACH where MA_SACH like @x ";
                DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, parameter);
                return data;

            }
        }

        public DataTable Load_Sach()
        { 
            string query = "LOAD_SACH";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }

        public DataTable Tim_Sach_Theo_MaSach(string x)
        {
            string query = " TIM_SACH_THEO_MA('" + x + "')";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
        public DataTable Tim_Sach_Theo_TenSach(string x)
        {
            string query = " TIM_SACH_THEO_TEN('" + x + "')";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }

        public DataTable Tim_Sach_Theo_TenTacGia(string x)
        {
            string query = " TIM_SACH_THEO_TEN_TG('" + x + "')";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
        public DataTable Tim_Sach_Theo_ChuDe(string x)
        {
            string query = "  TIM_SACH_THEO_THE_LOAI('" + x + "')";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }

    }
}
