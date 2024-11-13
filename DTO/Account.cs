using System;
using System.Data;

namespace DTO
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public int TypeID { get; set; }

        public Account(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public Account(int id, string userName, string displayName, int typeID, string password = null)
        {
            this.Id = id;
            this.UserName = userName;
            this.DisplayName = displayName;
            this.TypeID = typeID;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.UserName = Convert.ToString(row["UserName"]);
            this.DisplayName = Convert.ToString(row["DisplayName"]);
            this.TypeID = Convert.ToInt32(row["TypeID"]);
            this.Password = Convert.ToString(row["Password"]);
        }
        public static string ConnectionString { get; set; }

        // Kết nối tới DB
        //public static string connectionStringAdmin = @"Data Source=.;Initial Catalog=FashionShopManagement;Integrated Security=True";
        public static string connectionStringStaff = "Server=2THUANCR;Database=FashionShopManagement;User Id=staff;Password=DB_staff;";
        public static string connectionStringManager = "Server=2THUANCR;Database=FashionShopManagement;User Id=manager;Password=DB_manager;";

    }
}