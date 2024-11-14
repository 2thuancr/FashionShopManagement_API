using DTO;
using System;
using System.Data;

namespace DAO
{
    public class ReportDAO
    {
        private static ReportDAO instance;

        public static ReportDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReportDAO();
                return ReportDAO.instance;
            }
        }

        private ReportDAO() { }

        public long CountBillsInMonth(int year, int month)
        {
            string query = $"select dbo.CountBillsInMonth({year}, {month});";
            try
            {
                var result = DataProvider.Instance.ExecuteScalar(query);
                if (result == DBNull.Value)
                {
                    return 0;
                }
                return Convert.ToInt64(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long TotalRevenueByMonth(int year, int month)
        {
            string query = $"select dbo.TotalRevenueByMonth({year}, {month});";
            try
            {
                var result = DataProvider.Instance.ExecuteScalar(query);
                if (result == DBNull.Value)
                {
                    return 0;
                }
                return Convert.ToInt64(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}