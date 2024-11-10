using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
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

        public int InsertBill(int customerId, int staffId, decimal discount, decimal totalPrice, int status)
        {
            try
            {
                return BillDAO.Instance.InsertBill(customerId, staffId, discount, totalPrice, status);
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
                return BillDAO.Instance.InsertBill(bill);
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
                BillDAO.Instance.UpdateBillStatus(bill);
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

        public List<Bill> GetBillByCustomerId(int customerId)
        {
            DataTable table;
            try
            {
                table = BillDAO.Instance.GetBillByCustomerId(customerId);
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

        public Bill GetBillById(int Id)
        {
            DataTable table;
            try
            {
                table = BillDAO.Instance.GetBillById(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Bill bill = new Bill();
            if(table != null && table.Rows.Count > 0)
            {
                bill = new Bill(table.Rows[0]);
            }
            return bill;
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

        /// <summary>
        /// Trả ra link QR code thanh toán
        /// </summary>
        /// <param name="bill"></param>
        public string GetQrPayment(Bill bill, string bankName, string bankAccountID, string bankAccountName, string addInfo, string amount)
        {
          
            string url = $"https://img.vietqr.io/image/{bankName}-{bankAccountID}-print.png?amount={amount}&accountName={bankAccountName}&addInfo={addInfo}";
            return url;
        }
    }
}