using quanlylaptop.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace quanlylaptop
{
    public partial class Form_DangNhap : Form
    {
        public static string username;
        public static string password;
        public Form_DangNhap()
        {
            InitializeComponent();
            CheckRememberMe();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (AuthenticateUser(username, password, out bool isAdmin))
            {
                Properties.Settings.Default.Username = username;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.IsAdmin = isAdmin; // Lưu trạng thái admin
                                                               // Properties.Settings.Default.RememberMe = checkBox3.Checked; // Nếu có checkbox Remember Me
                Properties.Settings.Default.Save();

                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password, out bool isAdmin)
        {
            if (username == "admin" && password == "12345")
            {
                LoginSuccess();
                isAdmin = true;
                return true;
            }
            else if (username == "emp1" && password == "123")
            {
                LoginSuccess();
                isAdmin = false;
                return true;
            }

            isAdmin = false; // Nếu không đúng thì trả về false
            return false;
        }
        private void LoginSuccess()
        {
            string username = textBox1.Text;
            string matkhau = textBox2.Text;

            if (checkBox3.Checked)
            {
                Properties.Settings.Default.Username = username;
                Properties.Settings.Default.Password = matkhau;
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
            }
        }

        private void CheckRememberMe()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                string savedUsername = Properties.Settings.Default.Username;
                string savedPassword = Properties.Settings.Default.Password;
                textBox1.Text = savedUsername;
                textBox2.Text = savedPassword;
                checkBox3.Checked = true;
            }
        }
    }
}



