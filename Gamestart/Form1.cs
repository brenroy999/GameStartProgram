using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamestart
{
    public partial class GameStart : Form
    {
        public GameStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            startButton.Hide();
            Refresh();
            labelCountdown.Visible = true;
            labelCountdown.Text = "  3";
            Thread.Sleep(1000);
            Refresh();
            SoundPlayer player = new SoundPlayer(Properties.Resources.song207);
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            labelCountdown.Text = "  2";

            player.Play();
            Refresh();
            Thread.Sleep(1000);
            labelCountdown.Text = "  1";

            player.Play();
            Refresh();
            Thread.Sleep(1000);
            Refresh();
            labelCountdown.Text = "GO!!";
            SoundPlayer bouncePlayer = new SoundPlayer(Properties.Resources.song207);
            bouncePlayer.Play();
            Refresh();
            Thread.Sleep(1200);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
