using Shared.Helpers;
using System;
using System.Data;

namespace DTO.Customers
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DoB { get; set; }

        public string Address { get; set; }

        public string AccountId { get; set; }

        public Customer(int customerId, string customerName, string phoneNumber, DateTime doB,
            string address, string accountId)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.PhoneNumber = phoneNumber;
            this.DoB = doB;
            this.Address = address;
            this.AccountId = accountId;
        }

        public Customer(DataRow row)
        {
            this.CustomerId = Converter.ToInt32(row["customerId"]);
            this.CustomerName = Converter.ToString(row["customerName"]);
            this.PhoneNumber = Converter.ToString(row["phoneNumber"]);
            this.DoB = Converter.ToDateTime(row["doB"]);
            this.Address = Converter.ToString(row["address"]);
            this.AccountId = Converter.ToString(row["accountId"]);
        }

        public Customer()
        {

        }
    }
}
