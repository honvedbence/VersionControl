using Het6.Abstarctions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Het6.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }

        public Present(Color box, Color ribbon)
        {
            AutoSize = false;
            Height = 50;
            Width = 50;
            Paint += Present_Paint;
            BoxColor = new SolidBrush(box);
            RibbonColor = new SolidBrush(ribbon);
        }

        private void Present_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, 0, Height/2-Height/10, Width, Height/5);
            g.FillRectangle(RibbonColor, Width/2-Width/10, 0, Width/5, Height);

        }
    }
}
