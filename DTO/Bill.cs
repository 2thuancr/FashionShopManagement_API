using System;
using System.Data;

namespace DTO
{
    public class Bill
    {
        public int ID { get; set; }
        public DateTime BusinessTime { get; set; }
        public string Status { get; set; }

        public int CustomerId { get; set; }
        public int Discount { get; set; }

        public int TotalPrice { get; set; }

        public Bill(int id, DateTime businessTime, int status, int customerId, int discount = 0, int totalPrice = 0)
        {
            this.ID = id;
            this.BusinessTime = businessTime;
            //this.Status = status;
            if (status == 1)
            {
                this.Status = "Đã thanh toán";
            }
            else
            {
                this.Status = "Chưa thanh toán";
            }
            this.Discount = discount;
            this.TotalPrice = totalPrice;
            this.CustomerId = customerId;
        }

        public Bill(DataRow row)
        {
            try
            {
                this.ID = Convert.ToInt32(row["id"]);
                this.BusinessTime = Convert.ToDateTime(row["businessTime"]);
                var status = Convert.ToInt32(row["status"]);
                if (status == 1)
                {
                    this.Status = "Đã thanh toán";
                }
                else
                {
                    this.Status = "Chưa thanh toán";
                }
                this.Discount = Convert.ToInt32(row["discount"]);
                this.TotalPrice = Convert.ToInt32(row["totalPrice"]);
                this.CustomerId = Convert.ToInt32(row["customerId"]);
            }
            catch(Exception ex) 
            {
                
            }
           
        }
        public Bill()
        {

        }
    }
}