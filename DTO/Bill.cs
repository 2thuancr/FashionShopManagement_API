using System;
using System.Data;

namespace DTO
{
    public class Bill
    {
        public int ID { get; set; }
        public DateTime BusinessTime { get; set; }
        public int Status { get; set; }
        public int Discount { get; set; }


        public Bill(int id, DateTime businessTime, int status, int discount = 0)
        {
            this.ID = id;
            this.BusinessTime = businessTime;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            try
            {
                this.ID = Convert.ToInt32(row["id"]);
                this.BusinessTime = Convert.ToDateTime(row["businessTime"]);
                this.Status = Convert.ToInt32(row["status"]);
                this.Discount = Convert.ToInt32(row["discount"]);
            }
            catch
            {

            }
        }
    }
}