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
    public partial class fNhanVien : Form
    {
        private Staff staff = new Staff();
        private List<Staff> listStaff = new List<Staff>();
        public fNhanVien()
        {
            InitializeComponent();
        }
        public fNhanVien(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            this.ShowCustomer();
        }
        private void ShowCustomer()
        {
            this.textBox_MaNV.Text = this.staff.StaffId.ToString();
            this.textBox_Ho.Text = this.staff.SurNameStaff.ToString();
            this.textBox_Ten.Text = this.staff.NameStaff.ToString();
            this.dateTime_NgaySinh.Text = this.staff.DoB.ToString();
            this.comboBox_GioiTinh.Text = this.staff.Sex.ToString();
            this.textBox_DiaChi.Text = this.staff.Address.ToString();
            this.dateTime_NgayTuyenDung.Text = this.staff.RecruitmentDay.ToString();
            this.textBox_SoCa.Text = this.staff.NoS.ToString();
            this.textBox_MaCV.Text = this.staff.JobId.ToString();
            this.textBox_SDT.Text = this.staff.PhoneNumber.ToString();
        }

        private void poisonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TextBox_Ten_Click(object sender, EventArgs e)
        {

        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                this.listStaff = StaffBUS.Instance.GetAllStaff();
                if (this.listStaff.Count > 0)
                {
                    this.data_DSNhanVien.DataSource = this.listStaff;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
