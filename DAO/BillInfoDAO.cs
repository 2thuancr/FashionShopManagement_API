using System;
using System.Collections.Generic;
using System.Data;

using DTO;

namespace DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
        }

        private BillInfoDAO() { }

        public void InsertUpdateBillInfo(int billID, int productID, int amount)
        {
            string query = "USP_InsertBillInfo @BillID , @ProductID , @Amount";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID, productID, amount });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteBillInfoByBillID(int billID)
        {
            string query = string.Format("USP_DeleteBillInfoByBillID @BillID");
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}