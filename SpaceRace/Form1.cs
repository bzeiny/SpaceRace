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
//October 18, 2021
//This exhilerating space race makes you dodge asteroids and race to the top to try and hit a score of 3!


{
    public partial class spaceRace : Form
    {

        public spaceRace()
        {
            InitializeComponent();
        }

        private void spaceRace_Load(object sender, EventArgs e)
        {
            //As soon as form loads, go to the game screen
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }

       
    }
}
