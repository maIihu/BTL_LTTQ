using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public static class RoundedControlHelper
    {
        public static void SetRoundedCorners(Control control, int borderRadius, bool topLeft = true, bool topRight = true, bool bottomLeft = false, bool bottomRight = false)
        {
            GraphicsPath path = new GraphicsPath();

            if (topLeft)
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            }
            else
            {
                path.AddLine(0, 0, 0, borderRadius);
            }

            if (topRight)
            {
                path.AddArc(control.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            }
            else
            {
                path.AddLine(control.Width, 0, control.Width, borderRadius);
            }

            if (bottomRight)
            {
                path.AddArc(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            }
            else
            {
                path.AddLine(control.Width, control.Height, control.Width - borderRadius, control.Height);
            }

            if (bottomLeft)
            {
                path.AddArc(0, control.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            }
            else
            {
                path.AddLine(0, control.Height, 0, control.Height - borderRadius);
            }

            path.CloseAllFigures();

            control.Region = new Region(path);
        }
    }
}
