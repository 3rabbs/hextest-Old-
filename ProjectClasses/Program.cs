// C# program to print Hello World! 
using System;
using System.IO;
using System.Xml.Linq;
using ProjectClasses;

// namespace declaration 
namespace ProjectClasses
{

    // Class declaration 
    class Program
    {

        // Main Method 
        static void Main(string[] args)
        {
            //FileHandler.initialize(args);
            FileHandler.create_newWorldDirectory(new string[] { "world_template" });





            Console.WriteLine("Remarks Complete");
        }


    }
}
