using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static int[] playFieldSquare = new int[9];

        static void Main(string[] args)
        {
            RenderAPlayField(1);
        }

        static void RenderAPlayField(int sector)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" "+playFieldSquare[i]);
                if (i == 2)
                {
                    continue;
                }
                Console.Write(" |");
            }
            Console.WriteLine();
            Console.WriteLine("---+---+---");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" " + playFieldSquare[i]);
                if (i == 2)
                {
                    continue;
                }
                Console.Write(" |");
            }
            Console.WriteLine();
            Console.WriteLine("---+---+---");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" " + playFieldSquare[i]);
                if (i == 2)
                {
                    continue;
                }
                Console.Write(" |");
            }
            Console.WriteLine();
        }
    }
}
