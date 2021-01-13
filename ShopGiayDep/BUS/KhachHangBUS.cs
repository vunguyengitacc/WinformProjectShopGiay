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
    class KhachHangBUS
    {
        internal static int insert(string maKH, string tenKH, string diaChi, DateTime value, string sDT)
        {
            if (sDT == "" || tenKH == "" || maKH == "" || diaChi == "" || sDT == "")
                return 1;//1 la loi nhap thieu
            if (value > DateTime.Now)
                return 4;//4 la loi nhap sai thoi gian
            if (sDT[0] != '0')
                return 2;//2 la nhap khong dung dinh dang so dien thoai
            int temp;
            if (!Int32.TryParse(sDT, out temp))
                return 2;
            if (sDT.Length != 10)
                return 2;
            if (!KhachHangDAL.insert(maKH.ToUpper(), tenKH, diaChi, value, sDT))
                return 3;//3 la khach hang da ton tai
            return 0;//0 la them thanh cong
        }

        internal static int delete(string text)
        {
            return KhachHangDAL.delete(text);
        }

        internal static void bindingDataGridView(DataGridView dgvThongTinKH)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã Khách Hàng", typeof(string));
            table.Columns.Add("Tên Khách Hàng", typeof(string));
            table.Columns.Add("Địa chỉ", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(DateTime));
            table.Columns.Add("Số Điện Thoại", typeof(string));

            List<KhachHangDAL> lstKhachHang = KhachHangDAL.getListKhachHang();


            foreach (KhachHangDAL item in lstKhachHang)
            {
                table.Rows.Add(item.MaKH, item.HoTen, item.DiaChi, item.NgaySinh, item.SDT);
            }

            dgvThongTinKH.DataSource = table;
        }

        internal static void getMaKHMoi(TextBox txtMaKH)
        {

            txtMaKH.Text = KhachHangDAL.getMaKHMoi();
        }

        internal static int update(string maKH, string tenKH, string diaChi, DateTime value, string sDT)
        {
            int temp;
            if (!Int32.TryParse(sDT, out temp))
                return 3;
            if (sDT.Length != 10)
                return 3;
            if (value > DateTime.Now)
                return 2;//2 la loi sai du lieu nhap cua thoi gian

            if (!KhachHangDAL.update(maKH, tenKH, diaChi, value, sDT))
                return 1;// 1 la khong tim thay san pham
            return 0;//0 la cap nhat thanh cong
        }

    }
}
