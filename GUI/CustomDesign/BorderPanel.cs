using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI.CustomDesign
{
    public class BorderPanel : Panel
    {
        // Thuộc tính để tùy chỉnh bán kính góc bo
        public int CornerRadius { get; set; } = 20;

        // Thuộc tính để tùy chỉnh màu viền
        public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));

        // Thuộc tính để tùy chỉnh độ dày của viền
        public float BorderThickness { get; set; } = 0.5f;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = CornerRadius; // Sử dụng CornerRadius do người dùng đặt
            Graphics g = e.Graphics;

            // Bật chế độ AntiAlias để làm mượt các góc bo tròn
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            // Thêm các góc bo vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Đặt vùng của panel thành vùng bo góc
            this.Region = new Region(path);

            // Vẽ đường viền bo góc với màu BorderColor và độ dày BorderThickness
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                g.DrawPath(pen, path);
            }
        }
    }
}
