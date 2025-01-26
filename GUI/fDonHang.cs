using BUS;
using DTO.Bills;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class fDonHang : Form
    {
        private List<Bill> listBills = new List<Bill>();
        public fDonHang()
        {
            InitializeComponent();
        }

        private void fDonHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachDonHang();

        }

        private void LoadDanhSachDonHang()
        {
            try
            {
                this.listBills = BillBUS.Instance.GetAllBills();
                if (this.listBills.Count > 0)
                {
                    this.data_DSDonHang.DataSource = this.listBills;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi lấy danh sách đơn hàng");
            }
        }

        private void data_DSDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy id được click
            var selectedIndex = data_DSDonHang.SelectedCells[0].RowIndex;
            // GetBillById
            Bill bill = this.listBills[selectedIndex];
            // Hiển thị form
            fChiTietHoaDon fChiTietHoaDon = new fChiTietHoaDon(bill);
            fChiTietHoaDon.ShowDialog();

            LoadDanhSachDonHang();
        }
    }
}
