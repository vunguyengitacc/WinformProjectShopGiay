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
    public partial class FormDanhSachKhachHang : Form
    {
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
            KhachHangBUS.bindingDataGridView(dgvThongTinKH);
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            int result = KhachHangBUS.delete(txtMaKH.Text);
            if (result == 1)
            {
                MessageBox.Show("Khách Hàng không tồn tại", "Lỗi");
                return;
            }
            if (result == 2)
            {
                MessageBox.Show("Khách Hàng này tạm thời không thể xóa do đã có thực hiện giao dịch", "Lỗi");
                return;
            }     
            MessageBox.Show("Xóa thành công", "Thông Báo");
            KhachHangBUS.bindingDataGridView(dgvThongTinKH);
        }

        private void dgvThongTinKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtMaKH.Text = dgvThongTinKH.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenKH.Text = dgvThongTinKH.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvThongTinKH.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvThongTinKH.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSDT.Text = dgvThongTinKH.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            int result = KhachHangBUS.update(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, dtpNgaySinh.Value, txtSDT.Text);
            if (result == 1)
                MessageBox.Show("Không tìm thấy thông tin!\nHãy thử lại", "Lỗi nhập");
            else if (result == 2)
                MessageBox.Show("Không được nhập quá ngày hiện tại", "Lỗi nhập");
            else if (result == 3)
                MessageBox.Show("Không được nhập sai định dạng số điện thoại", "Lỗi nhập");
            else if (result == 0)
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            KhachHangBUS.bindingDataGridView(dgvThongTinKH);
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            int result = KhachHangBUS.insert(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, dtpNgaySinh.Value, txtSDT.Text);
            if (result == 1)
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi nhập");
            else if (result == 2)
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại", "Lỗi nhập");
            else if (result == 3)
                MessageBox.Show("Khách hàng đã tồn tại", "Lỗi nhập");
            else
                MessageBox.Show("Thêm thành công", "Thông báo");
            KhachHangBUS.bindingDataGridView(dgvThongTinKH);
        }

        private void btnGetMaKHMoi_Click(object sender, EventArgs e)
        {
            KhachHangBUS.getMaKHMoi(txtMaKH);
        }
    }
}
