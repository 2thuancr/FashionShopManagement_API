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
    public partial class fChiTietHoaDon : Form
    {
        private Bill bill = new Bill(); 
        public fChiTietHoaDon()
        {
            InitializeComponent();
        }
        public fChiTietHoaDon(Bill bill)
        {
            InitializeComponent();
            this.bill = bill;
            this.ShowBill();
        }
        private void ShowBill()
        {
           //this.textBox_NhanVien.TextButton = this.
            this.textBox_MaHoaDon.TextButton = this.bill.ID.ToString();
            this.textBox_TongTien.TextButton = this.bill.TotalPrice.ToString();
            this.textBox_GiamGia.TextButton = this.bill.Discount.ToString();
            this.textBox_ThanhTien.TextButton = (this.bill.TotalPrice -  this.bill.Discount).ToString();
        }
    }
}
