using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FlyWeight.Busness
{
    public class PositionFactory
    {
        private static PositionFactory positionFactory = new PositionFactory();
        private Hashtable positionTable = new Hashtable();
        static PositionFactory()
        {

        }
        public static PositionFactory getInstance()
        {
            return positionFactory;
        }
        public Position GetPosition(int X, int Y)
        {
            string key = X.ToString() + "|" + Y.ToString();
            if (positionTable == null || !positionTable.ContainsKey(key))
            {
                Position position = new Position(X, Y);
                positionTable.Add(key, position);
            }

            return (Position)positionTable[key]; ;
        }

    }

}

