using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 20;  // Độ bo tròn của góc
        public int BorderThickness { get; set; } = 2; // Độ dày của đường viền
        public Color BorderColor { get; set; } = Color.Blue; // Màu của border

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Chống nhòe khi vẽ
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Tạo GraphicsPath để vẽ bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            int radius = BorderRadius;

            // Thêm các góc bo tròn vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Góc trên trái
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Góc trên phải
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Góc dưới phải
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Góc dưới trái
            path.CloseFigure();

            // Tô màu nền cho panel
            e.Graphics.FillPath(new SolidBrush(this.BackColor), path);

            // Vẽ border nếu có BorderThickness
            if (BorderThickness > 0)
            {
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }

}
