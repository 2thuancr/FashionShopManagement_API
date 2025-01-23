using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CampaignDAO
    {
        private static CampaignDAO instance;

        public static CampaignDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CampaignDAO();
                return CampaignDAO.instance;
            }
        }
        private CampaignDAO() { }

        public DataTable GetAllCampaign()
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("SELECT * FROM [dbo].[ViewAllCampaigns]", new object[] { });
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertCampaign(Campaign newCampaign)
        {

            string query = $@"USP_InsertCampaign
                @Name = '{newCampaign.Name}',
                @StartDate = '{newCampaign.StartDate.ToString("yyyy-MM-dd")}', 
                @EndDate = '{newCampaign.EndDate.ToString("yyyy-MM-dd")}', 
                @ProductId = '{newCampaign.ProductId}',
                @DiscountPercentage = '{newCampaign.DiscountPercentage}',
                @MinimumQuantity = '{newCampaign.MinimumQuantity}',
                @StaffId = '{newCampaign.StaffId}'";

            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, null);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
