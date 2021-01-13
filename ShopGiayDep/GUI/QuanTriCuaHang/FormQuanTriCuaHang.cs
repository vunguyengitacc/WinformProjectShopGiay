using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGiayDep.GUI.QuanTriCuaHang
{
    public partial class FormQuanTriCuaHang : Form
    {
        public FormQuanTriCuaHang()
        {
            InitializeComponent();
        }

        private void btnnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.BringToFront();
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormQuanLyNhanVien)
                {
                    pnlNoiDung.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }
            addFormToPanel(1);
        }

        private void addFormToPanel(int choice)
        {
            Form frm;
            switch (choice)
            {
                case 1:
                    frm = new FormQuanLyNhanVien();
                    break;
                case 2:
                    frm = new FormThongKe();
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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.BringToFront();
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormThongKe)
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
