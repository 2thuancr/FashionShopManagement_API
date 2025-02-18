using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DAO;
using DTO.Accounts;

namespace BUS
{
    public class AccountTypeBUS
    {
        private static AccountTypeBUS instance;

        public static AccountTypeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountTypeBUS();
                return AccountTypeBUS.instance;
            }
        }

        public AccountTypeBUS() { }

        public List<AccountType> GetAllAccountType()
        {
            DataTable table = new DataTable();
            try
            {
                table =  AccountTypeDAO.Instance.GetAllAccountType();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<AccountType> accountTypes = new List<AccountType>();
            foreach (DataRow row in table.Rows)
            {
                accountTypes.Add(new AccountType(row));
            }
            return accountTypes;
        }

        public AccountType GetAccountTypeById(int accountTypeId)
        {
            List<AccountType> listAccountTypes = GetAllAccountType();

            var accountType = listAccountTypes.FirstOrDefault(x => x.ID == accountTypeId);
            return accountType;
        }
    }
}