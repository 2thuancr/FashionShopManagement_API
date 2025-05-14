﻿using BUS;
using DTO.Bills;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class fThanhToan : Form
    {
        public string PaymentStatus = Bill.BILL_CHUA_THANH_TOAN;
        private string bankName = "VietinBank";
        private string bankAccountID = "100874103875";
        private string bankAccountName = "VI QUOC THUAN";
        private Bill bill = new Bill();

        public fThanhToan()
        {
            InitializeComponent();
        }

        public fThanhToan(Bill bill)
        {
            InitializeComponent();
            this.bill = bill;
        }

        private void fThanhToan_Load(object sender, EventArgs e)
        {
            string amount = bill.TotalPrice.ToString();
            string addInfo = $"Thanh toan hoa don {bill.Id}";

            var url = BillBUS.Instance.GetQrPayment("print", bankName, bankAccountID, bankAccountName, addInfo, amount);
            try
            {
                this.picture_QRCode.Load(url);
                this.picture_QRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {

            }
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            this.PaymentStatus = Bill.BILL_DA_THANH_TOAN;
            this.Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
