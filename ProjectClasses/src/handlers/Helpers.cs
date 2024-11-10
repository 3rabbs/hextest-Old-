using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public struct HexCoords
    {
        public HexCoords(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        public override string ToString() => $"({X}, {Y}, {Z})";
    }

    public struct TileCoords
    {
        public TileCoords(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        public override string ToString() => $"({X}, {Y}, {Z})";
    }

    


    public class Helpers
    {

        public static int diceRoll(int numDice, int numVal, int modifer)
        {
            int outcome = 0;
            Random rand = new Random();
            for (int i = 0; i < numDice; i++)
            {
                outcome = outcome + rand.Next(1, numVal + 1) + modifer;
            }

            return outcome;
        }
    }
}
