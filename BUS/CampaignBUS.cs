using DAO;
using DTO;
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
        public List<Campaign> GetAllCampaign()
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
            List<Campaign> listCampaign = new List<Campaign>();
            foreach (DataRow row in table.Rows)
            {
                Campaign campaign = new Campaign(row);
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
