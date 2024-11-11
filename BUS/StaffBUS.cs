using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StaffBUS
    {

        private static StaffBUS instance;

        public static StaffBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffBUS();
                return StaffBUS.instance;
            }
        }
        private StaffBUS() { }
        public List<Staff> GetAllStaff()
        {
            DataTable table;
            try
            {
                table = StaffDAO.Instance.GetAllStaff();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<Staff> listStaff = new List<Staff>();
            foreach (DataRow row in table.Rows) 
            {
                Staff staff = new Staff(row);
                listStaff.Add(staff);
            }
            return listStaff;

        }
        //public int InsertStaff(int staffId, string surNameStaff , string nameStaff, DateTime doB, string sex, 
        //    string address, DateTime recruitmentDay, int noS, decimal reward, int jobId, string phoneNumber)
        //{
        //    try
        //    {
        //        return StaffDAO.Instance.InsertStaff(staffId, surNameStaff, nameStaff, doB, sex, address, recruitmentDay, noS, reward, jobId, phoneNumber);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public bool InsertStaff(Staff newStaff)
        {
            return StaffDAO.Instance.InsertStaff(newStaff);
        }
    }
}
