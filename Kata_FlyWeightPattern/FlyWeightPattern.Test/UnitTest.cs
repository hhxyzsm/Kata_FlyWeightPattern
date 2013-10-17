using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using FlyWeight.Busness;
namespace FlyWeightPattern.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestFlyWeightBusness()
        {

            IList<CharacterTest> expect = new List<CharacterTest>();
            IList<CharacterTest> actuals = new List<CharacterTest>();
            expect = ExpectData();
            actuals = ActualData();

            for (int i = 0; i < expect.Count; i++)
            {

                Assert.AreEqual(expect[i]._c.ToString(), actuals[i]._c.ToString());
                Assert.AreEqual(expect[i].Color.Name.ToString(), actuals[i].Color.Name.ToString());
                Assert.AreEqual(expect[i].X, actuals[i].X);
                Assert.AreEqual(expect[i].Y, actuals[i].Y);
            }

        }

        private IList<CharacterTest> ActualData()
        {
            IList<CharacterTest> actuals = new List<CharacterTest>();
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
                    if (j + (i * 40) <= 98)
                    {
                        character = characterFactory.GetCharacter(characters[j + (i * 40)]);
                        position = positionFactory.GetPosition(i, j);
                        setColor(character, i, j);
                        actuals.Add(new CharacterTest(character.Alphabet, character.Color, position.X, position.Y));
                    }
                }

            }

            return actuals;
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

        private IList<CharacterTest> ExpectData()
        {
            IList<CharacterTest> expect = new List<CharacterTest>();
            expect.Add(new CharacterTest('D', Color.Black, 0, 0));
            expect.Add(new CharacterTest('o', Color.Black, 0, 1));
            expect.Add(new CharacterTest(' ', Color.Black, 0, 2));
            expect.Add(new CharacterTest('n', Color.Black, 0, 3));
            expect.Add(new CharacterTest('o', Color.Black, 0, 4));
            expect.Add(new CharacterTest('t', Color.Black, 0, 5));
            expect.Add(new CharacterTest(' ', Color.Black, 0, 6));

            expect.Add(new CharacterTest('d', Color.Red, 0, 7));
            expect.Add(new CharacterTest('w', Color.Red, 0, 8));
            expect.Add(new CharacterTest('e', Color.Red, 0, 9));
            expect.Add(new CharacterTest('l', Color.Red, 0, 10));
            expect.Add(new CharacterTest('l', Color.Red, 0, 11));
            expect.Add(new CharacterTest(' ', Color.Black, 0, 12));

            expect.Add(new CharacterTest('i', Color.Black, 0, 13));
            expect.Add(new CharacterTest('n', Color.Black, 0, 14));
            expect.Add(new CharacterTest(' ', Color.Black, 0, 15));

            expect.Add(new CharacterTest('t', Color.Black, 0, 16));
            expect.Add(new CharacterTest('h', Color.Black, 0, 17));
            expect.Add(new CharacterTest('e', Color.Black, 0, 18));
            expect.Add(new CharacterTest(' ', Color.Black, 0, 19));

            expect.Add(new CharacterTest('p', Color.Orange, 0, 20));
            expect.Add(new CharacterTest('a', Color.Orange, 0, 21));
            expect.Add(new CharacterTest('s', Color.Orange, 0, 22));
            expect.Add(new CharacterTest('t', Color.Orange, 0, 23));
            expect.Add(new CharacterTest(',', Color.Black, 0, 24));
            expect.Add(new CharacterTest(' ', Color.Black, 0, 25));
            expect.Add(new CharacterTest('d', Color.Black, 0, 26));
            expect.Add(new CharacterTest('o', Color.Black, 0, 27));
            expect.Add(new CharacterTest(' ', Color.Black, 0, 28));

            expect.Add(new CharacterTest('n', Color.Black, 0, 29));
            expect.Add(new CharacterTest('o', Color.Black, 0, 30));
            expect.Add(new CharacterTest('t', Color.Black, 0, 31));
            expect.Add(new CharacterTest(' ', Color.Black, 0, 32));

            expect.Add(new CharacterTest('d', Color.Yellow, 0, 33));
            expect.Add(new CharacterTest('r', Color.Yellow, 0, 34));
            expect.Add(new CharacterTest('e', Color.Yellow, 0, 35));
            expect.Add(new CharacterTest('a', Color.Yellow, 0, 36));
            expect.Add(new CharacterTest('m', Color.Yellow, 0, 37));
            expect.Add(new CharacterTest(' ', Color.Black, 0, 38));
            expect.Add(new CharacterTest(' ', Color.Black, 0, 39));
            expect.Add(new CharacterTest('o', Color.Black, 1, 0));
            expect.Add(new CharacterTest('f', Color.Black, 1, 1));
            expect.Add(new CharacterTest(' ', Color.Black, 1, 2));

            expect.Add(new CharacterTest('t', Color.Black, 1, 3));
            expect.Add(new CharacterTest('h', Color.Black, 1, 4));
            expect.Add(new CharacterTest('e', Color.Black, 1, 5));
            expect.Add(new CharacterTest(' ', Color.Black, 1, 6));

            expect.Add(new CharacterTest('f', Color.Green, 1, 7));
            expect.Add(new CharacterTest('u', Color.Green, 1, 8));
            expect.Add(new CharacterTest('t', Color.Green, 1, 9));
            expect.Add(new CharacterTest('u', Color.Green, 1, 10));
            expect.Add(new CharacterTest('r', Color.Green, 1, 11));
            expect.Add(new CharacterTest('e', Color.Green, 1, 12));
            expect.Add(new CharacterTest(',', Color.Black, 1, 13));
            expect.Add(new CharacterTest(' ', Color.Black, 1, 14));
            expect.Add(new CharacterTest('c', Color.Blue, 1, 15));
            expect.Add(new CharacterTest('o', Color.Blue, 1, 16));
            expect.Add(new CharacterTest('n', Color.Blue, 1, 17));
            expect.Add(new CharacterTest('c', Color.Blue, 1, 18));
            expect.Add(new CharacterTest('e', Color.Blue, 1, 19));
            expect.Add(new CharacterTest('n', Color.Blue, 1, 20));
            expect.Add(new CharacterTest('t', Color.Blue, 1, 21));
            expect.Add(new CharacterTest('r', Color.Blue, 1, 22));
            expect.Add(new CharacterTest('a', Color.Blue, 1, 23));
            expect.Add(new CharacterTest('t', Color.Blue, 1, 24));
            expect.Add(new CharacterTest('e', Color.Blue, 1, 25));
            expect.Add(new CharacterTest(' ', Color.Black, 1, 26));

            expect.Add(new CharacterTest('t', Color.Black, 1, 27));
            expect.Add(new CharacterTest('h', Color.Black, 1, 28));
            expect.Add(new CharacterTest('e', Color.Black, 1, 29));
            expect.Add(new CharacterTest(' ', Color.Black, 1, 30));
            expect.Add(new CharacterTest('m', Color.Indigo, 1, 31));
            expect.Add(new CharacterTest('i', Color.Indigo, 1, 32));
            expect.Add(new CharacterTest('n', Color.Indigo, 1, 33));
            expect.Add(new CharacterTest('d', Color.Indigo, 1, 34));
            expect.Add(new CharacterTest(' ', Color.Black, 1, 35));
            expect.Add(new CharacterTest('o', Color.Black, 1, 36));
            expect.Add(new CharacterTest('n', Color.Black, 1, 37));
            expect.Add(new CharacterTest(' ', Color.Black, 1, 38));
            expect.Add(new CharacterTest(' ', Color.Black, 1, 39));
            expect.Add(new CharacterTest('t', Color.Black, 2, 0));
            expect.Add(new CharacterTest('h', Color.Black, 2, 1));
            expect.Add(new CharacterTest('e', Color.Black, 2, 2));
            expect.Add(new CharacterTest(' ', Color.Black, 2, 3));
            expect.Add(new CharacterTest('p', Color.Black, 2, 4));
            expect.Add(new CharacterTest('r', Color.Black, 2, 5));
            expect.Add(new CharacterTest('e', Color.Black, 2, 6));
            expect.Add(new CharacterTest('s', Color.Black, 2, 7));
            expect.Add(new CharacterTest('e', Color.Black, 2, 8));
            expect.Add(new CharacterTest('n', Color.Black, 2, 9));
            expect.Add(new CharacterTest('t', Color.Black, 2, 10));
            expect.Add(new CharacterTest(' ', Color.Black, 2, 11));
            expect.Add(new CharacterTest('m', Color.Violet, 2, 12));
            expect.Add(new CharacterTest('o', Color.Violet, 2, 13));
            expect.Add(new CharacterTest('m', Color.Violet, 2, 14));
            expect.Add(new CharacterTest('e', Color.Violet, 2, 15));
            expect.Add(new CharacterTest('n', Color.Violet, 2, 16));
            expect.Add(new CharacterTest('t', Color.Violet, 2, 17));
            expect.Add(new CharacterTest('.', Color.Black, 2, 18));

            return expect;
        }
    }
}
