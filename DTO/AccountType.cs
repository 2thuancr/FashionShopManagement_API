using System;
using System.Data;

namespace DTO
{
    public class AccountType
    {
        public int ID { get; set; }
        public string TypeName { get; set; }

        public AccountType() { }

        public AccountType(int id, string typeName)
        {
            this.ID = id;
            this.TypeName = typeName;
        }

        public AccountType(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"]);
            this.TypeName = Convert.ToString(row["TypeName"]);
        }
    }
}