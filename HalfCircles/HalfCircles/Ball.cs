using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    [Serializable]
    public class Ball
    {
        public static int RADIUS = 30;

        

        public Point Center { get; set; }

       public Color ColorFirst { get; set; } = Color.Red;

        public Color ColorSecond { get; set; }

        public int Size { get; set; }

        private double coef = 1.1; // 10% growth per pulse

        public int OriginalSize { get; set; }

        public Ball(Color color, int size, Point center)
        {
            ColorFirst = color != default ? color : Color.Red;
            ColorSecond = Color.FromArgb(255 - ColorFirst.R, 255- ColorFirst.G, 255 - ColorFirst.B);
            OriginalSize = size;
            Size = size;
            Center = center;
        }

        public void Draw(Graphics g)
        {

            Brush b = new SolidBrush(ColorFirst);
            Brush b2 = new SolidBrush(ColorSecond);
            int x = Center.X - Size;
            int y = Center.Y - Size;
            int diameter = Size * 2;

            g.FillPie(b, x, y , diameter, diameter, 0, 180);
            g.FillPie(b2, x, y, diameter, diameter, 180, 180);
            b.Dispose();
            b2.Dispose();
        }


        public void Pulse()
        {
            Size = (int)Math.Round(Size * coef);
           

            if (Size >=  OriginalSize * 2)
            {
                Size = OriginalSize;
            }
        }

    }
}
