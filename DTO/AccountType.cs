using Shared.Helpers;
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
            this.ID = Converter.ToInt32(row["ID"]);
            this.TypeName = Converter.ToString(row["TypeName"]);
        }
    }
}