using Shared.Helpers;
using System;
using System.Data;

namespace DTO.Bills
{
    public class BillInfoDetail
    {
        public int ID { get; set; }
        public DateTime BusinessTime { get; set; }
        //public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentStatus { get; set; }
        public int Status { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public int Amount { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int StaffId { get; set; }
        public string StaffName { get; set; }

        public BillInfoDetail() { }

        public BillInfoDetail(DataRow row)
        {
            this.ID = Converter.ToInt32(row["ID"]);
            this.BusinessTime = Converter.ToDateTime(row["BusinessTime"]);
            //this.Discount = Converter.ToDecimal(row["Discount"]);
            this.TotalPrice = Converter.ToDecimal(row["TotalPrice"]);
            this.Status = Converter.ToInt32(row["Status"]);
            this.ProductId = Converter.ToInt32(row["ProductId"]);
            this.ProductPrice = Converter.ToDecimal(row["ProductPrice"]);
            this.ProductDiscount = Converter.ToDecimal(row["ProductDiscount"]);
            this.ProductName = Converter.ToString(row["ProductName"]);
            this.Amount = Converter.ToInt32(row["Amount"]);
            this.CustomerId = Converter.ToInt32(row["CustomerId"]);
            this.CustomerName = Converter.ToString(row["CustomerName"]);
            this.StaffId = Converter.ToInt32(row["StaffId"]);
            this.StaffName = Converter.ToString(row["StaffName"]);
            if (this.Status == 1)
            {
                this.PaymentStatus = Bill.BILL_DA_THANH_TOAN;
            }
            else
            {
                this.PaymentStatus = Bill.BILL_CHUA_THANH_TOAN;
            }
        }
    }
}