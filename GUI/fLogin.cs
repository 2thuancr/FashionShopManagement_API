using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void DangNhap()
        {
            Account account = new Account(textBox_Email.Text, textBox_MatKhau.Text);
            try
            {
                if (AccountBUS.Instance.CheckLogin(account))
                {
                    Log.WriteLog("----------" + account.UserName + " log in ----------");

                    Account loginAccount = AccountBUS.Instance.GetAccountByUserName(account.UserName);

                    fHome form = new fHome();
                    // Gán thông tin tài khoản đã đăng nhập vào form Home.
                    fHome.LoginAccount = loginAccount;
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void textBox_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
    }
}
