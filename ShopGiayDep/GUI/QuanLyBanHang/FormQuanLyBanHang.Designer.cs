
namespace ShopGiayDep.GUI.QuanLyBanHang
{
    partial class FormQuanLyBanHang
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
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnDanhSachKhachHang = new System.Windows.Forms.Button();
            this.btnDanhSachHoaDon = new System.Windows.Forms.Button();
            this.btnnLapHoaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.Location = new System.Drawing.Point(421, 30);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(100, 50);
            this.pnlNoiDung.TabIndex = 22;
            // 
            // btnImage
            // 
            this.btnImage.Image = global::ShopGiayDep.Properties.Resources.hoadon;
            this.btnImage.Location = new System.Drawing.Point(21, 16);
            this.btnImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(360, 479);
            this.btnImage.TabIndex = 21;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // btnDanhSachKhachHang
            // 
            this.btnDanhSachKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDanhSachKhachHang.FlatAppearance.BorderSize = 0;
            this.btnDanhSachKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachKhachHang.Location = new System.Drawing.Point(397, 335);
            this.btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            this.btnDanhSachKhachHang.Size = new System.Drawing.Size(347, 54);
            this.btnDanhSachKhachHang.TabIndex = 20;
            this.btnDanhSachKhachHang.Text = "Danh Sách Khách Hàng";
            this.btnDanhSachKhachHang.UseVisualStyleBackColor = false;
            this.btnDanhSachKhachHang.Click += new System.EventHandler(this.btnDanhSachKhachHang_Click);
            // 
            // btnDanhSachHoaDon
            // 
            this.btnDanhSachHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDanhSachHoaDon.FlatAppearance.BorderSize = 0;
            this.btnDanhSachHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachHoaDon.Location = new System.Drawing.Point(430, 235);
            this.btnDanhSachHoaDon.Name = "btnDanhSachHoaDon";
            this.btnDanhSachHoaDon.Size = new System.Drawing.Size(287, 52);
            this.btnDanhSachHoaDon.TabIndex = 19;
            this.btnDanhSachHoaDon.Text = "Danh Sách Hóa Đơn";
            this.btnDanhSachHoaDon.UseVisualStyleBackColor = false;
            this.btnDanhSachHoaDon.Click += new System.EventHandler(this.btnDanhSachHoaDon_Click);
            // 
            // btnnLapHoaDon
            // 
            this.btnnLapHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnnLapHoaDon.FlatAppearance.BorderSize = 0;
            this.btnnLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnLapHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnLapHoaDon.Location = new System.Drawing.Point(462, 135);
            this.btnnLapHoaDon.Name = "btnnLapHoaDon";
            this.btnnLapHoaDon.Size = new System.Drawing.Size(232, 47);
            this.btnnLapHoaDon.TabIndex = 18;
            this.btnnLapHoaDon.Text = "Lập Hóa Đơn";
            this.btnnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnnLapHoaDon.Click += new System.EventHandler(this.btnnLapHoaDon_Click);
            // 
            // FormQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(764, 511);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnDanhSachKhachHang);
            this.Controls.Add(this.btnDanhSachHoaDon);
            this.Controls.Add(this.btnnLapHoaDon);
            this.Name = "FormQuanLyBanHang";
            this.Text = "FormQuanLyBanHang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNoiDung;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnDanhSachKhachHang;
        private System.Windows.Forms.Button btnDanhSachHoaDon;
        private System.Windows.Forms.Button btnnLapHoaDon;
    }
}