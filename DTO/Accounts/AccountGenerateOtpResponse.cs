using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Accounts
{
    public class AccountGenerateOtpResponse
    {
        public string OTP { get; set; }
        public string OTPExpiration { get; set; }
    }
}
