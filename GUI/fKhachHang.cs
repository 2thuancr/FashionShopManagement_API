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
    public partial class fKhachHang : Form
    {
        private List<Customer> listCustomer = new List<Customer>();

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                this.listCustomer = CustomerBUS.Instance.GetAllCustomer();
                if(this.listCustomer.Count > 0)
                {
                    this.data_DSKhachHang.DataSource = this.listCustomer;
                }    
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }
        
        public fKhachHang()
        {
            InitializeComponent();
        }

        private void btn_TaoDon_Click(object sender, EventArgs e)
        {
            fTaoDonHang fTaoDonHang = new fTaoDonHang();
            fTaoDonHang.ShowDialog();
        }

        private void data_DSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy id được click
            var selectedIndex = data_DSKhachHang.SelectedCells[0].RowIndex;
            // GetBillById
            Customer customer = this.listCustomer[selectedIndex];
            // Hiển thị form
            fChiTietKhachHang fChiTietKhachHang = new fChiTietKhachHang(customer);
            fChiTietKhachHang.ShowDialog();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy số điện thoại được ghi
                string phone = textBox_TimKiem.TextButton;
                // Gọi GetCustomerByPhone từ BUS
                this.listCustomer = CustomerBUS.Instance.GetCustomerByPhone(phone);
                // Hiện thị ra danh sách khách hàng với số điện thoại đã nhập
                this.data_DSKhachHang.DataSource = this.listCustomer;
            }
           catch(Exception ex)
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
    }
}
