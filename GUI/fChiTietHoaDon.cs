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
    public partial class fChiTietHoaDon : Form
    {
        private Bill bill = new Bill(); 
        public fChiTietHoaDon()
        {
            InitializeComponent();
        }
        public fChiTietHoaDon(Bill bill)
        {
            InitializeComponent();
            this.bill = bill;
            this.ShowBill();
        }
        private void ShowBill()
        {

            this.textBox_MaHoaDon.TextButton = this.bill.ID.ToString();
            this.textBox_TongTien.TextButton = this.bill.TotalPrice.ToString();
            this.textBox_ThanhTien.TextButton = (this.bill.TotalPrice).ToString();


            try
            {
                List<BillInfoDetail> listBillInfoDetails = BillInfoBUS.Instance.GetBillInfoDetailByBillId(bill.ID);
                if (listBillInfoDetails != null && listBillInfoDetails.Count > 0)
                {
                    var item = listBillInfoDetails.First();
                    this.textBox_NhanVien.TextButton = item.StaffName;
                    this.textBox_TenKhachHang.TextButton = item.CustomerName;
                    this.data_ChiTietHoaDon.DataSource = null;
                    this.data_ChiTietHoaDon.DataSource = listBillInfoDetails;
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy danh sách chi tiết hóa đơn");
            }
        }

        private void btn_XoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.bill != null)
                {
                    var billId = this.bill.ID;
                    var result = BillBUS.Instance.DeleteBill(this.bill.ID);
                    if (result == true)
                    {
                        MessageBox.Show("Đã xóa đơn thành công");
                        this.Close();
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
    }
}
