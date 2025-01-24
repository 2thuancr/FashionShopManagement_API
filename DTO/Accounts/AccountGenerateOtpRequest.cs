using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Accounts
{
    public class AccountGenerateOtpRequest
    {
        [Required]
        public string UserName { get; set; }
    }
}
