using System;
using System.Data;

namespace DTO
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
           
                this.ID = Convert.ToInt32(row["ID"]);
                this.BusinessTime = (row["BusinessTime"] != DBNull.Value) ? Convert.ToDateTime(row["BusinessTime"]) : DateTime.MinValue;
                //this.Discount = (row["Discount"] != DBNull.Value) ? Convert.ToDecimal(row["Discount"]) : 0;
                this.TotalPrice = (row["TotalPrice"] != DBNull.Value) ? Convert.ToDecimal(row["TotalPrice"]) : 0;
                this.Status = (row["Status"] != DBNull.Value) ? Convert.ToInt32(row["Status"]) : 0;
                this.ProductId = (row["ProductId"] != DBNull.Value) ? Convert.ToInt32(row["ProductId"]) : 0;
                this.ProductPrice = (row["ProductPrice"] != DBNull.Value) ? Convert.ToDecimal(row["ProductPrice"]) : 0;
                this.ProductDiscount = (row["ProductDiscount"] != DBNull.Value) ? Convert.ToDecimal(row["ProductDiscount"]) : 0;
                this.ProductName = (row["ProductName"] != DBNull.Value) ? Convert.ToString(row["ProductName"]) : null;
                this.Amount = (row["Amount"] != DBNull.Value) ? Convert.ToInt32(row["Amount"]) : 0;
                this.CustomerId = (row["CustomerId"] != DBNull.Value) ? Convert.ToInt32(row["CustomerId"]) : 0;
                this.CustomerName = (row["CustomerName"] != DBNull.Value) ? Convert.ToString(row["CustomerName"]) : null;
                this.StaffId = (row["StaffId"] != DBNull.Value) ? Convert.ToInt32(row["StaffId"]) : 0;
                this.StaffName = (row["StaffName"] != DBNull.Value) ? Convert.ToString(row["StaffName"]) : null;
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