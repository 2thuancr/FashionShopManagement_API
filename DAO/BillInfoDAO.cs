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

        public void InsertUpdateBillInfo(BillInfo billInfo)
        {
            string query = $@"[USP_InsertUpdateBillInfo] 
                @BillID = {billInfo.BillID}, 
                @ProductID = {billInfo.ProductID}, 
                @Amount = {billInfo.Amount}, 
                @Price = {billInfo.Price},
                @Discount = {billInfo.Discount}";

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetBillInfoDetailByBillId(int billId)
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery($"[USP_GetBillInfoDetailByBillId] @BillId = {billId}");
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetBillInfoDetailByMonth(int year, int month)
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery($"[USP_GetBillInfoDetailByMonth] @year = {year}, @month = {month}");
                return table;
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

        public void DeleteBillInfo(int billID, int productID)
        {
            string query = $"[USP_DeleteBillInfo] @BillID = {billID}, @ProductID = {productID}";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}