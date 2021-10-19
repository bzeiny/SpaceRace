using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SpaceRace
{
    class asteroid
    {
        // Create a brush and ints for the asteroids x, y, size and speed
        public int x, y, size, speed;
        public SolidBrush brush;
        
        public asteroid(int _x, int _y, int _size, int _speed, SolidBrush _brush)
        {
         //Take the previous _x, _y, _size, _speed and _brush value and turn them into regular x,y,size,speed,brush values
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            brush = _brush;
        }

        //Move the asteroids right to left
        public void Move()
        {
            x += speed;
        }

        public bool Collision(spaceships s)
            //Create rectangles for the asteroid and player, and if they intersect, return a true or false value
        {
            Rectangle asteroidRec = new Rectangle(x, y, size, size);
            Rectangle playerRec = new Rectangle(s.x, s.y, s.size, s.size);

            if (asteroidRec.IntersectsWith(playerRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


    
}
