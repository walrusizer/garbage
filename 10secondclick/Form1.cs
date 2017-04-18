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
        bool over = true;
        int keys;
        double bpm;

        public Form1()
        {
            InitializeComponent();
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
            timeRemaining = 10;
            timeDownDisplay.Text = timeRemaining.ToString("0.00");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            kps++;
            kpsText.Text = "KPS: " + kps;
            kpsThing();
            keys++;
            if (10 - timeRemaining != 0)
            {
                bpm = Math.Round((keys * 15) / (10 - timeRemaining));
                bpmText.Text = "BPM: " + bpm;
            }
            if (over == false)
            {
                keysText.Text = "Keys Presed: " + keys;
            }
            if (clicked)
            {
                clicked = false;
                over = false;
                timerThing();
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
            startButton.Text = "Click!";
            if (over)
            {
                timeRemaining = 10;
                clicked = true;
                keys = 0;
            }
        }
    }
}
