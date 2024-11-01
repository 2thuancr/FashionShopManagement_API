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
    public partial class fChiTietSanPham : Form
    {
        private Product product = new Product();

        public fChiTietSanPham()
        {
            InitializeComponent();
        }

        public fChiTietSanPham(Product product)
        {
            InitializeComponent();
            this.product = product;
            this.ShowProduct();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowProduct()
        {
            this.picture_SanPham.Load(this.product.Image);
            this.picture_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            this.label_TenSanPham.Text = this.product.Name;
            this.label_LoaiSanPham.Text = this.product.Category;
            this.label_GiaSanPham.Text = this.product.Price.ToString();
            this.label_SoLuong.Text = this.product.Quantity.ToString();
            this.label_KichCo.Text = this.product.Size;
        }
    }
}
