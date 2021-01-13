using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopGiayDep.Model;

namespace ShopGiayDep.DAL
{
    class SanPhamDAL
    {
        static DBContext db = new DBContext();
        public string MaSP { get; set; }

        public string TenSP { get; set; }

        public string MaTH { get; set; }


        public string MauSac { get; set; }


        public int Size { get; set; }

        public decimal? GiaVon { get; set; }

        public int SoLuongTon { get; set; }

        public decimal GiaBan { get; set; }

        public string TenTH { get; set; }

        public static SanPhamDAL convertFormModel(SanPham sp)
        {
            if (sp == null)
                return null;
            SanPhamDAL output = new SanPhamDAL() { MaSP = sp.MaSP, TenSP = sp.TenSP, MauSac = sp.MauSac, MaTH = sp.MaTH, Size = sp.Size, GiaBan = sp.GiaBan, GiaVon = sp.GiaVon, SoLuongTon = sp.SoLuongTon, TenTH = sp.ThuongHieu.TenTH };
            return output;
        }

        internal static int Find(string maHang, string tenHang, string thuongHieu, string mauSac, int size_int, int soLuong_int, float giaBan_float, float giaVon_float)
        {
            if (db.SanPhams.FirstOrDefault(val => val.MaSP == maHang) == null)
                return 0; // 0 la khong trung san pham
            if (db.SanPhams.FirstOrDefault(val => val.TenSP == tenHang && val.MaTH == "TH" + thuongHieu && val.Size == size_int && val.MauSac == mauSac && val.GiaVon == (decimal)giaBan_float && val.GiaBan == (decimal)giaVon_float) == null)
                return 1; // 1 la san pham bi trung
            else
                return 2; // 2 la co san pham nhung thong tin bi khac voi thong tin da luu
        }

        internal static string getMaSPMoi()
        {
            bool flag = true;
            int id = 0;
            string check = "";
            while (flag)
            {
                check = "SP" + id;
                if (db.SanPhams.FirstOrDefault(val => val.MaSP == check) == null)
                    break;
                id++;
            }
            return "SP" + id;
        }

        internal static int delete(string text)
        {

            SanPham tempSP = db.SanPhams.FirstOrDefault(val => val.MaSP == text);
            if (tempSP == null)
                return 1;//1 la san pham khong ton tai

            if (CTHDDAL.getListCTHD_MaSP(text) != null)
                return 2;//2 la san pham da co trong CSDL hoa don nen khong the xoa
            db.SanPhams.Remove(tempSP);
            db.SaveChanges();
            return 0; // 0 la xoa thanh cong

        }


        internal static SanPhamDAL getSanPham_Ma(string text)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(val => val.MaSP == text);
            return convertFormModel(sp);
        }
        internal static SanPhamDAL getSanPham_Ten(string text)
        {
            return convertFormModel(db.SanPhams.FirstOrDefault(val => val.TenSP == text));
        }

        internal static List<SanPhamDAL> getListSanPham()
        {
            List<SanPham> lstSp = db.SanPhams.ToList();
            List<SanPhamDAL> lstOutput = new List<SanPhamDAL>();
            foreach (SanPham item in lstSp)
            {
                lstOutput.Add(convertFormModel(item));
            }
            return lstOutput;
        }

        internal static void update(string maHang, int soLuong_int)//update so luong. dung khi them san pham vao hoa don
        {
            SanPham temp = db.SanPhams.FirstOrDefault(val => val.MaSP == maHang);
            temp.SoLuongTon += soLuong_int;
            db.SaveChanges();
        }

        internal static bool update(string maSP, string tenSP, int thuongHieu, string mauSac, int size_int, int soLuongTon_int)//update day du
        {
            SanPham temp = db.SanPhams.FirstOrDefault(val => val.MaSP == maSP);
            if (temp == null)
                return false;//1 la khong tim thay san pham
            temp.TenSP = tenSP;
            temp.MaTH = "TH" + thuongHieu;
            temp.MauSac = mauSac;
            temp.Size = size_int;
            temp.SoLuongTon = soLuongTon_int;
            db.SaveChanges();
            return true;//0 la cap nhat thanh cong
        }

        internal static void insert(string maHang, string tenHang, string thuongHieu, string mauSac, int size, int soLuong, float giaBan, float giaVon)
        {
            //Tao 1 obj san pham va them vao database
            SanPham temp = new SanPham()
            {
                MaSP = maHang,
                TenSP = tenHang,
                MaTH = "TH" + thuongHieu,
                MauSac = mauSac,
                Size = size,
                SoLuongTon = soLuong,
                GiaBan = (decimal)giaBan,
                GiaVon = (decimal)giaVon
            };
            db.SanPhams.Add(temp);
            db.SaveChanges();
        }

    }
}
