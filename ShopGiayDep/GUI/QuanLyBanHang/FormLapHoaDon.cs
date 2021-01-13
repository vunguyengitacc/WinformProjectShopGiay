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
    public partial class FormLapHoaDon : Form
    {
        static string maHoaDon = "";
        public FormLapHoaDon()
        {
            InitializeComponent();
            maHoaDon = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLapHoaDon_Load(object sender, EventArgs e)
        {
            if (maHoaDon == "")
            {
                txtMaHang.Text = "";
                txtSoLuong.Text = "";
                txtGiaTien.Text = "";
                txtTongTien.Text = "";
                txtGhiChu.ReadOnly = false;
                txtMaKH.ReadOnly = false;
                CTHDBUS.bindingDataGridView(dgvThongTinChiTieTHD, maHoaDon);
                HoaDonBUS.getHoaDonMoi(txtMaHD, txtMaNV);
                maHoaDon = txtMaHD.Text;
                btnThemBill.BackColor = Color.DarkBlue;
                btnCommit.BackColor = Color.Blue;
                btnThemCTHD.BackColor = Color.Blue;
                btnXoaCTHD.BackColor = Color.Blue;
                btnKhachMoi.BackColor = Color.DarkBlue;
            }
            if (dgvThongTinChiTieTHD.Rows.Count == 0)
                btnXoaCTHD.BackColor = Color.Blue;
            else
                btnXoaCTHD.BackColor = Color.DarkBlue;
        }

        private void btnThemBill_Click(object sender, EventArgs e)
        {
            if (btnThemBill.BackColor == Color.DarkBlue)
            {
                if (!HoaDonBUS.insert(txtMaHD, txtMaNV, txtMaKH, txtGhiChu))
                {
                    MessageBox.Show("Mã khách hàng không tồn tại!");
                    return;
                }
                btnThemBill.BackColor = Color.Blue;
                MessageBox.Show("Thêm thành công");
                btnCommit.BackColor = Color.DarkBlue;
                txtGhiChu.ReadOnly = true;
                txtMaKH.ReadOnly = true;
                btnKhachMoi.BackColor = Color.Blue;
            }
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            if (btnThemCTHD.BackColor == Color.Blue)
                return;
            if (btnThemBill.BackColor == Color.DarkBlue)
                MessageBox.Show("Vui lòng thêm hóa đơn trước");
            else
            {
                CTHDBUS.insert(txtMaHang.Text, txtSoLuong.Text, maHoaDon);
                CTHDBUS.bindingDataGridView(dgvThongTinChiTieTHD, maHoaDon);
                if (dgvThongTinChiTieTHD.Rows.Count == 0)
                    btnXoaCTHD.BackColor = Color.Blue;
                else
                    btnXoaCTHD.BackColor = Color.DarkBlue;

            }
            HoaDonBUS.fillTongTien(txtTongTien, maHoaDon);//tu dong dien tong tien moi khi them hang vao hoa don
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "" || txtSoLuong.Text == "0" || txtMaHang.Text == "" || btnThemBill.BackColor == Color.DarkBlue)
            {
                btnThemCTHD.BackColor = Color.Blue;
                return;
            }
            btnThemCTHD.BackColor = Color.DarkBlue;
            int result = SanPhamBUS.LoadGiaTien(txtGiaTien, txtMaHang, txtSoLuong);
            if (result == 1)
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
                txtMaHang.Text = "";
                txtSoLuong.Text = "";
            }
            if (result == 2)
                MessageBox.Show("Vui lòng nhập đúng định dạng số");
            if (result == 3)
            {
                MessageBox.Show("Không đủ hàng!");
                txtSoLuong.Text = "";
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (btnCommit.BackColor == Color.DarkBlue)
            {
                maHoaDon = "";
                FormLapHoaDon_Load(sender, e);
            }
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "" || txtSoLuong.Text == "0" || txtMaHang.Text == "" || btnThemBill.BackColor == Color.DarkBlue)
            {
                btnThemCTHD.BackColor = Color.Blue;
                return;
            }
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            if (btnXoaCTHD.BackColor == Color.Blue)
                return;
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            if (CTHDBUS.delete(txtMaHang.Text.ToUpper()) == 0)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                CTHDBUS.bindingDataGridView(dgvThongTinChiTieTHD, maHoaDon);
                HoaDonBUS.fillTongTien(txtTongTien, maHoaDon);

                if (dgvThongTinChiTieTHD.Rows.Count == 0)
                    btnXoaCTHD.BackColor = Color.Blue;
                else
                    btnXoaCTHD.BackColor = Color.DarkBlue;
            }
            else
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo");
        }

        private void dgvThongTinChiTieTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            txtMaHang.Text = dgvThongTinChiTieTHD.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSoLuong.Text = dgvThongTinChiTieTHD.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnKhachMoi_Click(object sender, EventArgs e)
        {
            if (btnKhachMoi.BackColor == Color.DarkBlue)
            {
                FormNhapKhachHang temp = new FormNhapKhachHang();
                temp.fillTxtBox(txtMaKH);
                temp.Show();
            }
        }
    }
}
