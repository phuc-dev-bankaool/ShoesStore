using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SaleShoes
{
    public partial class dangki : Form
    {
        QLBanHangEntities context = new QLBanHangEntities();

        public dangki()
        {
            InitializeComponent();
        }

        private void bt_dangki_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (context.KhachHangs.Any(kh => kh.TenDangNhap == txt_dangnhap.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Trùng tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var loaiKH = context.LoaiKhachHangs.FirstOrDefault(lkh => lkh.MaLoaiKH == 1);
                if (loaiKH == null)
                {
                    MessageBox.Show("Không tìm thấy loại khách hàng mặc định.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newKH = new KhachHang
                {
                    Ten = txt_ten.Text.Trim(),
                    DiaChi = txt_diachi.Text.Trim(),
                    TenDangNhap = txt_dangnhap.Text.Trim(),
                    MatKhau = HashPassword(txt_matkhau.Text.Trim()),
                    SDT = txt_sdt.Text.Trim(),
                    Email = txt_email.Text.Trim(),
                    LoaiKhachHang = loaiKH
                };

                context.KhachHangs.Add(newKH);
                context.SaveChanges();

                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Trangchu trangchu = new Trangchu();
                trangchu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng ký: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            var inputs = new[] { txt_ten, txt_diachi, txt_dangnhap, txt_matkhau, txt_sdt, txt_email };
            if (inputs.Any(tb => string.IsNullOrWhiteSpace(tb.Text)))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txt_matkhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Lỗi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txt_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txt_sdt.Text, @"^0\d{9}$")) // Đơn giản: số Việt Nam 10 số
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            Trangchu trangchu = new Trangchu();
            trangchu.Show();
            this.Close();
        }
    }
}
