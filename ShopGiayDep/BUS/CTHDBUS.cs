using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopGiayDep.DAL;

namespace ShopGiayDep.BUS
{
    class CTHDBUS
    {
        internal static int insert(string maSP, string soLuong, string maHoaDon)
        {
            if (maSP == "")
                return 1;
            maSP = maSP.Trim();
            maSP = maSP.ToUpper();
            if (soLuong == "" || soLuong == "0")
                return 1;//1 la chua nhap day du
            CTHDDAL.insert(maSP, Int32.Parse(soLuong), maHoaDon);
            return 0;
        }

        internal static void bindingDataGridView(DataGridView dgvThongTinChiTieTHD, string maHD)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã Sản Phẩm", typeof(string));
            table.Columns.Add("Tên Sản Phẩm", typeof(string));
            table.Columns.Add("Số Lượng", typeof(int));
            table.Columns.Add("Thành Tiền", typeof(decimal));
            List<CTHDDAL> lstCTHD = CTHDDAL.getListCTHD_MaHD(maHD);
            if (lstCTHD == null)
            {
                dgvThongTinChiTieTHD.DataSource = table;
                return;
            }
            List<SanPhamDAL> lstSanPham = SanPhamDAL.getListSanPham();
            var query = from val1 in lstCTHD
                        join val2 in lstSanPham
                        on val1.MaSP equals val2.MaSP
                        select new { val1.MaSP, val2.TenSP, val1.SoLuong, giaTien = val1.SoLuong * val2.GiaBan };
            foreach (var item in query)
            {
                table.Rows.Add(item.MaSP, item.TenSP, item.SoLuong, item.giaTien);
            }
            dgvThongTinChiTieTHD.DataSource = table;
        }

        internal static int delete(string v)
        {
            return CTHDDAL.delete(v);
        }
    }
}
