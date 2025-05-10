namespace SaleShoes
{
    partial class dangki
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_dangnhap;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button bt_dangki;
        private System.Windows.Forms.Button bt_huy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_dangnhap = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.bt_dangki = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_ten.Location = new System.Drawing.Point(140, 27);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(170, 34);
            this.txt_ten.TabIndex = 1;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_diachi.Location = new System.Drawing.Point(140, 72);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(170, 34);
            this.txt_diachi.TabIndex = 3;
            // 
            // txt_dangnhap
            // 
            this.txt_dangnhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_dangnhap.Location = new System.Drawing.Point(140, 117);
            this.txt_dangnhap.Name = "txt_dangnhap";
            this.txt_dangnhap.Size = new System.Drawing.Size(170, 34);
            this.txt_dangnhap.TabIndex = 5;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_matkhau.Location = new System.Drawing.Point(140, 162);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(170, 34);
            this.txt_matkhau.TabIndex = 7;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_sdt.Location = new System.Drawing.Point(140, 207);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(170, 34);
            this.txt_sdt.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_email.Location = new System.Drawing.Point(140, 252);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(170, 34);
            this.txt_email.TabIndex = 11;
            // 
            // bt_dangki
            // 
            this.bt_dangki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.bt_dangki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dangki.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_dangki.ForeColor = System.Drawing.Color.White;
            this.bt_dangki.Location = new System.Drawing.Point(80, 410);
            this.bt_dangki.Name = "bt_dangki";
            this.bt_dangki.Size = new System.Drawing.Size(100, 35);
            this.bt_dangki.TabIndex = 2;
            this.bt_dangki.Text = "Đăng ký";
            this.bt_dangki.UseVisualStyleBackColor = false;
            this.bt_dangki.Click += new System.EventHandler(this.bt_dangki_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.Gray;
            this.bt_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_huy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_huy.ForeColor = System.Drawing.Color.White;
            this.bt_huy.Location = new System.Drawing.Point(200, 410);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(100, 35);
            this.bt_huy.TabIndex = 3;
            this.bt_huy.Text = "Huỷ";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblTen);
            this.groupBox.Controls.Add(this.txt_ten);
            this.groupBox.Controls.Add(this.lblDiaChi);
            this.groupBox.Controls.Add(this.txt_diachi);
            this.groupBox.Controls.Add(this.lblDangNhap);
            this.groupBox.Controls.Add(this.txt_dangnhap);
            this.groupBox.Controls.Add(this.lblMatKhau);
            this.groupBox.Controls.Add(this.txt_matkhau);
            this.groupBox.Controls.Add(this.lblSdt);
            this.groupBox.Controls.Add(this.txt_sdt);
            this.groupBox.Controls.Add(this.lblEmail);
            this.groupBox.Controls.Add(this.txt_email);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox.Location = new System.Drawing.Point(30, 60);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(340, 330);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Thông tin đăng ký";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTen.Location = new System.Drawing.Point(20, 30);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(71, 28);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Họ tên";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiaChi.Location = new System.Drawing.Point(20, 75);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(71, 28);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDangNhap.Location = new System.Drawing.Point(20, 120);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(140, 28);
            this.lblDangNhap.TabIndex = 4;
            this.lblDangNhap.Text = "Tên đăng nhập";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatKhau.Location = new System.Drawing.Point(20, 165);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(94, 28);
            this.lblMatKhau.TabIndex = 6;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSdt.Location = new System.Drawing.Point(20, 210);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(128, 28);
            this.lblSdt.TabIndex = 8;
            this.lblSdt.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(20, 255);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 28);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // dangki
            // 
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.bt_dangki);
            this.Controls.Add(this.bt_huy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "dangki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblEmail;
    }
}
