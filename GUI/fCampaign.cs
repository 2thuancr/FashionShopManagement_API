using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fCampaign : Form
    {
        private List<Campaign> listCampaign = new List<Campaign>();

        public fCampaign()
        {
            InitializeComponent();
        }

        private void btn_ThemChienDich_Click(object sender, EventArgs e)
        {
            fSetCampaign fSetCampaign = new fSetCampaign();
            fSetCampaign.Show();

            this.fCampaign_Load(null, null);
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
                MessageBox.Show("lỗi lấy danh sách chiến dịch");
            }
        }

    }
}
