using DTO.Campaigns;
using System.Data;

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
            var query = "SELECT * FROM ViewAllCampaigns";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return table;
        }

        public bool InsertCampaign(Campaign newCampaign)
        {
            string query = $@"USP_InsertCampaign
                @Name = '{newCampaign.Name}',
                @StartDate = '{newCampaign.StartDate:yyyy-MM-dd}', 
                @EndDate = '{newCampaign.EndDate:yyyy-MM-dd}', 
                @ProductId = '{newCampaign.ProductId}',
                @DiscountPercentage = '{newCampaign.DiscountPercentage}',
                @MinimumQuantity = '{newCampaign.MinimumQuantity}',
                @StaffId = '{newCampaign.StaffId}'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
