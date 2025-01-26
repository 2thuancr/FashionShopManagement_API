using BUS;
using DTO.Bills;
using DTO.Customers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class fChiTietKhachHang : Form
    {
        private Customer customer = new Customer();
        private List<Bill> listBills = new List<Bill>();
        private Bill selectedBill = null;
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
        }

        private void fChiTietKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachDonHang();
        }

        private void LoadDanhSachDonHang()
        {
            try
            {
                // Lấy customerId
                int customerId = this.customer.CustomerId;
                // Gọi Bus lấy data
                this.listBills = BillBUS.Instance.GetBillByCustomerId(customerId);
                // Hiện thị lên dataGrid
                this.data_DonHangCuaKhachHang.DataSource = listBills;
            }
            catch
            {
                MessageBox.Show("Lỗi hiển thị danh sách đơn hàng");
            }

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_XoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.selectedBill != null)
                {
                    var billId = this.selectedBill.ID;
                    var result = BillBUS.Instance.DeleteBill(this.selectedBill.ID);
                    if (result == true)
                    {
                        this.selectedBill = null;
                        LoadDanhSachDonHang();
                        MessageBox.Show($"Đã xóa đơn {billId} thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đã xóa đơn thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn hàng để xóa");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xóa đơn");
            }

        }

        private void data_DonHangCuaKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // lấy index
                int selectedIndex = this.data_DonHangCuaKhachHang.SelectedRows[0].Index;
                // Lấy dữ liệu ở hàng selectedIndex
                this.selectedBill = this.listBills[selectedIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi phát sinh");
            }
        }
    }
}
