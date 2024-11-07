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
    public partial class fTaoDonHang : Form
    {
        private List<Product> listProducts = new List<Product>();
        private Customer customer = new Customer();
        public fTaoDonHang()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fTaoDonHang_Load(object sender, EventArgs e)
        {
            this.LoadLoginAccount();
            this.LoadProducts();

        }

        private void LoadProducts()
        {
            // Lấy GetAllProduct by BUS
            this.listProducts = ProductBUS.Instance.GetAllProduct();

            //Hiện thị tất cả các sp lên comboBox
            this.comboBox_SanPham.DataSource = listProducts;
            this.comboBox_SanPham.ValueMember = "Id";
            this.comboBox_SanPham.DisplayMember = "Name";
        }

        private void LoadLoginAccount()
        {
            this.textBox_NhanVien.TextButton = fHome.LoginAccount.DisplayName;
        }

        private void btn_TraCuuSDT_Click(object sender, EventArgs e)
        {
            // lấy số điện thoại được nhập
            string phone = this.textBox_SDT.TextButton;
            //  GetCustomer from BUS
            var listCustomer = CustomerBUS.Instance.GetCustomerByPhone(phone);
            if (listCustomer.Count == 0)
            {
                
                MessageBox.Show("Không tìm thấy khách hàng");
                this.textBox_SDT.TextButton = "";
                this.textBox_TenKhachHang.TextButton = "";
            }
            else
            {
                // Lấy thông tin của khách hàng đầu tiên
                this.customer = listCustomer[0];
                // Hiện thị lên textBox
                this.textBox_TenKhachHang.TextButton = this.customer.CustomerName;
                this.textBox_SDT.TextButton = this.customer.PhoneNumber;
            }


        }
    }
}
