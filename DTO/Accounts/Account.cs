using Shared.Helpers;
using System;
using System.Data;

namespace DTO.Accounts
{
    public class Account
    {
        public static string ConnectionName { get; set; }
        public const string connectionNameUser = "Connection: role_user";
        public const string connectionNameManager = "Connection: role_manager";
        public const string connectionNameStaff = "Connection: role_staff";

        // Kết nối tới DB
        public static string ConnectionString { get; set; }

        public static string connectionStringUser = @"Server=tcp:tiennhmit.database.windows.net,1433;Initial Catalog=FashionShop;Persist Security Info=False;User ID=tiennhmit;Password=m1nht13n@HCMUTE;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static string connectionStringAdmin = @"Server=tcp:tiennhmit.database.windows.net,1433;Initial Catalog=FashionShop;Persist Security Info=False;User ID=tiennhmit;Password=m1nht13n@HCMUTE;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public const string connectionStringStaff = @"Server=tcp:tiennhmit.database.windows.net,1433;Initial Catalog=FashionShop;Persist Security Info=False;User ID=tiennhmit;Password=m1nht13n@HCMUTE;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public const string connectionStringManager = @"Server=tcp:tiennhmit.database.windows.net,1433;Initial Catalog=FashionShop;Persist Security Info=False;User ID=tiennhmit;Password=m1nht13n@HCMUTE;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //public static string connectionStringAdmin = @"Data Source=.;Initial Catalog=FashionShopManagement;Integrated Security=True";
        //public const string connectionStringStaff = "Server=2THUANCR;Database=FashionShopManagement;User Id=staff;Password=DB_staff;";
        //public const string connectionStringManager = "Server=2THUANCR;Database=FashionShopManagement;User Id=manager;Password=DB_manager;";


        public int Id { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FirebaseId { get; set; }
        public string OTP { get; set; }
        public DateTime? OTPExpiration { get; set; }
        public int TypeID { get; set; }

        public Account()
        {
        }

        public Account(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public Account(int id, string userName, string displayName, int typeID,
            string password, string phoneNumber, string email, string firebaseId)
        {
            this.Id = id;
            this.UserName = userName;
            this.DisplayName = displayName;
            this.TypeID = typeID;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.FirebaseId = firebaseId;
        }

        public Account(DataRow row)
        {
            this.Id = Converter.ToInt32(row["Id"]);
            this.UserName = Converter.ToString(row["UserName"]);
            this.DisplayName = Converter.ToString(row["DisplayName"]);
            this.TypeID = Converter.ToInt32(row["TypeID"]);
            this.Password = Converter.ToString(row["Password"]);
            this.PhoneNumber = Converter.ToString(row["PhoneNumber"]);
            this.Email = Converter.ToString(row["Email"]);
            this.FirebaseId = Converter.ToString(row["FirebaseId"]);
            this.OTP = Converter.ToString(row["OTP"]);
            this.OTPExpiration = Converter.ToDateTimeNullable(row["OTPExpiration"]);
        }
    }
}