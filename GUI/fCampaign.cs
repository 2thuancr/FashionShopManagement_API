using BUS;
using DTO.Campaigns;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class fCampaign : Form
    {
        private List<CampaignView> listCampaign = new List<CampaignView>();

        public fCampaign()
        {
            InitializeComponent();
        }

        private void btn_ThemChienDich_Click(object sender, EventArgs e)
        {
            fSetCampaign fSetCampaign = new fSetCampaign();
            fSetCampaign.Show();

            this.fCampaign_Load(null, null);
            this.Show();
        }

        private void fCampaign_Load(object sender, EventArgs e)
        {
            try
            {
                this.listCampaign = CampaignBUS.Instance.GetAllCampaign();
                if (this.listCampaign.Count > 0)
                {
                    this.data_DSChienDich.DataSource = this.listCampaign;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi lấy danh sách chiến dịch");
                return;
            }
        }

    }
}
