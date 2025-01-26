using BUS;
using DTO.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class fNhanVien : Form
    {
        private Staff staff = new Staff();
        private List<Staff> listStaff = new List<Staff>();
        private Staff selectedStaff = new Staff();

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
            catch (Exception)
            {

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                Staff staff = new Staff();
                staff.SurNameStaff = textBox_Ho.Text;
                staff.NameStaff = textBox_Ten.Text;
                try
                {
                    staff.DoB = Convert.ToDateTime(dateTime_NgaySinh.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai kiểu dữ liệu! Vui lòng nhập lại.");
                    return;
                }
                staff.Sex = comboBox_GioiTinh.Text;

                staff.RecruitmentDay = Convert.ToDateTime(dateTime_NgayTuyenDung.Text);
                staff.Address = textBox_DiaChi.Text;
                try
                {
                    staff.JobId = Convert.ToInt32(textBox_MaCV.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai kiểu dữ liệu! Vui lòng nhập lại.");
                    return;
                }
                try
                {
                    staff.NoS = Convert.ToInt32(textBox_SoCa.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai kiểu dữ liệu! Vui lòng nhập lại.");
                    return;
                }
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
            catch (Exception)
            {
                MessageBox.Show("Bạn không có quyền này!");
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void data_DSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin hàng đang được chọn
            var selectedIndex = data_DSNhanVien.SelectedCells[0].RowIndex;
            // Lấy dữ liệu ở hàng selectedIndex
            var staffDetail = this.listStaff[selectedIndex];

            var staff = this.listStaff.FirstOrDefault(x => x.StaffId == staffDetail.StaffId);
            //var productAmount = this.productsInBill[product];
            if (staff != null)
            {
                this.selectedStaff = staff;
                // hiện thị lên giao diện
                this.textBox_MaNV.Text = this.selectedStaff.StaffId.ToString();
                this.textBox_Ho.Text = this.selectedStaff.SurNameStaff.ToString();
                this.textBox_Ten.Text = this.selectedStaff.NameStaff.ToString();
                this.dateTime_NgaySinh.Text = this.selectedStaff.DoB.ToString();
                this.comboBox_GioiTinh.Text = this.selectedStaff.Sex.ToString();
                this.dateTime_NgayTuyenDung.Text = this.selectedStaff.RecruitmentDay.ToString();
                this.textBox_DiaChi.Text = selectedStaff.Address.ToString();
                this.textBox_MaCV.Text = this.selectedStaff.JobId.ToString();
                this.textBox_SoCa.Text = this.selectedStaff.NoS.ToString();
                this.textBox_SDT.Text = this.selectedStaff.PhoneNumber.ToString();
            }
        }
    }
}
