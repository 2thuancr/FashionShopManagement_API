using DAO;
using DTO.Staffs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ShiftBUS
    {
        private static ShiftBUS instance;

        public static ShiftBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ShiftBUS();
                return ShiftBUS.instance;
            }
        }
        private ShiftBUS() { }
        public List<StaffShift> GetAllStaffShift()
        {
            DataTable table = new DataTable();
            try
            {
                table = ShiftDAO.Instance.GetAllStaffShift();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<StaffShift> lstStaffShift = new List<StaffShift>();
            foreach (DataRow row in table.Rows)
            {
                StaffShift staffShift = new StaffShift(row);
                lstStaffShift.Add(staffShift);
            }
            return lstStaffShift;
        }


        public List<Shift> GetAllShift()
        {
            DataTable table = new DataTable();
            try
            {
                table = ShiftDAO.Instance.GetAllShift();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Shift> lstShift = new List<Shift>();
            foreach (DataRow row in table.Rows)
            {
                Shift shift = new Shift(row);
                lstShift.Add(shift);
            }
            return lstShift;
        }

        public bool UpdateStaffShift(int staffId, int shiftId)
        {
            return ShiftDAO.Instance.UpdateStaffShift(staffId, shiftId);
        }

    }
}
