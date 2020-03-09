using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Color
    {
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = 255;
        }

        public byte Red { get; set; }

        public byte Green { get; set; }

        public byte Blue { get; set; }

        public byte Alpha { get; set; }

        public int GetGrayScale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}
