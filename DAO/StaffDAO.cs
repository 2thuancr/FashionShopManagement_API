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
    }
}
