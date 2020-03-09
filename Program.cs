using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball firstBall = new Ball(15, new Color(125, 50, 60));

            firstBall.Throw();
            firstBall.Throw();
            firstBall.Throw();
            firstBall.Pop();

            Ball secondBall = new Ball(12, new Color(55, 70, 99));
            Color theSecondBallColor = secondBall.GetColor();

            Console.WriteLine(theSecondBallColor.Alpha);
            Console.WriteLine(theSecondBallColor.Red);
            Console.WriteLine(theSecondBallColor.Green);
            Console.WriteLine(theSecondBallColor.Blue);
        }
    }
}
