using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class SendEmailBySMTPInput
    {
        public string Title { get; set; }

        public string Content { get; set; }

        [Required]
        public List<string> Recipient { get; set; }
    }
}
