using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Tree1
{
    class Draw
    {
        public static void Edge(Graphics g, int x1, int y1, int x2, int y2)
        {
            g.DrawLine(Pens.Black, x1, y1, x2, y2);
        }
        public static void Node(Graphics g, int x, int y, Node p)
        {
            Font f = new Font("TimeNewRoman", 15F);
            SizeF sz = g.MeasureString(Convert.ToString(p.value), f);
            g.DrawString(p.value, f, Brushes.Black, x - sz.Width / 2, y - sz.Height / 2);
        }
        public static void Ellipse(Graphics g, int x, int y, Node p)
        {
            Font f = new Font("TimeNewRoman", 15F);
            SizeF sz = g.MeasureString(Convert.ToString(p.value), f);
            g.FillEllipse(Brushes.LightBlue, x - sz.Width / 2, y - sz.Width / 2, sz.Width, sz.Width);
            g.DrawEllipse(Pens.GreenYellow, x - sz.Width / 2, y - sz.Width / 2, sz.Width, sz.Width);
        }
    }
}
