using BUS;
using DTO.Staffs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FPhanCa : Form
    {
        private List<StaffShift> lstStaffShift = new List<StaffShift>();
        public FPhanCa()
        {
            InitializeComponent();
        }

        private void btn_SuaCa_Click(object sender, EventArgs e)
        {
            FSuaCa fSuaCa = new FSuaCa();
            fSuaCa.Show();
        }

        private void FPhanCa_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            this.lstStaffShift = ShiftBUS.Instance.GetAllStaffShift();
            this.data_CaLamViec.DataSource = null;
            this.data_CaLamViec.DataSource = this.lstStaffShift;
        }

        private void data_CaLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Xác định cell vừa click
                var selectedIndex = data_CaLamViec.SelectedCells[0].RowIndex;
                var staffShift = this.lstStaffShift[selectedIndex];
                // show form sua ca len
                FSuaCa fSuaCa = new FSuaCa(staffShift);
                fSuaCa.ShowDialog();
                // load lai data
                this.LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi lấy thông tin ca làm việc");
            }
        }
    }
}
