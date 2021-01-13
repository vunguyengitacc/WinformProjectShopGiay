using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopGiayDep.BUS;
namespace ShopGiayDep.GUI.QuanLyKho
{
    public partial class FormNhapKho : Form
    {
        public FormNhapKho()
        {
            InitializeComponent();
            ThuongHieuBUS.fillingCombobox(cmbThuongHieu);
        }

        private void btnXacNhanThem_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "") 
            {
                MessageBox.Show("Không được để trống Mã Hàng", "Lỗi");
                return;
            }
            int check = SanPhamBUS.insert(txtMaHang.Text, txtTenHang.Text, cmbThuongHieu.SelectedIndex + 1, txtMauSac.Text, txtSize.Text, txtSoLuong.Text, txtGiaBan.Text, txtGiaVon.Text);
            if (check == 1) 
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng các trường", "Lỗi");
                return;
            }
            if (check == 2)
            {
                MessageBox.Show("Mã sản phẩm và các thông tin của hàng không trùng nhau! \nVui lòng nhập sản phẩm này với một mã mới", "Lỗi");
                return;
            }       
            MessageBox.Show("Thêm thành công");
        }

        private void btnGetMaSPMoi_Click(object sender, EventArgs e)
        {

            SanPhamBUS.getMaSPMoi(txtMaHang);
        }

        private void btnThemThuongHieu_Click(object sender, EventArgs e)
        {
            int result = ThuongHieuBUS.insert(txtTenThuongHieu.Text);
            if(result == 1)
            {
                MessageBox.Show("Vui lòng nhập tên thương hiệu","Lỗi Nhập");
                return;
            }    
            if(result == 2)
            {
                MessageBox.Show("Tên Thương Hiệu đã tồn tại", "Lỗi Nhập");
                return;
            }
            else
                MessageBox.Show("Thêm thành công", "Thông Báo");
            ThuongHieuBUS.fillingCombobox(cmbThuongHieu);
        }
    }
}
