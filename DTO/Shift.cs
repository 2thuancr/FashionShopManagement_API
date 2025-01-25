using Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Shift
    {
        public int ShiftId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Code { get; set; }

        public Shift()
        {

        }

        public Shift(int shiftId, TimeSpan startTime, TimeSpan endTime, string code)
        {
            this.ShiftId = shiftId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Code = code;
        }

        public Shift(DataRow row)
        {
            this.ShiftId = Converter.ToInt32(row["shiftId"]);
            this.StartTime = TimeSpan.Parse(Converter.ToString(row["StartTime"]));
            this.EndTime = TimeSpan.Parse(Converter.ToString(row["EndTime"]));
            this.Code = Converter.ToString(row["Code"]);
        }
    }
}
