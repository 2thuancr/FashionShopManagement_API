using BUS;
using DTO;
using Shared.Helpers;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            radio_Staff.Checked = true;
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
            if (radio_Manager.Checked)
            {
                Account.ConnectionString = Account.connectionStringManager;
                Account.ConnectionName = Account.connectionNameManager;
            }
            else
            {
                Account.ConnectionString = Account.connectionStringStaff;
                Account.ConnectionName = Account.connectionNameStaff;
            }
            Account account = new Account(textBox_Email.Text, textBox_MatKhau.Text);
            try
            {
                if (AccountBUS.Instance.CheckLogin(account))
                {
                    Logger.WriteLog("----------" + account.UserName + " log in ----------");

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
                Logger.WriteLog("Error: " + ex);
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

        private void radio_Staff_Click_1(object sender, EventArgs e)
        {
            if (radio_Manager.Checked)
            {
                radio_Staff.Checked = false;
            }
        }

        private void radio_Manager_Click(object sender, EventArgs e)
        {
            if (radio_Staff.Checked)
            {
                radio_Manager.Checked = false;
            }
        }
    }
}
