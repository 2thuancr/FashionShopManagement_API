using Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Staffs
{
    public class StaffShift
    {
        public int ShiftId { get; set; }
        public int StaffId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string ShiftCode { get; set; }
        public string FullNameStaff { get; set; }   

        public StaffShift ()
        {

        }

        public StaffShift(int shiftId, int staffId, TimeSpan startTime, TimeSpan endTime, 
            string shiftCode, string fullNameStaff)
        {
            this.ShiftId = shiftId;
            this.StaffId = staffId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ShiftCode = shiftCode;
            this.FullNameStaff = fullNameStaff;
        }

        public StaffShift (DataRow row)
        {
            this.ShiftId = Converter.ToInt32(row["shiftId"]);
            this.StaffId = Converter.ToInt32(row["StaffId"]);
            this.StartTime = TimeSpan.Parse(Converter.ToString(row["StartTime"]));
            this.EndTime = TimeSpan.Parse(Converter.ToString(row["EndTime"]));
            this.ShiftCode = Converter.ToString(row["ShiftCode"]);
            this.FullNameStaff = Converter.ToString(row["FullNameStaff"]);
        }
    }
    
}
