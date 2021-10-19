using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace SpaceRace
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        //If player quits, display thank you message and pause, then quit the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            spaceRaceLabel.Text = "Thanks for playing!";
            Refresh();
            Thread.Sleep(1500);
            Application.Exit();
        }

        //If player plays, go to the gamescreen
        private void startButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            SoundPlayer menuPlayer = new SoundPlayer(Properties.Resources.gameSound);
            menuPlayer.Play();
        }
    }
}
