
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FlyWeight.Busness
{
    public class CharacterFactory
    {
        private static Dictionary<char, Character> _character=new Dictionary<char,Character>();
        private static CharacterFactory glyphsfactory = new CharacterFactory();

        public CharacterFactory()
        {

        }
        public static CharacterFactory getInstance()
        {
            return glyphsfactory;
        }
        public Character GetCharacter(char c)
        {

            if (_character == null || !_character.ContainsKey(c))
            {
                //新建对象
                //string name = "FlyWeight.Busness" + "." +
                //              "Character" + c.ToString();
                //character = Activator.CreateInstance(
                //    Type.GetType(name)) as Character;
                Character character = new Character(c);
                _character.Add(c, character);
            }

            return _character[c];
        }

    }


}

