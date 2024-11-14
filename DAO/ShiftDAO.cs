using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ShiftDAO
    {
        private static ShiftDAO instance;

        public static ShiftDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ShiftDAO();
                return ShiftDAO.instance;
            }
        }
        private ShiftDAO() { }
        public DataTable GetAllStaffShift()
        {
            string query = "USP_GetAllStaffShift";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAllShift() 
        {
            string query = "SELECT * FROM ViewAllShifts";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateStaffShift(int staffId, int shiftId)
        {
            string query = string.Format($"USP_UpdateStaffShift @StaffId ={staffId}, @ShiftId = {shiftId} ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
