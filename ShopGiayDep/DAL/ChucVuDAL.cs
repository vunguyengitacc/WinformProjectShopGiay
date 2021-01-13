using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopGiayDep.Model;

namespace ShopGiayDep.DAL
{
    class ChucVuDAL
    {
        public string MaCV { get; set; }

        public string TenCV { get; set; }

        static DBContext db = new DBContext();

        static ChucVuDAL convertFromModel(ChucVu input)//method chuyen doi class o Model sang class o DAL
        {
            return new ChucVuDAL() { MaCV = input.MaCV, TenCV = input.TenCV };
        }

        internal static List<ChucVuDAL> getListChucVu()
        {
            List<ChucVu> lstCTHD = db.ChucVus.ToList();
            List<ChucVuDAL> lstOut = new List<ChucVuDAL>();
            foreach (ChucVu item in lstCTHD)
            {
                lstOut.Add(convertFromModel(item));
            }
            return lstOut;
        }
    }
}
