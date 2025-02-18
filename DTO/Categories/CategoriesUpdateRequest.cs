using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Accounts
{
    public class CategoriesUpdateRequest
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public int? parent_id { get; set; }
    }
}
