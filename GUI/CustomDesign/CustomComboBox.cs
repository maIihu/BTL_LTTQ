using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.CustomDesign
{
    public class CustomComboBox : ComboBox
    {
        private int _opacity = 100;

        [Browsable(true)] // Hiển thị trong bảng Properties
        [Category("Custom Appearance")] // Đặt vào một danh mục trong bảng Properties
        [Description("Sets the background color of the dropdown arrow.")]

        private Color arrowBackGround = Color.White;

        public Color ArrowBackGround
        {
            get { return arrowBackGround; }
            set
            {
                arrowBackGround = value;
                this.Invalidate();
            }
        }
        public int Opacity
        {
            get { return _opacity; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _opacity = value;
                    this.Invalidate();  // Vẽ lại ComboBox khi thay đổi opacity
                }
            }
        }

        public CustomComboBox()
        {
            // Bật chế độ vẽ tùy chỉnh cho ComboBox
            this.SetStyle(ControlStyles.UserPaint, true);
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Vẽ nền với opacity tùy chỉnh
            Color bgColor = Color.FromArgb((int)(_opacity * 2.55), this.BackColor);
            e.Graphics.FillRectangle(new SolidBrush(bgColor), this.ClientRectangle);

            // Vẽ text trong ComboBox nếu có mục được chọn
            if (this.SelectedIndex >= 0)
            {
                RectangleF textRect = new RectangleF(2, (this.Height - this.Font.Height) / 2, this.Width - 24, this.Height - 4);
                e.Graphics.DrawString(this.Items[this.SelectedIndex].ToString(), this.Font, Brushes.Black, new RectangleF(2, 2, this.Width - 20, this.Height - 4));
                
            }

            // Vẽ mũi tên thả xuống
            DrawDropDownButton(e.Graphics);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Vẽ lại từng mục trong danh sách ComboBox
            if (e.Index >= 0)
            {
                Color bgColor = Color.FromArgb((int)(_opacity * 2.55), this.BackColor);
                e.Graphics.FillRectangle(new SolidBrush(bgColor), e.Bounds);
                e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
            }
        }

        private void DrawDropDownButton(Graphics g)
        {
            // Xác định kích thước và vị trí của nút mũi tên
            Rectangle rect = new Rectangle(this.Width - 20, 2, 18, this.Height - 4);

            g.FillRectangle(new SolidBrush(arrowBackGround), rect);

            // Tạo điểm cho mũi tên thả xuống
            Point[] arrowPoints = new Point[]
            {
        new Point(rect.X + rect.Width / 2 - 5, rect.Height / 2 - 3),
        new Point(rect.X + rect.Width / 2 + 5, rect.Height / 2 - 3),
        new Point(rect.X + rect.Width / 2, rect.Height / 2 + 3)
            };

            // Vẽ mũi tên
            g.FillPolygon(Brushes.Black, arrowPoints);
        }

    }
}
