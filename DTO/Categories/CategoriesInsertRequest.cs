﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Categories
{
    public class CategoriesInsertRequest
    {
        [Required]
        public string name { get; set; }

        public int? parent_id { get; set; }
    }
}
