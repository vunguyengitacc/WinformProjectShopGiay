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
    public partial class FormAdmin : Form
    {

        static string trungChuyen;
        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(string text)
        {
            InitializeComponent();
            trungChuyen = text;
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

            FormQuanLyTaiKhoan frm = new FormQuanLyTaiKhoan(trungChuyen);
            
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }
        public void hideFatherEvent(FormAdmin frm)
        {
            frm.Hide();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.BringToFront();
            foreach (Form frmItem in pnlNoiDung.Controls)
            {
                if (frmItem is FormThemTaiKhoan)
                {
                    pnlNoiDung.BringToFront();
                    frmItem.BringToFront();
                    return;
                }
            }

            FormThemTaiKhoan frm = new FormThemTaiKhoan();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = 0;
            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }
    }
}
