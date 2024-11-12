using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fHome : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static Account LoginAccount { get; set; }

        public fHome()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // Chỉ hiện thị những menu mà Account có quyền thực hiện.
        }

        private void MOVE_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem Account này có quyền mở Menu hay không
            int accountTypeId = fHome.LoginAccount.TypeID;
            bool isHasPermission = AccountTypePermissionBUS.Instance.CheckPermissionByAccountTypeId(accountTypeId, "MenuSanPham");
            if (isHasPermission == false)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!");
                return;
            }
            

            fSanPham fSanPham = new fSanPham(); 
            fSanPham.Show();
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem Account này có quyền mở Menu hay không
            int accountTypeId = fHome.LoginAccount.TypeID;
            bool isHasPermission = AccountTypePermissionBUS.Instance.CheckPermissionByAccountTypeId(accountTypeId, "MenuDonHang");
            if (isHasPermission == false)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!");
                return;
            }
            fDonHang fDonHang = new fDonHang();
            fDonHang.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem Account này có quyền mở Menu hay không
            int accountTypeId = fHome.LoginAccount.TypeID;
            bool isHasPermission = AccountTypePermissionBUS.Instance.CheckPermissionByAccountTypeId(accountTypeId, "MenuKhachHang");
            if (isHasPermission == false)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!");
                return;
            }
            fKhachHang fKhachHang = new fKhachHang();
            fKhachHang.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem Account này có quyền mở Menu hay không
            int accountTypeId = fHome.LoginAccount.TypeID;
            bool isHasPermission = AccountTypePermissionBUS.Instance.CheckPermissionByAccountTypeId(accountTypeId, "MenuNhanVien");
            if (isHasPermission == false)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!");
                return;
            }
            fNhanVien fNhanVien = new fNhanVien();
            fNhanVien.Show();
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem Account này có quyền mở Menu hay không
            int accountTypeId = fHome.LoginAccount.TypeID;
            bool isHasPermission = AccountTypePermissionBUS.Instance.CheckPermissionByAccountTypeId(accountTypeId, "MenuBaoCao");
            if (isHasPermission == false)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!");
                return;
            }
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem Account này có quyền mở Menu hay không
            int accountTypeId = fHome.LoginAccount.TypeID;
            bool isHasPermission = AccountTypePermissionBUS.Instance.CheckPermissionByAccountTypeId(accountTypeId, "MenuCaiDat");
            if (isHasPermission == false)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!");
                return;
            }
        }
    }
}
