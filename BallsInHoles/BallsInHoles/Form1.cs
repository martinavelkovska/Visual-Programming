using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHoles
{
    public partial class Form1 : Form
    {

        Scene Scene;
        Color currentColor;
        Timer timer;

        //ovie se za pravoagolniko
        int leftX;
        int topY;
        int width;
        int height;

        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            currentColor = Color.Red;
            DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            leftX = 20;
            topY = 60;
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.MoveBalls(leftX, topY, width, height);
            Scene.CheckCollisions();
            toolStripStatusLabel1.Text = string.Format("# Balls: {0}", Scene.balls.Count);
            Invalidate();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.AddBall(new Ball(e.Location, currentColor));
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 3); // za pravoagolnikot
            e.Graphics.DrawRectangle(pen, leftX, topY, width, height);
            pen.Dispose();
            Scene.Draw(e.Graphics);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
            {
                currentColor = color.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene();
            Invalidate();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene.GenerateHoles(leftX, topY, width, height);
        }



        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("# Balls: {0}", Scene.balls.Count);
        }

        private void serializeScene(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, Scene);
            fileStream.Close();
        }

        private void deserializeScene(string path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            Scene = (Scene)formatter.Deserialize(file);
            file.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = saveFileDialog.FileName;
                serializeScene(path);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                String path = openFileDialog.FileName;
                deserializeScene(path);
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
        }


    }
}
