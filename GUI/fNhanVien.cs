using BUS;
using DTO;
using NPOI.SS.Formula.Functions;
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.StaffId = Convert.ToInt32(textBox_MaNV.Text);
            staff.SurNameStaff = textBox_Ho.Text;
            staff.NameStaff = textBox_Ten.Text;
            staff.DoB = Convert.ToDateTime(dateTime_NgaySinh.Text);
            staff.Sex = comboBox_GioiTinh.Text;
            staff.RecruitmentDay = Convert.ToDateTime(dateTime_NgayTuyenDung.Text);
            staff.Address = textBox_DiaChi.Text;
            staff.JobId = Convert.ToInt32(textBox_MaCV.Text);
            staff.NoS = Convert.ToInt32(textBox_SoCa.Text);
            staff.PhoneNumber = textBox_SDT.Text;

            var result = StaffBUS.Instance.InsertStaff(staff);
            if (result == true)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
           
        }
    }
}
