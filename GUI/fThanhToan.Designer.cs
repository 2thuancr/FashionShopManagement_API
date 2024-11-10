namespace GUI
{
    partial class fThanhToan
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
            this.picture_QRCode = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Done = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_Huy = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture_QRCode)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_QRCode
            // 
            this.picture_QRCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture_QRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_QRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_QRCode.Location = new System.Drawing.Point(0, 0);
            this.picture_QRCode.Name = "picture_QRCode";
            this.picture_QRCode.Size = new System.Drawing.Size(518, 676);
            this.picture_QRCode.TabIndex = 4;
            this.picture_QRCode.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Huy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Done, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 676);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 67);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // btn_Done
            // 
            this.btn_Done.AutoSize = false;
            this.btn_Done.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Done.BackColor = System.Drawing.Color.Crimson;
            this.btn_Done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Done.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btn_Done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Done.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Done.Depth = 0;
            this.btn_Done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Done.HighEmphasis = true;
            this.btn_Done.Icon = null;
            this.btn_Done.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_Done.Location = new System.Drawing.Point(6, 9);
            this.btn_Done.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_Done.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Done.Size = new System.Drawing.Size(247, 49);
            this.btn_Done.TabIndex = 22;
            this.btn_Done.Text = "Xong";
            this.btn_Done.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Done.UseAccentColor = true;
            this.btn_Done.UseVisualStyleBackColor = false;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
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
            this.btn_Huy.Location = new System.Drawing.Point(265, 9);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_Huy.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Huy.Size = new System.Drawing.Size(247, 49);
            this.btn_Huy.TabIndex = 23;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Huy.UseAccentColor = false;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // fThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 743);
            this.Controls.Add(this.picture_QRCode);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "fThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.fThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_QRCode)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_QRCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialButton btn_Huy;
        private ReaLTaiizor.Controls.MaterialButton btn_Done;
    }
}