using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Accounts
{
    public class AccountVerifyOtpByUserNameResponse
    {
        public string Status { get; set; }
        public string UserName { get; set; }
        public string OTP { get; set; }
        public string VerifiedOTP { get; set; }
        public DateTime? ExpirationTime { get; set; }
    }
}
