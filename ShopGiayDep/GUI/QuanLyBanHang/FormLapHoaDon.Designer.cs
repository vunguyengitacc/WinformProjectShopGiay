
namespace ShopGiayDep.GUI.QuanLyBanHang
{
    partial class FormLapHoaDon
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
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemBill = new System.Windows.Forms.Button();
            this.btnXoaCTHD = new System.Windows.Forms.Button();
            this.dgvThongTinChiTieTHD = new System.Windows.Forms.DataGridView();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnKhachMoi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnThemCTHD = new System.Windows.Forms.Button();
            this.pnlMatHang = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTieTHD)).BeginInit();
            this.pnlMatHang.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 810);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "Tổng Giá Trị";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(7, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Ghi Chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(11, 34);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(330, 120);
            this.txtGhiChu.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtGhiChu);
            this.panel3.Location = new System.Drawing.Point(383, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 166);
            this.panel3.TabIndex = 74;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 835);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 39);
            this.panel2.TabIndex = 73;
            // 
            // btnThemBill
            // 
            this.btnThemBill.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThemBill.FlatAppearance.BorderSize = 0;
            this.btnThemBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBill.ForeColor = System.Drawing.Color.White;
            this.btnThemBill.Location = new System.Drawing.Point(34, 240);
            this.btnThemBill.Name = "btnThemBill";
            this.btnThemBill.Size = new System.Drawing.Size(317, 34);
            this.btnThemBill.TabIndex = 64;
            this.btnThemBill.Text = "Thêm Hóa Đơn";
            this.btnThemBill.UseVisualStyleBackColor = false;
            this.btnThemBill.Click += new System.EventHandler(this.btnThemBill_Click);
            // 
            // btnXoaCTHD
            // 
            this.btnXoaCTHD.BackColor = System.Drawing.Color.Navy;
            this.btnXoaCTHD.FlatAppearance.BorderSize = 0;
            this.btnXoaCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCTHD.ForeColor = System.Drawing.Color.White;
            this.btnXoaCTHD.Location = new System.Drawing.Point(294, 481);
            this.btnXoaCTHD.Name = "btnXoaCTHD";
            this.btnXoaCTHD.Size = new System.Drawing.Size(178, 34);
            this.btnXoaCTHD.TabIndex = 70;
            this.btnXoaCTHD.Text = "Xóa Hàng";
            this.btnXoaCTHD.UseVisualStyleBackColor = false;
            this.btnXoaCTHD.Click += new System.EventHandler(this.btnXoaCTHD_Click);
            // 
            // dgvThongTinChiTieTHD
            // 
            this.dgvThongTinChiTieTHD.AllowUserToAddRows = false;
            this.dgvThongTinChiTieTHD.AllowUserToDeleteRows = false;
            this.dgvThongTinChiTieTHD.AllowUserToResizeColumns = false;
            this.dgvThongTinChiTieTHD.AllowUserToResizeRows = false;
            this.dgvThongTinChiTieTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinChiTieTHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongTinChiTieTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTinChiTieTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChiTieTHD.Location = new System.Drawing.Point(34, 536);
            this.dgvThongTinChiTieTHD.Name = "dgvThongTinChiTieTHD";
            this.dgvThongTinChiTieTHD.ReadOnly = true;
            this.dgvThongTinChiTieTHD.RowHeadersWidth = 51;
            this.dgvThongTinChiTieTHD.Size = new System.Drawing.Size(700, 250);
            this.dgvThongTinChiTieTHD.TabIndex = 66;
            this.dgvThongTinChiTieTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinChiTieTHD_CellClick);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(154, 809);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(186, 26);
            this.txtTongTien.TabIndex = 72;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnKhachMoi
            // 
            this.btnKhachMoi.BackColor = System.Drawing.Color.DarkBlue;
            this.btnKhachMoi.FlatAppearance.BorderSize = 0;
            this.btnKhachMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachMoi.ForeColor = System.Drawing.Color.White;
            this.btnKhachMoi.Location = new System.Drawing.Point(163, 131);
            this.btnKhachMoi.Name = "btnKhachMoi";
            this.btnKhachMoi.Size = new System.Drawing.Size(133, 23);
            this.btnKhachMoi.TabIndex = 41;
            this.btnKhachMoi.Text = "Khách Mới";
            this.btnKhachMoi.UseVisualStyleBackColor = false;
            this.btnKhachMoi.Click += new System.EventHandler(this.btnKhachMoi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(14, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(163, 60);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(133, 26);
            this.txtMaNV.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Số Lượng Hàng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(163, 77);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(251, 26);
            this.txtSoLuong.TabIndex = 30;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(14, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(14, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mã Hóa Đơn";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(163, 101);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(133, 26);
            this.txtMaKH.TabIndex = 34;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(163, 16);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(133, 26);
            this.txtMaHD.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Thành Tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(163, 124);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(251, 26);
            this.txtGiaTien.TabIndex = 32;
            // 
            // btnThemCTHD
            // 
            this.btnThemCTHD.BackColor = System.Drawing.Color.Navy;
            this.btnThemCTHD.FlatAppearance.BorderSize = 0;
            this.btnThemCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTHD.ForeColor = System.Drawing.Color.White;
            this.btnThemCTHD.Location = new System.Drawing.Point(34, 481);
            this.btnThemCTHD.Name = "btnThemCTHD";
            this.btnThemCTHD.Size = new System.Drawing.Size(204, 34);
            this.btnThemCTHD.TabIndex = 71;
            this.btnThemCTHD.Text = "Thêm Hàng";
            this.btnThemCTHD.UseVisualStyleBackColor = false;
            this.btnThemCTHD.Click += new System.EventHandler(this.btnThemCTHD_Click);
            // 
            // pnlMatHang
            // 
            this.pnlMatHang.BackColor = System.Drawing.Color.OldLace;
            this.pnlMatHang.Controls.Add(this.label3);
            this.pnlMatHang.Controls.Add(this.txtGiaTien);
            this.pnlMatHang.Controls.Add(this.label2);
            this.pnlMatHang.Controls.Add(this.txtSoLuong);
            this.pnlMatHang.Controls.Add(this.label6);
            this.pnlMatHang.Controls.Add(this.txtMaHang);
            this.pnlMatHang.Location = new System.Drawing.Point(34, 299);
            this.pnlMatHang.Name = "pnlMatHang";
            this.pnlMatHang.Size = new System.Drawing.Size(438, 176);
            this.pnlMatHang.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(16, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mã Hàng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(163, 27);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(251, 26);
            this.txtMaHang.TabIndex = 28;
            this.txtMaHang.TextChanged += new System.EventHandler(this.txtMaHang_TextChanged);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(764, 50);
            this.pnlTitle.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập Hóa Đơn";
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCommit.FlatAppearance.BorderSize = 0;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.ForeColor = System.Drawing.Color.White;
            this.btnCommit.Location = new System.Drawing.Point(511, 810);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(221, 25);
            this.btnCommit.TabIndex = 68;
            this.btnCommit.Text = "Xác Nhận Thanh Toán";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.BackColor = System.Drawing.Color.OldLace;
            this.pnlKhachHang.Controls.Add(this.btnKhachMoi);
            this.pnlKhachHang.Controls.Add(this.label7);
            this.pnlKhachHang.Controls.Add(this.txtMaNV);
            this.pnlKhachHang.Controls.Add(this.label9);
            this.pnlKhachHang.Controls.Add(this.label5);
            this.pnlKhachHang.Controls.Add(this.txtMaKH);
            this.pnlKhachHang.Controls.Add(this.txtMaHD);
            this.pnlKhachHang.Location = new System.Drawing.Point(35, 68);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(317, 166);
            this.pnlKhachHang.TabIndex = 67;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ShopGiayDep.Properties.Resources._4;
            this.button1.Location = new System.Drawing.Point(496, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 176);
            this.button1.TabIndex = 75;
            this.button1.Text = "Xóa Hàng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(781, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnThemBill);
            this.Controls.Add(this.btnXoaCTHD);
            this.Controls.Add(this.dgvThongTinChiTieTHD);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnThemCTHD);
            this.Controls.Add(this.pnlMatHang);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.pnlKhachHang);
            this.Name = "FormLapHoaDon";
            this.Text = "FormLapHoaDon";
            this.Load += new System.EventHandler(this.FormLapHoaDon_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTieTHD)).EndInit();
            this.pnlMatHang.ResumeLayout(false);
            this.pnlMatHang.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlKhachHang.ResumeLayout(false);
            this.pnlKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemBill;
        private System.Windows.Forms.Button btnXoaCTHD;
        private System.Windows.Forms.DataGridView dgvThongTinChiTieTHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnKhachMoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnThemCTHD;
        private System.Windows.Forms.Panel pnlMatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Panel pnlKhachHang;
    }
}