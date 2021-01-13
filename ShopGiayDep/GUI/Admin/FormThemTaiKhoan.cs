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
    public partial class FormThemTaiKhoan : Form
    {
        public FormThemTaiKhoan()
        {
            InitializeComponent();
            ChucVuBUS.fillingComboBox(cmbChucVu);
            btnCommit.BackColor = Color.Blue;
        }

        private void setColorbtnCommit()
        {
            if (txtUsername.Text.Length > 20 || txtUsername.Text.Length < 7 || txtPassword.Text.Length > 20 || txtPassword.Text.Length < 7)
                btnCommit.BackColor = Color.Blue;
            else
                btnCommit.BackColor = Color.DarkBlue;
            if (txtUsername.Text.Length > 20 || txtPassword.Text.Length > 20)
            {
                MessageBox.Show("Không được nhập quá 20 kí tự cho trường này", "Lỗi Nhập");
                txtUsername.Text = txtPassword.Text = "";
            }

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (btnCommit.BackColor == Color.Blue)
                return;
            int result = AccountBUS.insert(txtUsername.Text, txtPassword.Text, txtXacNhanPass.Text, txtMaNV.Text, cmbChucVu.SelectedIndex);
            if (result == 1)
                MessageBox.Show("Mã xác thực mật khẩu không chính xác", "Lỗi Nhập");
            else if (result == 2)
                MessageBox.Show("Nhân viên không tồn tại, hãy tạo mới trước khi thêm tài khoản", "Lỗi Nhập");
            else if (result == 0)
            {
                MessageBox.Show("Thêm thành công", "Thông Báo");
                txtMaNV.Text = "";
                txtPassword.Text = "";
                txtXacNhanPass.Text = "";
                txtUsername.Text = "";
                btnCommit.BackColor = Color.Blue;
                cmbChucVu.SelectedIndex = 0;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (AccountBUS.checkAccount(txtUsername.Text))
            {
                txtUsername.BackColor = Color.Red;
                btnCommit.BackColor = Color.Blue;
            }
            else
            {
                txtUsername.BackColor = Color.White;
                setColorbtnCommit();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            setColorbtnCommit();
        }
    }
}
