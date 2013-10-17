using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Design;
using System.Drawing;
namespace FlyWeightPattern.Test
{
    public class CharacterTest
    {
        public CharacterTest(char p, Color color,int x,int y)
        {
            // TODO: Complete member initialization
            this._c = p;
            this.Color = color;
            this.X = x;
            this.Y = y;

        }
        public Color Color { get; set; }
        public char _c { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
