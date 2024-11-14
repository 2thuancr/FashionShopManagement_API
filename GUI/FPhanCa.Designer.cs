namespace GUI
{
    partial class FPhanCa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.data_CaLamViec = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNgayLam = new System.Windows.Forms.Label();
            this.label_MaNV = new System.Windows.Forms.Label();
            this.label_MaCa = new System.Windows.Forms.Label();
            this.btn_XoaCa = new System.Windows.Forms.Button();
            this.btn_SuaCa = new System.Windows.Forms.Button();
            this.btn_ThemCa = new System.Windows.Forms.Button();
            this.date_NgayLam = new System.Windows.Forms.DateTimePicker();
            this.textBox_MaNV = new System.Windows.Forms.TextBox();
            this.textBox_MaCa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_CaLamViec)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 653);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.data_CaLamViec, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.61103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.38898F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 653);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // data_CaLamViec
            // 
            this.data_CaLamViec.BackgroundColor = System.Drawing.Color.MistyRose;
            this.data_CaLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_CaLamViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_CaLamViec.Location = new System.Drawing.Point(3, 84);
            this.data_CaLamViec.Name = "data_CaLamViec";
            this.data_CaLamViec.ReadOnly = true;
            this.data_CaLamViec.RowHeadersVisible = false;
            this.data_CaLamViec.RowHeadersWidth = 51;
            this.data_CaLamViec.Size = new System.Drawing.Size(1028, 374);
            this.data_CaLamViec.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 75);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelNgayLam);
            this.panel3.Controls.Add(this.label_MaNV);
            this.panel3.Controls.Add(this.label_MaCa);
            this.panel3.Controls.Add(this.btn_XoaCa);
            this.panel3.Controls.Add(this.btn_SuaCa);
            this.panel3.Controls.Add(this.btn_ThemCa);
            this.panel3.Controls.Add(this.date_NgayLam);
            this.panel3.Controls.Add(this.textBox_MaNV);
            this.panel3.Controls.Add(this.textBox_MaCa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 186);
            this.panel3.TabIndex = 3;
            // 
            // labelNgayLam
            // 
            this.labelNgayLam.AutoSize = true;
            this.labelNgayLam.Location = new System.Drawing.Point(728, 31);
            this.labelNgayLam.Name = "labelNgayLam";
            this.labelNgayLam.Size = new System.Drawing.Size(74, 20);
            this.labelNgayLam.TabIndex = 19;
            this.labelNgayLam.Text = "Ngày làm";
            // 
            // label_MaNV
            // 
            this.label_MaNV.AutoSize = true;
            this.label_MaNV.Location = new System.Drawing.Point(484, 31);
            this.label_MaNV.Name = "label_MaNV";
            this.label_MaNV.Size = new System.Drawing.Size(57, 20);
            this.label_MaNV.TabIndex = 18;
            this.label_MaNV.Text = "Mã NV";
            // 
            // label_MaCa
            // 
            this.label_MaCa.AutoSize = true;
            this.label_MaCa.Location = new System.Drawing.Point(196, 31);
            this.label_MaCa.Name = "label_MaCa";
            this.label_MaCa.Size = new System.Drawing.Size(55, 20);
            this.label_MaCa.TabIndex = 17;
            this.label_MaCa.Text = "Mã Ca";
            // 
            // btn_XoaCa
            // 
            this.btn_XoaCa.BackColor = System.Drawing.Color.Crimson;
            this.btn_XoaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaCa.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_XoaCa.Location = new System.Drawing.Point(751, 108);
            this.btn_XoaCa.Name = "btn_XoaCa";
            this.btn_XoaCa.Size = new System.Drawing.Size(109, 47);
            this.btn_XoaCa.TabIndex = 16;
            this.btn_XoaCa.Text = "Xóa Ca";
            this.btn_XoaCa.UseVisualStyleBackColor = false;
            // 
            // btn_SuaCa
            // 
            this.btn_SuaCa.BackColor = System.Drawing.Color.Blue;
            this.btn_SuaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaCa.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_SuaCa.Location = new System.Drawing.Point(456, 108);
            this.btn_SuaCa.Name = "btn_SuaCa";
            this.btn_SuaCa.Size = new System.Drawing.Size(109, 47);
            this.btn_SuaCa.TabIndex = 15;
            this.btn_SuaCa.Text = "Sửa Ca";
            this.btn_SuaCa.UseVisualStyleBackColor = false;
            this.btn_SuaCa.Click += new System.EventHandler(this.btn_SuaCa_Click);
            // 
            // btn_ThemCa
            // 
            this.btn_ThemCa.BackColor = System.Drawing.Color.Blue;
            this.btn_ThemCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemCa.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ThemCa.Location = new System.Drawing.Point(168, 108);
            this.btn_ThemCa.Name = "btn_ThemCa";
            this.btn_ThemCa.Size = new System.Drawing.Size(109, 47);
            this.btn_ThemCa.TabIndex = 14;
            this.btn_ThemCa.Text = "Thêm Ca";
            this.btn_ThemCa.UseVisualStyleBackColor = false;
            // 
            // date_NgayLam
            // 
            this.date_NgayLam.Location = new System.Drawing.Point(660, 60);
            this.date_NgayLam.Name = "date_NgayLam";
            this.date_NgayLam.Size = new System.Drawing.Size(200, 26);
            this.date_NgayLam.TabIndex = 13;
            // 
            // textBox_MaNV
            // 
            this.textBox_MaNV.Location = new System.Drawing.Point(456, 60);
            this.textBox_MaNV.Name = "textBox_MaNV";
            this.textBox_MaNV.Size = new System.Drawing.Size(100, 26);
            this.textBox_MaNV.TabIndex = 12;
            // 
            // textBox_MaCa
            // 
            this.textBox_MaCa.Location = new System.Drawing.Point(168, 60);
            this.textBox_MaCa.Name = "textBox_MaCa";
            this.textBox_MaCa.Size = new System.Drawing.Size(100, 26);
            this.textBox_MaCa.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Androgyne", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(342, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý Ca Làm Việc";
            // 
            // FPhanCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 653);
            this.Controls.Add(this.panel1);
            this.Name = "FPhanCa";
            this.Text = "FPhanCa";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_CaLamViec)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView data_CaLamViec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNgayLam;
        private System.Windows.Forms.Label label_MaNV;
        private System.Windows.Forms.Label label_MaCa;
        private System.Windows.Forms.Button btn_XoaCa;
        private System.Windows.Forms.Button btn_SuaCa;
        private System.Windows.Forms.Button btn_ThemCa;
        private System.Windows.Forms.DateTimePicker date_NgayLam;
        private System.Windows.Forms.TextBox textBox_MaNV;
        private System.Windows.Forms.TextBox textBox_MaCa;
        private System.Windows.Forms.Label label1;
    }
}