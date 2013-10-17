using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Design;
using System.Drawing;
namespace FlyWeight.Busness
{
    public  class Character
    {
        public Color Color { get; set; }
        private char alphabet;

        public Character(char c)
        {
            this.alphabet = c;
            this.Color = Color.Black;
        }

        public Character()
        {

        }
        public char Alphabet
        {
            get { return alphabet; }
            private set { alphabet = value; }
        }

    }
}
