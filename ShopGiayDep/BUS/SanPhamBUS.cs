using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using ShopGiayDep.DAL;

namespace ShopGiayDep.BUS
{
    class SanPhamBUS
    {
        internal static int insert(string maHang, string tenHang, int thuongHieu, string mauSac, string size, string soLuong, string giaBan, string giaVon)
        {
            int soLuong_int, size_int;
            if (!Int32.TryParse(soLuong, out soLuong_int))
                return 1;
            if (!Int32.TryParse(size, out size_int))
                return 1;
            float giaBan_float, giaVon_float;
            if (!float.TryParse(giaBan, out giaBan_float))
                return 1;
            if (!float.TryParse(giaBan, out giaVon_float))
                return 1;

            int check = SanPhamDAL.Find(maHang.ToUpper(), tenHang, thuongHieu.ToString(), mauSac, size_int, soLuong_int, giaBan_float, giaVon_float);
            if (check == 1)
            {
                SanPhamDAL.update(maHang.ToUpper(), soLuong_int);
                return 0;//0 la them hoac cap nhat so luong thanh cong
            }
            if (check == 2)
                return 2;// 2 la san pham nhap da ton tai nhung cac thong tin san pham khac thong tin da co
            SanPhamDAL.insert(maHang.ToUpper(), tenHang, thuongHieu.ToString(), mauSac, size_int, soLuong_int, giaBan_float, giaVon_float);
            return 0;//0 la them hoac cap nhat so luong thanh cong
        }

        internal static void getMaSPMoi(TextBox txtMaHang)
        {
            txtMaHang.Text = SanPhamDAL.getMaSPMoi();
        }

        internal static int delete(string text)
        {
            int result = SanPhamDAL.delete(text);
            if (result == 0)
                return 0; // 0 la xoa thanh cong
            if (result == 1)
                return 1;//1 la san pham khong ton tai
            return 2; //2 la san pham khong the xoa

        }

        internal static void bindingDataGridView(DataGridView dgvThongTin, string text)
        {
            SanPhamDAL sanPham;
            sanPham = SanPhamDAL.getSanPham_Ma(text);
            bindingDataGridview(dgvThongTin, sanPham);
        }

        private static void bindingDataGridview(DataGridView dgvThongTin, SanPhamDAL sanPham)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã Sản Phẩm", typeof(string));
            table.Columns.Add("Tên Sản Phẩm", typeof(string));
            table.Columns.Add("Tên Thương Hiệu", typeof(string));
            table.Columns.Add("Màu Sắc", typeof(string));
            table.Columns.Add("Size", typeof(int));
            table.Columns.Add("Giá Bán", typeof(decimal));
            table.Columns.Add("Giá Vốn", typeof(decimal));
            table.Columns.Add("Số Lượng Tồn", typeof(int));
            if (sanPham == null)
            {
                dgvThongTin.DataSource = table;
                return;
            }
            table.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.TenTH, sanPham.MauSac, sanPham.Size, sanPham.GiaBan, sanPham.GiaVon, sanPham.SoLuongTon);
            dgvThongTin.DataSource = table;
        }

        internal static int update(string maSP, string tenSP, int thuongHieu, string mauSac, string Size, string soLuongTon)
        {
            int size_int, soLuongTon_int;
            if (!Int32.TryParse(Size, out size_int))
                return 1;// 1 la sai dinh dang input
            if (!Int32.TryParse(soLuongTon, out soLuongTon_int))
                return 1;// 1 la sai dinh dang input
            if (!SanPhamDAL.update(maSP.ToUpper(), tenSP, thuongHieu, mauSac, size_int, soLuongTon_int))
                return 2;// 2 la khong tim thay san pham
            return 0;//0 la cap nhat thanh cong
        }


        private static void bindingDataGridview(DataGridView dgvThongTin, List<SanPhamDAL> sanPham)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã Sản Phẩm", typeof(string));
            table.Columns.Add("Tên Sản Phẩm", typeof(string));
            table.Columns.Add("Tên Thương Hiệu", typeof(string));
            table.Columns.Add("Màu Sắc", typeof(string));
            table.Columns.Add("Size", typeof(int));
            table.Columns.Add("Giá Bán", typeof(decimal));
            table.Columns.Add("Giá Vốn", typeof(decimal));
            table.Columns.Add("Số Lượng Tồn", typeof(int));
            foreach (SanPhamDAL item in sanPham)
            {
                table.Rows.Add(item.MaSP, item.TenSP, item.TenTH, item.MauSac, item.Size, item.GiaBan, item.GiaVon, item.SoLuongTon);
            }
            dgvThongTin.DataSource = table;
        }

        internal static void bindingDataGridView(DataGridView dgvThongTin)
        {
            List<SanPhamDAL> lstSanPham = SanPhamDAL.getListSanPham();
            bindingDataGridview(dgvThongTin, lstSanPham);
        }

        internal static int LoadGiaTien(TextBox txtGiaTien, TextBox txtMaHang, TextBox txtSoLuong)
        {
            SanPhamDAL temp = SanPhamDAL.getSanPham_Ma(txtMaHang.Text);
            if (temp == null)
                return 1;//1 la khong tim thay san pham
            int soLuong_int;
            if (txtSoLuong.Text == "")
                txtSoLuong.Text = "0";
            if (!Int32.TryParse(txtSoLuong.Text, out soLuong_int))
                return 2;//2 la loi nhap sai dinh dang so
            if (soLuong_int > temp.SoLuongTon)
                return 3;//3 la khong du hang
            txtGiaTien.Text = (temp.GiaBan * soLuong_int).ToString();
            return 0;//0 la cap nhat thanh cong
        }

    }
}
