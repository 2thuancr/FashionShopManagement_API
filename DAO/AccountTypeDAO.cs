using System.Data;

namespace DAO
{
    public class AccountTypeDAO
    {
        private static AccountTypeDAO instance;

        public static AccountTypeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountTypeDAO();
                return AccountTypeDAO.instance;
            }
        }

        public AccountTypeDAO() { }

        public DataTable GetAllAccountType()
        {
            return DataProvider.Instance.ExecuteQuery("select * from AccountType");
        }
    }
}