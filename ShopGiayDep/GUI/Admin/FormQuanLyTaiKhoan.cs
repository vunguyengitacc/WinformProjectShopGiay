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

namespace ShopGiayDep.GUI.Admin
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
            AccountBUS.bindingDataGridView(dgvThongTin);
            ChucVuBUS.fillingComboBox(cmbChucVu);
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thay đổi trạng thái của tài khoản này", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!AccountBUS.update_TinhTrang(txtUsername))
                    MessageBox.Show("Không tìm thấy tài khoản", "Thông báo");
                else
                {
                    MessageBox.Show("Đã thay đổi trạng thái");
                    AccountBUS.bindingDataGridView(dgvThongTin);
                }

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            AccountBUS.find(txtUsername, txtMaNV, dgvThongTin);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!AccountBUS.delete(txtUsername))
                MessageBox.Show("Không tìm thấy tài khoản", "Lỗi Nhập");
            else
                MessageBox.Show("Xóa thành công", "Thông Báo");
            AccountBUS.bindingDataGridView(dgvThongTin);
        }

        private void btnUpadate_Click(object sender, EventArgs e)
        {

            int result = AccountBUS.update(txtUsername, txtPassword, txtMaNV, cmbChucVu.Text);
            if (result == 2)
                MessageBox.Show("Không tìm thấy tài khoản", "Lỗi Nhập");
            if (result == 1)
                MessageBox.Show("Mã Nhân Viên không tồn tại, vui lòng sửa lại hoặc thêm nhân viên mới", "Lỗi Nhập");
            else if (result == 0)
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            AccountBUS.bindingDataGridView(dgvThongTin);
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtUsername.Text = dgvThongTin.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPassword.Text = dgvThongTin.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaNV.Text = dgvThongTin.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbChucVu.Text = dgvThongTin.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (dgvThongTin.Rows[e.RowIndex].Cells[5].Value.ToString() == "Hoạt động")
            {
                btnKhoa.Text = "Khoá";
            }
            else
            {
                btnKhoa.Text = "Mở Khoá";
            }
        }
    }
}
