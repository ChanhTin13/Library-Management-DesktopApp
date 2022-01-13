using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DTO
{
    public class DTO_Sach
    {
        private string maSach;
        private string tenSach;
        private string theLoai;
        private string tacGia;
        private long gia;
        private int soLuongCon;
        private string hinhAnh;

        public DTO_Sach(string maSach, string tenSach, string theLoai, string tacGia, long gia, int soLuongCon, string hinhAnh)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.theLoai = theLoai;
            this.tacGia = tacGia;
            this.gia = gia;
            this.soLuongCon = soLuongCon;
            this.hinhAnh = hinhAnh;
        }
        public DTO_Sach(DataRow row)
        {
            this.maSach = row["MA_SACH"].ToString();
            this.tenSach = row["TEN_SACH"].ToString();
            this.theLoai = row["TEN_THE_LOAI"].ToString();
            this.tacGia = row["TEN_TAC_GIA"].ToString();
            this.gia = (long)row["GIA"];
            this.soLuongCon = (int)row["SO_LUONG_CON"];
            this.hinhAnh = row["IMG"].ToString();
        }

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public long Gia { get => gia; set => gia = value; }
        public int SoLuongCon { get => soLuongCon; set => soLuongCon = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}
