using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeBoozt.Classes
{
    class Snake
    {
        private Point position = new Point(0, 0);

        public List<int> Body { get; private set; }
        public int Speed { get; set; }
        public bool IsAlive { get; set; }
        public Point Direction { get; private set; }

        public Snake(int speed = 3)
        {
            Body.Add(1);
            Speed = speed;
            IsAlive = true;
            Direction = new Point(1,1);
        }

        public void AddBodyPart(int part)
        {
            Body.Add(part);
        }

        public void RemoveBodyPrat(int index)
        {
            if(index > 0 && index < Body.Count())
            {
                // Bygg vidare på sedan
            }
        }

        public void Move(int dirX = 0, int dirY = 0)
        {
            if (dirX == 0 || dirY == 0)
            {
                dirX = this.Direction.X;
                dirY = this.Direction.Y;
            }
            else
            {
                this.Direction = new Point(dirX, dirY);
            }

            position.X = dirX * Speed;
            position.Y = dirY * Speed;
        }
    }
}
