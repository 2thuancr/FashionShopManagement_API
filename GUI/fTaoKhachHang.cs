using BUS;
using DTO;
using DTO.Customers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class fTaoKhachHang : Form
    {
        private Customer customer = new Customer();
        public fTaoKhachHang()
        {
            InitializeComponent();
        }

        public fTaoKhachHang(Customer customer)
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
        }

        private void fChiTietKhachHang_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi lấy thông tin khách hàng");
            }

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                if (textBox_HoVaTen.TextButton == null || textBox_HoVaTen.TextButton == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập tên");
                    return;
                }
                else if (textBox_HoVaTen.TextButton.Any(char.IsDigit) || textBox_HoVaTen.TextButton.Any(char.IsSymbol))
                {
                    MessageBox.Show("Tên chỉ chứa ký tự chữ cái");
                    return;
                }
                else if (textBox_HoVaTen.TextButton.Length > 50)
                {
                    MessageBox.Show("Tên chỉ được tối đa 50 ký tự");
                    return;
                }
                else
                {
                    customer.CustomerName = Convert.ToString(textBox_HoVaTen.TextButton);
                }

                customer.DoB = date_NgaySinh.Value;

                if (textBox_SDT.TextButton.Length != 10)
                {
                    MessageBox.Show("Số điện thoại yêu cầu có 10 số");
                    return;
                }
                else if (textBox_SDT.TextButton.All(char.IsDigit) == false)
                {
                    MessageBox.Show("Số điện thoại chỉ chứa ký tự số");
                    return;
                }
                else if (textBox_SDT.TextButton.StartsWith("0") == false)
                {
                    MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0");
                    return;
                }
                else
                {
                    customer.PhoneNumber = textBox_SDT.TextButton;
                }

                var result = CustomerBUS.Instance.InsertCustomer(customer);
                if (result == true)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi thêm khách hàng");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không có quyền này!");
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
