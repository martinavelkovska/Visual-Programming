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

namespace _2kol_2022
{
    public partial class Form1 : Form
    {
        Scene scene;
        Timer addBallTimer;

        Ball blackBall;
        public int TimerTicks { get; set; }

        public bool flag = false;

        public bool Started { get; set; } = false;
        public Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            DoubleBuffered = true;

            timer1.Interval = 100;
            //  timer1.Start();
            паузаToolStripMenuItem.Text = "Старт";

            addBallTimer = new Timer();
            addBallTimer.Interval = 1000;
            addBallTimer.Tick += AddBallTimer_Tick;
           // addBallTimer.Start();

            


        }
        private void AddBallTimer_Tick(object sender, EventArgs e)
        {
            scene.Ball(new Ball(random.Next(0, Width), random.Next(0, Height), this.Width, this.Height));
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == false)
            {
                blackBall = new Ball(0, 0, this.Width, this.Height) { color = Color.Black };
                scene.addBall(blackBall);
                
                flag = true;
                Invalidate();
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scene.addBall(new Ball(78, 6, this.Width, this.Height));
            scene.addBall(new Ball(20, 82, this.Width, this.Height));
            scene.addBall(new Ball(20, 82, this.Width, this.Height));
            Invalidate();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
            scene.Move();
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (blackBall != null)
            {
                blackBall.Center = new Point(e.X, e.Y);
           

                Invalidate();
            }
        }

        private void serializeScene(string path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, scene);
            file.Close();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = saveFileDialog.FileName;
                serializeScene(path);
            }
        }
        private void deserializeScene(String path)
        {
            FileStream filestream = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = (Scene)formatter.Deserialize(filestream);
            filestream.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog.FileName;
                deserializeScene(path);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            Invalidate();
        }

        private void паузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Started = !Started;

            if (Started)
            {
                timer1.Start();
                addBallTimer.Start();
                // startTime = DateTime.Now;
                blackBall?.Move();
                blackBall?.IncreaseRadius();
                паузаToolStripMenuItem.Text = "Пауза";

            }
            else
            {
                timer1.Stop();
                addBallTimer.Stop();
               // blackBall.Move();
                паузаToolStripMenuItem.Text = "Старт";
            }

        }
    }
}
