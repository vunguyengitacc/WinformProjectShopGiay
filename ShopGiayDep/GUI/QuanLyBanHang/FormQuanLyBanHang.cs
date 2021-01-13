using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGiayDep.GUI.QuanLyBanHang
{
    public partial class FormQuanLyBanHang : Form
    {
        public FormQuanLyBanHang()
        {
            InitializeComponent();
        }

        private void addFormToPanel(int choice)
        {
            Form frm;
            switch (choice)
            {
                case 1:
                    frm = new FormLapHoaDon();
                    break;
                case 2:
                    frm = new FormDanhSachHoaDon();
                    break;
                case 3:
                    frm = new FormDanhSachKhachHang();
                    break;
                default:
                    return;
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnnLapHoaDon_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.BringToFront();
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormLapHoaDon)
                {
                    pnlNoiDung.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            int choice = 1;
            addFormToPanel(choice);
        }

        private void btnDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.BringToFront();
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormDanhSachHoaDon)
                {
                    frmItem.BringToFront();
                    return;
                }
            }
            int choice = 2;
            addFormToPanel(choice);
        }

        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.BringToFront();
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormDanhSachKhachHang)
                {
                    pnlNoiDung.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            int choice = 3;
            addFormToPanel(choice);
        }
    }
}
