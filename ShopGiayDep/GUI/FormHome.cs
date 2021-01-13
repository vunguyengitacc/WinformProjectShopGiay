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
using ShopGiayDep.GUI.Admin;
using ShopGiayDep.GUI.QuanLyBanHang;
using ShopGiayDep.GUI.QuanLyKho;
using ShopGiayDep.GUI.QuanTriCuaHang;

namespace ShopGiayDep.GUI
{
    public partial class FormHome : Form
    {

        static AccountBUS session;
        public FormHome()
        {
            InitializeComponent();
            ThuongHieuBUS.init();
            ChucVuBUS.init();
        }
        public FormHome(string user)
        {
            InitializeComponent();
            session = AccountBUS.getAccount(user);
            button1.Text = "Xin chào, " + NhanVienBUS.getTenNV(session);
        }

        private void btnQuanLyBanHang_Click(object sender, EventArgs e)
        {
            if (session.MaCV == "CV0")
                return;
            pnlNoiDung.Controls.Clear();
            setClickEventButton(btnQuanLyBanHang);
            FormQuanLyBanHang frm = new FormQuanLyBanHang();
            pnlNoiDung.Height = frm.Height;
            pnlNoiDung.AutoScroll = true;
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormQuanLyBanHang)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void setClickEventButton(Button btn)
        {
            foreach (object item in panel1.Controls)
            {
                if (item is Panel)
                {
                    resetColor((Panel)item);
                }
            }

            //btn.ForeColor = Color.FromArgb(255, 128, 0);
            btn.BackColor = Color.Gray;
        }
        private void resetColor(Panel panelVar)
        {
            foreach (Button item in panelVar.Controls)
            {
                item.BackColor = Color.FromArgb(255, 128, 0);
                item.ForeColor = Color.White;
            }
            btnLogOut.BackColor = Color.Red;
        }

        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            setClickEventButton(btnQuanLyKho);
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormQuanLyKho)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            FormQuanLyKho frm = new FormQuanLyKho();
            pnlNoiDung.Height = frm.Height;
            pnlNoiDung.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnQuanTriCuaHang_Click(object sender, EventArgs e)
        {
            if (session.MaCV == "CV1" || session.MaCV == "CV2")
            {
                pnlNoiDung.Controls.Clear();
                setClickEventButton(btnQuanTriCuaHang);
                foreach (Form frmItem in pnlNoiDung.Controls)
                {
                    if (frmItem is FormQuanTriCuaHang)
                    {
                        frmItem.BringToFront();
                        return;
                    }
                }
                FormQuanTriCuaHang frm = new FormQuanTriCuaHang();
                pnlNoiDung.Height = frm.Height;
                pnlNoiDung.AutoScroll = true;
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = 0;
                pnlNoiDung.Controls.Add(frm);
                frm.Show();
                frm.BringToFront();
            }
            else
            {
                MessageBox.Show("Tài khoản của bạn không có quyền truy cập vào vùng này");
                return;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (session.MaCV == "CV1")
            {
                pnlNoiDung.Controls.Clear();
                setClickEventButton(btnAdmin);
                foreach (Form frmItem in pnlNoiDung.Controls)
                {
                    if (frmItem is FormAdmin)
                    {
                        frmItem.BringToFront();
                        return;
                    }
                }
                FormAdmin frm = new FormAdmin(session.Username);
                pnlNoiDung.Height = frm.Height;
                pnlNoiDung.AutoScroll = true;
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = 0;
                pnlNoiDung.Controls.Add(frm);
                frm.Show();
                frm.BringToFront();
            }
            else
            {
                MessageBox.Show("Tài khoản của bạn không có quyền truy cập vào vùng này");
                return;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormDangNhap nf = new FormDangNhap();
            nf.Show();
            this.Hide();
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
