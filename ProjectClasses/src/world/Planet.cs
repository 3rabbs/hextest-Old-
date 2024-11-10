using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    internal class Planet
    {
        public String name;
        public String description;
        public String worldTypeGeo;
        public Hex[,] worldHexMap;

        
        public Planet(String[] args) {
            worldHexMap = new Hex[50, 50];
            GenHex("default");

 
        }

        public void GenHex(String data)
        {
            int[,] perlin = new int[worldHexMap.GetLength(0), worldHexMap.GetLength(1)];

            if (data.Equals("default")) {
                for (int i = 0; i <= worldHexMap.GetLength(0); i++) {
                    for (int j = 0; j <= worldHexMap.GetLength(1); j++) { 
                        
                    
                    
                    }
                }
            
            
            }


        }

        
    }
}
