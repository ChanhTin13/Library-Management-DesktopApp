using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DTO
{
    public class Account_DTO
    {
        public Account_DTO(int id, string taiKhoan, string passWord, int typeAcc)
        {
            this.Id = id;
            this.TaiKhoan = taiKhoan;
            this.PassWord = passWord;
            this.TypeAcc = typeAcc;
        }
        public Account_DTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.TaiKhoan = row["taiKhoan"].ToString();
            this.PassWord = row["passWord"].ToString();
            this.TypeAcc = (int)row["typeAcc"];
        }

        private int id;
        public int Id { get => id; set => id = value; }

        private string taiKhoan;
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }

        private string passWord;
        public string PassWord { get => passWord; set => passWord = value; }

        private int typeAcc;
        public int TypeAcc { get => typeAcc; set => typeAcc = value; }
    }
}



