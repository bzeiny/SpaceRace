using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SpaceRace
{
    class spaceships
    {
        public int x, y, size, speed;

        public spaceships(int _x, int _y, int _size, int _speed)
        {
            //Take the previous _x, _y, _size, _speed and _brush value and turn them into regular x,y,size,speed,brush values
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
        }
        
        public void movePlayer()
        {
            y -= speed;
        }
    }
}
