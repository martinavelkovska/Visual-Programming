using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHoles
{
    [Serializable]
    public class Scene
    {
        public List<Ball> balls {  get; set; }

        public List<Hole> holes { get; set; }

        Random random;

        Font font;

        public Scene()
        {
            balls = new List<Ball>();
            holes = new List<Hole>();
            random = new Random();
            font = new Font("Arial", 20);
        }

        public void AddBall(Ball b)
        {
            balls.Add(b);
        }

        public void GenerateHoles (int left, int top, int width, int height)
        {
            holes = new List<Hole>();
            GenerateHolesR(left, top, width, height);
        }

        void GenerateHolesR(int left, int top, int width, int height)
        {
            if (holes.Count == 5) return;
            int x = random.Next(left +Hole.RADIUS, (left + width) - Hole.RADIUS);
            int y = random.Next(top + Hole.RADIUS,(top + height) - Hole.RADIUS);

            bool touches = false;

            foreach(Hole h in holes) // gi iziminuva site dupki
            {
                touches = h.Touches(x, y); // dali se dopiraat 
                if (touches) break;
            }
            if (!touches)
            {
                Hole h = new Hole(new Point(x, y));
                holes.Add(h);
            }
            GenerateHolesR(left, top, width, height);
        }

        public void Draw(Graphics g)
        {
            foreach(Hole h in holes) //crtanje dupki
            {
                h.Draw(g, font);
            }
            foreach(Ball b in balls) //crtanje topcinja
            {
                b.Draw(g);
            }
        }

        public void MoveBalls(int left, int top, int width, int height)
        {
            foreach (Ball ball in balls)
            {
                ball.Move(left, top, width, height);
            }
        }

        public void CheckCollisions()
        {
            for(int i = 0; i < balls.Count; i++) //izmunva topki
            {
                for(int j=0; j < holes.Count; j++) // izminuva dupki
                {
                    if (balls[i].InHole(holes[j])) //dali topkata e vo dupkata
                    {
                        balls[i].IsInHole = true; // true
                        holes[j].Count++; // broj na topki vo dupka se zgolemuva
                    }
                }


            }

            for (int i=balls.Count - 1; i>=0; i--) /// za da se izbrise topkata koja e vo dupkata
            {
                if (balls[i].IsInHole)
                {
                    balls.RemoveAt(i);
                }
            }
        }

    }
}
