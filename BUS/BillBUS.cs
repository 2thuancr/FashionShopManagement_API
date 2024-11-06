using System;
using System.Collections.Generic;
using System.Data;

using DAO;
using DTO;

namespace BUS
{
    public class BillBUS
    {
        private static BillBUS instance;

        public static BillBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillBUS();
                return BillBUS.instance;
            }
        }

        private BillBUS() { }

        public int GetUnCheckBillIDByTableID(int id)
        {
            try
            {
                return BillDAO.Instance.GetUnCheckBillIDByTableID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertBill(int tableID)
        {
            try
            {
                BillDAO.Instance.InsertBill(tableID);
            }
            catch { }
        }

        public int GetMaxBillID()
        {
            try
            {
                return BillDAO.Instance.GetMaxBillID();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CheckOut(int billID, int discount, int totalPrice)
        {
            try
            {
                BillDAO.Instance.CheckOut(billID, discount, totalPrice);
            }
            catch { }
        }

        public List<Bill> GetListBillByDate(DateTime fromDate, DateTime toDate)
        {
            DataTable table;
            try
            {
                table = BillDAO.Instance.GetListBillByDate(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Bill> listBill = new List<Bill>();
            foreach (DataRow row in table.Rows)
            {
                Bill bill = new Bill(row);
                listBill.Add(bill);
            }
            return listBill;
        }

        public List<Bill> GetAllBills()
        {
            DataTable table;
            try
            {
                table = BillDAO.Instance.GetAllBills();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Bill> listBill = new List<Bill>();
            foreach (DataRow row in table.Rows)
            {
                Bill bill = new Bill(row);
                listBill.Add(bill);
            }
            return listBill;
        }

        public bool DeleteBill(int id)
        {
            try
            {
                return BillDAO.Instance.DeleteBill(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}