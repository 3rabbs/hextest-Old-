using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClasses;

namespace ProjectClasses
{
    public class Debugger
    {
        public static void toString_intArr(int[,] intsArr)
        {
            Console.WriteLine("");
            for (int i = 0; i < intsArr.GetLength(0); i++)
            {
                for (int j = 0; j < intsArr.GetLength(1); j++)
                {
                    Console.Write(" " + intsArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }
    }



}