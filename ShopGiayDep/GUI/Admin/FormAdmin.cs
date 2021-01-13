using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGiayDep.GUI.Admin
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.BringToFront();
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormQuanLyTaiKhoan)
                {
                    pnlNoiDung.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            addFormToPanel(1);
        }

        private void addFormToPanel(int choice)//Ham goi Form len
        {
            Form frm;
            switch (choice)
            {
                case 1:
                    frm = new FormQuanLyTaiKhoan();
                    break;
                case 2:
                    frm = new FormThemTaiKhoan();
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

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.BringToFront();
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormQuanLyTaiKhoan)
                {
                    pnlNoiDung.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            addFormToPanel(2);
        }
    }
}
