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

        private void dungeonHeaderLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void aloneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Ho_Click(object sender, EventArgs e)
        {

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
    }
}
