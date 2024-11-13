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
    public partial class fSanPham : Form
    {
        private List<Product> listProducts = new List<Product>();

        public fSanPham()
        {
            InitializeComponent();
        }

        private void fSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                // Gọi qua Product BUS để thực hiện tìm kiếm
                this.listProducts = ProductBUS.Instance.GetAllProduct();
                if (this.listProducts.Count > 0)
                {
                    this.data_DSDonHang.DataSource = this.listProducts;                    
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi hiển thị danh sách đơn hàng!");
            }
        }

        private void data_DSDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin hàng đang được chọn
            var selectedIndex = data_DSDonHang.SelectedCells[0].RowIndex;
            // Lấy dữ liệu ở hàng selectedIndex
            Product product = this.listProducts[selectedIndex];

            fChiTietSanPham fChiTietSanPham = new fChiTietSanPham(product);
            fChiTietSanPham.ShowDialog();
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            fThemSanPham fThemSanPham = new fThemSanPham();
            fThemSanPham.ShowDialog();

            // Load lại form
            this.fSanPham_Load(null, null);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ textBox_TimKiem.TextButton
            string text = textBox_TimKiem.TextButton;

            try
            {
                // Gọi qua Product BUS để thực hiện tìm kiếm
                this.listProducts = ProductBUS.Instance.SearchProductByName(text);
                if (this.listProducts.Count > 0)
                {
                    this.data_DSDonHang.DataSource = this.listProducts;
                    foreach (Product product in this.listProducts)
                    {
                        Console.WriteLine(product.Name);
                    }
                    MessageBox.Show($"Đã tìm thấy {this.listProducts.Count} sản phẩm");
                }
            }
            catch (Exception ) 
            {
                MessageBox.Show("Lỗi tìm kiếm sản phẩm!");
            }
        }
    }
}
