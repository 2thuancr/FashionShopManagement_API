using System;
using System.Data;

namespace DTO
{
    public class BillInfo
    {
        public int ID { get; set; }
        public int BillID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }

        public BillInfo() { }

        public BillInfo(int id, int billID, int productID, int amount)
        {
            this.ID = id;
            this.BillID = billID;
            this.ProductID = productID;
            this.Amount = amount;
        }

        public BillInfo(DataRow row)
        {
            try 
            {
                this.ID = Convert.ToInt32(row["Id"]);
                this.BillID = Convert.ToInt32(row["billID"]);
                this.ProductID = Convert.ToInt32(row["productID"]);
                this.Amount = Convert.ToInt32(row["amount"]);
            }
            catch
            {

            }
           
        }
    }
}