using DTO.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Accounts
{
    public class AccountCustomerRegisterResponse : ApiRepose<AccountCustomerRegisterResponseDto>
    {
    }

    public class AccountCustomerRegisterResponseDto
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public string Otp { get; set; }
        public string OtpExpiration { get; set; }
    }
}
