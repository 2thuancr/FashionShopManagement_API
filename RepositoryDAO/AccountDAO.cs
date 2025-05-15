using DTO.Accounts;
using System;
using System.Data;

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
            //    Email = @Email , 
            //    Password = @Password";

            var query = "USP_RegisterCustomerAccount ";
            query += "@FullName = " + (string.IsNullOrWhiteSpace(request.FullName) ? "NULL, " : $"N'{request.FullName}', ");
            query += "@PhoneNumber = " + (string.IsNullOrWhiteSpace(request.PhoneNumber) ? "NULL, " : $"N'{request.PhoneNumber}', ");
            query += "@Email = " + (string.IsNullOrWhiteSpace(request.Email) ? "NULL, " : $"N'{request.Email}', ");
            query += "@FirebaseId = " + (string.IsNullOrWhiteSpace(request.FirebaseId) ? "NULL, " : $"N'{request.FirebaseId}', ");
            query += "@DoB = " + (request.DoB == null ? "NULL, " : $"'{request.DoB:yyyy-MM-dd}', ");
            query += "@Address = " + (string.IsNullOrWhiteSpace(request.Address) ? "NULL, " : $"N'{request.Address}', ");
            //query += "@Email = " + (string.IsNullOrWhiteSpace(request.Email) ? "NULL, " : $"N'{request.Email}', ");
            query += "@UserName = " + ($"N'{request.Email ?? request.UserName}', ");
            query += "@Password = " + (string.IsNullOrWhiteSpace(request.Password) ? "NULL" : $"N'{request.Password}'");

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable Login(Account account)
        {
            string query = "USP_Login @Email , @Password";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { account.UserName, account.Password });
        }

        public bool CheckLogin(Account account)
        {
            string query = "USP_Login @Email , @Password";
            var parameter = new object[]
            {
                account.UserName,
                account.Password
            };

            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameter);
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

            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return table;
        }

        public DataTable VerifyOtpByUsername(AccountVerifyOtpByUserNameRequest input)
        {
            var isUserNameExists = this.IsUserNameExists(input.UserName);
            if (!isUserNameExists)
            {
                throw new Exception("Username not found");
            }
            string query = $"USP_VerifyOTP @UserName = '{input.UserName}', @OTP = '{input.Otp}' ";

            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return table;
        }

        public DataTable GetAllAcount()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from [dbo].[ViewAllAccounts]");
        }

        public DataTable GetAccountByUserName(string userName)
        {
            string query = "USP_GetAccountByUserName @Email";
            var parameter = new object[] { userName };

            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

        public bool Insert(string userName, string displayName, int typeID)
        {
            string query = string.Format("USP_InsertAccount @Email , @DisplayName , @TypeID");
            var parameter = new object[] { userName, displayName, typeID };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("USP_ResetPassword @Email");
            var parameter = new object[] { userName };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result > 0;
        }
        public bool UpdatePassword (string email, string password)
        {
            string query = $@"UPDATE Account
                            SET Password = '{password}'
                            WHERE Email = '{email}'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

            //string query = string.Format("USP_UpdatePassword @Email , @NewPassword");

            //var parameter = new object[] { email, password };

            //int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            //return result > 0;
        }

        public bool Delete(string userName)
        {
            string query = string.Format("USP_DeleteAccount @Email");
            var parameter = new object[] { userName };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public bool UpdateInformation(string userName, string displayName, string password, string newPass)
        {
            string query = "USP_UpdateAccount @Email , @DisplayName , @Password , @NewPass";
            var parameter = new object[] { userName, displayName, password, newPass };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public bool IsUserNameExists(string username)
        {
            //var query = $"SELECT dbo.IsUserNameExists('{username}')";
            //var result = (int)DataProvider.Instance.ExecuteScalar(query);
            //return result > 0;

            var result = this.SearchAccountByUserName(username);
            return result.Rows.Count > 0;
        }

        public DataTable SearchAccountByUserName(string userName)
        {

            string query = string.Format("USP_SearchAccountByUserName @Email");
            var parameter = new object[] { userName };

            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

    }
}