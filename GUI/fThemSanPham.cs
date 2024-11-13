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
    public partial class fThemSanPham : Form
    {
        public fThemSanPham()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                product.Image = "https://product.hstatic.net/1000284478/product/z4429178934158_aada2cc3203de7d297a76f3507509257_c84bff2d4ef14a9bb9a6a0ae4cfd446e.jpg";

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
            catch(Exception)
            {
                MessageBox.Show("Bạn không có quyền này!");
            }
           
        }
    }
}
