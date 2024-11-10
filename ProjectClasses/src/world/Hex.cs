using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualBasic.FileIO;
using ProjectClasses;

namespace ProjectClasses
{
    public class Hex
    {
        public String name;
        public String terrain;
        public String biome;
        public HexCoords hexCoord;
        public int genClimate;
        public int civStat;
        List<Settlement> locSettlements = new List<Settlement>();


        /**     ARGS Format:
         *      [0] Hex Name (example: "Forest of Kalameet"
         *      [1] Terrain ("Dense Forest")
         *      [2] Biome ("Temperate)
         *      [3] Hex Coordinates ("3,4,5")
         *      [4] General Climate in Fahrenheit ("70")
         *      [5] Civilized Statistic, from 0 to 16 ("3")
         *      [6] 
         * 
         * 
         **/
        public Hex(string[] args)
        {
            this.name = args[0];
            this.terrain = args[1];
            this.biome = args[2];
            string[] coords = args[3].Split(",");
            this.hexCoord = new HexCoords(Convert.ToInt32(coords[0]), Convert.ToInt32(coords[1]), Convert.ToInt32(coords[2]));     
        }

        /**     ARGS Format:
         *      [0] Hex Name (example: "Forest of Kalameet"
         *      [1] Terrain ("Dense Forest")
         *      [2] Biome ("Temperate)
         *      [3] Hex Coordinates ("3,4,5")
         *      [4] General Climate in Fahrenheit ("70")
         *      [5] Civilized Statistic, from 0 to 16 ("3")
         *      [6] 
         * 
         * 
         **/
        static Hex neighborFetch(String[] args)
        {

            return new Hex(args);
        }
    }
}
