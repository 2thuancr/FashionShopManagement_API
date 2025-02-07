using System.Data;

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
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAllShift()
        {
            string query = "SELECT * FROM ViewAllShifts";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool UpdateStaffShift(int staffId, int shiftId)
        {
            string query = string.Format($"USP_UpdateStaffShift @StaffId ={staffId}, @ShiftId = {shiftId} ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
