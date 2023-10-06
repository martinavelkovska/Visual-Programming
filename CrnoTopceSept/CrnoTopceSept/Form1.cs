using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrnoTopceSept
{
    public partial class Form1 : Form
    {
        Scene Scene;

        Random random = new Random();
        Color color;

        bool Started = false;

        Ball blackBall;

        bool flag = false;
        int timerTick;
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            for (int i = 0; i < 3; i++)
            {
                Scene.AddBall(new Ball(random.Next(0, Width), random.Next(0, Height), this.Width, this.Height, Color.Red));
            }
            timer1.Interval = 100;
            timer1.Stop();
             timerTick = 0;

           // Started = false;
         

            DoubleBuffered = true;
          //  InitializeScene();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          /*  for (int i = 0; i < 3; i++)
            {
                Scene.AddBall(new Ball(random.Next(0, Width), random.Next(0, Height), this.Width, this.Height, Color.Red));
            }
            Invalidate();*/
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
           Scene.Move(); 
            timerTick++; 
            if (timerTick % 10 == 0)
            {
                Scene.AddBall(new Ball(random.Next(0, Width), random.Next(0, Height), this.Width, this.Height, Color.Red));
            }

            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if (flag == false)
            {
                blackBall = new Ball(0 , 0, this.Width, this.Height, Color.Black);
                Scene.AddBall(blackBall);
                flag = true;
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (blackBall != null)
            {
                blackBall.Center = new Point(e.X, e.Y);
               foreach (var redBall in Scene.Balls)
                {
                    if (blackBall != redBall)
                    {
                        blackBall.checkCollison(redBall);
                    }
                }
            //  blackBall.Move();
                Invalidate();
            }
        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Started = !Started;
            if (Started)
            {
                timer1.Start();
             //   blackBall?.Move();
                стартToolStripMenuItem.Text = "Пауза";

            }
            else if(!Started)
            {
                timer1.Stop();
               // blackBall?.Move();
                стартToolStripMenuItem.Text = "Старт";
            }
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void serialize(String path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create);

            IFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fileStream, Scene);
            fileStream.Close();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if(saveFile.ShowDialog() == DialogResult.OK) { 
            String path = saveFile.FileName;
                serialize(path);
            }
        }

        private void deserialize(String path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();

            Scene = (Scene) formatter.Deserialize(fileStream);
            fileStream.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                String path = openFile.FileName;
                deserialize(path);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            Scene = new Scene();
            Ball.RADIUS = 15;
            for (int i = 0; i < 3; i++)
            {
                Scene.AddBall(new Ball(random.Next(0, Width), random.Next(0, Height), this.Width, this.Height, Color.Red));
            }

            blackBall = null;
            flag = false;
            Invalidate();
        }
    }
}
