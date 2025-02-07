using Shared.Helpers;
using System;
using System.Data;

namespace DTO.Staffs
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string SurNameStaff { get; set; }
        public string NameStaff { get; set; }
        public DateTime? DoB { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public DateTime? RecruitmentDay { get; set; }
        public int? NoS { get; set; }
        public decimal? Reward { get; set; }
        public int? JobId { get; set; }
        public string PhoneNumber { get; set; }

        public Staff(int staffId, string surNameStaff, string nameStaff, DateTime? doB,
            string sex, string address, DateTime? recruitmentDay, int? noS, 
            decimal? reward, int? jobId, string phoneNumber)
        {
            this.StaffId = staffId;
            this.SurNameStaff = surNameStaff;
            this.NameStaff = nameStaff;
            this.DoB = doB;
            this.Sex = sex;
            this.Address = address;
            this.RecruitmentDay = recruitmentDay;
            this.NoS = noS;
            this.JobId = jobId;
            this.PhoneNumber = phoneNumber;
        }

        public Staff(DataRow row)
        {
            this.StaffId = Converter.ToInt32(row["staffId"]);
            this.SurNameStaff = Converter.ToString(row["surnameStaff"]);
            this.NameStaff = Converter.ToString(row["nameStaff"]);
            this.DoB = Converter.ToDateTime(row["doB"]);
            this.Sex = Converter.ToString(row["sex"]);
            this.Address = Converter.ToString(row["address"]);
            this.RecruitmentDay = Converter.ToDateTime(row["recruitmentDay"]);
            this.NoS = Converter.ToInt32(row["noS"]);
            this.Reward = Converter.ToDecimal(row["reward"]);
            this.JobId = Converter.ToInt32(row["jobId"]);
            this.PhoneNumber = Converter.ToString(row["phoneNumber"]);
        }

        public Staff()
        {

        }
    }
}
