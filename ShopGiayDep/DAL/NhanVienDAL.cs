using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopGiayDep.Model;

namespace ShopGiayDep.DAL
{
    class NhanVienDAL
    {
        public string MaNV { get; set; }

        public string HoTen { get; set; }

        public string DiaChi { get; set; }

        public DateTime? NgaySinh { get; set; }

        public int? GioiTinh { get; set; }
        public string SDT { get; set; }

        static NhanVienDAL convertFromModel(NhanVien input)
        {
            if (input == null)
                return null;
            return new NhanVienDAL() { MaNV = input.MaNV, HoTen = input.HoTen, DiaChi = input.DiaChi, GioiTinh = input.GioiTinh, NgaySinh = input.NgaySinh, SDT = input.SDT };
        }

        static DBContext db = new DBContext();

        internal static List<NhanVienDAL> getListNhanVien()
        {
            List<NhanVien> lst = db.NhanViens.ToList();
            List<NhanVienDAL> output = new List<NhanVienDAL>();
            foreach (NhanVien item in lst)
            {
                output.Add(convertFromModel(item));
            }
            return output;
        }

        internal static bool insert(string maNV, string tenNV, string diaChi, string soDT, int selectedGioiTinh, DateTime value)
        {
            if (db.NhanViens.FirstOrDefault(val => val.MaNV == maNV) != null)
                return false;//khach hang da ton tai
            NhanVien temp = new NhanVien() { MaNV = maNV, HoTen = tenNV, DiaChi = diaChi, NgaySinh = value, GioiTinh = selectedGioiTinh, SDT = soDT };
            db.NhanViens.Add(temp);
            db.SaveChanges();
            return true;//them thanh cong
        }

        internal static bool update(string maNV, string tenNV, string diaChi, DateTime value, string sDT, int selectedIndex)
        {
            NhanVien temp = db.NhanViens.FirstOrDefault(val => val.MaNV == maNV);
            if (temp == null)
                return false;
            temp.HoTen = tenNV;
            temp.DiaChi = diaChi;
            temp.NgaySinh = value;
            temp.SDT = sDT;
            temp.GioiTinh = selectedIndex;
            db.SaveChanges();
            return true;
        }

        internal static int delete(string text)
        {
            NhanVien temp = db.NhanViens.FirstOrDefault(val => val.MaNV == text);
            if (temp == null)
                return 1;//1 la hoa don khong ton tai
            if (db.HoaDons.FirstOrDefault(val => val.MaNV == text) != null)
                return 2;//2 la hoa don da co thuc hien giao dich nen khong the xoa
            db.NhanViens.Remove(temp);
            db.SaveChanges();
            return 0; // 0 la xoa thanh cong
        }

        internal static NhanVienDAL getNhanVien_Ma(string text)
        {
            return convertFromModel(db.NhanViens.FirstOrDefault(val => val.MaNV == text));
        }

        internal static NhanVienDAL getNhanVien_Ten(string text)
        {
            return convertFromModel(db.NhanViens.FirstOrDefault(val => val.HoTen == text));
        }

        internal static string getMaNVMoi()
        {
            bool flag = true;
            int id = 0;
            string check = "";
            while (flag)
            {
                check = "NV" + id;
                if (db.NhanViens.FirstOrDefault(val => val.MaNV == check) == null)
                    break;
                id++;
            }
            return "NV" + id;
        }

    }
}
