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

    }
}
