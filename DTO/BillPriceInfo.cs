using System;
using System.Data;

namespace DTO
{
    public class BillPriceInfo
    {
        public int BillID { get; set; }

        public decimal TongTien { get; set; }

        public decimal GiamGia { get; set; }

        public decimal ThanhTien { get; set; }
        public BillPriceInfo() { }

        public BillPriceInfo(int billID, decimal tongTien, decimal giamGia, decimal thanhTien)
        {
            this.BillID = billID;
            this.TongTien = tongTien;
            this.GiamGia = giamGia;
            this.ThanhTien = thanhTien;
        }

        public BillPriceInfo(DataRow row)
        {
            try
            {
                this.BillID = Convert.ToInt32(row["billID"]);
                this.TongTien = Convert.ToDecimal(row["TongTien"]);
                this.GiamGia = Convert.ToDecimal(row["GiamGia"]);
                this.ThanhTien = Convert.ToDecimal(row["ThanhTien"]);
            }
            catch
            {

            }

        }
    }
}
