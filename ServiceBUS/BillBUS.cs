using DAO;
using DTO.Bills;
using System;
using System.Collections.Generic;
using System.Data;

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

        public Bill CreateBill(BillCreateRequest billCreateRequest)
        {
            try
            {
                Bill bill = new Bill
                {
                    BusinessTime = billCreateRequest.BusinessTime.Value,
                    CustomerId = billCreateRequest.CustomerId,
                    StaffId = billCreateRequest.StaffId,
                    TotalPrice = billCreateRequest.TotalPrice,
                    TotalDiscount = billCreateRequest.TotalDiscount,
                    Status = billCreateRequest.Status,
                    DeliveryAddress = billCreateRequest.DeliveryAddress,
                    PaymentMethod = billCreateRequest.PaymentMethod,
                };
                int billId = BillDAO.Instance.InsertBill(bill);

                if (billId > 0)
                {
                    foreach (var item in billCreateRequest.Items)
                    {
                        BillInfo billInfo = new BillInfo
                        {
                            BillID = billId,
                            ProductID = item.ProductID,
                            Amount = item.Amount,
                            Price = item.Price,
                            Discount = item.Discount,
                            CampaignDiscountPercent = item.CampaignDiscountPercent,
                            TotalProductPrice = item.Amount * item.Price - item.Discount - item.CampaignDiscountPercent,
                        };
                        BillInfoDAO.Instance.InsertUpdateBillInfo(billInfo);
                    }
                }

                return bill;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Bill UpdateBill(BillUpdateRequest billUpdateRequest)
        {
            try
            {
                Bill bill = new Bill
                {
                    Id = billUpdateRequest.Id,
                    BusinessTime = billUpdateRequest.BusinessTime.Value,
                    CustomerId = billUpdateRequest.CustomerId,
                    StaffId = billUpdateRequest.StaffId,
                    TotalPrice = billUpdateRequest.TotalPrice,
                    TotalDiscount = billUpdateRequest.TotalDiscount,
                    Status = billUpdateRequest.Status,
                    DeliveryAddress = billUpdateRequest.DeliveryAddress,
                    PaymentMethod = billUpdateRequest.PaymentMethod,
                };
                BillDAO.Instance.UpdateBill(bill);
                foreach (var item in billUpdateRequest.Items)
                {
                    BillInfo billInfo = new BillInfo
                    {
                        BillID = bill.Id,
                        ProductID = item.ProductID,
                        Amount = item.Amount,
                        Price = item.Price,
                        Discount = item.Discount,
                        CampaignDiscountPercent = item.CampaignDiscountPercent,
                        TotalProductPrice = item.Amount * item.Price - item.Discount - item.CampaignDiscountPercent,
                    };
                    BillInfoDAO.Instance.InsertUpdateBillInfo(billInfo);
                }
                return bill;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool RemoveProduct(BillUpdateRequest request)
        {
            try
            {
                foreach (var item in request.Items)
                {
                    BillInfoDAO.Instance.DeleteBillInfo(request.Id, item.ProductID);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Bill Checkout(int billId)
        {
            try
            {
                DataTable dataTable = BillDAO.Instance.GetBillById(billId);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    Bill bill = new Bill(dataTable.Rows[0]);
                    bill.Status = 1; // Đã thanh toán
                    BillDAO.Instance.UpdateBillStatus(bill);
                    return bill;
                }
                else
                {
                    throw new Exception("Bill not found");
                }
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

        public void UpdateBill(Bill bill)
        {
            try
            {
                BillDAO.Instance.UpdateBill(bill);
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
            catch (Exception ex)
            {
                throw ex;
            }
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

        public BillPriceInfo GetBillPriceInfo(int billId)
        {
            DataTable table;
            try
            {
                table = BillDAO.Instance.GetBillPriceInfo(billId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (table != null && table.Rows.Count > 0)
            {
                var firstRow = table.Rows[0];
                BillPriceInfo billPriceInfo = new BillPriceInfo(firstRow);
                return billPriceInfo;
            }
            else
            {
                return null;
            }

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
            if (table != null && table.Rows.Count > 0)
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
        public string GetQrPayment(string qrType, string bankName, string bankAccountID, string bankAccountName, string addInfo, string amount)
        {

            string url = $"https://img.vietqr.io/image/{bankName}-{bankAccountID}-{qrType}.png?amount={amount}&accountName={bankAccountName}&addInfo={addInfo}";
            return url;
        }
    }
}