using DTO.Bills;
using System;
using System.Data;

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
                @BillID = {billInfo.BillId}, 
                @ProductID = {billInfo.ProductId}, 
                @Amount = {Convert.ToInt32(billInfo.Amount)};";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillInfoDetailByBillId(int billId)
        {
            var query = $"USP_GetBillInfoDetailByBillId @Id = {billId}";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return table;
        }

        public DataTable GetBillInfoDetailByMonth(int year, int month)
        {
            var query = $"USP_GetBillInfoDetailByMonth @year = {year}, @month = {month}";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return table;
        }

        public void DeleteBillInfoByBillID(int billID)
        {
            string query = string.Format("USP_DeleteBillInfoByBillID @BillId");
            var parameters = new object[] { billID };

            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void DeleteBillInfo(int billID, int productID)
        {
            string query = $"[USP_DeleteBillInfo] @BillId = {billID}, @ProductId = {productID}";

            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}