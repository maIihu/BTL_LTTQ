using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.CustomDesign
{
    public class CustomDateTimePicker : Panel
    {
        private DateTimePicker dateTimePicker;

        public CustomDateTimePicker()
        {
            this.BackColor = Color.LightBlue; // Màu nền của Panel
            this.Padding = new Padding(1); // Tạo chút khoảng cách viền

            dateTimePicker = new DateTimePicker
            {
                Dock = DockStyle.Fill,
                Format = DateTimePickerFormat.Short
            };

            // Thêm DateTimePicker vào Panel
            this.Controls.Add(dateTimePicker);
        }

        // Để thay đổi màu nền thông qua thuộc tính BackgroundColor
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
    }
}
