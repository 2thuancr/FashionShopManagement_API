using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountTypePermissionDAO
    {
        private static AccountTypePermissionDAO instance;

        public static AccountTypePermissionDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountTypePermissionDAO();
                return AccountTypePermissionDAO.instance;
            }
        }
        public DataTable GetPermissionByAccountTypeId(int accountTypeId)
        {
            string query = $"USP_GetPermissionByAccountTypeId @AccountTypeId = {accountTypeId}";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
