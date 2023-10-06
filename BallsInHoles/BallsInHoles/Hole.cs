using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    public class Hole
    {
        public static int RADIUS = 30;

        public Point Center { get; set; }

        public int Count { get; set; }

        public Hole(Point center) { 
        
            Center = center;
            Count = 0;
        }

        public void Draw(Graphics g, Font font)
        {
            Brush b = new SolidBrush(Color.Black);
            Brush fontbrush = new SolidBrush(Color.White);

            g.FillEllipse(b, Center.X - RADIUS, Center.Y -RADIUS, RADIUS*2, RADIUS*2);
            g.DrawString(string.Format("{0}", Count), font, fontbrush, Center.X - 10, Center.Y - 10);

            b.Dispose();

        }

        public bool Touches(int x, int y) // dali se preklopuvaat crnite topki
        {
            return (x - Center.X) * (x - Center.X) + (y - Center.Y) * (y - Center.Y) <= RADIUS * RADIUS;
        }
    }
}
