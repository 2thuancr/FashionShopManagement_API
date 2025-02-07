using BUS;
using DTO.Products;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class fThemSanPham : Form
    {
        private const string DEFAULT_PRODUCT_IMAGE = "https://product.hstatic.net/1000284478/product/z4429178934158_aada2cc3203de7d297a76f3507509257_c84bff2d4ef14a9bb9a6a0ae4cfd446e.jpg";
        public fThemSanPham()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Name = textBox_TenSanPham.TextButton;
                try
                {
                    product.Price = Convert.ToDecimal(textBox_GiaSanPham.TextButton);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai kiểu dữ liệu! Vui lòng nhập lại.");
                    return;
                }
                product.Category = textBox_LoaiSanPham.TextButton;
                try
                {
                    product.Quantity = Convert.ToInt32(textbox_SoLuong.TextButton);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai kiểu dữ liệu! Vui lòng nhập lại.");
                    return;
                }
                product.Size = textbox_KichCo.TextButton;
                product.Description = textBox_ChiTietSanPham.TextButton;
                product.Image = DEFAULT_PRODUCT_IMAGE;

                var result = ProductBUS.Instance.InsertProduct(product);
                if (result == true)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không có quyền này!");
            }
        }
    }
}
