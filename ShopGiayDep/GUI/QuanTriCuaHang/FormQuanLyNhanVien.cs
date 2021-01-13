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

namespace ShopGiayDep.GUI.QuanTriCuaHang
{
    public partial class FormQuanLyNhanVien : Form
    {
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            NhanVienBUS.bindingDataGridView(dgvThongTin);
            ChucVuBUS.fillingComboBox(cmbChucVu);
            NhanVienBUS.fillingComboBox(cmbGioiTinh);
            cmbGioiTinh.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int result = NhanVienBUS.insert(txtMaNV.Text, txtTen.Text, txtDiaChi.Text, txtSDT.Text, cmbGioiTinh.SelectedIndex, dtpNgaySinh.Value);
            if (result == 0)
                MessageBox.Show("Thêm thành công", "Thông Báo");
            if (result == 1)
                MessageBox.Show("Vui lòng nhập đầy đủ các trường", "Lỗi Nhập");
            if (result == 2)
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại", "Lỗi Nhập");
            if (result == 3)
                MessageBox.Show("Nhân viên đã tồn tại", "Lỗi Nhập");
            NhanVienBUS.bindingDataGridView(dgvThongTin);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result = NhanVienBUS.delete(txtMaNV);
            if (result == 1)
                MessageBox.Show("Khách Hàng không tồn tại", "Lỗi Nhập");
            if (result == 2)
                MessageBox.Show("Khách Hàng này tạm thời không thể xóa do đã có liên quan đến tác vụ giao dịch", "Lỗi Nhập");
            else
                MessageBox.Show("Xóa thành công", "Thông Báo");
            NhanVienBUS.bindingDataGridView(dgvThongTin);
        }

        private void btnUpadate_Click(object sender, EventArgs e)
        {
            int result = NhanVienBUS.update(txtMaNV.Text, txtTen.Text, txtDiaChi.Text, dtpNgaySinh.Value, txtSDT.Text, cmbGioiTinh.SelectedIndex);
            if (result == 1)
                MessageBox.Show("Không tìm thấy thông tin!\nHãy thử lại", "Lỗi nhập");
            else if (result == 2)
                MessageBox.Show("Không được nhập quá ngày hiện tại", "Lỗi nhập");
            else if (result == 3)
                MessageBox.Show("Không được nhập sai định dạng số điện thoại", "Lỗi nhập");
            else if (result == 0)
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            NhanVienBUS.bindingDataGridView(dgvThongTin);
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtMaNV.Text = dgvThongTin.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text = dgvThongTin.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvThongTin.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvThongTin.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbGioiTinh.Text = dgvThongTin.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSDT.Text = dgvThongTin.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" && txtTen.Text == "")
                NhanVienBUS.bindingDataGridView(dgvThongTin);
            else
            {
                if (txtTen.Text == "")
                    NhanVienBUS.bindingDataGridView(dgvThongTin, txtMaNV.Text);
                else
                    NhanVienBUS.bindingDataGridView(dgvThongTin, txtTen.Text);
            }
        }

        private void btnGetMaKHMoi_Click(object sender, EventArgs e)
        {
            NhanVienBUS.getMaNVMoi(txtMaNV);
        }
    }
}
