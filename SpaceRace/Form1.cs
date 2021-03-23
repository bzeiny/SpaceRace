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
//Bilal Zeineddine
//March 23, 2021
//This exhilerating space race is a 2 player thriller, beat your friends to the top and get 3 points for victory!


{
    public partial class spaceRace : Form
    {
        //Set variables
        string gameState = "waiting";
        bool wPress;
        bool sPress;
        bool upPress;
        bool downPress;

        int player1Score = 0;
        int player2Score = 0;
        int counter1 = 0;
        int counter2 = 0;

        Random randGen = new Random();
        int randValue = 0;
        int asteroidSpeed = 6;
        int asteroidSize = 7;

        string player1Name;
        string player2Name;
            
        Pen playerPen = new Pen(Color.White, 10);
        SolidBrush playerBrush = new SolidBrush(Color.White);
        Pen obstaclePen = new Pen(Color.White, 10);
        SolidBrush obstacleBrush = new SolidBrush(Color.White);

        int player1X = 50;
        int player1Y = 350;
        int player2X = 450;
        int player2Y = 350;
        int playerSpeed = 8;
        int playerSize = 20;



        List<int> asteroidLeftRightX = new List<int>();
        List<int> asteroidLeftRightY = new List<int>();

        List<int> asteroidRightLeftX = new List<int>();
        List<int> asteroidRightLeftY = new List<int>();
        public spaceRace()
        {
            InitializeComponent();
        }

        public void GameInitialize()
        //Initialize/Start game function - turning off labels, resetting player positions, enabling timer. Reset scores.
        {
            titleLabel.Text = "";
            subLabel.Text = "";
            gameTimer.Enabled = true;
            gameState = "running"; ;

            asteroidLeftRightX.Add(0);
            asteroidLeftRightY.Add(250);

            asteroidRightLeftX.Add(this.Width);
            asteroidRightLeftY.Add(180);

            player1Y = 350;
            player2Y = 350;

            player1X = this.Width / 4 - playerSize;
            player2X = 465;
            score1.Text = "";
            score2.Text = "";       
        }
        private void spaceRace_KeyUp(object sender, KeyEventArgs e)
        {
            //When the keys are not being pressed
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPress = false;
                    break;
                case Keys.S:
                    sPress = false;
                    break;
                case Keys.Up:
                    upPress = false;
                    break;
                case Keys.Down:
                    downPress = false;
                    break;
            }
        }

        private void spaceRace_KeyDown(object sender, KeyEventArgs e)
        {
            //When the following keys are down, set the press methods to true
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPress = true;
                    break;
                case Keys.S:
                    sPress = true;
                    break;
                case Keys.Up:
                    upPress = true;
                    break;
                case Keys.Down:
                    downPress = true;
                    break;
                case Keys.Space:
                    if (gameState == "waiting" || gameState == "over" || gameState == "player1Win" || gameState == "player2Win")
                    {
                        GameInitialize();
                        gameState = "running";
                    }
                    break;
                case Keys.Escape:
                    if (gameState == "waiting" || gameState == "over" || gameState == "player1Win" || gameState == "player2Win")
                    {
                        Application.Exit();
                    }
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (wPress == true && player1Y > 0)
            {
                player1Y -= playerSpeed;
            }
            if (sPress == true && player1Y < this.Height - playerSize * 3)
            {
                player1Y += playerSpeed;
            }
            if (upPress == true && player2Y > 0)
            {
                player2Y -= playerSpeed;
            }
            if (downPress == true && player2Y < this.Height - playerSize * 3)
            {
                player2Y += playerSpeed;
            }

            if (player1Y <= 15)
            {
                player1Y = this.Height - playerSize * 3;
                counter1++;
                player1Score++;
                score1.Text = $"{player1Score}";
                SoundPlayer player = new SoundPlayer(Properties.Resources.point);
                player.Play();
            }
            if (player2Y <= 15)
            {
                player2Y = this.Height - playerSize * 3;
                counter2++;
                player2Score++;
                score2.Text = $"{player2Score}";
                SoundPlayer player = new SoundPlayer(Properties.Resources.point);
                player.Play();
            }
            if (player1Score == 3)
            {
                gameTimer.Enabled = false;
                gameState = "player1Win";
                SoundPlayer player = new SoundPlayer(Properties.Resources.w);
                player.Play();
            }
            if (player2Score == 3)
            {
                gameTimer.Enabled = false;
                gameState = "player2Win";
                SoundPlayer player = new SoundPlayer(Properties.Resources.w);
                player.Play();
            }
            for (int i = 0; i < asteroidLeftRightX.Count(); i++)
            {
                asteroidLeftRightX[i] += asteroidSpeed;
            }
            for (int i = 0; i < asteroidRightLeftX.Count(); i++)
            {
                asteroidRightLeftX[i] -= asteroidSpeed;
            }


            //Create rectangles for player 1 and player 2, aswell as rectangles for asteroids. Check for collisions, and if so, reset ships back to original position
            Rectangle player1Rec = new Rectangle(player1X, player1Y, playerSize, playerSize);
            Rectangle player2Rec = new Rectangle(player2X, player2Y, playerSize, playerSize);
            for (int i = 0; i < asteroidLeftRightX.Count(); i++)
            {
                Rectangle asteroidRec = new Rectangle(asteroidLeftRightX[i], asteroidLeftRightY[i], asteroidSize, asteroidSize);
                if (player1Rec.IntersectsWith(asteroidRec))
                {
                    player1Y = 350;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.ouch);
                    player.Play();
                }
                else if (player2Rec.IntersectsWith(asteroidRec))
                {
                    player2Y = 350;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.ouch);
                    player.Play();
                }
            }

            for (int i = 0; i < asteroidRightLeftX.Count(); i++)
            {
                Rectangle asteroid2Rec = new Rectangle(asteroidRightLeftX[i], asteroidRightLeftY[i], asteroidSize, asteroidSize);
                if (player1Rec.IntersectsWith(asteroid2Rec))
                {
                    player1Y = 350;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.ouch);
                    player.Play();
                }
                else if (player2Rec.IntersectsWith(asteroid2Rec))
                {
                    player2Y = 350;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.ouch);
                    player.Play();
                }

                //Create random value in order to determine where asteroids spawn in 

            }
            randValue = randGen.Next(0, 101);
            if (randValue < 7)
            {
                asteroidLeftRightX.Add(0);
                asteroidLeftRightY.Add(randGen.Next(0, 300));

                asteroidRightLeftX.Add(this.Width);
                asteroidRightLeftY.Add(randGen.Next(0, 300));
            }
            Refresh();
        }

        private void spaceRace_Paint(object sender, PaintEventArgs e)
        {
            if (gameState == "waiting")
            {
                titleLabel.Text = "BALL CATCH";
                subLabel.Text = "Press Space Bar to Start or Escape to Exit";
            }
            else if (gameState == "player1Win")
            {
                titleLabel.Text = "WINNER: PLAYER 1";
                subLabel.Text = "\nPress Space Bar to Play Again or Escape to Exit";
            }
            else if (gameState == "player2Win")
            {
                titleLabel.Text = "WINNER: PLAYER 2";
                subLabel.Text = "\nPress Space Bar to Play Again or Escape to Exit";
            }

            else if (gameState == "running")
            {
                e.Graphics.FillRectangle(playerBrush, player1X, player1Y, playerSize, playerSize);
                e.Graphics.FillRectangle(playerBrush, player2X, player2Y, playerSize, playerSize);
                e.Graphics.FillRectangle(obstacleBrush, this.Width / 2, 0, 9, 390);
            }
            for (int i = 0; i < asteroidLeftRightX.Count(); i++)
            {
                e.Graphics.FillRectangle(obstacleBrush, asteroidLeftRightX[i], asteroidLeftRightY[i], asteroidSize, asteroidSize);
            }
            for (int i = 0; i < asteroidRightLeftX.Count(); i++)
            {
                e.Graphics.FillRectangle(obstacleBrush, asteroidRightLeftX[i], asteroidRightLeftY[i], asteroidSize, asteroidSize);
            }



        }
    }
}
