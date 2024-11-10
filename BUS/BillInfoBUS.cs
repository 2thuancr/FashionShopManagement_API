using System;
using System.Collections.Generic;

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

        public void InsertBillInfo(int billID, int productID, int amount)
        {
            try
            {
                BillInfoDAO.Instance.InsertUpdateBillInfo(billID, productID, amount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertUpdateBillInfo(BillInfo billInfo)
        {
            try
            {
                BillInfoDAO.Instance.InsertUpdateBillInfo(billInfo.BillID, billInfo.ProductID, billInfo.Amount);
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
            catch { }
        }
    }
}