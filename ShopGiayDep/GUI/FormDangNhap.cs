using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopGiayDep.BUS;

namespace ShopGiayDep.GUI
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            
        }


        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (AccountBUS.loginCall(txtUsername.Text, txtPassword.Text))
            {
                FormHome nf = new FormHome(txtUsername.Text);
                nf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không đúng thông tin đăng nhập!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát", "Xác Nhận",MessageBoxButtons.YesNo)==DialogResult.Yes)
                Application.Exit();
        }
    }
}
