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
    class NhanVienBUS
    {
        internal static void bindingDataGridView(DataGridView dgvThongTin)
        {
            List<NhanVienDAL> lst = NhanVienDAL.getListNhanVien();
            DataTable table = new DataTable();
            table.Columns.Add("Mã Nhân Viên", typeof(string));
            table.Columns.Add("Tên Nhân Viên", typeof(string));
            table.Columns.Add("Địa Chỉ", typeof(string));
            table.Columns.Add("Ngày Sinh", typeof(DateTime));
            table.Columns.Add("Giới Tính", typeof(string));
            table.Columns.Add("Số Điện Thoại", typeof(string));
            foreach (NhanVienDAL item in lst)
            {
                table.Rows.Add(item.MaNV, item.HoTen, item.DiaChi, item.NgaySinh, getGioiTinh(item.GioiTinh), item.SDT);
            }

            dgvThongTin.DataSource = table;
        }


        internal static void bindingDataGridView(DataGridView dgvThongTin, List<NhanVienDAL> lst)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã Nhân Viên", typeof(string));
            table.Columns.Add("Tên Nhân Viên", typeof(string));
            table.Columns.Add("Địa Chỉ", typeof(string));
            table.Columns.Add("Ngày Sinh", typeof(DateTime));
            table.Columns.Add("Giới Tính", typeof(string));
            table.Columns.Add("Số Điện Thoại", typeof(string));
            foreach (NhanVienDAL item in lst)
            {
                table.Rows.Add(item.MaNV, item.HoTen, item.DiaChi, item.NgaySinh, getGioiTinh(item.GioiTinh), item.SDT);
            }

            dgvThongTin.DataSource = table;
        }

        internal static int insert(string maNV, string tenNV, string diaChi, string soDT, int selectedGioiTinh, DateTime value)
        {
            if (soDT == "" || maNV == "" || tenNV == "" || diaChi == "")
                return 1;//1 la loi nhap thieu
            if (soDT[0] != '0')
                return 2;//2 la nhap khong dung dinh dang so dien thoai
            int temp;
            if (!Int32.TryParse(soDT, out temp))
                return 2;
            if (soDT.Length != 10)
                return 2;
            if (!NhanVienDAL.insert(maNV, tenNV, diaChi, soDT, selectedGioiTinh, value))
                return 3;//3 la khach hang da ton tai
            return 0;//0 la them thanh cong
        }

        internal static int delete(TextBox txtMaNV)
        {
            return NhanVienDAL.delete(txtMaNV.Text);
        }

        internal static int update(string maNV, string tenNV, string diaChi, DateTime value, string sDT, int selectedIndex)
        {
            int temp;
            if (!Int32.TryParse(sDT, out temp))
                return 3;
            if (sDT.Length != 10)
                return 3;
            if (value > DateTime.Now)
                return 2;//2 la loi sai du lieu nhap cua thoi gian

            if (!NhanVienDAL.update(maNV, tenNV, diaChi, value, sDT, selectedIndex))
                return 1;// 1 la khong tim thay san pham
            return 0;//0 la cap nhat thanh cong
        }

        internal static void fillingComboBox(ComboBox cmbGioiTinh)
        {

            cmbGioiTinh.Items.Add("Không Xác Định");
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
        }

        private static string getGioiTinh(int? gioiTinh)
        {
            if (gioiTinh == 1)
            {
                return "Nam";
            }
            if (gioiTinh == 2)
            {
                return "Nữ";
            }
            return "Không xác định";
        }


        internal static void getMaNVMoi(TextBox txtMaNV)
        {
            txtMaNV.Text = NhanVienDAL.getMaNVMoi();
        }

        internal static void bindingDataGridView(DataGridView dgvThongTin, string text)
        {
            NhanVienDAL nv = NhanVienDAL.getNhanVien_Ma(text);
            List<NhanVienDAL> lst = new List<NhanVienDAL>();
            if (nv != null)
                lst.Add(nv);
            bindingDataGridView(dgvThongTin, lst);
        }

        internal static string getTenNV(AccountBUS session)
        {
            return NhanVienDAL.getNhanVien_Ma(session.MaNV).HoTen;
        }
    }
}
