using DAO;
using DTO.Campaigns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CampaignBUS
    {
        private static CampaignBUS instance;

        public static CampaignBUS Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new CampaignBUS ();
                }
                return CampaignBUS.instance;
            }
        }
        private CampaignBUS() { }
        public List<CampaignView> GetAllCampaign()
        {
            DataTable table;
            try
            {
                table = CampaignDAO.Instance.GetAllCampaign();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<CampaignView> listCampaign = new List<CampaignView>();
            foreach (DataRow row in table.Rows)
            {
                CampaignView campaign = new CampaignView(row);
                listCampaign.Add(campaign);
            }
            return listCampaign;
        }
        public bool InsertCampaign(Campaign newCampaign)
        {
            return CampaignDAO.Instance.InsertCampaign(newCampaign);
        }
    }
}
