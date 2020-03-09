using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ball
    {
        private int size;
        private Color color;
        private int thrownTimes;

        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
        }

        public void Pop()
        {
            size = 0;
            Console.WriteLine("Ball size will popped and it now is 0.");
        }

        public void Throw()
        {
            if (size==0)
            {
                Console.WriteLine("Can't throw the ball because size is equal to 0.");
            }
            else if( size > 0)
            {
                thrownTimes++;
                Console.WriteLine($"The ball throwed. Total:{thrownTimes}");
            }
        }

        public Color GetColor()
        {
            return color;
        }
    }
}
