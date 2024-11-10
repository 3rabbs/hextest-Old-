using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class Perlin
    {
        public static int[,] gen_WhiteNoise(int[,] map, int min, int max)
        {
            var rand = new Random();
            
            for (int i = 0; i < map.GetLength(0); i++) { 
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = rand.Next(min, max);
                }
            }
            return map;
        }
    }

    
}
