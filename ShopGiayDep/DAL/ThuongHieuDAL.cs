using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopGiayDep.Model;

namespace ShopGiayDep.DAL
{
    class ThuongHieuDAL
    {
        static DBContext db = new DBContext();
        public string MaTH { get; set; }

        public string TenTH { get; set; }
        internal static List<ThuongHieuDAL> getListThuongHieu()
        {
            List<ThuongHieu> lstThuongHieu = db.ThuongHieux.ToList();
            List<ThuongHieuDAL> lstResult = new List<ThuongHieuDAL>();
            foreach (ThuongHieu item in lstThuongHieu)
            {
                ThuongHieuDAL temp = new ThuongHieuDAL() { MaTH = item.MaTH, TenTH = item.TenTH };
                lstResult.Add(temp);
            }
            return lstResult;
        }

        internal static bool insert(string text)
        {
            if (db.ThuongHieux.FirstOrDefault(val => val.TenTH == text)!=null)
                return false;
            int id = 0;
            string check = "";
            while (true)
            {
                check = "TH" + id;
                if (db.ThuongHieux.FirstOrDefault(val => val.MaTH == check) == null)
                    break;
                id++;
            }
            ThuongHieu temp = new ThuongHieu() { MaTH = "TH" + id, TenTH = text };
            db.ThuongHieux.Add(temp);
            db.SaveChanges();
            return true;
        }

        internal static void init()
        {
            if(db.ThuongHieux.ToList().Count==0)
            {
                ThuongHieu temp = new ThuongHieu() { MaTH = "TH0", TenTH = "Chưa Xác Định" };
                db.ThuongHieux.Add(temp);
                db.SaveChanges();
            }    
        }
    }
}
