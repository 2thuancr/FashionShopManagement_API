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
                this.BusinessTime = Convert.ToDateTime(row["businessTime"]);
                this.Status = Convert.ToInt32(row["status"]);
                if (this.Status == 1)
                {
                    this.PaymentStatus = Bill.BILL_DA_THANH_TOAN;
                }
                else
                {
                    this.PaymentStatus = Bill.BILL_CHUA_THANH_TOAN;
                }
                this.Discount = Convert.ToDecimal(row["discount"]);
                this.TotalPrice = Convert.ToDecimal(row["totalPrice"]);
                this.CustomerId = Convert.ToInt32(row["customerId"]);
                this.StaffId = Convert.ToInt32(row["StaffId"]);
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