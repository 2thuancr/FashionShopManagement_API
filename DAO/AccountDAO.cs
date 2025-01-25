using System;
using System.Data;
using System.Collections.Generic;

using DTO;
using DTO.Accounts;
using System.Data.SqlClient;
using System.Security.Principal;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
        }

        public DataTable RegisterCustomerAccount(AccountCustomerRegisterRequest request)
        {
            var isUserNameExists = this.IsUserNameExists(request.UserName);
            if (isUserNameExists)
            {
                throw new Exception("Username is already exists");
            }

            //string query = $@"USP_RegisterCustomerAccount 
            //    FullName = @FullName , 
            //    PhoneNumber = @PhoneNumber , 
            //    Email = @Email , 
            //    FirebaseId = @FirebaseId , 
            //    DoB = @DoB , 
            //    Address = @Address , 
            //    UserName = @UserName , 
            //    Password = @Password";

            var query = "USP_RegisterCustomerAccount ";
            query += "@FullName = " + (string.IsNullOrWhiteSpace(request.FullName) ? "NULL, " : $"N'{request.FullName}', ");
            query += "@PhoneNumber = " + (string.IsNullOrWhiteSpace(request.PhoneNumber) ? "NULL, " : $"N'{request.PhoneNumber}', ");
            query += "@Email = " + (string.IsNullOrWhiteSpace(request.Email) ? "NULL, " : $"N'{request.Email}', ");
            query += "@FirebaseId = " + (string.IsNullOrWhiteSpace(request.FirebaseId) ? "NULL, " : $"N'{request.FirebaseId}', ");
            query += "@DoB = " + (request.DoB == null ? "NULL, " : $"'{request.DoB:yyyy-MM-dd}', ");
            query += "@Address = " + (string.IsNullOrWhiteSpace(request.Address) ? "NULL, " : $"N'{request.Address}', ");
            query += "@UserName = " + (string.IsNullOrWhiteSpace(request.UserName) ? "NULL, " : $"N'{request.UserName}', ");
            query += "@Password = " + (string.IsNullOrWhiteSpace(request.Password) ? "NULL" : $"N'{request.Password}'");

            DataTable result = new DataTable();
            try
            {
                return result = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Login(Account account)
        {
            string query = "USP_Login @UserName , @Password";
            DataTable result = new DataTable();
            try
            {
                return result = DataProvider.Instance.ExecuteQuery(query, new object[] { account.UserName, account.Password });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CheckLogin(Account account)
        {
            string query = "USP_Login @UserName , @Password";
            DataTable result = new DataTable();
            try
            {
                result = DataProvider.Instance.ExecuteQuery(query, new object[] { account.UserName, account.Password});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result.Rows.Count > 0;
        }

        public DataTable UpdateOTPByUsername(string username, string otp)
        {
            var isUserNameExists = this.IsUserNameExists(username);
            if (!isUserNameExists)
            {
                throw new Exception("Username not found");
            }

            string query = $"USP_UpdateOTPByUsername @UserName = '{username}', @NewOTP = '{otp}' ";
            try
            {
                DataTable table = DataProvider.Instance.ExecuteQuery(query);

                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable VerifyOtpByUsername(AccountVerifyOtpByUserNameRequest input)
        {
            var isUserNameExists = this.IsUserNameExists(input.UserName);
            if (!isUserNameExists)
            {
                throw new Exception("Username not found");
            }
            string query = $"USP_VerifyOTP @UserName = '{input.UserName}', @OTP = '{input.Otp}' ";
            try
            {
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAllAcount()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Select * from [dbo].[ViewAllAccounts]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAccountByUserName(string userName)
        {
            string query = "USP_GetAccountByUserName @UserName";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(string userName, string displayName, int typeID)
        {
            string query = string.Format("USP_InsertAccount @UserName , @DisplayName , @TypeID");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { userName, displayName, typeID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("USP_ResetPassword @UserName");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool Delete(string userName)
        {
            string query = string.Format("USP_DeleteAccount @UserName");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdateInformation(string userName, string displayName, string password, string newPass)
        {
            string query = "USP_UpdateAccount @UserName , @DisplayName , @Password , @NewPass";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { userName, displayName, password, newPass });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool IsUserNameExists(string username)
        {
            try
            {
                //var query = $"SELECT dbo.IsUserNameExists('{username}')";
                //var result = (int)DataProvider.Instance.ExecuteScalar(query);
                //return result > 0;

                var result = this.SearchAccountByUserName(username);
                return result.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchAccountByUserName(string userName)
        {

            string query = string.Format("USP_SearchAccountByUserName @UserName");

            DataTable table = new DataTable();
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}