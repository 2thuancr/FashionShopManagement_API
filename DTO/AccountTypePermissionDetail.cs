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
        public AccountTypePermissionDetail(int accountTypeId, int permissionId, string accountTypeName, string permissionName)
        {
            AccountTypeId = accountTypeId;
            PermissionId = permissionId;
            AccountTypeName = accountTypeName;
            PermissionName = permissionName;
        }
        public AccountTypePermissionDetail(DataRow row)
        {
            try
            {
                this.AccountTypeId = Convert.ToInt32(row["AccountTypeId"]);
                this.PermissionId = Convert.ToInt32(row["PermissionId"]);
                this.AccountTypeName = Convert.ToString(row["AccountTypeName"]);
                this.PermissionName = Convert.ToString(row["PermissionName"]);
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
    }
}
