using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace GUI.UC
{
    public partial class UCJobCard : UserControl
    {
        //[Browsable(true)]
        //[Category("Action")]
        //[Description("Invoked when user clicks button menu")]
        //public event EventHandler MenuClick;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button view")]
        public event EventHandler ViewClick;

        private Size defaultCardSize = new Size(300, 250);

        #region Fields
        private int id = 0;
        private int? ungTuyenId = 0;
        //private CongViec congViec;
        private Color cardBackground = Color.LightBlue;
        private Color buttonViewBackground = Color.Cornsilk;
        //private Color buttonMenuBackground = Color.LightCyan;
        private Color jobNameTextColor = SystemColors.Highlight;
        private Image bgImage;
        //private Image buttonViewImage;
        //private Image buttonMenuImage;
        #endregion Fields

        #region Properties
        public Size CardSize
        {
            get { return this.Size; }
        }

        public Size DefaultCardSize
        {
            get { return defaultCardSize; }
        }

        [Category("CUSTOMIZE DATA")]
        [DisplayName("ID")]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        [Category("CUSTOMIZE DATA")]
        [DisplayName("UngTuyen ID")]
        public int? UngTuyenId
        {
            get { return ungTuyenId; }
            set
            {
                ungTuyenId = value;
            }
        }

        //[Category("CUSTOMIZE DATA")]
        //[DisplayName("CongViec")]
        //public CongViec CongViec
        //{
        //    get { return congViec; }
        //    set
        //    {
        //        congViec = value;
        //        if (congViec != null)
        //        {
        //            this.label_TenCongViec.Text = congViec.Ten;
        //            this.label_TenCty.Text = congViec.TenCongTy;
        //            this.label_DiaDiem.Text = congViec.DiaDiem;
        //            this.label_MucLuong.Text = $"{congViec.MucLuong} đ";
        //        }
        //    }
        //}

        [Category("CUSTOMIZE UI")]
        [DisplayName("BackColor Card")]
        public Color CardBackground
        {
            get { return cardBackground; }
            set
            {
                if (value == null)
                {
                    value = Color.LightBlue;
                }
                cardBackground = value;
                this.pictureBox_Logo.BackColor = value;
                this.label_TenCty.BackColor = value;
                this.label_TenCongViec.BackColor = value;
                this.label_DiaDiem.BackColor = value;
                this.label_MucLuong.BackColor = value;
                // this.Invalidate();
            }
        }

   /*     [Category("CUSTOMIZE UI")]
        [DisplayName("BackColor View")]
        public Color ButtonViewBackground
        {
            get { return buttonViewBackground; }
            set
            {
                if (value == null)
                {
                    value = Color.Cornsilk;
                }
                buttonViewBackground = value;
                this.button_View.BackColor = buttonViewBackground;
                // this.Invalidate();
            }
        }*/

        //[Category("CUSTOMIZE UI")]
        //[DisplayName("BackColor Menu")]
        //public Color ButtonMenuBackground
        //{
        //    get { return buttonMenuBackground; }
        //    set
        //    {
        //        if (value == null)
        //        {
        //            value = Color.Azure;
        //        }
        //        buttonMenuBackground = value;
        //        this.button_Menu.BackColor = buttonMenuBackground;
        //        // this.Invalidate();
        //    }
        //}

        [Category("CUSTOMIZE UI")]
        [DisplayName("JobNameTextColor")]
        public Color JobNameTextColor
        {
            get { return jobNameTextColor; }
            set
            {
                if (value == null)
                {
                    value = Color.RoyalBlue;
                }
                jobNameTextColor = value;
                this.label_TenCongViec.ForeColor = jobNameTextColor;
                // this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        [DisplayName("Background Image")]
        public Image BgImage
        {
            get { return bgImage; }
            set
            {
                if (value == null)
                {
                    //value = Properties.Resources.default_cv;
                }
                bgImage = value;
                this.BackgroundImage = bgImage;
                // this.Invalidate();
            }
        }
        #endregion Properties

        public UCJobCard()
        {
            InitializeComponent();
            this.pictureBox_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            this.DoubleBuffered = true;
            this.AutoScaleMode = AutoScaleMode.None;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public Size ScaleSize(float scale)
        {
            var size = new Size((int)(defaultCardSize.Width * scale), (int)(defaultCardSize.Height * scale));
            this.Size = size;
            return size;
        }

        private void button_View_Click(object sender, EventArgs e)
        {

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            Rectangle gradientRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            Brush borderBrush = new LinearGradientBrush(gradientRectangle, Color.DarkSlateGray, Color.DarkSlateGray, 0.0f);
            Brush backgroundBrush = new LinearGradientBrush(gradientRectangle, Color.Azure, Color.Azure, 0.0f);

            graphics.SmoothingMode = SmoothingMode.HighQuality;
            //GuiHelper.FillRoundedRectangle(gradientRectangle, 10, graphics, backgroundBrush, borderBrush);

            this.BackColor = Color.Transparent;
        }

        private void label_TenCongViec_Click(object sender, EventArgs e)
        {
            if (ViewClick != null)
            {
                ViewClick(this, e);
            }
            else
            {
                //UCMessageBox.Show($"View id = {id}");
            }
        }
    }
}
