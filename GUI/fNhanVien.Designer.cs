namespace GUI
{
    partial class fNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Ten = new ReaLTaiizor.Controls.HopeTextBox();
            this.textBox_Ho = new ReaLTaiizor.Controls.HopeTextBox();
            this.textBox_MaNV = new ReaLTaiizor.Controls.HopeTextBox();
            this.comboBox_GioiTinh = new System.Windows.Forms.ComboBox();
            this.dateTime_NgayTuyenDung = new System.Windows.Forms.DateTimePicker();
            this.labelNgayTuyenDung = new System.Windows.Forms.Label();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.dateTime_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.label_Ten = new System.Windows.Forms.Label();
            this.label_Ho = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_SoCa = new ReaLTaiizor.Controls.HopeTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Password = new ReaLTaiizor.Controls.HopeTextBox();
            this.textBox_SDT = new ReaLTaiizor.Controls.HopeTextBox();
            this.textBox_MaCV = new ReaLTaiizor.Controls.HopeTextBox();
            this.textBox_DiaChi = new ReaLTaiizor.Controls.HopeTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            this.btn_Them = new ReaLTaiizor.Controls.MaterialButton();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.label_MaCV = new System.Windows.Forms.Label();
            this.btn_CapNhat = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_Xoa = new ReaLTaiizor.Controls.MaterialButton();
            this.data_DSNhanVien = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSNhanVien)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Ten);
            this.panel1.Controls.Add(this.textBox_Ho);
            this.panel1.Controls.Add(this.textBox_MaNV);
            this.panel1.Controls.Add(this.comboBox_GioiTinh);
            this.panel1.Controls.Add(this.dateTime_NgayTuyenDung);
            this.panel1.Controls.Add(this.labelNgayTuyenDung);
            this.panel1.Controls.Add(this.labelGioiTinh);
            this.panel1.Controls.Add(this.labelMaNV);
            this.panel1.Controls.Add(this.dateTime_NgaySinh);
            this.panel1.Controls.Add(this.label_NgaySinh);
            this.panel1.Controls.Add(this.label_Ten);
            this.panel1.Controls.Add(this.label_Ho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 365);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.BackColor = System.Drawing.Color.Snow;
            this.textBox_Ten.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_Ten.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_Ten.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_Ten.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Ten.ForeColor = System.Drawing.Color.Black;
            this.textBox_Ten.Hint = "";
            this.textBox_Ten.Location = new System.Drawing.Point(188, 123);
            this.textBox_Ten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Ten.MaxLength = 128;
            this.textBox_Ten.Multiline = false;
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.PasswordChar = '\0';
            this.textBox_Ten.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Ten.SelectedText = "";
            this.textBox_Ten.SelectionLength = 0;
            this.textBox_Ten.SelectionStart = 0;
            this.textBox_Ten.Size = new System.Drawing.Size(324, 48);
            this.textBox_Ten.TabIndex = 72;
            this.textBox_Ten.TabStop = false;
            this.textBox_Ten.UseSystemPasswordChar = false;
            this.textBox_Ten.Click += new System.EventHandler(this.TextBox_Ten_Click);
            // 
            // textBox_Ho
            // 
            this.textBox_Ho.BackColor = System.Drawing.Color.Snow;
            this.textBox_Ho.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_Ho.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_Ho.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_Ho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Ho.ForeColor = System.Drawing.Color.Black;
            this.textBox_Ho.Hint = "";
            this.textBox_Ho.Location = new System.Drawing.Point(188, 60);
            this.textBox_Ho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Ho.MaxLength = 128;
            this.textBox_Ho.Multiline = false;
            this.textBox_Ho.Name = "textBox_Ho";
            this.textBox_Ho.PasswordChar = '\0';
            this.textBox_Ho.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Ho.SelectedText = "";
            this.textBox_Ho.SelectionLength = 0;
            this.textBox_Ho.SelectionStart = 0;
            this.textBox_Ho.Size = new System.Drawing.Size(324, 48);
            this.textBox_Ho.TabIndex = 71;
            this.textBox_Ho.TabStop = false;
            this.textBox_Ho.UseSystemPasswordChar = false;
            // 
            // textBox_MaNV
            // 
            this.textBox_MaNV.BackColor = System.Drawing.Color.Snow;
            this.textBox_MaNV.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_MaNV.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_MaNV.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_MaNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_MaNV.ForeColor = System.Drawing.Color.Black;
            this.textBox_MaNV.Hint = "";
            this.textBox_MaNV.Location = new System.Drawing.Point(188, 3);
            this.textBox_MaNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MaNV.MaxLength = 128;
            this.textBox_MaNV.Multiline = false;
            this.textBox_MaNV.Name = "textBox_MaNV";
            this.textBox_MaNV.PasswordChar = '\0';
            this.textBox_MaNV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_MaNV.SelectedText = "";
            this.textBox_MaNV.SelectionLength = 0;
            this.textBox_MaNV.SelectionStart = 0;
            this.textBox_MaNV.Size = new System.Drawing.Size(324, 48);
            this.textBox_MaNV.TabIndex = 70;
            this.textBox_MaNV.TabStop = false;
            this.textBox_MaNV.UseSystemPasswordChar = false;
            // 
            // comboBox_GioiTinh
            // 
            this.comboBox_GioiTinh.FormattingEnabled = true;
            this.comboBox_GioiTinh.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox_GioiTinh.Location = new System.Drawing.Point(188, 234);
            this.comboBox_GioiTinh.Name = "comboBox_GioiTinh";
            this.comboBox_GioiTinh.Size = new System.Drawing.Size(111, 33);
            this.comboBox_GioiTinh.TabIndex = 69;
            // 
            // dateTime_NgayTuyenDung
            // 
            this.dateTime_NgayTuyenDung.Location = new System.Drawing.Point(220, 290);
            this.dateTime_NgayTuyenDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTime_NgayTuyenDung.Name = "dateTime_NgayTuyenDung";
            this.dateTime_NgayTuyenDung.Size = new System.Drawing.Size(233, 30);
            this.dateTime_NgayTuyenDung.TabIndex = 68;
            // 
            // labelNgayTuyenDung
            // 
            this.labelNgayTuyenDung.AutoSize = true;
            this.labelNgayTuyenDung.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.labelNgayTuyenDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNgayTuyenDung.Location = new System.Drawing.Point(43, 297);
            this.labelNgayTuyenDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNgayTuyenDung.Name = "labelNgayTuyenDung";
            this.labelNgayTuyenDung.Size = new System.Drawing.Size(158, 23);
            this.labelNgayTuyenDung.TabIndex = 67;
            this.labelNgayTuyenDung.Text = "Ngày tuyển dụng:";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.labelGioiTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGioiTinh.Location = new System.Drawing.Point(43, 244);
            this.labelGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(85, 23);
            this.labelGioiTinh.TabIndex = 66;
            this.labelGioiTinh.Text = "Giới tính";
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMaNV.Location = new System.Drawing.Point(41, 13);
            this.labelMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(136, 23);
            this.labelMaNV.TabIndex = 65;
            this.labelMaNV.Text = "Mã Nhân Viên:";
            // 
            // dateTime_NgaySinh
            // 
            this.dateTime_NgaySinh.Location = new System.Drawing.Point(188, 188);
            this.dateTime_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTime_NgaySinh.Name = "dateTime_NgaySinh";
            this.dateTime_NgaySinh.Size = new System.Drawing.Size(324, 30);
            this.dateTime_NgaySinh.TabIndex = 64;
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label_NgaySinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_NgaySinh.Location = new System.Drawing.Point(43, 188);
            this.label_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(99, 23);
            this.label_NgaySinh.TabIndex = 63;
            this.label_NgaySinh.Text = "Ngày sinh:";
            // 
            // label_Ten
            // 
            this.label_Ten.AutoSize = true;
            this.label_Ten.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Ten.Location = new System.Drawing.Point(47, 133);
            this.label_Ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(49, 23);
            this.label_Ten.TabIndex = 62;
            this.label_Ten.Text = "Tên:";
            // 
            // label_Ho
            // 
            this.label_Ho.AutoSize = true;
            this.label_Ho.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Ho.Location = new System.Drawing.Point(52, 70);
            this.label_Ho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ho.Name = "label_Ho";
            this.label_Ho.Size = new System.Drawing.Size(42, 23);
            this.label_Ho.TabIndex = 61;
            this.label_Ho.Text = "Họ:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 84);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1167, 371);
            this.tableLayoutPanel2.TabIndex = 37;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_SoCa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_Password);
            this.panel2.Controls.Add(this.textBox_SDT);
            this.panel2.Controls.Add(this.textBox_MaCV);
            this.panel2.Controls.Add(this.textBox_DiaChi);
            this.panel2.Controls.Add(this.labelPassword);
            this.panel2.Controls.Add(this.labelSDT);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.label_DiaChi);
            this.panel2.Controls.Add(this.label_MaCV);
            this.panel2.Controls.Add(this.btn_CapNhat);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(586, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 365);
            this.panel2.TabIndex = 37;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox_SoCa
            // 
            this.textBox_SoCa.BackColor = System.Drawing.Color.Snow;
            this.textBox_SoCa.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_SoCa.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_SoCa.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_SoCa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_SoCa.ForeColor = System.Drawing.Color.Black;
            this.textBox_SoCa.Hint = "";
            this.textBox_SoCa.Location = new System.Drawing.Point(174, 123);
            this.textBox_SoCa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_SoCa.MaxLength = 128;
            this.textBox_SoCa.Multiline = false;
            this.textBox_SoCa.Name = "textBox_SoCa";
            this.textBox_SoCa.PasswordChar = '\0';
            this.textBox_SoCa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_SoCa.SelectedText = "";
            this.textBox_SoCa.SelectionLength = 0;
            this.textBox_SoCa.SelectionStart = 0;
            this.textBox_SoCa.Size = new System.Drawing.Size(324, 48);
            this.textBox_SoCa.TabIndex = 79;
            this.textBox_SoCa.TabStop = false;
            this.textBox_SoCa.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(37, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 78;
            this.label2.Text = "Số Ca";
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.Snow;
            this.textBox_Password.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_Password.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_Password.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Password.ForeColor = System.Drawing.Color.Black;
            this.textBox_Password.Hint = "";
            this.textBox_Password.Location = new System.Drawing.Point(175, 256);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Password.MaxLength = 128;
            this.textBox_Password.Multiline = false;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '\0';
            this.textBox_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Password.SelectedText = "";
            this.textBox_Password.SelectionLength = 0;
            this.textBox_Password.SelectionStart = 0;
            this.textBox_Password.Size = new System.Drawing.Size(324, 48);
            this.textBox_Password.TabIndex = 77;
            this.textBox_Password.TabStop = false;
            this.textBox_Password.UseSystemPasswordChar = false;
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.BackColor = System.Drawing.Color.Snow;
            this.textBox_SDT.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_SDT.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_SDT.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_SDT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_SDT.ForeColor = System.Drawing.Color.Black;
            this.textBox_SDT.Hint = "";
            this.textBox_SDT.Location = new System.Drawing.Point(174, 188);
            this.textBox_SDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_SDT.MaxLength = 128;
            this.textBox_SDT.Multiline = false;
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.PasswordChar = '\0';
            this.textBox_SDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_SDT.SelectedText = "";
            this.textBox_SDT.SelectionLength = 0;
            this.textBox_SDT.SelectionStart = 0;
            this.textBox_SDT.Size = new System.Drawing.Size(324, 48);
            this.textBox_SDT.TabIndex = 76;
            this.textBox_SDT.TabStop = false;
            this.textBox_SDT.UseSystemPasswordChar = false;
            // 
            // textBox_MaCV
            // 
            this.textBox_MaCV.BackColor = System.Drawing.Color.Snow;
            this.textBox_MaCV.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_MaCV.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_MaCV.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_MaCV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_MaCV.ForeColor = System.Drawing.Color.Black;
            this.textBox_MaCV.Hint = "";
            this.textBox_MaCV.Location = new System.Drawing.Point(174, 60);
            this.textBox_MaCV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MaCV.MaxLength = 128;
            this.textBox_MaCV.Multiline = false;
            this.textBox_MaCV.Name = "textBox_MaCV";
            this.textBox_MaCV.PasswordChar = '\0';
            this.textBox_MaCV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_MaCV.SelectedText = "";
            this.textBox_MaCV.SelectionLength = 0;
            this.textBox_MaCV.SelectionStart = 0;
            this.textBox_MaCV.Size = new System.Drawing.Size(324, 48);
            this.textBox_MaCV.TabIndex = 75;
            this.textBox_MaCV.TabStop = false;
            this.textBox_MaCV.UseSystemPasswordChar = false;
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.BackColor = System.Drawing.Color.Snow;
            this.textBox_DiaChi.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_DiaChi.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_DiaChi.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_DiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.textBox_DiaChi.Hint = "";
            this.textBox_DiaChi.Location = new System.Drawing.Point(175, 3);
            this.textBox_DiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_DiaChi.MaxLength = 128;
            this.textBox_DiaChi.Multiline = false;
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.PasswordChar = '\0';
            this.textBox_DiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_DiaChi.SelectedText = "";
            this.textBox_DiaChi.SelectionLength = 0;
            this.textBox_DiaChi.SelectionStart = 0;
            this.textBox_DiaChi.Size = new System.Drawing.Size(324, 48);
            this.textBox_DiaChi.TabIndex = 74;
            this.textBox_DiaChi.TabStop = false;
            this.textBox_DiaChi.UseSystemPasswordChar = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPassword.Location = new System.Drawing.Point(37, 274);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(90, 23);
            this.labelPassword.TabIndex = 73;
            this.labelPassword.Text = "Password";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.labelSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSDT.Location = new System.Drawing.Point(42, 204);
            this.labelSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(48, 23);
            this.labelSDT.TabIndex = 72;
            this.labelSDT.Text = "SĐT";
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Them.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Them.Depth = 0;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Them.HighEmphasis = true;
            this.btn_Them.Icon = null;
            this.btn_Them.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_Them.Location = new System.Drawing.Point(64, 315);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn_Them.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Them.Size = new System.Drawing.Size(64, 36);
            this.btn_Them.TabIndex = 71;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Them.UseAccentColor = false;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label_DiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_DiaChi.Location = new System.Drawing.Point(42, 13);
            this.label_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(75, 23);
            this.label_DiaChi.TabIndex = 67;
            this.label_DiaChi.Text = "Địa chỉ:";
            // 
            // label_MaCV
            // 
            this.label_MaCV.AutoSize = true;
            this.label_MaCV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label_MaCV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_MaCV.Location = new System.Drawing.Point(37, 85);
            this.label_MaCV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaCV.Name = "label_MaCV";
            this.label_MaCV.Size = new System.Drawing.Size(129, 23);
            this.label_MaCV.TabIndex = 68;
            this.label_MaCV.Text = "Mã Công Việc";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CapNhat.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_CapNhat.Depth = 0;
            this.btn_CapNhat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.HighEmphasis = true;
            this.btn_CapNhat.Icon = null;
            this.btn_CapNhat.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_CapNhat.Location = new System.Drawing.Point(238, 315);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn_CapNhat.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_CapNhat.Size = new System.Drawing.Size(93, 36);
            this.btn_CapNhat.TabIndex = 69;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_CapNhat.UseAccentColor = false;
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Xoa.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Xoa.Depth = 0;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.HighEmphasis = true;
            this.btn_Xoa.Icon = null;
            this.btn_Xoa.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_Xoa.Location = new System.Drawing.Point(460, 315);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn_Xoa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Xoa.Size = new System.Drawing.Size(64, 36);
            this.btn_Xoa.TabIndex = 70;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Xoa.UseAccentColor = false;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // data_DSNhanVien
            // 
            this.data_DSNhanVien.AllowUserToResizeRows = false;
            this.data_DSNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_DSNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_DSNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_DSNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DSNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_DSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_DSNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_DSNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_DSNhanVien.EnableHeadersVisualStyles = false;
            this.data_DSNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.data_DSNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_DSNhanVien.Location = new System.Drawing.Point(0, 451);
            this.data_DSNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_DSNhanVien.Name = "data_DSNhanVien";
            this.data_DSNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DSNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_DSNhanVien.RowHeadersWidth = 62;
            this.data_DSNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_DSNhanVien.RowTemplate.Height = 28;
            this.data_DSNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_DSNhanVien.Size = new System.Drawing.Size(1167, 245);
            this.data_DSNhanVien.TabIndex = 21;
            this.data_DSNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_DSNhanVien_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.12712F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.87288F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1167, 84);
            this.tableLayoutPanel1.TabIndex = 34;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("SVN-Blog Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(238, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(925, 84);
            this.label1.TabIndex = 15;
            this.label1.Text = "CHI TIẾT NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Pink;
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.Remove_bg_ai_1729599973417;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 78);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1167, 696);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.data_DSNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fNhanVien";
            this.Text = "fNhanVien";
            this.Load += new System.EventHandler(this.fNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSNhanVien)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.PoisonDataGridView data_DSNhanVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeTextBox textBox_Ten;
        private ReaLTaiizor.Controls.HopeTextBox textBox_Ho;
        private ReaLTaiizor.Controls.HopeTextBox textBox_MaNV;
        private System.Windows.Forms.ComboBox comboBox_GioiTinh;
        private System.Windows.Forms.DateTimePicker dateTime_NgayTuyenDung;
        private System.Windows.Forms.Label labelNgayTuyenDung;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.DateTimePicker dateTime_NgaySinh;
        private System.Windows.Forms.Label label_NgaySinh;
        private System.Windows.Forms.Label label_Ten;
        private System.Windows.Forms.Label label_Ho;
        private ReaLTaiizor.Controls.HopeTextBox textBox_SoCa;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.HopeTextBox textBox_Password;
        private ReaLTaiizor.Controls.HopeTextBox textBox_SDT;
        private ReaLTaiizor.Controls.HopeTextBox textBox_MaCV;
        private ReaLTaiizor.Controls.HopeTextBox textBox_DiaChi;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelSDT;
        private ReaLTaiizor.Controls.MaterialButton btn_Them;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.Label label_MaCV;
        private ReaLTaiizor.Controls.MaterialButton btn_CapNhat;
        private ReaLTaiizor.Controls.MaterialButton btn_Xoa;
    }
}