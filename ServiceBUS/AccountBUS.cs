using System;
using System.Data;
using System.Collections.Generic;

using DAO;
using DTO;
using DTO.Accounts;
using Shared.Helpers;
using System.Data.SqlClient;
using System.Web;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
        }

        private AccountBUS() { }

        public AccountCustomerRegisterResponseDto RegisterCustomerAccount(AccountCustomerRegisterRequest request)
        {
            try
            {
                DataTable table;
                try
                {
                    table = AccountDAO.Instance.RegisterCustomerAccount(request);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (table.Rows.Count == 0)
                    return null;

                var result = new AccountCustomerRegisterResponseDto
                {
                    AccountId = System.Convert.ToInt32(table.Rows[0]["AccountId"]),
                    CustomerId = System.Convert.ToInt32(table.Rows[0]["CustomerId"])
                };

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Account Login(AccountLoginRequest request)
        {
            try
            {
                DataTable table;
                try
                {
                    var account = new Account
                    {
                        UserName = request.UserName,
                        Password = request.Password
                    };
                    table = AccountDAO.Instance.Login(account);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                if (table.Rows.Count == 0)
                    return null;

                return new Account(table.Rows[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CheckLogin(Account account)
        {
            if (account.UserName == "")
                return false;
            if (account.Password == "")
                return false;

            try
            {
                return AccountDAO.Instance.CheckLogin(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AccountGenerateOtpResponse UpdateOTPByUsername(AccountGenerateOtpRequest input)
        {
            try
            {
                var otp = CodeHelper.OtpGenerator(6);
                var table = AccountDAO.Instance.UpdateOTPByUsername(input.Email, otp);

                if (table.Rows.Count == 0)
                {
                    throw new Exception("Cannot update OTP");
                }    

                var otpObject = table.Rows[0]["OTP"].ToString();
                var otpExpiration = table.Rows[0]["OTPExpiration"].ToString();

                var response = new AccountGenerateOtpResponse
                {
                    OTP = otpObject,
                    OTPExpiration = otpExpiration
                };
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AccountVerifyOtpByUserNameResponse VerifyOtpByUserName(AccountVerifyOtpByUserNameRequest request)
        {
            try
            {
                var table = AccountDAO.Instance.VerifyOtpByUsername(request);
                if (table.Rows.Count == 0)
                {
                    throw new Exception("Cannot verify OTP");
                }
                var response = new AccountVerifyOtpByUserNameResponse
                {
                    Status = Converter.ToString(table.Rows[0]["Status"]),
                    UserName = Converter.ToString(table.Rows[0]["Email"]),
                    OTP = Converter.ToString(table.Rows[0]["OTP"]),
                    VerifiedOTP = Converter.ToString(table.Rows[0]["VerifiedOTP"]),
                    ExpirationTime = Converter.ToDateTimeNullable(table.Rows[0]["ExpirationTime"])
                };
                return response;
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
                return AccountDAO.Instance.GetAllAcount();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable table;
            try
            {
                table = AccountDAO.Instance.GetAccountByUserName(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new Account(table.Rows[0]);
        }

        public bool Insert(string userName, string displayName, int type)
        {
            try
            {
                return AccountDAO.Instance.Insert(userName, displayName, type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(string userName)
        {
            try
            {
                return AccountDAO.Instance.Delete(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetPassword(string userName)
        {
            try
            {
                return AccountDAO.Instance.ResetPassword(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool UpdatePassword (AccountCustomerUpdatePasswordRequest request)
        {
            try
            {
                return AccountDAO.Instance.UpdatePassword(request.Email, request.Password);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateInformation(string userName, string displayName, string password, string newPass)
        {
            try
            {
                return AccountDAO.Instance.UpdateInformation(userName, displayName, password, newPass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Account> SearchAccountByUserName(string userName)
        {
            List<Account> listAccount = new List<Account>();
            DataTable table;
            try
            {
                table = AccountDAO.Instance.SearchAccountByUserName(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in table.Rows)
            {
                Account account = new Account(row);
                listAccount.Add(account);
            }
            return listAccount;
        }
    }
}