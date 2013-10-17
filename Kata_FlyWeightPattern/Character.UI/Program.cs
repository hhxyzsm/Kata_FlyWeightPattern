using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlyWeight.Busness;
using System.Drawing;

namespace FlyWeight.Busness
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Data = "Do not dwell in the past, do not dream  of the future, concentrate the mind on  the present moment.";
            char[] characters = new char[120];
            characters = Data.ToCharArray();
            CharacterFactory characterFactory = CharacterFactory.getInstance();
            PositionFactory positionFactory = PositionFactory.getInstance();
            Character character;
            Position position;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if ((j + (i * 40)) <= 98)
                    {
                        character = characterFactory.GetCharacter(characters[j + (i * 40)]);
                        position = positionFactory.GetPosition(i, j);
                        setColor(character, i, j);
                        Console.WriteLine("{0}[{1}]({2},{3})", character.Alphabet, character.Color.Name.ToString(), position.X, position.Y);
                    }
                }
            }
            Console.ReadKey();
        }

        private static void setColor(Character character, int i, int j)
        {
            if (j + (i * 40) >= 7 && j + (i * 40) <= 11)
            {
                character.Color = Color.Red;
            }
            else if (j + (i * 40) >= 20 && j + (i * 40) <= 23)
            {
                character.Color = Color.Orange;
            }
            else if (j + (i * 40) >= 33 && j + (i * 40) <= 37)
            {
                character.Color = Color.Yellow;
            }
            else if (j + (i * 40) >= 47 && j + (i * 40) <= 52)
            {
                character.Color = Color.Green;
            }
            else if (j + (i * 40) >= 55 && j + (i * 40) <= 65)
            {
                character.Color = Color.Blue;
            }
            else if (j + (i * 40) >= 71 && j + (i * 40) <= 74)
            {
                character.Color = Color.Indigo;
            }
            else if (j + (i * 40) >= 92 && j + (i * 40) <= 97)
            {
                character.Color = Color.Violet;
            }
            else
            {
                character.Color = Color.Black;
            }
        } 
    }
}

