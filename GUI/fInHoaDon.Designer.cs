namespace GUI
{
    partial class fInHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Huy = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_Print = new ReaLTaiizor.Controls.MaterialButton();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel_Print = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.data_DSSanPham = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.parrotGroupBox4 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.textbox_KhachHang = new ReaLTaiizor.Controls.MetroTextBox();
            this.parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.textbox_NgayMua = new ReaLTaiizor.Controls.MetroTextBox();
            this.parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.textbox_NhanVien = new ReaLTaiizor.Controls.MetroTextBox();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.textbox_MaHoaDon = new ReaLTaiizor.Controls.MetroTextBox();
            this.picture_QRCode = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.parrotGroupBox5 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.textbox_TongHoaDon = new ReaLTaiizor.Controls.MetroTextBox();
            this.smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            this.label1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_Print.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSSanPham)).BeginInit();
            this.parrotGroupBox4.SuspendLayout();
            this.parrotGroupBox3.SuspendLayout();
            this.parrotGroupBox2.SuspendLayout();
            this.parrotGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_QRCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.parrotGroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Huy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Print, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 712);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 67);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // btn_Huy
            // 
            this.btn_Huy.AutoSize = false;
            this.btn_Huy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Huy.BackColor = System.Drawing.Color.Crimson;
            this.btn_Huy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Huy.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Huy.Depth = 0;
            this.btn_Huy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Huy.HighEmphasis = true;
            this.btn_Huy.Icon = null;
            this.btn_Huy.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_Huy.Location = new System.Drawing.Point(273, 9);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_Huy.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Huy.Size = new System.Drawing.Size(255, 49);
            this.btn_Huy.TabIndex = 23;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Huy.UseAccentColor = false;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.AutoSize = false;
            this.btn_Print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Print.BackColor = System.Drawing.Color.Crimson;
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Print.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Print.Depth = 0;
            this.btn_Print.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Print.HighEmphasis = true;
            this.btn_Print.Icon = null;
            this.btn_Print.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_Print.Location = new System.Drawing.Point(6, 9);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_Print.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Print.Size = new System.Drawing.Size(255, 49);
            this.btn_Print.TabIndex = 22;
            this.btn_Print.Text = "In";
            this.btn_Print.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Print.UseAccentColor = true;
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // panel_Print
            // 
            this.panel_Print.Controls.Add(this.tableLayoutPanel2);
            this.panel_Print.Controls.Add(this.label1);
            this.panel_Print.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Print.Location = new System.Drawing.Point(0, 0);
            this.panel_Print.Name = "panel_Print";
            this.panel_Print.Size = new System.Drawing.Size(534, 712);
            this.panel_Print.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.data_DSSanPham, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.parrotGroupBox4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.parrotGroupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.parrotGroupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.parrotGroupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.picture_QRCode, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 649);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // data_DSSanPham
            // 
            this.data_DSSanPham.AllowUserToResizeRows = false;
            this.data_DSSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_DSSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_DSSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_DSSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DSSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_DSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.data_DSSanPham, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_DSSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_DSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_DSSanPham.Enabled = false;
            this.data_DSSanPham.EnableHeadersVisualStyles = false;
            this.data_DSSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.data_DSSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_DSSanPham.Location = new System.Drawing.Point(4, 145);
            this.data_DSSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_DSSanPham.Name = "data_DSSanPham";
            this.data_DSSanPham.ReadOnly = true;
            this.data_DSSanPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DSSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_DSSanPham.RowHeadersWidth = 62;
            this.data_DSSanPham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_DSSanPham.RowTemplate.Height = 28;
            this.data_DSSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_DSSanPham.Size = new System.Drawing.Size(526, 244);
            this.data_DSSanPham.TabIndex = 39;
            // 
            // parrotGroupBox4
            // 
            this.parrotGroupBox4.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox4.BorderWidth = 1;
            this.parrotGroupBox4.Controls.Add(this.textbox_KhachHang);
            this.parrotGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGroupBox4.Location = new System.Drawing.Point(270, 73);
            this.parrotGroupBox4.Name = "parrotGroupBox4";
            this.parrotGroupBox4.ShowText = true;
            this.parrotGroupBox4.Size = new System.Drawing.Size(261, 64);
            this.parrotGroupBox4.TabIndex = 3;
            this.parrotGroupBox4.TabStop = false;
            this.parrotGroupBox4.Text = "Khách hàng";
            this.parrotGroupBox4.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // textbox_KhachHang
            // 
            this.textbox_KhachHang.AutoCompleteCustomSource = null;
            this.textbox_KhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_KhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_KhachHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textbox_KhachHang.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textbox_KhachHang.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textbox_KhachHang.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.textbox_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_KhachHang.Enabled = false;
            this.textbox_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textbox_KhachHang.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textbox_KhachHang.Image = null;
            this.textbox_KhachHang.IsDerivedStyle = true;
            this.textbox_KhachHang.Lines = null;
            this.textbox_KhachHang.Location = new System.Drawing.Point(3, 22);
            this.textbox_KhachHang.MaxLength = 32767;
            this.textbox_KhachHang.Multiline = false;
            this.textbox_KhachHang.Name = "textbox_KhachHang";
            this.textbox_KhachHang.ReadOnly = false;
            this.textbox_KhachHang.Size = new System.Drawing.Size(255, 39);
            this.textbox_KhachHang.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.textbox_KhachHang.StyleManager = null;
            this.textbox_KhachHang.TabIndex = 1;
            this.textbox_KhachHang.Text = "Khách hàng";
            this.textbox_KhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_KhachHang.ThemeAuthor = "Taiizor";
            this.textbox_KhachHang.ThemeName = "MetroLight";
            this.textbox_KhachHang.UseSystemPasswordChar = false;
            this.textbox_KhachHang.WatermarkText = "";
            // 
            // parrotGroupBox3
            // 
            this.parrotGroupBox3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox3.BorderWidth = 1;
            this.parrotGroupBox3.Controls.Add(this.textbox_NgayMua);
            this.parrotGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGroupBox3.Location = new System.Drawing.Point(3, 73);
            this.parrotGroupBox3.Name = "parrotGroupBox3";
            this.parrotGroupBox3.ShowText = true;
            this.parrotGroupBox3.Size = new System.Drawing.Size(261, 64);
            this.parrotGroupBox3.TabIndex = 2;
            this.parrotGroupBox3.TabStop = false;
            this.parrotGroupBox3.Text = "Ngày mua";
            this.parrotGroupBox3.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // textbox_NgayMua
            // 
            this.textbox_NgayMua.AutoCompleteCustomSource = null;
            this.textbox_NgayMua.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_NgayMua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_NgayMua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textbox_NgayMua.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textbox_NgayMua.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textbox_NgayMua.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.textbox_NgayMua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_NgayMua.Enabled = false;
            this.textbox_NgayMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textbox_NgayMua.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textbox_NgayMua.Image = null;
            this.textbox_NgayMua.IsDerivedStyle = true;
            this.textbox_NgayMua.Lines = null;
            this.textbox_NgayMua.Location = new System.Drawing.Point(3, 22);
            this.textbox_NgayMua.MaxLength = 32767;
            this.textbox_NgayMua.Multiline = false;
            this.textbox_NgayMua.Name = "textbox_NgayMua";
            this.textbox_NgayMua.ReadOnly = false;
            this.textbox_NgayMua.Size = new System.Drawing.Size(255, 39);
            this.textbox_NgayMua.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.textbox_NgayMua.StyleManager = null;
            this.textbox_NgayMua.TabIndex = 1;
            this.textbox_NgayMua.Text = "2024-11-01";
            this.textbox_NgayMua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_NgayMua.ThemeAuthor = "Taiizor";
            this.textbox_NgayMua.ThemeName = "MetroLight";
            this.textbox_NgayMua.UseSystemPasswordChar = false;
            this.textbox_NgayMua.WatermarkText = "";
            // 
            // parrotGroupBox2
            // 
            this.parrotGroupBox2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox2.BorderWidth = 1;
            this.parrotGroupBox2.Controls.Add(this.textbox_NhanVien);
            this.parrotGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGroupBox2.Location = new System.Drawing.Point(270, 3);
            this.parrotGroupBox2.Name = "parrotGroupBox2";
            this.parrotGroupBox2.ShowText = true;
            this.parrotGroupBox2.Size = new System.Drawing.Size(261, 64);
            this.parrotGroupBox2.TabIndex = 1;
            this.parrotGroupBox2.TabStop = false;
            this.parrotGroupBox2.Text = "Nhân viên";
            this.parrotGroupBox2.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // textbox_NhanVien
            // 
            this.textbox_NhanVien.AutoCompleteCustomSource = null;
            this.textbox_NhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_NhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_NhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textbox_NhanVien.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textbox_NhanVien.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textbox_NhanVien.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.textbox_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_NhanVien.Enabled = false;
            this.textbox_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textbox_NhanVien.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textbox_NhanVien.Image = null;
            this.textbox_NhanVien.IsDerivedStyle = true;
            this.textbox_NhanVien.Lines = null;
            this.textbox_NhanVien.Location = new System.Drawing.Point(3, 22);
            this.textbox_NhanVien.MaxLength = 32767;
            this.textbox_NhanVien.Multiline = false;
            this.textbox_NhanVien.Name = "textbox_NhanVien";
            this.textbox_NhanVien.ReadOnly = false;
            this.textbox_NhanVien.Size = new System.Drawing.Size(255, 39);
            this.textbox_NhanVien.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.textbox_NhanVien.StyleManager = null;
            this.textbox_NhanVien.TabIndex = 1;
            this.textbox_NhanVien.Text = "Nhân viên";
            this.textbox_NhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_NhanVien.ThemeAuthor = "Taiizor";
            this.textbox_NhanVien.ThemeName = "MetroLight";
            this.textbox_NhanVien.UseSystemPasswordChar = false;
            this.textbox_NhanVien.WatermarkText = "";
            // 
            // parrotGroupBox1
            // 
            this.parrotGroupBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox1.BorderWidth = 1;
            this.parrotGroupBox1.Controls.Add(this.textbox_MaHoaDon);
            this.parrotGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.ShowText = true;
            this.parrotGroupBox1.Size = new System.Drawing.Size(261, 64);
            this.parrotGroupBox1.TabIndex = 0;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.Text = "Mã hóa đơn";
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // textbox_MaHoaDon
            // 
            this.textbox_MaHoaDon.AutoCompleteCustomSource = null;
            this.textbox_MaHoaDon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_MaHoaDon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_MaHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textbox_MaHoaDon.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textbox_MaHoaDon.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textbox_MaHoaDon.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.textbox_MaHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_MaHoaDon.Enabled = false;
            this.textbox_MaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textbox_MaHoaDon.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textbox_MaHoaDon.Image = null;
            this.textbox_MaHoaDon.IsDerivedStyle = true;
            this.textbox_MaHoaDon.Lines = null;
            this.textbox_MaHoaDon.Location = new System.Drawing.Point(3, 22);
            this.textbox_MaHoaDon.MaxLength = 32767;
            this.textbox_MaHoaDon.Multiline = false;
            this.textbox_MaHoaDon.Name = "textbox_MaHoaDon";
            this.textbox_MaHoaDon.ReadOnly = false;
            this.textbox_MaHoaDon.Size = new System.Drawing.Size(255, 39);
            this.textbox_MaHoaDon.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.textbox_MaHoaDon.StyleManager = null;
            this.textbox_MaHoaDon.TabIndex = 1;
            this.textbox_MaHoaDon.Text = "1";
            this.textbox_MaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_MaHoaDon.ThemeAuthor = "Taiizor";
            this.textbox_MaHoaDon.ThemeName = "MetroLight";
            this.textbox_MaHoaDon.UseSystemPasswordChar = false;
            this.textbox_MaHoaDon.WatermarkText = "";
            // 
            // picture_QRCode
            // 
            this.picture_QRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_QRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_QRCode.Location = new System.Drawing.Point(270, 397);
            this.picture_QRCode.Name = "picture_QRCode";
            this.picture_QRCode.Size = new System.Drawing.Size(261, 249);
            this.picture_QRCode.TabIndex = 41;
            this.picture_QRCode.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.parrotGroupBox5);
            this.panel1.Controls.Add(this.smallLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 249);
            this.panel1.TabIndex = 42;
            // 
            // parrotGroupBox5
            // 
            this.parrotGroupBox5.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox5.BorderWidth = 1;
            this.parrotGroupBox5.Controls.Add(this.textbox_TongHoaDon);
            this.parrotGroupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.parrotGroupBox5.Location = new System.Drawing.Point(0, 0);
            this.parrotGroupBox5.Name = "parrotGroupBox5";
            this.parrotGroupBox5.ShowText = true;
            this.parrotGroupBox5.Size = new System.Drawing.Size(261, 64);
            this.parrotGroupBox5.TabIndex = 42;
            this.parrotGroupBox5.TabStop = false;
            this.parrotGroupBox5.Text = "Tổng hóa đơn";
            this.parrotGroupBox5.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // textbox_TongHoaDon
            // 
            this.textbox_TongHoaDon.AutoCompleteCustomSource = null;
            this.textbox_TongHoaDon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_TongHoaDon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_TongHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textbox_TongHoaDon.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textbox_TongHoaDon.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textbox_TongHoaDon.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.textbox_TongHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_TongHoaDon.Enabled = false;
            this.textbox_TongHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textbox_TongHoaDon.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textbox_TongHoaDon.Image = null;
            this.textbox_TongHoaDon.IsDerivedStyle = true;
            this.textbox_TongHoaDon.Lines = null;
            this.textbox_TongHoaDon.Location = new System.Drawing.Point(3, 22);
            this.textbox_TongHoaDon.MaxLength = 32767;
            this.textbox_TongHoaDon.Multiline = false;
            this.textbox_TongHoaDon.Name = "textbox_TongHoaDon";
            this.textbox_TongHoaDon.ReadOnly = true;
            this.textbox_TongHoaDon.Size = new System.Drawing.Size(255, 39);
            this.textbox_TongHoaDon.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.textbox_TongHoaDon.StyleManager = null;
            this.textbox_TongHoaDon.TabIndex = 1;
            this.textbox_TongHoaDon.Text = "100000";
            this.textbox_TongHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_TongHoaDon.ThemeAuthor = "Taiizor";
            this.textbox_TongHoaDon.ThemeName = "MetroLight";
            this.textbox_TongHoaDon.UseSystemPasswordChar = false;
            this.textbox_TongHoaDon.WatermarkText = "";
            // 
            // smallLabel1
            // 
            this.smallLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.smallLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.smallLabel1.Location = new System.Drawing.Point(0, 93);
            this.smallLabel1.Name = "smallLabel1";
            this.smallLabel1.Size = new System.Drawing.Size(261, 156);
            this.smallLabel1.TabIndex = 41;
            this.smallLabel1.Text = resources.GetString("smallLabel1.Text");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("SVN-Blog Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "FASHION SHOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 779);
            this.Controls.Add(this.panel_Print);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "fInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.fInHoaDon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_Print.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_DSSanPham)).EndInit();
            this.parrotGroupBox4.ResumeLayout(false);
            this.parrotGroupBox4.PerformLayout();
            this.parrotGroupBox3.ResumeLayout(false);
            this.parrotGroupBox3.PerformLayout();
            this.parrotGroupBox2.ResumeLayout(false);
            this.parrotGroupBox2.PerformLayout();
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_QRCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.parrotGroupBox5.ResumeLayout(false);
            this.parrotGroupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialButton btn_Huy;
        private ReaLTaiizor.Controls.MaterialButton btn_Print;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Panel panel_Print;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox4;
        private ReaLTaiizor.Controls.MetroTextBox textbox_KhachHang;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox3;
        private ReaLTaiizor.Controls.MetroTextBox textbox_NgayMua;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private ReaLTaiizor.Controls.MetroTextBox textbox_NhanVien;
        private ReaLTaiizor.Controls.MetroTextBox textbox_MaHoaDon;
        private ReaLTaiizor.Controls.PoisonDataGridView data_DSSanPham;
        private System.Windows.Forms.PictureBox picture_QRCode;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox5;
        private ReaLTaiizor.Controls.MetroTextBox textbox_TongHoaDon;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
    }
}