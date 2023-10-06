using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kol_2022
{
    [Serializable]
    public class Scene
    {
        List<Ball> balls;

        public Scene()
        {
            balls = new List<Ball>();

        }

    
        public void addBall(Ball b)
        {
            balls.Add(b);
        }

        public void Draw(Graphics g)
        {

            foreach (Ball ball in balls)
            {

                ball.Draw(g);
            }
        }

        public void Move()
        {
            foreach (Ball ball in balls)
            {

                ball.Move();

                if(ball.color == Color.Black) {
                    foreach (Ball otherBall in balls)
                    {
                        if (otherBall != ball)
                        {
                            ball.collision(otherBall);
                        }
                    }

                }
            }
            balls.RemoveAll(ball => ball.color == Color.Transparent);
        }



    }
}
