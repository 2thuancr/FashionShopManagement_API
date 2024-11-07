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
    public partial class fChiTietKhachHang : Form
    {
        private Customer customer = new Customer();
        public fChiTietKhachHang()
        {
            InitializeComponent();
        }
        public fChiTietKhachHang(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            this.ShowCustomer();
        }

        private void ShowCustomer()
        {
            this.textBox_MaKH.TextButton = this.customer.CustomerId.ToString();
            this.textBox_HoVaTen.TextButton = this.customer.CustomerName.ToString();
            this.textBox_DiaChi.TextButton = this.customer.Address.ToString();
            this.textBox_SDT.TextButton = this.customer.PhoneNumber.ToString();
            this.textBox_MaGiamGia.TextButton = this.customer.Discount.ToString();
        }

        private void poisonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fChiTietKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                // Lấy customerId
                int customerId = this.customer.CustomerId;
                // Gọi Bus lấy data
                List<Bill> listBills = BillBUS.Instance.GetBillByCustomerId(customerId);
                // Hiện thị lên dataGrid
                this.data_DonHangCuaKhachHang.DataSource = listBills;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            
        }
    }
}
