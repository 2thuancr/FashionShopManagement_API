using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Helpers
{
    public static class CodeHelper
    {
        public static string OtpGenerator(int length = 6)
        {
            string numbers = "0123456789";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                sb.Append(numbers[random.Next(0, numbers.Length)]);
            }
            return sb.ToString();
        }
    }
}
