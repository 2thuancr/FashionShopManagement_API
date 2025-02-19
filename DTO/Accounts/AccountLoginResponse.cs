using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Accounts
{
    public class AccountLoginResponse
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public int TypeID { get; set; }
        public string Token { get; set; }
    }
}
