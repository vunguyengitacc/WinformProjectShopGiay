using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopGiayDep.DAL;
using System.Windows.Forms;

namespace ShopGiayDep.BUS
{
    class ChucVuBUS
    {
        internal static void fillingComboBox(ComboBox cmbChucVu)
        {
            cmbChucVu.DataSource = ChucVuDAL.getListChucVu();
            cmbChucVu.DisplayMember = "TenCV";
            cmbChucVu.ValueMember = "MaCV";
        }
    }
}
