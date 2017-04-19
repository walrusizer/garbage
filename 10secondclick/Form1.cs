using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10secondclick
{
    public partial class Form1 : Form
    {
        int kps;
        double timeRemaining = 10;
        bool clicked = false;
        bool over = false;
        bool reset = false;
        bool currentlyRunning = false;
        double avgKps;
        int keys;
        double bpm;
        int maxKPS;

        public Form1()
        {
            InitializeComponent();
        }

        public void text()
        {
            keysText.Text = "Keys pressed: " + keys;
            bpmText.Text = "BPM: " + bpm;
            mKpsT.Text = "Max KPS: " + maxKPS;
        }

        public async Task kpsThing()
        {
            await Task.Delay(1000);
            kps--;
            kpsText.Text = "KPS: " + kps;
        }

        public async Task timeDown()
        {
            await Task.Delay(110);
            timeRemaining -= .11;
            timeDownDisplay.Text = Math.Round(timeRemaining, 2).ToString("0.00");
        }

        private void kpsText_Click(object sender, EventArgs e)
        {

        }

        public async Task timerThing()
        {
            for (int i = 0; i < 91; i++)
            {
                await timeDown();
            }
            over = true;
            startButton.Text = "Reset";
            timeRemaining = 10;
            currentlyRunning = false;
            timeDownDisplay.Text = timeRemaining.ToString("0.00");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (clicked)
            {
                currentlyRunning = true;
                timerThing();
            }
            if (kps > maxKPS)
            {
                maxKPS = kps;
                mKpsT.Text = "Max KPS: " + maxKPS;
            }
            if (currentlyRunning)
            {
                over = false;
                clicked = false;
                kps++;
                kpsText.Text = "KPS: " + kps;
                kpsThing();
                keys++;
                if (10 - timeRemaining != 0)
                {
                    bpm = Math.Round((keys * 15) / (10 - timeRemaining));
                    bpmText.Text = "BPM: " + bpm;
                }
                if (!over)
                {
                    keysText.Text = "Keys Presed: " + keys;
                }
            }
        }

        private void timeDownDisplay_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
           
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            startButton.Text = "Begin!";
            clicked = true;
            if (over)
            {
                clicked = true;
                startButton.Text = "Reset";
            }
            if (startButton.Text == "Reset")
            {
                keys = 0;
                bpm = 0;
                avgKps = 0;
                kps = 0;
                maxKPS = 0;
                timeRemaining = 10;
                text();
                startButton.Text = "Start!";
            }
        }
    }
}
