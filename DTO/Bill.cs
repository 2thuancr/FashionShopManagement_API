using System;
using System.Data;

namespace DTO
{
    public class Bill
    {
        public static string BILL_DA_THANH_TOAN = "Đã thanh toán";
        public static string BILL_CHUA_THANH_TOAN = "Chưa thanh toán";

        public int ID { get; set; }
        public DateTime BusinessTime { get; set; }
        public int CustomerId { get; set; }
        public int StaffId { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentStatus { get; set; }
        public int Status { get; set; }

        public Bill(int id, DateTime businessTime, int status, int customerId, int staffId, decimal discount = 0, decimal totalPrice = 0)
        {
            this.ID = id;
            this.BusinessTime = businessTime;
            this.Status = status;
            if (status == 1)
            {
                this.PaymentStatus = Bill.BILL_DA_THANH_TOAN;
            }
            else
            {
                this.PaymentStatus = Bill.BILL_CHUA_THANH_TOAN;
            }
            this.Discount = discount;
            this.TotalPrice = totalPrice;
            this.CustomerId = customerId;
            this.StaffId = staffId;
        }

        public Bill(DataRow row)
        {
            try
            {
                this.ID = Convert.ToInt32(row["id"]);
                this.BusinessTime = (row["businessTime"] != DBNull.Value) ? Convert.ToDateTime(row["businessTime"]) : DateTime.MinValue;
                this.Status = (row["status"] != DBNull.Value) ? Convert.ToInt32(row["status"]) : 0;
                if (this.Status == 1)
                {
                    this.PaymentStatus = Bill.BILL_DA_THANH_TOAN;
                }
                else
                {
                    this.PaymentStatus = Bill.BILL_CHUA_THANH_TOAN;
                }
                this.Discount = (row["discount"] != DBNull.Value) ? Convert.ToDecimal(row["discount"]) : 0;
                this.TotalPrice = (row["totalPrice"] != DBNull.Value) ? Convert.ToDecimal(row["totalPrice"]) : 0;
                this.CustomerId = (row["customerId"] != DBNull.Value) ? Convert.ToInt32(row["customerId"]) : 0;
                this.StaffId = (row["staffId"] != DBNull.Value) ? Convert.ToInt32(row["staffId"]) : 0;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
           
        }
        public Bill()
        {
            
        }
    }
}