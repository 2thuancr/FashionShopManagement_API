using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("USP_GetAllCustomer", new object[] { } );
                return table;
            }
            catch( Exception ex) 
            {    
                throw ex;
            }
        }
        public DataTable GetCustomerById(int customerId)
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("USP_GetCustomerById @CustomerId", new object[] { customerId });
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCustomerByPhone(string phoneNumber)
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("USP_GetCustomerByPhone @PhoneNumber", new object[] { phoneNumber });
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertCustomer(Customer newCustomer)
        {

            string query = $@"USP_InsertCustomer 
                @CustomerName = '{newCustomer.CustomerName}',
                @DoB = '{newCustomer.DoB}', 
                @Address = '{newCustomer.Address}', 
                @PhoneNumber = '{newCustomer.PhoneNumber}'";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }








    }
}
