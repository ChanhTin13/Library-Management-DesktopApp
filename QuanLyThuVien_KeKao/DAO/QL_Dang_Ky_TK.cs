using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_KeKao.DAO
{
    public class QL_Dang_Ky_TK
    {
        private static QL_Dang_Ky_TK thuc_Thi;

        public static QL_Dang_Ky_TK Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Dang_Ky_TK();
                }
                return thuc_Thi;
            }
        }
        private int Check_Ma_NV(object ma_NV)
        {
            string q = "select count(*) from NHAN_VIEN where MA_NV  like N'" + ma_NV + "'"; // kt Ma NV co ton tai khong
            return (int)DataProvider.Thuc_Thi.ExcuteScalar(q);
        }
        private int is_Have_Account(object ma_NV)
        {
            string q = "select count(*) from ACCOUNT where MA_NV  like N'" + ma_NV + "'"; // kt NV co tai khoan chua
            return (int)DataProvider.Thuc_Thi.ExcuteScalar(q);
        }


        public DataTable Dang_Ky(object[] parameter = null)
        {
            string dem_so_tk = "select count(*) from NHAN_VIEN";
            int co_tk = (int)DataProvider.Thuc_Thi.ExcuteScalar(dem_so_tk);
            if (co_tk == 0)
            {
                if (parameter[2].Equals(parameter[3]) == false) 
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                string them_tk_boss = " TAO_ACC_CHO_BOSS @a , @b , @c  "; // thêm account
                MessageBox.Show("Đăng ký thành công");
                return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(them_tk_boss, new object[] { parameter[0], parameter[1], parameter[2] });

            }
            else if (Check_Ma_NV(parameter[0]) == 0)
            {
                MessageBox.Show("Mã Nhân viên không tồn tại", "Không thể xử lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            else if (is_Have_Account(parameter[0]) == 1)
            {
                MessageBox.Show("Nhân viên này đã có tài khoản", "Không thể xử lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            else if (parameter[2].Equals(parameter[3]) == false)
            {
                MessageBox.Show("Mật khẩu nhập lại đéo khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string q = "TAO_ACC_CHO_NV  @a , @b , @c  "; // thêm account
                return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q, new object[] { parameter[0], parameter[1], parameter[2] });
            }
        }

    }
}
