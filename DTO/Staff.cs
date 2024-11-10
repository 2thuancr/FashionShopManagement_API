using System;
using System.Data;

namespace DTO
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
       string sex, string address, DateTime? recruitmentDay, int? noS, decimal? reward, int? jobId, string phoneNumber)
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
            try
            {
                this.StaffId = Convert.ToInt32(row["staffId"]);
                this.SurNameStaff = Convert.ToString(row["surnameStaff"]);
                this.NameStaff = Convert.ToString(row["nameStaff"]);
                this.DoB = Convert.ToDateTime(row["doB"]);
                this.Sex = Convert.ToString(row["sex"]);
                this.Address = Convert.ToString(row["address"]);
                if (row["recruitmentDay"] != null)
                {
                    this.RecruitmentDay = Convert.ToDateTime(row["recruitmentDay"]);
                }
                if (row["noS"] != null)
                {
                    this.NoS = Convert.ToInt32(row["noS"]);
                }
                if (row["Reward"] != null)
                {
                    this.Reward = Convert.ToDecimal(row["reward"]);

                }
                if (row["JobId"] != null)
                {
                    this.JobId = Convert.ToInt32(row["jobId"]);

                }
                this.PhoneNumber = Convert.ToString(row["phoneNumber"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Staff()
        {

        }
    }
}
