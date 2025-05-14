using Shared.Helpers;
using System;
using System.Data;

namespace DTO.Bills
{
    public class Bill
    {
        public static string BILL_DA_THANH_TOAN = "Đã thanh toán";
        public static string BILL_CHUA_THANH_TOAN = "Chưa thanh toán";

        public int Id { get; set; }
        public DateTime BusinessTime { get; set; }
        public int CustomerId { get; set; }
        public int StaffId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public string DeliveryAddress { get; set; }
        public string PaymentMethod { get; set; } = "COD";
        public string PaymentStatus { get; set; }

        /// <summary>
        /// 0: Pending, 1: Processing, 2: Shipped, 3: Delivered, 4: Cancelled
        /// </summary>
        public int Status { get; set; }

        public Bill(DataRow row)
        {
            this.Id = Converter.ToInt32(row["id"]);
            this.BusinessTime = Converter.ToDateTime(row["businessTime"]);
            this.Status = Converter.ToInt32(row["status"]);
            if (this.Status != 0)
            {
                this.PaymentStatus = Bill.BILL_DA_THANH_TOAN;
            }
            else
            {
                this.PaymentStatus = Bill.BILL_CHUA_THANH_TOAN;
            }
            this.TotalPrice = Converter.ToDecimal(row["totalPrice"]);
            this.TotalDiscount = Converter.ToDecimal(row["discount"]);
            this.CustomerId = Converter.ToInt32(row["customerId"]);
            this.StaffId = Converter.ToInt32(row["staffId"]);
            this.DeliveryAddress = Converter.ToString(row["deliveryAddress"]);
            this.PaymentMethod = Converter.ToString(row["paymentMethod"]);
        }

        public Bill()
        {

        }
    }
}