using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DTO
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string PhoneNumber { get; set; }
        public DateTime DoB { get; set; }
        public string Address { get; set; }


        public Customer(int customerId, string customerName, string phoneNumber, 
                        DateTime doB, string address)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.PhoneNumber = phoneNumber;
            this.DoB = doB;
            this.Address = address;
        }
        public Customer(DataRow row)
        {
            try
            {
                this.CustomerId = Convert.ToInt32(row["customerId"]);
                this.CustomerName = Convert.ToString(row["customerName"]);
                this.PhoneNumber = Convert.ToString(row["phoneNumber"]);
                this.DoB = Convert.ToDateTime(row["doB"]);
                this.Address = Convert.ToString(row["address"]);
            }
            catch
            {

            }
        }
        public Customer()
        {

        }
    }
}
