namespace GUI
{
    partial class fChiTietSanPham
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picture_SanPham = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_ChiTietSanPham = new ReaLTaiizor.Controls.CyberRichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_KichCo = new System.Windows.Forms.Label();
            this.label_SoLuong = new System.Windows.Forms.Label();
            this.label_LoaiSanPham = new System.Windows.Forms.Label();
            this.label_GiaSanPham = new System.Windows.Forms.Label();
            this.label_TenSanPham = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_SanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.08761F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.91239F));
            this.tableLayoutPanel1.Controls.Add(this.picture_SanPham, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(993, 624);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // picture_SanPham
            // 
            this.picture_SanPham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture_SanPham.BackgroundImage = global::GUI.Properties.Resources.ao_len_1;
            this.picture_SanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_SanPham.Location = new System.Drawing.Point(3, 3);
            this.picture_SanPham.Name = "picture_SanPham";
            this.picture_SanPham.Size = new System.Drawing.Size(401, 618);
            this.picture_SanPham.TabIndex = 0;
            this.picture_SanPham.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.textBox_ChiTietSanPham);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_KichCo);
            this.panel1.Controls.Add(this.label_SoLuong);
            this.panel1.Controls.Add(this.label_LoaiSanPham);
            this.panel1.Controls.Add(this.label_GiaSanPham);
            this.panel1.Controls.Add(this.label_TenSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(410, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 618);
            this.panel1.TabIndex = 1;
            // 
            // textBox_ChiTietSanPham
            // 
            this.textBox_ChiTietSanPham.Alpha = 20;
            this.textBox_ChiTietSanPham.BackColor = System.Drawing.Color.Transparent;
            this.textBox_ChiTietSanPham.Background_WidthPen = 4F;
            this.textBox_ChiTietSanPham.BackgroundPen = true;
            this.textBox_ChiTietSanPham.ColorBackground = System.Drawing.Color.MistyRose;
            this.textBox_ChiTietSanPham.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox_ChiTietSanPham.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_ChiTietSanPham.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_ChiTietSanPham.ColorPen_2 = System.Drawing.Color.White;
            this.textBox_ChiTietSanPham.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.textBox_ChiTietSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ChiTietSanPham.Font = new System.Drawing.Font("Arial", 11F);
            this.textBox_ChiTietSanPham.ForeColor = System.Drawing.Color.Black;
            this.textBox_ChiTietSanPham.Lighting = false;
            this.textBox_ChiTietSanPham.LinearGradientPen = false;
            this.textBox_ChiTietSanPham.Location = new System.Drawing.Point(0, 321);
            this.textBox_ChiTietSanPham.Name = "textBox_ChiTietSanPham";
            this.textBox_ChiTietSanPham.PenWidth = 10;
            this.textBox_ChiTietSanPham.RGB = false;
            this.textBox_ChiTietSanPham.Rounding = true;
            this.textBox_ChiTietSanPham.RoundingInt = 10;
            this.textBox_ChiTietSanPham.Size = new System.Drawing.Size(580, 297);
            this.textBox_ChiTietSanPham.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.textBox_ChiTietSanPham.TabIndex = 6;
            this.textBox_ChiTietSanPham.Tag = "Cyber";
            this.textBox_ChiTietSanPham.TextButton = "Vải chính 100% len";
            this.textBox_ChiTietSanPham.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.textBox_ChiTietSanPham.Timer_RGB = 300;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("SVN-Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(580, 48);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chi tiết sản phẩm:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_KichCo
            // 
            this.label_KichCo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_KichCo.Font = new System.Drawing.Font("SVN-Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KichCo.ForeColor = System.Drawing.Color.Sienna;
            this.label_KichCo.Location = new System.Drawing.Point(0, 225);
            this.label_KichCo.Name = "label_KichCo";
            this.label_KichCo.Size = new System.Drawing.Size(580, 48);
            this.label_KichCo.TabIndex = 4;
            this.label_KichCo.Text = "Kích cỡ: M/L/XL";
            this.label_KichCo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_SoLuong
            // 
            this.label_SoLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_SoLuong.Font = new System.Drawing.Font("SVN-Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoLuong.ForeColor = System.Drawing.Color.Sienna;
            this.label_SoLuong.Location = new System.Drawing.Point(0, 177);
            this.label_SoLuong.Name = "label_SoLuong";
            this.label_SoLuong.Size = new System.Drawing.Size(580, 48);
            this.label_SoLuong.TabIndex = 3;
            this.label_SoLuong.Text = "Số lượng: 121";
            this.label_SoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_LoaiSanPham
            // 
            this.label_LoaiSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_LoaiSanPham.Font = new System.Drawing.Font("SVN-Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoaiSanPham.ForeColor = System.Drawing.Color.Sienna;
            this.label_LoaiSanPham.Location = new System.Drawing.Point(0, 129);
            this.label_LoaiSanPham.Name = "label_LoaiSanPham";
            this.label_LoaiSanPham.Size = new System.Drawing.Size(580, 48);
            this.label_LoaiSanPham.TabIndex = 2;
            this.label_LoaiSanPham.Text = "Loại sản phẩm: Áo len";
            this.label_LoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_GiaSanPham
            // 
            this.label_GiaSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_GiaSanPham.Font = new System.Drawing.Font("SVN-Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GiaSanPham.ForeColor = System.Drawing.Color.Red;
            this.label_GiaSanPham.Location = new System.Drawing.Point(0, 81);
            this.label_GiaSanPham.Name = "label_GiaSanPham";
            this.label_GiaSanPham.Size = new System.Drawing.Size(580, 48);
            this.label_GiaSanPham.TabIndex = 1;
            this.label_GiaSanPham.Text = "1.000.000 VNĐ";
            this.label_GiaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TenSanPham
            // 
            this.label_TenSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_TenSanPham.Font = new System.Drawing.Font("SVN-Blog Script", 18F, System.Drawing.FontStyle.Bold);
            this.label_TenSanPham.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_TenSanPham.Location = new System.Drawing.Point(0, 0);
            this.label_TenSanPham.Name = "label_TenSanPham";
            this.label_TenSanPham.Size = new System.Drawing.Size(580, 81);
            this.label_TenSanPham.TabIndex = 0;
            this.label_TenSanPham.Text = "Áo len";
            this.label_TenSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 624);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "fChiTietSanPham";
            this.Text = "Chi tiết sản phẩm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_SanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_TenSanPham;
        private System.Windows.Forms.Label label_GiaSanPham;
        private System.Windows.Forms.Label label_KichCo;
        private System.Windows.Forms.Label label_SoLuong;
        private System.Windows.Forms.Label label_LoaiSanPham;
        private ReaLTaiizor.Controls.CyberRichTextBox textBox_ChiTietSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picture_SanPham;
    }
}