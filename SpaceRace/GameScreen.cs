using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace SpaceRace
{
    public partial class GameScreen : UserControl
    {
        //Set initial values, create brushes, and public variables that will be used across classes and screens
        SolidBrush asteroidBrush = new SolidBrush(Color.White);
        SolidBrush playerBrush = new SolidBrush(Color.Red);
        int counter = 0;
        public int player1Score = 0;
        Random randGen = new Random();
        Pen drawPen = new Pen(Color.White);
        List<asteroid> asteroids = new List<asteroid>();
        Boolean nArrowDown, vArrowDown, wArrowDown, upArrowDown;
        string direction = "";
        spaceships s = new spaceships(125, 325, 9, 6);
        public GameScreen()
        {
            InitializeComponent();
            //Upon start, go to create asteroid 
            CreateAsteroid();
        }
        public void CreateAsteroid()
        {       
           //Find a random value between 1 and 4, and depending on said number, pick a colour of the summoned asteroid
            int colourValue = randGen.Next(1, 4);
            if (colourValue == 1)
            {
                asteroidBrush = new SolidBrush(Color.LightBlue);
            }
            else if (colourValue == 2)
            {
                asteroidBrush = new SolidBrush(Color.Purple);
            }
            else
            {
                asteroidBrush = new SolidBrush(Color.White);
            }
            //Get a random Y value for where the asteroid will spawn, and then add it to the list 
            int yValue = randGen.Next(5, 350);
            asteroid a = new asteroid(0,yValue,8, 10, asteroidBrush);
            asteroids.Add(a);

        }


        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
          //Arcade and keyboard controls, if pressed, return true value
            switch (e.KeyCode)
            {
                case Keys.N:
                    nArrowDown = true;
                    direction = "up";
                    break;
                case Keys.V:
                    vArrowDown = true;
                    direction = "up";
                    break;
                case Keys.W:
                    wArrowDown = true;
                    direction = "up";
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    direction = "up";
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.N:
                    nArrowDown = false;
                    direction = "";
                    break;
                case Keys.V:
                    vArrowDown = false;
                    direction = "";
                    break;
                case Keys.W:
                    wArrowDown = false;
                    direction = "";
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    direction = "";
                    break;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //If any of the "up" keys are pressed, move the player upwards
            if (direction == "up")
            {
                s.movePlayer();
            }
            //On the game timer tick, the counter will continually add by 1. Once it reaches 10, go to CreateAsteroid() then set counter back to 0
            counter++;
            foreach (asteroid a in asteroids)
            {
                a.Move();
            }        
            if (counter == 10)
            {
                CreateAsteroid();
                counter = 0;
            }
            //For each loop going to collision method in asteroid, if collision is true, return player to start point
            foreach (asteroid a in asteroids)
            {
             
               if (a.Collision(s) == true)
                {
                    SoundPlayer collisionPlayer = new SoundPlayer(Properties.Resources.collide);
                    collisionPlayer.Play();
                    s.y = 325;
                }
            }
            //If the player reaches the top of the screen, give it a point and return back to start point
            if (s.y < 5)
            {
                player1Score++;
                s.y = 325;
                player1ScoreLabel.Text = $"{player1Score}";
                SoundPlayer levelPlayer = new SoundPlayer(Properties.Resources.level);
                levelPlayer.Play();
            }

            //If the player reaches the score of 3, they win and are sent to the game over screen
            if (player1Score == 3)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
                GameTimer.Enabled = false;
            }
          
            Refresh();
        }
        //Paint the player, asteroids, halfway line
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(drawPen, this.Width / 2, 0, this.Width / 2, this.Height);
            e.Graphics.FillRectangle(playerBrush, s.x, s.y, s.size, s.size);
            foreach (asteroid a in asteroids)
            {
                e.Graphics.FillRectangle(a.brush, a.x, a.y, a.size, a.size);
            }
        }
    }
}
