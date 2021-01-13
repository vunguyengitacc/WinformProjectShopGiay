
namespace ShopGiayDep.GUI.QuanTriCuaHang
{
    partial class FormQuanTriCuaHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.btnnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::ShopGiayDep.Properties.Resources.nv;
            this.button1.Location = new System.Drawing.Point(76, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(636, 379);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(412, 398);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(300, 76);
            this.btnThongKe.TabIndex = 19;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.Location = new System.Drawing.Point(42, 52);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(12, 23);
            this.pnlNoiDung.TabIndex = 18;
            // 
            // btnnQuanLyNhanVien
            // 
            this.btnnQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.btnnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnQuanLyNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnQuanLyNhanVien.Location = new System.Drawing.Point(76, 398);
            this.btnnQuanLyNhanVien.Name = "btnnQuanLyNhanVien";
            this.btnnQuanLyNhanVien.Size = new System.Drawing.Size(295, 76);
            this.btnnQuanLyNhanVien.TabIndex = 17;
            this.btnnQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnnQuanLyNhanVien.Click += new System.EventHandler(this.btnnQuanLyNhanVien_Click);
            // 
            // FormQuanTriCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(754, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.btnnQuanLyNhanVien);
            this.Name = "FormQuanTriCuaHang";
            this.Text = "FormQuanTriCuaHang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel pnlNoiDung;
        private System.Windows.Forms.Button btnnQuanLyNhanVien;
    }
}