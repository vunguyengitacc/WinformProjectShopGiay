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
    public partial class FormDanhSachTonKho : Form
    {
        public FormDanhSachTonKho()
        {
            InitializeComponent();
            ThuongHieuBUS.fillingCombobox(cmbThuongHieu);
            SanPhamBUS.bindingDataGridView(dgvThongTin);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
                SanPhamBUS.bindingDataGridView(dgvThongTin);
            else
            {
                SanPhamBUS.bindingDataGridView(dgvThongTin, txtMaHang.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnUpadate.BackColor == Color.DarkBlue)
            {
                int result = SanPhamBUS.delete(txtMaHang.Text);
                if (result == 1)
                    MessageBox.Show("Mã Sản Phẩm không tồn tại", "Lỗi");
                if (result == 2)
                    MessageBox.Show("Sản phẩm tạm thời không thể xóa do đã có ràng buộc với các Hóa Đơn", "Lỗi");
                else
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                SanPhamBUS.bindingDataGridView(dgvThongTin);
            }
        }

        private void FormDanhSachTonKho_Load(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
                btnDelete.BackColor = Color.Blue;
            else
                btnDelete.BackColor = Color.DarkBlue;
            if (txtMaHang.Text == "")
                btnUpadate.BackColor = Color.Blue;
            else
                btnUpadate.BackColor = Color.DarkBlue;
        }

        private void btnUpadate_Click(object sender, EventArgs e)
        {
            if (btnUpadate.BackColor == Color.DarkBlue)
            {
                SanPhamBUS.update(txtMaHang.Text, txtTen.Text, cmbThuongHieu.SelectedIndex, txtColor.Text, txtSize.Text, txtSoLuong.Text);
                SanPhamBUS.bindingDataGridView(dgvThongTin);
            }
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtMaHang.Text = dgvThongTin.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text = dgvThongTin.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbThuongHieu.Text = dgvThongTin.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtColor.Text = dgvThongTin.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSize.Text = dgvThongTin.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSoLuong.Text = dgvThongTin.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (txtMaHang.Text == "")
                btnDelete.BackColor = Color.Blue;
            else
                btnDelete.BackColor = Color.DarkBlue;
            if (txtMaHang.Text == "")
                btnUpadate.BackColor = Color.Blue;
            else
                btnUpadate.BackColor = Color.DarkBlue;
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
                btnDelete.BackColor = Color.Blue;
            else
                btnDelete.BackColor = Color.DarkBlue;

            if (txtMaHang.Text == "")
                btnUpadate.BackColor = Color.Blue;
            else
                btnUpadate.BackColor = Color.DarkBlue;
        }
    }
}
