using System;
using System.Collections.Generic;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class BillInfoBUS
    {
        private static BillInfoBUS instance;

        public static BillInfoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoBUS();
                return BillInfoBUS.instance;
            }
        }

        private BillInfoBUS() { }

        public void InsertUpdateBillInfo(BillInfo billInfo)
        {
            try
            {
                BillInfoDAO.Instance.InsertUpdateBillInfo(billInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteBillInfoByBillID(int billID)
        {
            try
            {
                BillInfoDAO.Instance.DeleteBillInfoByBillID(billID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteBillInfo(int billID, int productID)
        {
            try
            {
                BillInfoDAO.Instance.DeleteBillInfo(billID, productID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<BillInfoDetail> GetBillInfoDetailByBillId(int billId)
        {
            DataTable table;
            try
            {
                table = BillInfoDAO.Instance.GetBillInfoDetailByBillId(billId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<BillInfoDetail> result = new List<BillInfoDetail>();
            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row  in table.Rows)
                {
                    result.Add(new BillInfoDetail(row));
                }
            }
            return result;
        }

        public List<BillInfoDetail> GetBillInfoDetailByMonth(int year, int month)
        {
            DataTable table;
            try
            {
                table = BillInfoDAO.Instance.GetBillInfoDetailByMonth(year, month);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<BillInfoDetail> result = new List<BillInfoDetail>();
            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    result.Add(new BillInfoDetail(row));
                }
            }
            return result;
        }
    }
}