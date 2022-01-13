using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DAO
{
    public class QL_Doi_Mat_Khau
    {
        private static QL_Doi_Mat_Khau thuc_Thi;

        public static QL_Doi_Mat_Khau Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Doi_Mat_Khau();
                }
                return thuc_Thi;
            }
        }
    }
}
