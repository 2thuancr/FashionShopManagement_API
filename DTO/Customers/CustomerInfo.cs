using Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Customers
{
    public class CustomerInfo
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? DoB { get; set; }

        public string Address { get; set; }

        public string AccountId { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirebaseId { get; set; }
        public string OTP { get; set; }
        public DateTime? OTPExpiration { get; set; }
        public int TypeID { get; set; }

        public CustomerInfo(DataRow row)
        {
            this.CustomerId = Converter.ToInt32(row["customerId"]);
            this.CustomerName = Converter.ToString(row["customerName"]);
            this.PhoneNumber = Converter.ToString(row["phoneNumber"]);
            this.DoB = Converter.ToDateTimeNullable(row["doB"]);
            this.Address = Converter.ToString(row["address"]);
            this.AccountId = Converter.ToString(row["accountId"]);
            this.UserName = Converter.ToString(row["userName"]);
            this.DisplayName = Converter.ToString(row["displayName"]);
            this.Password = Converter.ToString(row["password"]);
            this.Email = Converter.ToString(row["email"]);
            this.FirebaseId = Converter.ToString(row["firebaseId"]);
            this.OTP = Converter.ToString(row["otp"]);
            this.OTPExpiration = Converter.ToDateTimeNullable(row["otpExpiration"]);
            this.TypeID = Converter.ToInt32(row["typeId"]);
        }

        public CustomerInfo()
        {

        }
    }
}
