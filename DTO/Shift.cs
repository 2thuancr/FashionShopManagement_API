using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Shift
    {
        public string MaCa { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLam { get; set; }
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }
        public string HoTenNV { get; set; }
    }

}
