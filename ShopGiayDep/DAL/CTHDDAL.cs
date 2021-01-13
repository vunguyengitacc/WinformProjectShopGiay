using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopGiayDep.Model;

namespace ShopGiayDep.DAL
{
    class CTHDDAL
    {
        public string MaHD { get; set; }

        public string MaSP { get; set; }

        public int SoLuong { get; set; }

        static DBContext db = new DBContext();

        static CTHDDAL convertFromModel(CTHD input)//method chuyen doi class o Model sang class o DAL
        {
            return new CTHDDAL() { MaHD = input.MaHD, MaSP = input.MaSP, SoLuong = input.SoLuong };
        }

        internal static void insert(string maSP, int v, string maHoaDon)
        {
            CTHD temp = db.CTHDs.FirstOrDefault(val => val.MaHD == maHoaDon && val.MaSP == maSP);
            if (temp != null)
            {
                temp.SoLuong = temp.SoLuong + v;
                SanPham temp2 = db.SanPhams.FirstOrDefault(val => val.MaSP == maSP);
                temp2.SoLuongTon = temp2.SoLuongTon - v;
                db.SaveChanges();
                return;
            }
            temp = new CTHD() { MaHD = maHoaDon, MaSP = maSP, SoLuong = v };
            db.CTHDs.Add(temp);
            SanPham temp3 = db.SanPhams.FirstOrDefault(val => val.MaSP == maSP);
            temp3.SoLuongTon = temp3.SoLuongTon - v;
            db.SaveChanges();
        }

        internal static List<CTHDDAL> getListCTHD()
        {
            List<CTHD> lstCTHD = db.CTHDs.ToList();
            List<CTHDDAL> lstOut = new List<CTHDDAL>();
            foreach (CTHD item in lstCTHD)
            {
                lstOut.Add(convertFromModel(item));
            }
            return lstOut;
        }

        internal static List<CTHDDAL> getListCTHD_MaHD(string maHD)
        {
            List<CTHD> lstCTHD = db.CTHDs.Where(val => val.MaHD == maHD).ToList();

            if (lstCTHD.Count != 0)
            {
                List<CTHDDAL> lstOut = new List<CTHDDAL>();
                foreach (CTHD item in lstCTHD)
                {
                    lstOut.Add(convertFromModel(item));
                }
                return lstOut;
            }
            else
                return null;

        }

        internal static List<CTHDDAL> getListCTHD_MaSP(string maSP)
        {
            List<CTHD> lstCTHD = db.CTHDs.Where(val => val.MaSP == maSP).ToList();
            if (lstCTHD.Count == 0)
                return null;
            List<CTHDDAL> lstOut = new List<CTHDDAL>();
            foreach (CTHD item in lstCTHD)
            {
                lstOut.Add(convertFromModel(item));
            }
            return lstOut;
        }

        internal static int delete(string v)
        {
            CTHD temp = db.CTHDs.FirstOrDefault(val => val.MaSP == v);
            if (temp == null)
                return 1;//1 la khong tim thay
            SanPham temp2 = db.SanPhams.FirstOrDefault(val => val.MaSP == v);
            if (temp2 == null)
                return 1;//1 la khong tim thay
            temp2.SoLuongTon = temp2.SoLuongTon + temp.SoLuong;
            db.CTHDs.Remove(temp);
            db.SaveChanges();
            return 0;//0 la xoa thanh cong
        }

    }
}
