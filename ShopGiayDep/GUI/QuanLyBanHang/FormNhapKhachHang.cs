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
    public partial class FormNhapKhachHang : Form
    {
        public delegate void fillTextboxMaKH(TextBox txt);
        public event fillTextboxMaKH fillEvent;
        public FormNhapKhachHang()
        {
            InitializeComponent();
            KhachHangBUS.getMaKHMoi(txtMaKH);
            txtMaKH.ReadOnly = true;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            int resul = KhachHangBUS.insert(txtMaKH.Text, txtHoten.Text, txtDiaChi.Text, dtpNgayLap.Value, txtSDT.Text);
            if (resul == 1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi Nhập");
                return;
            }
            if (resul == 2)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại", "Lỗi Nhập");
                return;
            }
            if (resul == 4)
            {
                MessageBox.Show("Không được nhập quá thời gian hiện tại", "Lỗi Nhập");
                return;
            }
            if (resul == 0)
                MessageBox.Show("Thêm thành công");
            this.fillEvent += fillTxtBox;
            this.Close();
        }

        public void fillTxtBox(TextBox txt)
        {
            txt.Text = txtMaKH.Text;
        }
    }
}
