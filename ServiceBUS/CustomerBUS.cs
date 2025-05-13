using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using DAO;
using DTO.Customers;

namespace BUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance;

        public static CustomerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerBUS();
                return CustomerBUS.instance;
            }
        }

        private CustomerBUS() { }

        public List<Customer> GetAllCustomer() 
        {
            DataTable table;
            try
            {
                table = CustomerDAO.Instance.GetAllCustomer();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            List<Customer> listCustomer = new List<Customer>();
            foreach (DataRow row in table.Rows) 
            {
                Customer customer = new Customer(row);
                listCustomer.Add(customer);
            }
            return listCustomer;
        }

        /// <summary>
        /// Lấy danh sách khách hàng từ số điện thoại
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomerByPhone(string phoneNumber)
        {
            DataTable table;
            try
            {
                table = CustomerDAO.Instance.GetCustomerByPhone(phoneNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<Customer> listCustomer = new List<Customer>();
            foreach (DataRow row in table.Rows)
            {
                Customer customer = new Customer(row);
                listCustomer.Add(customer);
            }
            return listCustomer;
        }

        public CustomerInfo GetCustomerInfo(GetCustomerInfoInput input)
        {
            DataTable table;
            try
            {
                table = CustomerDAO.Instance.GetCustomerInfo(input.Email ?? input.UserName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (table != null && table.Rows.Count > 0)
            {
                return new CustomerInfo(table.Rows[0]);
            }
            return null;
        }

        public Customer GetCustomerById(int customerId)
        {
            DataTable table;
            try
            {
                table = CustomerDAO.Instance.GetCustomerById(customerId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Customer customer = new Customer();
            if (table != null && table.Rows.Count > 0)
            {
                customer = new Customer(table.Rows[0]);
            }
            return customer;
        }

        public bool InsertCustomer(Customer newCustomer)
        {
            return CustomerDAO.Instance.InsertCustomer(newCustomer);
        }
    }
}
