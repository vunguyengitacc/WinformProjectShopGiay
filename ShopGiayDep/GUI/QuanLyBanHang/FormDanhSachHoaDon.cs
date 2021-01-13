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

namespace ShopGiayDep.GUI.QuanLyBanHang
{
    public partial class FormDanhSachHoaDon : Form
    {
        public FormDanhSachHoaDon()
        {
            InitializeComponent();
            HoaDonBUS.bindingDataGridView(dgvThongTinHoaDon);
            CTHDBUS.bindingDataGridView(dgvThongTinChiTietHD, "");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HoaDonBUS.bindingDataGridView(dgvThongTinHoaDon);
            CTHDBUS.bindingDataGridView(dgvThongTinChiTietHD, "");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int result = HoaDonBUS.delete(txtMaHD.Text);
            if (result == 1)
            {
                MessageBox.Show("Mã Hóa Đơn không tồn tại", "Lỗi");
                return;
            }        
            if (result == 2)
            {
                MessageBox.Show("Hóa Đơn này tạm thời không thể xóa do đã có thực hiện thanh toán", "Lỗi");
                return;
            }
            MessageBox.Show("Xóa thành công", "Thông Báo");
            HoaDonBUS.bindingDataGridView(dgvThongTinHoaDon);
        }

        private void dgvThongTinHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtMaHD.Text = dgvThongTinHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaKH.Text = dgvThongTinHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaNV.Text = dgvThongTinHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTongTien.Text = dgvThongTinHoaDon.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtpNgayLap.Text = dgvThongTinHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtGhiChu.Text = HoaDonBUS.fillGhiChu(dgvThongTinHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
            CTHDBUS.bindingDataGridView(dgvThongTinChiTietHD, dgvThongTinHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int result = HoaDonBUS.UpdateSanPham(txtMaKH.Text, txtMaNV.Text, dtpNgayLap.Value, txtMaHD.Text);
            if (result == 1)
                MessageBox.Show("Không tìm thấy thông tin!\nHãy thử lại", "Thông báo");
            else if (result == 2)
                MessageBox.Show("Không được nhập quá ngày hiện tại", "Thông báo");
            else if (result == 3)
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại", "Thông báo");
            else if (result == 0)
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            HoaDonBUS.bindingDataGridView(dgvThongTinHoaDon);
        }
    }
}
