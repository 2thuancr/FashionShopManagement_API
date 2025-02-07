using BUS;
using DTO.Staffs;
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
    public partial class FSuaCa : Form
    {
        private List<Shift> shifts =new List<Shift>();
        public StaffShift StaffShift { get; set; }
        public FSuaCa()
        {
            InitializeComponent();
        }

        public FSuaCa(StaffShift staffShift)
        {
            InitializeComponent();
            this.StaffShift = staffShift;
            this.LoadInfo();
        }

        private void LoadInfo()
        {
            if (this.StaffShift != null)
            {
                this.comboBox_MaCa.Text = this.StaffShift.ShiftCode;
                this.txt_TenNhanVien.Text = this.StaffShift.FullNameStaff;
            }
        }

        private void FSuaCa_Load(object sender, EventArgs e)
        {
            try
            {
                this.shifts = ShiftBUS.Instance.GetAllShift();
                this.comboBox_MaCa.DataSource = null;
                this.comboBox_MaCa.DataSource = this.shifts;
                this.comboBox_MaCa.ValueMember = "ShiftId";
                this.comboBox_MaCa.DisplayMember = "Code";
            }
            catch { }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = this.comboBox_MaCa.SelectedItem as Shift;

                int shiftId = Convert.ToInt32(selectedItem.ShiftId);
                int staffId = this.StaffShift.StaffId;

                var result = ShiftBUS.Instance.UpdateStaffShift(staffId, shiftId);
                if(result == true)
                {
                    MessageBox.Show("Cập nhật ca thành công");
                    this.Close();   
                }
                else
                {
                    MessageBox.Show("Cập nhật ca thất bại");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi cập nhật ca");
            }
        }
    }
}
