using DTO.Staffs;
using System.Data;

namespace DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffDAO();
                return StaffDAO.instance;
            }
        }

        public DataTable GetAllStaff()
        {
            var query = "SELECT * FROM dbo.ViewAllStaffs";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertStaff(Staff newStaff)
        {
            string query = $@"USP_InsertStaff 
                @StaffId = {newStaff.StaffId}, 
                @SurNameStaff = '{newStaff.SurNameStaff}', 
                @NameStaff = '{newStaff.NameStaff}', 
                @DoB = '{newStaff.DoB}', 
                @Sex = '{newStaff.Sex}', 
                @Address = '{newStaff.Address}', 
                @RecruitmentDay = '{newStaff.RecruitmentDay}', 
                @NoS = {newStaff.NoS}, 
                @Reward = {newStaff.Reward ?? 0}, 
                @JobId = '{newStaff.JobId}', 
                @PhoneNumber = '{newStaff.PhoneNumber}'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
