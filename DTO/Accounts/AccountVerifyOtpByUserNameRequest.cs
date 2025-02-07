using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Accounts
{
    public class AccountVerifyOtpByUserNameRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Otp { get; set; }
    }
}
