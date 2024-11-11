using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("USP_GetAllStaff", new object[] { });
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
