using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DTO
{ 
    public class DTO_Doc_Gia
    {
        private string maDG;
        private string tenDG;
        private bool gt;
        private DateTime ngayHetHan;
        private int soluong;
        private string hinhAnh;
        public DTO_Doc_Gia(string maDG, string tenDG, bool gt, DateTime ngayHetHan, int soluong, string hinhAnh)
        {
            this.maDG = maDG;
            this.tenDG = tenDG;
            this.gt = gt;
            this.ngayHetHan = ngayHetHan;
            this.soluong = soluong;
            this.hinhAnh = hinhAnh;
        }
        public DTO_Doc_Gia(DataRow row)
        {
            this.maDG = row["MA_DOCGIA"].ToString();
            this.tenDG = row["TEN_DOCGIA"].ToString();
            this.gt = (bool)row["GIOI_TINH"];
            this.ngayHetHan = (DateTime)row["NGAY_HET_HAN"];
            this.soluong = (int)row["SACH_CO_THE_MUON"];
            this.hinhAnh = row["IMG"].ToString();
        }

        public string MaDG { get => maDG; set => maDG = value; }
        public string TenDG { get => tenDG; set => tenDG = value; }
        public bool Gt { get => gt; set => gt = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}
