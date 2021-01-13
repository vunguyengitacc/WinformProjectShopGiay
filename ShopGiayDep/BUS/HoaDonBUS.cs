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
    class HoaDonBUS
    {
        internal static void getHoaDonMoi(TextBox txtMaHD, TextBox txtMaNV)
        {
            txtMaHD.Text = HoaDonDAL.getMaHoaDonMoi();
            txtMaNV.Text = "NV1";
        }

        internal static bool insert(TextBox txtMaHD, TextBox txtMaNV, TextBox txtMaKH, TextBox txtGhiChu)
        {
            if (KhachHangDAL.getKhackHang_MaKH(txtMaKH.Text) == null)
                return false;
            HoaDonDAL.insert(txtMaHD.Text, txtMaNV.Text, txtMaKH.Text, txtGhiChu.Text);
            return true;
        }

        internal static void bindingDataGridView(DataGridView dgvThongTinHoaDon)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã Hóa Đơn", typeof(string));
            table.Columns.Add("Mã Khách Hàng", typeof(string));
            table.Columns.Add("Tên Khách Hàng", typeof(string));
            table.Columns.Add("Mã Nhân Viên", typeof(string));
            table.Columns.Add("Tên Nhân Viên", typeof(string));
            table.Columns.Add("Ngày Lập", typeof(DateTime));
            table.Columns.Add("Tổng giá trị", typeof(decimal));
            List<HoaDonDAL> lstHoaDon = HoaDonDAL.getListHoaDon();
            List<CTHDDAL> lstCTHD = CTHDDAL.getListCTHD();
            List<NhanVienDAL> lstNhanVien = NhanVienDAL.getListNhanVien();
            List<KhachHangDAL> lstKhachHang = KhachHangDAL.getListKhachHang();

            var query = from val1 in lstHoaDon
                        join val2 in lstNhanVien on val1.MaNV equals val2.MaNV
                        join val3 in lstKhachHang on val1.MaKH equals val3.MaKH
                        select new
                        {
                            val1.MaHD,
                            val1.MaKH,
                            val3.HoTen,
                            val1.MaNV,
                            tenNV = val2.HoTen,
                            val1.NgayTao
                        };

            foreach (var item in query)
                table.Rows.Add(item.MaHD, item.MaKH, item.HoTen, item.MaNV, item.tenNV, item.NgayTao, HoaDonDAL.getTongTien(item.MaHD));

            dgvThongTinHoaDon.DataSource = table;
        }

        internal static string fillGhiChu(string v)
        {
            return HoaDonDAL.getHoaDon(v).GhiChu;
        }

        internal static int UpdateSanPham(string MaKH, string MaNV, DateTime value, string maHD)
        {
            if (value > DateTime.Now)
                return 2;//2 la loi sai du lieu nhap cua thoi gian
            if (!HoaDonDAL.update(MaKH, MaNV, value, maHD))
                return 1;// 1 la khong tim thay san pham
            return 0;//0 la cap nhat thanh cong
        }

        internal static int delete(string text)
        {
            return HoaDonDAL.delete(text);

        }

        internal static void fillTongTien(TextBox txtTongTien, string maHoaDon)
        {
            txtTongTien.Text = HoaDonDAL.getTongTien(maHoaDon).ToString();
        }

    }
}
