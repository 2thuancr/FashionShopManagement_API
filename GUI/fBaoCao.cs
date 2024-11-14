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
    public partial class fBaoCao : Form
    {
        private List<BillInfoDetail> billInfoDetails = new List<BillInfoDetail>();
        public fBaoCao()
        {
            InitializeComponent();
        }

        private void fBaoCao_Load(object sender, EventArgs e)
        {
            this.LoadSoDonHang();
            this.LoadTongDoanhThu();
            this.LoadDSDonHang();
        }

        private void LoadSoDonHang()
        {
            try
            {
                int year = this.date_Thang.Value.Year;
                int month = this.date_Thang.Value.Month;

                var result = ReportBUS.Instance.CountBillsInMonth(year, month);
                this.label_SoLuongDon.Text = result.ToString();

            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi đếm số lượng đơn hàng theo tháng");            
            }
        }

        private void LoadTongDoanhThu() 
        {
            try
            {
                int year = this.date_Thang.Value.Year;
                int month = this.date_Thang.Value.Month;

                var result = ReportBUS.Instance.TotalRevenueByMonth(year, month);
                this.label_TongDoanhThu.Text = result.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi tính tổng doanh thu theo tháng");
            }
        }

        private void LoadDSDonHang()
        {
            try
            {
                int year = this.date_Thang.Value.Year;
                int month = this.date_Thang.Value.Month;

                this.billInfoDetails = BillInfoBUS.Instance.GetBillInfoDetailByMonth(year, month);
                this.data_DonHang.DataSource = null;
                this.data_DonHang.DataSource = this.billInfoDetails;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi lấy danh sách đơn hàng theo tháng");
            }
        }

        private void date_Thang_ValueChanged(object sender, EventArgs e)
        {
            this.LoadSoDonHang();
            this.LoadTongDoanhThu();
            this.LoadDSDonHang();
        }
    }
}
