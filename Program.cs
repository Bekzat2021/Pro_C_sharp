using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(1, 2, 3);
            Vector vector2 = new Vector(3, 3, 3);

            Vector vector3 = vector1 + vector2;
            Console.WriteLine($" {vector1.X} {vector1.Y} {vector1.Z}");
            Console.WriteLine($"+{vector2.X} {vector2.Y} {vector2.Z}");
            Console.WriteLine("------");
            Console.WriteLine($" {vector3.X} {vector3.Y} {vector3.Z}");

            Console.WriteLine();

            vector3 = vector1 - vector2;
            Console.WriteLine($" {vector1.X} {vector1.Y} {vector1.Z}");
            Console.WriteLine($"-{vector2.X} {vector2.Y} {vector2.Z}");
            Console.WriteLine("------");
            Console.WriteLine($" {vector3.X} {vector3.Y} {vector3.Z}");

            vector1.X = 2;
            vector1.Y = 0;
            vector1.Z = 4;

            vector3 = -vector1;

            Console.WriteLine();

            Console.WriteLine($" {vector3.X} {vector3.Y} {vector3.Z}");

            Console.WriteLine();

            vector1.X = 1;
            vector1.Y = 2;
            vector1.Z = 3;

            vector3 = vector1 * 4;
            Console.WriteLine($" {vector1.X} {vector1.Y} {vector1.Z}");
            Console.WriteLine("x 4");
            Console.WriteLine("------");
            Console.WriteLine($" {vector3.X} {vector3.Y} {vector3.Z}");

            Console.WriteLine();

            vector1.X = 4;
            vector1.Y = 8;
            vector1.Z = 13;

            vector3 = vector1 / 2;
            Console.WriteLine($" {vector1.X} {vector1.Y} {vector1.Z}");
            Console.WriteLine("/ 4");
            Console.WriteLine("------");
            Console.WriteLine($" {vector3.X} {vector3.Y} {vector3.Z}");
        }
    }
}
