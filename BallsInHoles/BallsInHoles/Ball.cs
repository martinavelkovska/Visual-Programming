using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    public class Ball
    {

       public Point Center { get; set; }

        public static int RADIUS = 25;

        public static Random Random = new Random();

        public bool IsInHole { get; set; }

        public double Velocity { get; set; }  //brzina se pridvizuva za 10 pikseli
        
        public double Angle { get; set; }

        private float velocityX;

        private float velocityY;



        public Color Color { get; set; }

        public Ball(Point center, Color color)
        {
            Center = center;
            Color = color;
            IsInHole = false;

            Velocity = 10;
            Angle = Random.NextDouble() * 2 * Math.PI;

            velocityX = (float) (Math.Cos(Angle) * Velocity);
            velocityY = (float)(Math.Sin(Angle) * Velocity);
        }

        public void Draw (Graphics g)
        {
            Brush brush = new SolidBrush (Color); // so bojata sho kje ja odberam od menu
            g.FillEllipse(brush, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            brush.Dispose();
        }

        public bool InHole(Hole hole) // DALI E vo dupkata topkata
        {
            float d = (Center.X - hole.Center.X) * (Center.X - hole.Center.X) + (Center.Y - hole.Center.Y) * (Center.Y - hole.Center.Y);
            return d <= RADIUS*RADIUS;
        }

        public void Move(int left, int top, int width, int height)
        {
            int nextX = (int) (Center.X + velocityX);
            int nextY =(int) (Center.Y + velocityY);
            int lft = left + width;
            int rgt = left + width - RADIUS;
            int tp = top + RADIUS;
            int btm = top + height - RADIUS;

            if(nextX <= lft)
            {
                nextX = lft + (lft - nextX);
                velocityX = -velocityY;


            }
            if(nextX >= rgt)
            {
                nextX = rgt - (nextX - rgt);
                velocityX = -velocityY;

            }
            if( nextY <= tp)
            {
                nextY = tp + (tp - nextY);
                velocityY = -velocityY;
            }
            if(nextY >= btm)
            {
                nextY = btm - (nextY - btm);
                velocityY = -velocityY;
            }
            Center = new Point(nextX, nextY);

        }

    }
}
