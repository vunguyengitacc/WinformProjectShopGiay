using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopGiayDep.Model;

namespace ShopGiayDep.DAL
{
    class AccountDAL
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string MaCV { get; set; }

        public string MaNV { get; set; }

        public int TinhTrang { get; set; }

        static DBContext db = new DBContext();

        static AccountDAL converFromModel(Account input)
        {
            if (input == null)
                return null;
            return new AccountDAL() { Username = input.Username, Password = input.Password, MaCV = input.MaCV, MaNV = input.MaNV, TinhTrang = input.TinhTrang };
        }

        internal static List<AccountDAL> getListAccount()
        {
            List<Account> lst = db.Accounts.ToList();
            List<AccountDAL> lstOutput = new List<AccountDAL>();
            foreach (Account item in lst)
            {
                lstOutput.Add(converFromModel(item));
            }
            return lstOutput;
        }

        internal static AccountDAL getAccount(string text)
        {
            return converFromModel(db.Accounts.FirstOrDefault(val => val.Username == text));
        }

        internal static bool update(string text1, string text2, string text3, string text)
        {

            Account temp = db.Accounts.FirstOrDefault(val => val.Username == text1);

            if (temp == null)
                return false;
            else
            {
                temp.Password = text2;
                temp.MaNV = text3;
                temp.ChucVu.TenCV = text;
                db.SaveChanges();
                return true;
            }
        }

        internal static void insert(string username, string pass, string maNV, int chucVu)
        {
            Account temp = new Account() { Username = username, Password = pass, MaNV = maNV, TinhTrang = 1, MaCV = "CV" + chucVu };
            db.Accounts.Add(temp);
            db.SaveChanges();
        }

        internal static bool delete(string text)
        {
            Account acc = db.Accounts.FirstOrDefault(val => val.Username == text);
            if (acc == null)
                return false;//1 la khong tim thay tai khoan
            db.Accounts.Remove(acc);
            db.SaveChanges();
            return true;//0 la xoa thanh cong
        }

        internal static List<AccountDAL> getListAccount_MaNV(string text)
        {
            List<Account> temp = db.Accounts.Where(val => val.MaNV == text).ToList();
            List<AccountDAL> lstOutput = new List<AccountDAL>();
            if (temp.Count == 0)
                return lstOutput;
            foreach (Account item in temp)
            {
                lstOutput.Add(converFromModel(item));
            }
            return lstOutput;
        }

        internal static void update_TinhTrang(string text)
        {
            Account temp = db.Accounts.FirstOrDefault(val => val.Username == text);
            if (temp.TinhTrang == 1)
                temp.TinhTrang = 0;
            else
                temp.TinhTrang = 1;
            db.SaveChanges();
        }

        internal static bool checkAccount(string v1, string v2)
        {
            if (db.Accounts.FirstOrDefault(val => val.Username == v1 && val.Password == v2) != null)
                return true;
            return false;
        }
    }
}
