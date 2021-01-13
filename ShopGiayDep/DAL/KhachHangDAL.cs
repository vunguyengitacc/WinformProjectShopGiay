using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopGiayDep.Model;

namespace ShopGiayDep.DAL
{
    class KhachHangDAL
    {
        public string MaKH { get; set; }

        public string HoTen { get; set; }

        public string DiaChi { get; set; }

        public DateTime? NgaySinh { get; set; }
        public string SDT { get; set; }

        static KhachHangDAL convertFromModel(KhachHang input)
        {
            if (input is null)
                return null;
            return new KhachHangDAL() { MaKH = input.MaKH, HoTen = input.HoTen, DiaChi = input.DiaChi, NgaySinh = input.NgaySinh, SDT = input.SDT };
        }

        internal static KhachHangDAL getKhackHang_MaKH(string text)
        {

            return convertFromModel(db.KhachHangs.FirstOrDefault(val => val.MaKH == text));
        }

        internal static bool insert(string maKH, string tenKH, string diaChi, DateTime value, string sDT)
        {
            if (db.KhachHangs.FirstOrDefault(val => val.MaKH == maKH) != null)
                return false;//khach hang da ton tai
            KhachHang temp = new KhachHang() { MaKH = maKH, HoTen = tenKH, DiaChi = diaChi, NgaySinh = value, SDT = sDT };
            db.KhachHangs.Add(temp);
            db.SaveChanges();
            return true;//them thanh cong
        }

        internal static int delete(string text)
        {
            DBContext db = new DBContext();
            KhachHang temp = db.KhachHangs.FirstOrDefault(val => val.MaKH == text);
            if (temp == null)
                return 1;//1 la hoa don khong ton tai
            if (db.HoaDons.FirstOrDefault(val => val.MaKH == text) != null)
                return 2;//2 la hoa don da co thuc hien giao dich nen khong the xoa
            db.KhachHangs.Remove(temp);
            db.SaveChanges();
            return 0; // 0 la xoa thanh cong
        }

        internal static string getMaKHMoi()
        {
            bool flag = true;
            int id = 0;
            string check = "";
            while (flag)
            {
                check = "KH" + id;
                if (db.KhachHangs.FirstOrDefault(val => val.MaKH == check) == null)
                    break;
                id++;
            }
            return "KH" + id;
        }

        internal static bool update(string maKH, string tenKH, string diaChi, DateTime value, string sDT)
        {
            KhachHang temp = db.KhachHangs.FirstOrDefault(val => val.MaKH == maKH);
            if (temp == null)
                return false;
            temp.MaKH = maKH;
            temp.HoTen = tenKH;
            temp.NgaySinh = value;
            temp.DiaChi = diaChi;
            temp.SDT = sDT;
            db.SaveChanges();
            return true;
        }

        static DBContext db = new DBContext();

        internal static List<KhachHangDAL> getListKhachHang()
        {
            List<KhachHang> lst = db.KhachHangs.ToList();
            List<KhachHangDAL> output = new List<KhachHangDAL>();
            foreach (KhachHang item in lst)
            {
                output.Add(convertFromModel(item));
            }
            return output;
        }

    }
}
