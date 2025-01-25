using Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountTypePermissionDetail
    {
        public int AccountTypeId { get; set; }
        public int PermissionId { get; set; }
        public string AccountTypeName { get; set; }
        public string PermissionName { get; set; }

        public AccountTypePermissionDetail()
        {

        }

        public AccountTypePermissionDetail(int accountTypeId, int permissionId, 
            string accountTypeName, string permissionName)
        {
            AccountTypeId = accountTypeId;
            PermissionId = permissionId;
            AccountTypeName = accountTypeName;
            PermissionName = permissionName;
        }

        public AccountTypePermissionDetail(DataRow row)
        {
            this.AccountTypeId = Converter.ToInt32(row["AccountTypeId"]);
            this.PermissionId = Converter.ToInt32(row["PermissionId"]);
            this.AccountTypeName = Converter.ToString(row["AccountTypeName"]);
            this.PermissionName = Converter.ToString(row["PermissionName"]);
        }
    }
}
