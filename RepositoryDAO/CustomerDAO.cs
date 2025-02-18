using DTO.Customers;
using System.Data;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return CustomerDAO.instance;
            }
        }

        private CustomerDAO() { }

        public DataTable GetAllCustomer()
        {
            var query = "SELECT * FROM [dbo].[ViewAllCustomers]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetCustomerById(int customerId)
        {
            var query = "USP_GetCustomerById @CustomerId";
            var parameters = new object[] { customerId };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable GetCustomerByPhone(string phoneNumber)
        {
            var query = $"SELECT * FROM SearchCustomers('{phoneNumber}')";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertCustomer(Customer newCustomer)
        {

            string query = $@"USP_InsertCustomer 
                @CustomerName = '{newCustomer.CustomerName}',
                @DoB = '{newCustomer.DoB}', 
                @Address = '{newCustomer.Address}', 
                @PhoneNumber = '{newCustomer.PhoneNumber}'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
