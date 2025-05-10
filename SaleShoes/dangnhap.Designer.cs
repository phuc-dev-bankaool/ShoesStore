namespace SaleShoes
{
    partial class dangnhap
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cb_quyen = new System.Windows.Forms.ComboBox();
            this.lbl_quyen = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.txt_dangnhap = new System.Windows.Forms.TextBox();
            this.lbl_dangnhap = new System.Windows.Forms.Label();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG NHẬP";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.cb_quyen);
            this.groupBox.Controls.Add(this.lbl_quyen);
            this.groupBox.Controls.Add(this.txt_matkhau);
            this.groupBox.Controls.Add(this.lbl_matkhau);
            this.groupBox.Controls.Add(this.txt_dangnhap);
            this.groupBox.Controls.Add(this.lbl_dangnhap);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox.Location = new System.Drawing.Point(30, 60);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(340, 330);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Thông tin đăng nhập";
            // 
            // cb_quyen
            // 
            this.cb_quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_quyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_quyen.FormattingEnabled = true;
            this.cb_quyen.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cb_quyen.Location = new System.Drawing.Point(140, 207);
            this.cb_quyen.Name = "cb_quyen";
            this.cb_quyen.Size = new System.Drawing.Size(170, 36);
            this.cb_quyen.TabIndex = 5;
            // 
            // lbl_quyen
            // 
            this.lbl_quyen.AutoSize = true;
            this.lbl_quyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_quyen.Location = new System.Drawing.Point(20, 210);
            this.lbl_quyen.Name = "lbl_quyen";
            this.lbl_quyen.Size = new System.Drawing.Size(69, 28);
            this.lbl_quyen.TabIndex = 4;
            this.lbl_quyen.Text = "Quyền";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_matkhau.Location = new System.Drawing.Point(140, 162);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(170, 34);
            this.txt_matkhau.TabIndex = 3;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_matkhau.Location = new System.Drawing.Point(20, 165);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(94, 28);
            this.lbl_matkhau.TabIndex = 2;
            this.lbl_matkhau.Text = "Mật khẩu";
            // 
            // txt_dangnhap
            // 
            this.txt_dangnhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_dangnhap.Location = new System.Drawing.Point(140, 117);
            this.txt_dangnhap.Name = "txt_dangnhap";
            this.txt_dangnhap.Size = new System.Drawing.Size(170, 34);
            this.txt_dangnhap.TabIndex = 1;
            // 
            // lbl_dangnhap
            // 
            this.lbl_dangnhap.AutoSize = true;
            this.lbl_dangnhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_dangnhap.Location = new System.Drawing.Point(20, 120);
            this.lbl_dangnhap.Name = "lbl_dangnhap";
            this.lbl_dangnhap.Size = new System.Drawing.Size(140, 28);
            this.lbl_dangnhap.TabIndex = 0;
            this.lbl_dangnhap.Text = "Tên đăng nhập";
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.bt_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dangnhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_dangnhap.ForeColor = System.Drawing.Color.White;
            this.bt_dangnhap.Location = new System.Drawing.Point(80, 410);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(100, 35);
            this.bt_dangnhap.TabIndex = 2;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
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
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // dangnhap
            // 
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txt_dangnhap;
        private System.Windows.Forms.Label lbl_dangnhap;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.ComboBox cb_quyen;
        private System.Windows.Forms.Label lbl_quyen;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Button bt_huy;
    }
}