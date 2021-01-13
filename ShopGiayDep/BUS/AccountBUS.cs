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
    class AccountBUS
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string MaCV { get; set; }

        public string MaNV { get; set; }

        public int TinhTrang { get; set; }

        static AccountBUS converFromModel(AccountDAL input)
        {
            if (input == null)
                return null;
            return new AccountBUS() { Username = input.Username, Password = input.Password, MaCV = input.MaCV, MaNV = input.MaNV, TinhTrang = input.TinhTrang };
        }


        internal static void bindingDataGridView(DataGridView dgvThongTin)
        {
            List<AccountDAL> lstAccount = AccountDAL.getListAccount();
            getDataGridView(dgvThongTin, lstAccount);
        }
        internal static void bindingDataGridView(DataGridView dgvThongTin, AccountDAL acc)
        {
            List<AccountDAL> lstAccount = new List<AccountDAL>();
            if (acc != null)
                lstAccount.Add(acc);
            getDataGridView(dgvThongTin, lstAccount);
        }

        internal static bool checkAccount(string text)
        {
            if (AccountDAL.getAccount(text) != null)
                return true;
            else
                return false;

        }

        internal static void bindingDataGridView(DataGridView dgvThongTin, List<AccountDAL> lstAccount)
        {
            getDataGridView(dgvThongTin, lstAccount);
        }

        internal static int insert(string username, string pass, string passXacNhan, string maNV, int chucvu)
        {
            if (pass != passXacNhan)
                return 1;//1 la xac thuc mat khau khong dung
            if (NhanVienDAL.getNhanVien_Ma(maNV) == null)
                return 2;//nhan vien khong ton tai

            AccountDAL.insert(username, pass, maNV, chucvu);
            return 0;// them thanh cong
        }

        internal static void getDataGridView(DataGridView dgvThongTin, List<AccountDAL> lstAccount)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Mã Nhân Viên", typeof(string));
            table.Columns.Add("Tên Nhân Viên", typeof(string));
            table.Columns.Add("Chức Vụ", typeof(string));
            table.Columns.Add("Tình Trạng", typeof(string));
            if (lstAccount.Count == 0)
            {
                dgvThongTin.DataSource = table;
                return;
            }
            List<NhanVienDAL> lstNhanVien = NhanVienDAL.getListNhanVien();
            List<ChucVuDAL> lstChucVu = ChucVuDAL.getListChucVu();

            var query = from val1 in lstAccount
                        join val2 in lstNhanVien on val1.MaNV equals val2.MaNV
                        join val3 in lstChucVu on val1.MaCV equals val3.MaCV
                        select new
                        {
                            val1.Username,
                            val1.Password,
                            val1.MaNV,
                            val2.HoTen,
                            val3.TenCV,
                            tinhtrang = TranslateTinhTrang(val1.TinhTrang)
                        };

            foreach (var item in query)
            {
                table.Rows.Add(item.Username, item.Password, item.MaNV, item.HoTen, item.TenCV, item.tinhtrang);
            }

            dgvThongTin.DataSource = table;
        }

        internal static int update(TextBox txtUsername, TextBox txtPassword, TextBox txtMaNV, string text)
        {
            if (NhanVienDAL.getNhanVien_Ma(txtMaNV.Text) == null)
                return 1;//1 la khong ton tai nhan vien 
            if (AccountDAL.update(txtUsername.Text, txtPassword.Text, txtMaNV.Text, text))
                return 0;//cap nhat thanh cong
            else
                return 2; // khong tim thay tai khoan
        }

        internal static bool update_TinhTrang(TextBox txtUsername)
        {
            if (AccountDAL.getAccount(txtUsername.Text) != null)
            {
                AccountDAL.update_TinhTrang(txtUsername.Text);
                return true;
            }
            else
                return false;
        }

        internal static void find(TextBox txtUsername, TextBox txtMaNV, DataGridView dgvThongTin)
        {
            if (txtMaNV.Text == "" && txtUsername.Text == "")
            {
                AccountBUS.bindingDataGridView(dgvThongTin);
                return;
            }
            if (txtMaNV.Text == "")
            {
                AccountBUS.bindingDataGridView(dgvThongTin, AccountDAL.getAccount(txtUsername.Text));
                return;//
            }
            else if (txtUsername.Text == "")
            {
                AccountBUS.bindingDataGridView(dgvThongTin, AccountDAL.getListAccount_MaNV(txtMaNV.Text));
                return;//
            }

        }

        internal static AccountBUS getAccount(string user)
        {
            return converFromModel(AccountDAL.getAccount(user));
        }

        internal static bool delete(TextBox txtUsername)
        {
            return AccountDAL.delete(txtUsername.Text);
        }

        private static string TranslateTinhTrang(int tinhTrang)
        {
            if (tinhTrang == 1)
                return "Hoạt động";
            if (tinhTrang == 0)
                return "Đã Khóa";
            return "";
        }


        internal static bool loginCall(string username, string passwword)
        {
            return AccountDAL.checkAccount(username.Trim(), passwword.Trim());
        }


    }
}
