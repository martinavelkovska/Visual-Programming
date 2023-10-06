using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrnoTopceSept
{

    [Serializable]
    public class Scene
    {

       public List<Ball> Balls { get; set; } = new List<Ball>();
    
        public Scene() { }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void Move()
        {
            foreach (Ball b in Balls)
            {

                if (b.Color != Color.Black)
                {

                    b.Move();
                }


                if(b.Color == Color.Black)
                {
                    foreach(Ball other  in Balls)
                    {
                        if(other != b)
                        {
                            b.checkCollison(other);
                        }
                    }
                }
            }

            Balls.RemoveAll(b => b.Color == Color.Transparent);
        }
        public void Draw(Graphics graphics)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(graphics);
            }
        }
       
    }
}
