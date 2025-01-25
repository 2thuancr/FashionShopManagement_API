using Shared.Helpers;
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
        public decimal TotalPrice { get; set; }
        public string PaymentStatus { get; set; }
        public int Status { get; set; }

        public Bill(int id, DateTime businessTime, int status, int customerId, int staffId, decimal totalPrice = 0)
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
            this.TotalPrice = totalPrice;
            this.CustomerId = customerId;
            this.StaffId = staffId;
        }

        public Bill(DataRow row)
        {
            this.ID = Converter.ToInt32(row["id"]);
            this.BusinessTime = Converter.ToDateTime(row["businessTime"]);
            this.Status = Converter.ToInt32(row["status"]);
            if (this.Status == 1)
            {
                this.PaymentStatus = Bill.BILL_DA_THANH_TOAN;
            }
            else
            {
                this.PaymentStatus = Bill.BILL_CHUA_THANH_TOAN;
            }
            this.TotalPrice = Converter.ToDecimal(row["totalPrice"]);
            this.CustomerId = Converter.ToInt32(row["customerId"]);
            this.StaffId = Converter.ToInt32(row["staffId"]);
        }

        public Bill()
        {

        }
    }
}