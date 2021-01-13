using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopGiayDep.DAL;

namespace ShopGiayDep.BUS
{
    class ThuongHieuBUS
    {internal static void fillingCombobox(ComboBox cmbThuongHieu)
        {
            List<ThuongHieuDAL> lstThuongHieu = ThuongHieuDAL.getListThuongHieu();
            cmbThuongHieu.DataSource = lstThuongHieu;
            cmbThuongHieu.DisplayMember = "TenTH";
        }

        internal static int insert(string text)
        {
            if (text == "")
                return 1;//1 la loi nhap khong day du
            if (!ThuongHieuDAL.insert(text))
                return 2;//2 la loi da ton tai
            return 0;//0 la them thanh cong
        }

        internal static void init()
        {
            ThuongHieuDAL.init();
        }
    }
}
