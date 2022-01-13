using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DAO
{
    public class Get_Type_Acc
    {
        private static Get_Type_Acc thuc_Thi; 
        public static Get_Type_Acc Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new Get_Type_Acc();
                }
                return thuc_Thi;
            }
        }
        int x;
        public void Get_Type(int type)
        {
            x = type;
        }
        public int Set_Type()
        {
            return x;
        }
    }
}
