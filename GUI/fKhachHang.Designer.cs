namespace GUI
{
    partial class fKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_TimKiem = new ReaLTaiizor.Controls.CyberTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new ReaLTaiizor.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TaoDon = new ReaLTaiizor.Controls.MaterialButton();
            this.data_DSKhachHang = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSKhachHang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("SVN-Blog Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(218, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(844, 141);
            this.label1.TabIndex = 15;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.Remove_bg_ai_1729599973417;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 135);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Alpha = 20;
            this.textBox_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.textBox_TimKiem.Background_WidthPen = 3F;
            this.textBox_TimKiem.BackgroundPen = true;
            this.textBox_TimKiem.ColorBackground = System.Drawing.Color.White;
            this.textBox_TimKiem.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_TimKiem.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_TimKiem.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_TimKiem.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.textBox_TimKiem.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.textBox_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TimKiem.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.textBox_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.textBox_TimKiem.Lighting = false;
            this.textBox_TimKiem.LinearGradientPen = false;
            this.textBox_TimKiem.Location = new System.Drawing.Point(0, 0);
            this.textBox_TimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.PenWidth = 15;
            this.textBox_TimKiem.RGB = false;
            this.textBox_TimKiem.Rounding = true;
            this.textBox_TimKiem.RoundingInt = 60;
            this.textBox_TimKiem.Size = new System.Drawing.Size(536, 54);
            this.textBox_TimKiem.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.textBox_TimKiem.TabIndex = 49;
            this.textBox_TimKiem.Tag = "Cyber";
            this.textBox_TimKiem.TextButton = "";
            this.textBox_TimKiem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.textBox_TimKiem.Timer_RGB = 300;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_TimKiem);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(222, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 54);
            this.panel1.TabIndex = 36;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_TimKiem.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_TimKiem.Depth = 0;
            this.btn_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.HighEmphasis = true;
            this.btn_TimKiem.Icon = null;
            this.btn_TimKiem.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_TimKiem.Location = new System.Drawing.Point(536, 0);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(20, 8, 5, 8);
            this.btn_TimKiem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_TimKiem.Size = new System.Drawing.Size(85, 54);
            this.btn_TimKiem.TabIndex = 53;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_TimKiem.UseAccentColor = false;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.aloneComboBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 141);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1066, 80);
            this.tableLayoutPanel2.TabIndex = 43;
            // 
            // aloneComboBox1
            // 
            this.aloneComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aloneComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aloneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.aloneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aloneComboBox1.EnabledCalc = true;
            this.aloneComboBox1.FormattingEnabled = true;
            this.aloneComboBox1.ItemHeight = 20;
            this.aloneComboBox1.Location = new System.Drawing.Point(13, 13);
            this.aloneComboBox1.Name = "aloneComboBox1";
            this.aloneComboBox1.Size = new System.Drawing.Size(203, 26);
            this.aloneComboBox1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_TaoDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(849, 13);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.panel2.Size = new System.Drawing.Size(204, 54);
            this.panel2.TabIndex = 37;
            // 
            // btn_TaoDon
            // 
            this.btn_TaoDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_TaoDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_TaoDon.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_TaoDon.Depth = 0;
            this.btn_TaoDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TaoDon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_TaoDon.HighEmphasis = true;
            this.btn_TaoDon.Icon = null;
            this.btn_TaoDon.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_TaoDon.Location = new System.Drawing.Point(25, 0);
            this.btn_TaoDon.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn_TaoDon.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_TaoDon.Name = "btn_TaoDon";
            this.btn_TaoDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_TaoDon.Size = new System.Drawing.Size(154, 54);
            this.btn_TaoDon.TabIndex = 52;
            this.btn_TaoDon.Text = "Tạo đơn";
            this.btn_TaoDon.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_TaoDon.UseAccentColor = true;
            this.btn_TaoDon.UseVisualStyleBackColor = true;
            this.btn_TaoDon.Click += new System.EventHandler(this.btn_TaoDon_Click);
            // 
            // data_DSKhachHang
            // 
            this.data_DSKhachHang.AllowUserToResizeRows = false;
            this.data_DSKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_DSKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_DSKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_DSKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DSKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_DSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_DSKhachHang.DefaultCellStyle = dataGridViewCellStyle5;
            this.data_DSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_DSKhachHang.EnableHeadersVisualStyles = false;
            this.data_DSKhachHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.data_DSKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_DSKhachHang.Location = new System.Drawing.Point(0, 221);
            this.data_DSKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_DSKhachHang.Name = "data_DSKhachHang";
            this.data_DSKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DSKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.data_DSKhachHang.RowHeadersWidth = 62;
            this.data_DSKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_DSKhachHang.RowTemplate.Height = 28;
            this.data_DSKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_DSKhachHang.Size = new System.Drawing.Size(1066, 400);
            this.data_DSKhachHang.TabIndex = 41;
            this.data_DSKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_DSKhachHang_CellClick);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1066, 141);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1066, 621);
            this.Controls.Add(this.data_DSKhachHang);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "fKhachHang";
            this.Text = "fKhachHang";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSKhachHang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberTextBox textBox_TimKiem;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton btn_TimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.MaterialButton btn_TaoDon;
        private ReaLTaiizor.Controls.PoisonDataGridView data_DSKhachHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}