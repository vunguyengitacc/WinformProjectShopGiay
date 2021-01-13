
namespace ShopGiayDep.GUI.QuanLyKho
{
    partial class FormQuanLyKho
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
            this.btnnNhapKho = new System.Windows.Forms.Button();
            this.btnDanhSachHangTon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.BackColor = System.Drawing.Color.Gray;
            this.pnlNoiDung.Location = new System.Drawing.Point(17, 312);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(40, 39);
            this.pnlNoiDung.TabIndex = 16;
            // 
            // btnImage
            // 
            this.btnImage.Image = global::ShopGiayDep.Properties.Resources.kho1;
            this.btnImage.Location = new System.Drawing.Point(62, 25);
            this.btnImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(680, 377);
            this.btnImage.TabIndex = 15;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // btnnNhapKho
            // 
            this.btnnNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnNhapKho.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnnNhapKho.Location = new System.Drawing.Point(62, 418);
            this.btnnNhapKho.Name = "btnnNhapKho";
            this.btnnNhapKho.Size = new System.Drawing.Size(319, 67);
            this.btnnNhapKho.TabIndex = 13;
            this.btnnNhapKho.Text = "Nhập Kho";
            this.btnnNhapKho.UseVisualStyleBackColor = false;
            this.btnnNhapKho.Click += new System.EventHandler(this.btnnNhapKho_Click);
            // 
            // btnDanhSachHangTon
            // 
            this.btnDanhSachHangTon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDanhSachHangTon.FlatAppearance.BorderSize = 0;
            this.btnDanhSachHangTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachHangTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachHangTon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDanhSachHangTon.Location = new System.Drawing.Point(423, 418);
            this.btnDanhSachHangTon.Name = "btnDanhSachHangTon";
            this.btnDanhSachHangTon.Size = new System.Drawing.Size(319, 67);
            this.btnDanhSachHangTon.TabIndex = 14;
            this.btnDanhSachHangTon.Text = "Danh Sách Tồn Kho";
            this.btnDanhSachHangTon.UseVisualStyleBackColor = false;
            this.btnDanhSachHangTon.Click += new System.EventHandler(this.btnDanhSachHangTon_Click);
            // 
            // FormQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(764, 511);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnnNhapKho);
            this.Controls.Add(this.btnDanhSachHangTon);
            this.Name = "FormQuanLyKho";
            this.Text = "FormQuanLyKho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNoiDung;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnnNhapKho;
        private System.Windows.Forms.Button btnDanhSachHangTon;
    }
}