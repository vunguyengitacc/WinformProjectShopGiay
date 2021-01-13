using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopGiayDep.Model;

namespace ShopGiayDep.DAL
{
    class HoaDonDAL
    {
        public string MaHD { get; set; }
        public string MaNV { get; set; }

        public string MaKH { get; set; }

        public DateTime? NgayTao { get; set; }

        public string GhiChu { get; set; }

        static DBContext db = new DBContext();
        internal static List<HoaDonDAL> getListHoaDon()
        {
            List<HoaDon> temp = db.HoaDons.ToList();
            List<HoaDonDAL> output = new List<HoaDonDAL>();
            foreach (HoaDon item in temp)
            {
                output.Add(convertFromModel(item));
            }
            return output;
        }

        internal static string getMaHoaDonMoi()
        {
            bool flag = true;
            int id = 0;
            string check = "";
            while (flag)
            {
                check = "HD" + id;
                if (db.HoaDons.FirstOrDefault(val => val.MaHD == check) == null)
                    break;
                id++;
            }
            return "HD" + id;
        }


        static HoaDonDAL convertFromModel(HoaDon input)
        {
            if (input == null)
                return null;
            return new HoaDonDAL() { MaHD = input.MaHD, MaKH = input.MaKH, MaNV = input.MaNV, NgayTao = input.NgayTao, GhiChu = input.GhiChu };
        }

        internal static void insert(string text, string text2, string maKH, string text1)
        {
            HoaDon temp = new HoaDon()
            {
                MaHD = text,
                MaNV = text2,
                NgayTao = DateTime.Now,
                MaKH = maKH,
                GhiChu = text1
            };
            db.HoaDons.Add(temp);
            db.SaveChanges();
        }

        internal static decimal getTongTien(string maHoaDon)
        {
            decimal result = 0;
            List<CTHD> temp = db.CTHDs.Where(val => val.MaHD == maHoaDon).ToList();
            foreach (CTHD item in temp)
            {
                result += item.SoLuong * item.SanPham.GiaBan;
            }
            return result;
        }


        internal static int delete(string text)
        {
            DBContext db = new DBContext();
            HoaDon tempHD = db.HoaDons.FirstOrDefault(val => val.MaHD == text);
            if (tempHD == null)
                return 1;//1 la hoa don khong ton tai
            if (CTHDDAL.getListCTHD_MaHD(text) != null)
                return 2;//2 la hoa don da co thuc hien giao dich nen khong the xoa
            db.HoaDons.Remove(tempHD);
            db.SaveChanges();
            return 0; // 0 la xoa thanh cong
        }

        internal static HoaDonDAL getHoaDon(string v)
        {
            return convertFromModel(db.HoaDons.FirstOrDefault(val => val.MaHD == v));
        }

        internal static bool update(string maKH, string maNV, DateTime value, string maHD)
        {
            if (db.KhachHangs.FirstOrDefault(val => val.MaKH == maKH) == null || db.NhanViens.FirstOrDefault(val => val.MaNV == maNV) == null)
                return false;
            HoaDon temp = db.HoaDons.FirstOrDefault(val => val.MaHD == maHD);
            if (temp == null)
                return false;
            temp.MaKH = maKH;
            temp.MaNV = maNV;
            temp.NgayTao = value;
            db.SaveChanges();
            return true;

        }
    }
}
