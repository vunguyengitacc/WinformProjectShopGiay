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
    }
}
