using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kol_2022
{
    [Serializable]
     public enum BallDirection
    {
        Left,
        Right,
        Up,
        Down

    }
    public class Ball
    {
       public Point Center { get; set; }
        public Color color { get; set; }

      //  public Point CenterBlac { get; set; }

        public static int RADIUS = 15;

        public static Random Random = new Random();

        public int ScreenWidth { get; set; }

        public int ScreenHeight { get; set; }

        public BallDirection Direction { get; set; } 
        public Ball(int X, int Y, int screenWidth, int screenHeight)
        {


            Center = new Point(Random.Next(X), Random.Next(Y));
            Direction = ( BallDirection) Random.Next(1, 4);
            ScreenHeight = screenHeight;
            ScreenWidth = screenWidth;
            color = Color.Red;
           // CenterBlac = new Point(Center.X, )

        }


      
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(color);

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

            if(Center.X + RADIUS >= ScreenWidth)
            {
                Direction = BallDirection.Left;
            }
            else if(Center.X - RADIUS <= 0)
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

        public void collision(Ball otherBall)
        {
            int distance = (int)Math.Sqrt(Math.Pow(Center.X - otherBall.Center.X, 2) + Math.Pow(Center.Y - otherBall.Center.Y, 2));

            if(distance <= RADIUS && this.color == Color.Black && otherBall.color == Color.Red) 
            {
                otherBall.color = Color.Transparent; // Make the red ball disappear
                RADIUS += 5; // Increase the radius of the black ball by 5
            }
        }

        public void IncreaseRadius()
        {
            if (color == Color.Black)
            {
                RADIUS += 5; // Increase the radius of the black ball by 1
            }
        }




    }
}
