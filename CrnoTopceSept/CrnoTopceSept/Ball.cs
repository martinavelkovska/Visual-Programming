using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrnoTopceSept
{
    [Serializable]
    public enum BallDirection
    {
        Up,
        Down,
        Left,
        Right
    }
    public class Ball
    {
        public static int RADIUS = 15;
        public Point Center { get; set; }
        
        public int ScreenWidth { get; set; }

        public int ScreenHeight { get; set; }

        public BallDirection Direction { get; set; }

        public Random Random { get; set; } = new Random();

        public Color Color { get; set; }

        public bool IsHit { get; set; }

  
        public Ball(int X, int Y, int screenWidth, int screenHeight, Color color)
        {
            Center = new Point(Random.Next(X), Random.Next(Y));
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
            Direction = (BallDirection)Random.Next(4);
            Color = color;
            // Color = Color.Red;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            b.Dispose();
        }

        public void Move()
        {
            int dx = 0;
            int dy = 0;

            switch (Direction)
            {

                case BallDirection.Left:
                    dx = -15;
                    break;
                case BallDirection.Right:
                    dx = 15;
                    break;
                case BallDirection.Up:
                    dy = -15;
                    break;
                case BallDirection.Down:
                    dy = 15;
                    break;

            }
            Center = new Point(Center.X + dx, Center.Y + dy);

            if (Center.X + RADIUS >= ScreenWidth)
            {
                Direction = BallDirection.Left;
            }
            else if (Center.X - RADIUS <= 0)
            {
                Direction = BallDirection.Right;
            }
            else if (Center.Y + RADIUS >= ScreenHeight)
            {
                Direction = BallDirection.Up;
            }
            else if (Center.Y - RADIUS <= 0)
            {
                Direction = BallDirection.Down;
            }
        }

        public void checkCollison(Ball otherBall)
        {
            int distance = (int)Math.Sqrt(Math.Pow(Center.X - otherBall.Center.X,2) + Math.Pow(Center.Y - otherBall.Center.Y,2));

            if(distance <= RADIUS && this.Color == Color.Black && otherBall.Color == Color.Red)
            {
                otherBall.Color = Color.Transparent;
                //RADIUS += 5;
                
                increaseRadius();


            }
        }

       public void increaseRadius()
        {
            if(Color == Color.Black)
            {
                RADIUS += 5;
            }
        }
    
    }
}
