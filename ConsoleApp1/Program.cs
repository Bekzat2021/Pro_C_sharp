using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer="";
            do
            {
                Console.WriteLine("Please enter the times you want roll a dice:");
                int count = Convert.ToInt32(Console.ReadLine());

                RollTheDice(count);

                Console.WriteLine("Repeat or stop? Enter(exit/quit): ");
                answer = Convert.ToString(Console.ReadLine());

            } while (answer != "exit" && answer != "quit");
            Console.ReadKey();
        }

        /// <summary>
        /// Roll the dice and show the result
        /// </summary>
        /// <returns>void</returns>
        static public void RollTheDice(int rollTimes)
        {
            Random random = new Random();

            for (int i = 0; i < rollTimes; i++)
            {
                int aRandomNumber = random.Next(1, 6);
                Console.WriteLine($"A random dice number: {aRandomNumber}.");
            }            
        }
    }
}
