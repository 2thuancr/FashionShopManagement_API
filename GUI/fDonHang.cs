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
    public partial class fDonHang : Form
    {
        private List<Bill> listBills = new List<Bill> ();
        public fDonHang()
        {
            InitializeComponent();
        }

        private void fDonHang_Load(object sender, EventArgs e)
        {
            try
            {
                this.listBills = BillBUS.Instance.GetAllBills();
                if(this.listBills.Count > 0 )
                {
                    this.data_DSDonHang.DataSource = this.listBills;
                }
            }
            catch 
            {
                MessageBox.Show("Lỗi");
            }
            
        }

        private void btn_TaoDon_Click(object sender, EventArgs e)
        {
            fTaoDonHang fTaoDonHang = new fTaoDonHang();
            fTaoDonHang.ShowDialog();
        }

        private void data_DSDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin row được chọn
            //var selectedRow = (sender as DataGridViewRow).Selected;

            fChiTietHoaDon fChiTietHoaDon = new fChiTietHoaDon();
            fChiTietHoaDon.ShowDialog();
        }

        private void data_DSDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin row được chọn
            //var selectedRow = (sender as DataGridViewRow).Selected;

            fChiTietHoaDon fChiTietHoaDon = new fChiTietHoaDon();
            fChiTietHoaDon.ShowDialog();
        }
    }
}
