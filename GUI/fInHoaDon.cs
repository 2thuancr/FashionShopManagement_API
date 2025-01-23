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
    public partial class fInHoaDon : Form
    {
        public string PaymentStatus = Bill.BILL_CHUA_THANH_TOAN;
        private string bankName = "VietinBank";
        private string bankAccountID = "100874103875";
        private string bankAccountName = "VI QUOC THUAN";
        private Bill bill = new Bill();

        public fInHoaDon()
        {
            InitializeComponent();
        }

        public fInHoaDon(Bill bill)
        {
            InitializeComponent();
            this.bill = bill;
        }

        private void fInHoaDon_Load(object sender, EventArgs e)
        {
            LoadBill();
            LoadBillInfo();
            LoadQR();
        }

        private void LoadBill()
        {
            this.textbox_MaHoaDon.Text = this.bill.ID.ToString();
            
        }

        private void LoadBillInfo()
        {
            var result = BillInfoBUS.Instance.GetBillInfoDetailByBillId(this.bill.ID);

            if (result != null && result.Count > 0)
            {
                // Bill
                string customerName = result[0].CustomerName;
                string staffName = result[0].StaffName;
                string businessTime = result[0].BusinessTime.ToString();
                decimal totalPrice = result[0].TotalPrice;
                //decimal discount = result[0].Discount;

                this.textbox_KhachHang.Text = customerName;
                this.textbox_NhanVien.Text = staffName;
                this.textbox_NgayMua.Text = businessTime;
                //this.textbox_TongHoaDon.Text = (totalPrice - discount).ToString();

                // BillInfo
                List<ProductInBill> listProductInBills = new List<ProductInBill>();
                foreach (var item in result)
                {
                    var productInBill = new ProductInBill();
                    productInBill.ProductId = item.ProductId;
                    productInBill.Name = item.ProductName;
                    productInBill.Price = item.ProductPrice;
                    productInBill.Discount = item.ProductDiscount;
                    productInBill.Amount = item.Amount;

                    listProductInBills.Add(productInBill);
                }
                this.data_DSSanPham.DataSource = null;
                this.data_DSSanPham.DataSource = listProductInBills;
            }
        }

        private void LoadQR()
        {
            string amount = (bill.TotalPrice).ToString();
            string addInfo = $"Thanh toan hoa don {bill.ID}";

            var url = BillBUS.Instance.GetQrPayment("qr_only", bankName, bankAccountID, bankAccountName, addInfo, amount);
            try
            {
                this.picture_QRCode.Load(url);
                this.picture_QRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            this.PaymentStatus = Bill.BILL_DA_THANH_TOAN;
            this.Close();
        }
    }
}
