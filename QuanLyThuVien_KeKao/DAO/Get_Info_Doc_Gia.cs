using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DAO
{
    public class Get_Info_Doc_Gia
    {
        private static Get_Info_Doc_Gia thuc_Thi;

        public static Get_Info_Doc_Gia Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new Get_Info_Doc_Gia();
                }
                return thuc_Thi;
            }
        }

        public string ID;
        public string MDG;
        public string TDG;
        public string GT;
        public string NS;
        public string NLT;
        public void Set_Ten_ID(string x)
        {
            ID = x;
        }
        public void Set_Ten_MDG(string x)
        {
            MDG = x;
        }
        public void Set_Ten_TDG(string x)
        {
            TDG = x;
        }
        public void Set_Ten_GT(string x)
        {
            GT = x;
        }
        public void Set_Ten_NS(string x)
        {
            NS = x;
        }
        public void Set_Ten_NLT(string x)
        {
            NLT = x;
        }


    }
}
