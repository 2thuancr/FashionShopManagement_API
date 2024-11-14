namespace GUI
{
    partial class FSuaCa
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
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaCa = new System.Windows.Forms.Label();
            this.comboBox_MaCa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Blue;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Luu.Location = new System.Drawing.Point(149, 208);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(114, 38);
            this.btn_Luu.TabIndex = 14;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Enabled = false;
            this.txt_TenNhanVien.Location = new System.Drawing.Point(169, 109);
            this.txt_TenNhanVien.Multiline = true;
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(200, 33);
            this.txt_TenNhanVien.TabIndex = 11;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(31, 122);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(132, 20);
            this.lblMaNV.TabIndex = 10;
            this.lblMaNV.Text = "Tên Nhân Viên:";
            // 
            // lblMaCa
            // 
            this.lblMaCa.AutoSize = true;
            this.lblMaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCa.Location = new System.Drawing.Point(37, 68);
            this.lblMaCa.Name = "lblMaCa";
            this.lblMaCa.Size = new System.Drawing.Size(65, 20);
            this.lblMaCa.TabIndex = 8;
            this.lblMaCa.Text = "Mã Ca:";
            // 
            // comboBox_MaCa
            // 
            this.comboBox_MaCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MaCa.FormattingEnabled = true;
            this.comboBox_MaCa.Location = new System.Drawing.Point(169, 60);
            this.comboBox_MaCa.Name = "comboBox_MaCa";
            this.comboBox_MaCa.Size = new System.Drawing.Size(200, 28);
            this.comboBox_MaCa.TabIndex = 16;
            // 
            // FSuaCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(406, 285);
            this.Controls.Add(this.comboBox_MaCa);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_TenNhanVien);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblMaCa);
            this.Name = "FSuaCa";
            this.Text = "FSuaCa";
            this.Load += new System.EventHandler(this.FSuaCa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaCa;
        private System.Windows.Forms.ComboBox comboBox_MaCa;
    }
}