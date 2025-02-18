using Shared.Helpers;

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
            string query = $"SELECT dbo.CountBillsInMonth({year}, {month});";
            var result = DataProvider.Instance.ExecuteScalar(query);
            return Converter.ToInt64(result);
        }

        public long TotalRevenueByMonth(int year, int month)
        {
            string query = $"SELECT dbo.TotalRevenueByMonth({year}, {month});";
            var result = DataProvider.Instance.ExecuteScalar(query);
            return Converter.ToInt64(result);
        }
    }
}