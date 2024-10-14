using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomDesign
{
    [ToolboxItem(true)]
    public class CustomButton : Button
    {
        // Thuộc tính để tùy chỉnh màu viền
        public Color BorderColor { get; set; }

        // Thuộc tính để tùy chỉnh độ dày của viền
        public float BorderThickness { get; set; } = 1.5f;

        // Thuộc tính để tùy chỉnh màu nền
        public Color BackgroundColor { get; set; } = Color.White;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Vẽ hình chữ nhật cho button
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            // Vẽ màu nền
            using (SolidBrush backgroundBrush = new SolidBrush(BackgroundColor))
            {
                pevent.Graphics.FillRectangle(backgroundBrush, rect);
            }

            // Vẽ viền
            using (Pen borderPen = new Pen(BorderColor, BorderThickness))
            {
                pevent.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }

            // Vẽ chữ trên button
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, rect, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Không vẽ background để tránh bị trùng
        }
    }
}
