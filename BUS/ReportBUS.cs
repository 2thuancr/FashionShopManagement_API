using System;
using System.Collections.Generic;
using System.Data;

using DTO;
using DAO;
using System.Linq;

namespace BUS
{
    public class ReportBUS
    {
        private static ReportBUS instance;

        public static ReportBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReportBUS();
                return ReportBUS.instance;
            }
        }

        private ReportBUS() { }

        public long CountBillsInMonth(int year, int month)
        {
            return ReportDAO.Instance.CountBillsInMonth(year, month);
        }

        public long TotalRevenueByMonth(int year, int month)
        {
            return ReportDAO.Instance.TotalRevenueByMonth(year, month);
        }
    }
}