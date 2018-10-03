using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(gonnaFlyNow, rocket1);
            ThreadPool.QueueUserWorkItem(gonnaFlyNow, rocket2);
            ThreadPool.QueueUserWorkItem(gonnaFlyNow, rocket5);
            ThreadPool.QueueUserWorkItem(gonnaFlyNow, rocket4);
            ThreadPool.QueueUserWorkItem(gonnaFlyNow, rocket3);
        }

        public void gonnaFlyNow(object pb)
        {
            PictureBox rocket = pb as PictureBox;
            while (rocket.Location.Y >= 0)
            {
                Thread.Sleep(10);
                Random rnd = new Random((int)Stopwatch.GetTimestamp());

                rocket.Invoke(new Action(() =>
                {
                    rocket.Location = new Point(rocket.Location.X, rocket.Location.Y - rnd.Next(1, 5));
                }));
                
            }
            shedule.Invoke(new Action(() =>
            {
                shedule.Items.Add(rocket.Name);
            }));
        }
    }
}
