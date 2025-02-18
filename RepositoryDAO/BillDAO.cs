using System;
using System.Collections.Generic;
using System.Data;
using DTO.Bills;

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

        public DataTable GetAllBills()
        {
            var query = "SELECT * FROM ViewAllBills";
            
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return table;
        }

        public DataTable GetBillById(int Id)
        {
            var query = "USP_GetBillById @Id";
            var parameters = new object[] { Id };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, parameters);
            return table;
        }

        public DataTable GetBillByCustomerId(int CustomerId)
        {
            var query = "USP_GetBillByCustomerId @CustomerId";
            var parameters = new object[] { CustomerId };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, parameters);
            return table;
        }

        public int InsertBill(int customerId, int staffId, decimal discount, decimal totalPrice, int status)
        {
            var query = "USP_InsertBill @CustomerID , @StaffID , @Discount , @TotalPrice , @Status";
            var parameters = new object[]
            {
                customerId,
                staffId,
                discount,
                totalPrice,
                status,
            };

            var result = DataProvider.Instance.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }

        public int InsertBill(Bill bill)
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

        public DataTable GetBillPriceInfo(int billId)
        {
            var query = $"select * from GetBillPriceInfo({billId})";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateBillStatus(Bill bill)
        {
            string query = $@"[USP_UpdateBillStatus] 
                    @BillID = {bill.ID},
                    @Status = {bill.Status}
                    ";

            DataProvider.Instance.ExecuteScalar(query);
        }

        public void UpdateBill(Bill bill)
        {
            string query = $@"[USP_UpdateBill] 
                    @ID = {bill.ID},
                    @TotalPrice = {bill.TotalPrice},
                    @Status = {bill.Status}
                    ";

            DataProvider.Instance.ExecuteScalar(query);
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
            var parameters = new object[] { billID, discount, totalPrice };

            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetListBillByDate(DateTime fromDate, DateTime toDate)
        {
            var query = "USP_GetListBillByDate @fromDate , @toDate";
            var parameters = new object[] { fromDate, toDate };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public bool DeleteBill(int id)
        {
            string query = string.Format("USP_DeleteBill @ID");
            var parameters = new object[] { id };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}