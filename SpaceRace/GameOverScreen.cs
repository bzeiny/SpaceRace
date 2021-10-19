using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceRace
{
    public partial class GameOverScreen : UserControl
    {
        Boolean spaceArrowDown, escArrowDown;
        public GameOverScreen()
        {
            InitializeComponent();
        }
     
        //If player wants to restart, send it back to game screeen
        private void restartLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
        }

        private void restartLabel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceArrowDown = true;
                    break;
                case Keys.Escape:
                    escArrowDown = true;
                    break;          
            }
          
            if (spaceArrowDown == true)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);
            }
            else if (escArrowDown == true)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                MainScreen ms = new MainScreen();
                f.Controls.Add(ms);
            }
          
        }

        private void restartLabel_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceArrowDown = false;
                    break;
                case Keys.Escape:
                    escArrowDown = false;
                    break;
            }
        }

        //Display which player won the game
        private void GameOverScreen_Load(object sender, EventArgs e)
        {
       
        }

        //If the player does not wish to play again, send them back to the main screen which has the option of quitting.
        private void backButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
