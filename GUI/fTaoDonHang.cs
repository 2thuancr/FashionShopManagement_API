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
        // Dùng để load lên comboBox
        private List<Product> listProducts = new List<Product>();
        //Lưu thông tin sản phẩm đang được chọn
        private Product selectedProduct = new Product();
        // Lưu các sản phẩm có trong đơn hàng
        private Dictionary<Product, int> productsInBill = new Dictionary<Product, int>();
        private List<BillInfo> listBillInfo = new List<BillInfo>();
        private Customer customer = new Customer();
        private Bill bill = new Bill();

        private decimal totalPrice = 0;
        private decimal totalDiscount = 0;
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

        private void comboBox_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy ra index sản phẩm đang đc chọn
            var selectedIndex = this.comboBox_SanPham.SelectedIndex;

            // Lấy ra sản phẩm tại index trong list
            this.selectedProduct = this.listProducts[selectedIndex];

            // hiện thị lên giao diện
            this.textBox_DonGia.TextButton = this.selectedProduct.Price.ToString();
            this.textbox_KhuyenMai.TextButton = this.selectedProduct.Discount.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // lấy thông tin từ this.selectedProduct luu vào dataGrid
            int amount = Convert.ToInt32(this.textbox_SoLuong.TextButton);
            if (this.productsInBill.ContainsKey(selectedProduct))
            {

                this.productsInBill[selectedProduct] += amount;
            }
            else
            {
                this.productsInBill[selectedProduct] = amount;
            }

         

            // cập nhật lại tổng tiền, mã giảm giá và thành tiền
            this.totalPrice = 0;
            this.totalDiscount = 0;
            this.listBillInfo = new List<BillInfo>();
            foreach (var product in this.productsInBill.Keys)
            {
                var productAmount = this.productsInBill[product];
                this.totalPrice += product.Price * productAmount;
                this.totalDiscount += product.Discount * productAmount;

                var billInfo = new BillInfo(0, 0, product.Id, productAmount);
                this.listBillInfo.Add(billInfo);
            }
            this.data_DSSanPham.DataSource = null;
            this.data_DSSanPham.DataSource = this.listBillInfo;
            this.textBox_TongTien.TextButton = this.totalPrice.ToString();
            this.textBox_GiamGia.TextButton = this.totalDiscount.ToString();
            this.textBox_ThanhTien.TextButton = (this.totalPrice - this.totalDiscount).ToString();

            // Để cập nhật giao diện dataGridView thì cần phải thay đổi datasource

            this.data_DSSanPham.Refresh();

            this.data_DSSanPham.Invalidate();
        }
    }
}
