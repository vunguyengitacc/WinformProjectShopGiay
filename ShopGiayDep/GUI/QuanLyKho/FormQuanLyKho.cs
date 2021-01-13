using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGiayDep.GUI.QuanLyKho
{
    public partial class FormQuanLyKho : Form
    {
        public FormQuanLyKho()
        {
            InitializeComponent();
        }

        private void addFormToPanel(int choice)
        {
            Form frm;
            switch (choice)
            {
                case 1:
                    frm = new FormNhapKho();
                    break;
                case 2:
                    frm = new FormDanhSachTonKho();
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

        private void btnnNhapKho_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.BringToFront();
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormNhapKho)
                {
                    pnlNoiDung.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            int choice = 1;
            addFormToPanel(choice);
        }

        private void btnDanhSachHangTon_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.BringToFront();
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormNhapKho)
                {
                    pnlNoiDung.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            int choice = 2;
            addFormToPanel(choice);
        }
    }
}
