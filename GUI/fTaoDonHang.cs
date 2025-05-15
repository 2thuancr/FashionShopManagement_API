using BUS;
using DTO.Bills;
using DTO.Customers;
using DTO.Products;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private List<ProductInBill> listProductInBillDetails = new List<ProductInBill>();

        private Customer customer = new Customer();
        private Bill bill = new Bill();
        private BillPriceInfo billPriceInfo = new BillPriceInfo();

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
            this.textbox_SoLuong.TextButton = "1";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textbox_SoLuong.TextButton))
            {
                MessageBox.Show("Vui lòng nhập số lượng cho sản phẩm");
                return;
            }
            // lấy thông tin từ this.selectedProduct luu vào dataGrid
            int amount = 1;
            try
            {
                amount = Convert.ToInt32(this.textbox_SoLuong.TextButton);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
                return;
            }
            if (amount <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }

            if (this.productsInBill.ContainsKey(selectedProduct))
            {
                this.productsInBill[selectedProduct] += amount;
            }
            else
            {
                this.productsInBill[selectedProduct] = amount;
            }

            this.CapNhatBillInfo();
        }

        /// <summary>
        /// Không dùng tới nữa, dùng trigger
        /// </summary>
        private void CapNhatBillInfo()
        {

            try
            {
                // Tính lại tổng tiền, tổng giảm giá và danh sách sản phẩm trong đơn hàng
                decimal totalPrice = 0;
                decimal totalDiscount = 0;
                var listProductInBillDetails = new List<ProductInBill>();
                foreach (var product in this.productsInBill.Keys)
                {
                    // Lấy thông tin amount của sản phẩm trong đơn hàng
                    var productAmount = this.productsInBill[product];


                    totalPrice += product.Price * productAmount;
                    totalDiscount += product.Discount * productAmount;

                    var p = new ProductInBill();
                    p.ProductId = product.Id;
                    p.Name = product.Name;
                    p.Amount = productAmount;
                    p.Price = product.Price;
                    p.Discount = product.Discount;
                    p.Category = product.Category;
                    p.Size = product.Size;
                    p.Image = product.ImageUrl;
                    p.Description = product.Description;

                    listProductInBillDetails.Add(p);
                }

                // Cập nhật lại Bill
                this.totalPrice = totalPrice;
                this.totalDiscount = totalDiscount;
                //this.textBox_TongTien.TextButton = this.totalPrice.ToString();
                //this.textBox_GiamGia.TextButton = this.totalDiscount.ToString();
                //this.textBox_ThanhTien.TextButton = (this.totalPrice - this.totalDiscount).ToString();

                // Cập nhật lại BillInfo
                this.listProductInBillDetails = listProductInBillDetails;
                this.data_DSSanPham.DataSource = null;
                this.data_DSSanPham.DataSource = this.listProductInBillDetails;

                this.data_DSSanPham.Refresh();
                this.data_DSSanPham.Invalidate();
            }
            catch
            {
                MessageBox.Show("Có lỗi phát sinh");
                return;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (this.customer == null || this.customer.CustomerId <= 0)
            {
                MessageBox.Show("Chưa chọn thông tin Khách hàng");
                this.textBox_SDT.Focus();
                return;
            }

            if (this.bill == null || !this.listProductInBillDetails.Any())
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi lưu hóa đơn");
                return;
            }

            if (this.bill != null && this.bill.Id > 0)
            {
                UpdateBill();
            }
            else
            {
                InsertBill();
            }

            ReloadBillPrice();
        }

        private void ReloadBillPrice()
        {
            try
            {
                if (this.bill != null && this.bill.Id > 0)
                {

                    this.billPriceInfo = BillBUS.Instance.GetBillPriceInfo(this.bill.Id);

                    this.textBox_TongTien.TextButton = this.billPriceInfo.TongTien.ToString();
                    this.textBox_GiamGia.TextButton = this.billPriceInfo.GiamGia.ToString();
                    this.textBox_ThanhTien.TextButton = this.billPriceInfo.ThanhTien.ToString();
                    this.bill.TotalPrice = this.billPriceInfo.ThanhTien;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi phát sinh khi lấy thông tin từ database");
            }
        }

        private void InsertBill()
        {
            int billID = 0;
            // Lưu Bill
            this.bill = new Bill();
            this.bill.CustomerId = this.customer.CustomerId;
            this.bill.StaffId = fHome.LoginAccount.Id;
            this.bill.TotalPrice = this.totalPrice;
            this.bill.Status = 0;
            this.bill.PaymentStatus = Bill.BILL_CHUA_THANH_TOAN;

            try
            {
                billID = BillBUS.Instance.InsertBill(bill);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi tạo hóa đơn");
                return;
            }

            if (billID <= 0)
            {
                MessageBox.Show("Tạo đơn thất bại");
                return;
            }
            else
            {
                this.bill.Id = billID;
                this.textBox_MaHoaDon.TextButton = billID.ToString();
            }

            // Lưu BillInfo
            try
            {
                foreach (var product in this.listProductInBillDetails)
                {
                    BillInfo billInfo = new BillInfo()
                    {
                        ProductID = product.ProductId,
                        Amount = product.Amount,
                        BillID = billID,
                        Price = product.Price,
                        Discount = product.Discount
                    };

                    BillInfoBUS.Instance.InsertUpdateBillInfo(billInfo);
                }

                //this.btn_Luu.Enabled = false;
                MessageBox.Show("Lưu hóa đơn thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi tạo Chi tiết hóa đơn");
                return;
            }
        }

        private void UpdateBill()
        {
            // Lưu Bill
            this.bill.TotalPrice = this.totalPrice;
            // Nếu đúng thì tự cập nhật 
            //try
            //{
            //    BillBUS.Instance.UpdateBill(bill);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Cập nhật đơn thất bại");
            //    return;
            //}


            // Lưu BillInfo
            try
            {
                foreach (var product in this.listProductInBillDetails)
                {
                    BillInfo billInfo = new BillInfo()
                    {
                        ProductID = product.ProductId,
                        Amount = product.Amount,
                        BillID = this.bill.Id,
                        Price = product.Price,
                        Discount = product.Discount
                    };

                    BillInfoBUS.Instance.InsertUpdateBillInfo(billInfo);
                }

                //this.btn_Luu.Enabled = false;
                MessageBox.Show("Lưu hóa đơn thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi cập nhật Chi tiết hóa đơn");
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (this.bill != null && this.bill.Id > 0)
            {
                fThanhToan fThanhToan = new fThanhToan(this.bill);
                fThanhToan.ShowDialog();

                string paymentStatus = fThanhToan.PaymentStatus;

                if (paymentStatus == Bill.BILL_DA_THANH_TOAN)
                {
                    // Update Status = 1 (Đã thanh toán)
                    this.bill.Status = 1;
                    this.bill.PaymentStatus = paymentStatus;
                    try
                    {
                        BillBUS.Instance.UpdateBillStatus(this.bill);
                        MessageBox.Show(paymentStatus);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi cập nhật trạng thái thanh toán hóa đơn");
                    }
                }
                else
                {
                    MessageBox.Show(paymentStatus);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng lưu hóa đơn");
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (this.selectedProduct != null)
            {
                try
                {
                    int amount = Convert.ToInt32(textbox_SoLuong.TextButton);
                    if (amount <= 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ. Bạn phải chọn tối thiểu 1 sản phẩm!");
                        return;
                    }
                    else
                    {
                        // Cập nhật giao diện
                        this.productsInBill[this.selectedProduct] = amount;

                        var index = this.listProductInBillDetails.FindIndex(x => x.ProductId == this.selectedProduct.Id);
                        if (index > -1)
                        {
                            this.listProductInBillDetails[index].Amount = amount;
                        }

                        this.CapNhatBillInfo();

                        if (this.bill != null && this.bill.Id > 0)
                        {
                            var billInfo = new BillInfo();
                            //billInfo.Id = ...;
                            billInfo.BillID = this.bill.Id;
                            billInfo.ProductID = this.selectedProduct.Id;
                            billInfo.Amount = amount;
                            // Gọi BUS để xóa product khỏi BillInfo
                            BillInfoBUS.Instance.InsertUpdateBillInfo(billInfo);
                        }

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi cập nhật chi tiết hóa đơn");
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (this.selectedProduct != null)
            {
                try
                {
                    if (this.bill != null && this.bill.Id > 0)
                    {
                        // Gọi BUS để xóa product khỏi BillInfo
                        BillInfoBUS.Instance.DeleteBillInfo(this.bill.Id, this.selectedProduct.Id);
                    }

                    // Cập nhật giao diện
                    this.productsInBill.Remove(this.selectedProduct);
                    var index = this.listProductInBillDetails.FindIndex(x => x.ProductId == this.selectedProduct.Id);
                    if (index > -1)
                    {
                        this.listProductInBillDetails.RemoveAt(index);
                    }

                    this.CapNhatBillInfo();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi xóa hóa đơn");
                }
            }
        }

        private void data_DSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Lấy thông tin hàng đang được chọn
                var selectedIndex = data_DSSanPham.SelectedCells[0].RowIndex;
                // Lấy dữ liệu ở hàng selectedIndex
                var productInBillDetail = this.listProductInBillDetails[selectedIndex];

                var product = this.listProducts.FirstOrDefault(x => x.Id == productInBillDetail.ProductId);
                var productAmount = this.productsInBill[product];
                if (product != null)
                {
                    this.selectedProduct = product;
                    // hiện thị lên giao diện
                    this.comboBox_SanPham.Text = this.selectedProduct.Name;
                    this.textBox_DonGia.TextButton = this.selectedProduct.Price.ToString();
                    this.textbox_KhuyenMai.TextButton = this.selectedProduct.Discount.ToString();
                    this.textbox_SoLuong.TextButton = productAmount.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi chọn sản phẩm");
            }
        }

        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            if (this.bill == null || this.bill.Id <= 0)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn");
                return;
            }

            if (this.bill.Status == 0)
            {
                MessageBox.Show("Vui lòng thanh toán trước khi in hóa đơn");
                return;
            }

            fInHoaDon inHoaDon = new fInHoaDon(this.bill);
            inHoaDon.Show();
        }
    }
}
