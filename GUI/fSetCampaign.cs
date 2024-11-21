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
    public partial class fSetCampaign : Form
    {
        private List<Product> listProducts = new List<Product>();
        public fSetCampaign()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void fSetCampaign_Load(object sender, EventArgs e)
        {
            this.LoadProducts();
        }
        private void LoadProducts()
        {
            // Lấy GetAllProduct by BUS
            this.listProducts = ProductBUS.Instance.GetAllProduct();

            //Hiện thị tất cả các sp lên comboBox
            this.comboBox_SanPham.DataSource = listProducts;
            this.comboBox_SanPham.ValueMember = "Id";
            this.comboBox_SanPham.DisplayMember = "Name";
        }

        private void comboBox_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                Campaign campaign = new Campaign();
                if (textBox_TenChienDich.TextButton == null || textBox_TenChienDich.TextButton == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập tên chiến dịch");
                    return;
                }
                else if (textBox_TenChienDich.TextButton.Length > 50)
                {
                    MessageBox.Show("Tên chỉ được tối đa 50 ký tự");
                    return;
                }
                else
                {
                    campaign.Name = Convert.ToString(textBox_TenChienDich.TextButton);
                }

                campaign.Startdate = date_NgayBatDau.Value;
                campaign.Enddate = date_NgayKetThuc.Value;

                var result = CampaignBUS.Instance.InsertCampaign(campaign);
                if (result == true)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi thêm chiến dịch");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không có quyền này!");
            }
        }
    }
}
