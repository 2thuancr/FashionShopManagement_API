using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Categories
{
    public class CategoriesDeleteRequest
    {
        [Required]
        public int id { get; set; }
    }
}
