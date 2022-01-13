using QuanLyThuVien_KeKao.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DAO
{ 
    public class QL_Muon_Sach
    {
        private static QL_Muon_Sach thuc_Thi;

        public static QL_Muon_Sach Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Muon_Sach();
                }
                return thuc_Thi;
            }
        }
        public DataTable ShowDaTa()
        {
            string query = " LOAD_DS_TraSach ";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
        public List<DTO_Doc_Gia> GetList_Info_DG(string para) 
        {
            List<DTO_Doc_Gia> list_Info_DG = new List<DTO_Doc_Gia>();

            string query = " select DOCGIA.MA_DOCGIA, TEN_DOCGIA, GIOI_TINH, NGAY_HET_HAN, SACH_CO_THE_MUON, IMG " +
                " from DOCGIA, THE_THU_VIEN " +
                " where DOCGIA.MA_DOCGIA = THE_THU_VIEN.MA_DOCGIA and " +
                " DOCGIA.MA_DOCGIA = N'" + para + "'";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);

            foreach (DataRow row in data.Rows)
            {
                DTO_Doc_Gia x = new DTO_Doc_Gia(row);
                list_Info_DG.Add(x);
            }
            return list_Info_DG;
        }

        public List<DTO_Sach> GetList_Info_Sach(string para)
        {
            List<DTO_Sach> list_Info_Sach = new List<DTO_Sach>();

            string query = " select MA_SACH, TEN_SACH, TEN_THE_LOAI, TEN_TAC_GIA, GIA, SO_LUONG_CON, IMG " +
                " from SACH  " +
                " where MA_SACH = N'" + para + "'";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);

            foreach (DataRow row in data.Rows)
            {
                DTO_Sach x = new DTO_Sach(row);
                list_Info_Sach.Add(x);
            }
            return list_Info_Sach;
        }

        public void Cho_Muon_Sach(object[] para = null)
        {
            string q = "CHO_MUON_SACH @MA_DOCGIA , @MA_SACH , @MA_PHIEU_MUON ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q, para);
        }
        //public void Gia_Han(string x)
        //{
        //    string q = " GIA_HAN N'" + x + "'";
        //    DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q);
        //}

    }
}
