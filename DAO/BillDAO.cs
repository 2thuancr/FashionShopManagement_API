using System;
using System.Collections.Generic;
using System.Data;

using DTO;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
        }

        private BillDAO() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableID"></param>
        /// <returns>Bill ID, if Bill ID is null, this function will return -1</returns>
        public int GetUnCheckBillIDByTableID(int tableID)
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("GetUnCheckBillIDByTableID @TableID", new object[] { tableID });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (table.Rows.Count > 0)
            {
                Bill bill = new Bill(table.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public DataTable GetAllBills()
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("Select * from ViewAllBills", new object[] { });
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetBillById(int Id)
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("USP_GetBillById @Id", new object[] { Id });
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetBillByCustomerId(int CustomerId)
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("USP_GetBillByCustomerId @CustomerId", new object[] { CustomerId });
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertBill(int customerId, int staffId, decimal discount, decimal totalPrice, int status)
        {
            try
            {
                var parameters = new object[]
                {
                    customerId,
                    staffId,
                    discount,
                    totalPrice,
                    status,
                };
                var result = DataProvider.Instance.ExecuteScalar("[USP_InsertBill] @CustomerID, @StaffID, @Discount, @TotalPrice, @Status", parameters);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertBill(Bill bill)
        {
            try
            {
                var parameters = new object[]
                {
                    bill.CustomerId,
                    bill.StaffId,
                    bill.TotalPrice,
                    bill.Status,
                };
                string query = $@"[USP_InsertBill] 
                    @CustomerID = {bill.CustomerId}, 
                    @StaffID = {bill.StaffId}, 
                    @TotalPrice = {bill.TotalPrice}, 
                    @Status = {bill.Status}
                    ";
                var result = DataProvider.Instance.ExecuteScalar(query, parameters);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetBillPriceInfo(int billId)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery($"select * from GetBillPriceInfo({billId})");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateBillStatus(Bill bill)
        {
            try
            {
                string query = $@"[USP_UpdateBillStatus] 
                    @BillID = {bill.ID},
                    @Status = {bill.Status}
                    ";
                DataProvider.Instance.ExecuteScalar(query, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateBill(Bill bill)
        {
            try
            {
                string query = $@"[USP_UpdateBill] 
                    @ID = {bill.ID},
                    @TotalPrice = {bill.TotalPrice},
                    @Status = {bill.Status}
                    ";
                DataProvider.Instance.ExecuteScalar(query, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetMaxBillID()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("USP_GetMaxBillID");
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut(int billID, int discount, int totalPrice)
        {
            string query = "USP_CheckOut @ID , @Discount , @TotalPrice";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID, discount, totalPrice });
            }
            catch { }
        }

        public DataTable GetListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetListBillByDay @fromDate , @toDate",
                    new object[] { fromDate, toDate });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteBill(int id)
        {
            string query = string.Format("USP_DeleteBill @ID");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        

    }
}