using Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Categories
{
    public class Categories
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? parent_id { get; set; }

        public Categories() { }

        public Categories(int id, string name, int? parent_id)
        {
            this.id = id;
            this.name = name;
            this.parent_id = parent_id;
        }

        public Categories(DataRow row)
        {
            this.id = Converter.ToInt32(row["id"]);
            this.name = Converter.ToString(row["name"]);
            this.parent_id = Converter.ToInt32Nullable(row["parent_id"]);
        }
    }


}
