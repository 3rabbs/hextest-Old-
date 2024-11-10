using System;
using System.IO;
using System.Linq.Expressions;

namespace ProjectClasses
{
    /**     Info on FileHandler
     *          Filehandler is responsible for dealing with the input and output of writing file information to save data. 
     *          Data 
     * 
     * 
     * 
     * 
     * 
     * **/
    public class FileHandler
    {
        //      Returns C:\...ProjectClasses
        public static readonly string sourceDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
        public static string workingDir = sourceDir;
        
        public FileHandler(string[] args)
        {
            if (args[0].Equals("0"))
            {
                Console.WriteLine(sourceDir);
                Console.WriteLine(sourceDir + "\\prog\\");
            }


        }
        /**     Initalizes the program
         *      ARGS format
         *          [0] : File path extension in the form of C:\...\ProjectClasses + PATH
         *          [1] : Name of file, in the form of FILENAME.extension
         * **/
        internal static void initialize(string[] args)
        {
            create_newWorldDirectory(args);
            //throw new NotImplementedException();
        }
        
        /**         Debugger that shows a directory   
         *          ARGS format
         *          [0] : File path extension in the form of C:\...\ProjectClasses + PATH
         *          [1] : Name of file, in the form of FILENAME.extension
         * **/
        internal static void showDirectory(string[] args)
            {
                Console.WriteLine(" ");
                Console.WriteLine("In Directory " + args[0]);
                string[] directories = Directory.GetDirectories(sourceDir + args[0]);
                string[] files = Directory.GetFiles(sourceDir + args[0]);

                foreach (string directory in directories)
                {
                    Console.WriteLine("| " + directory);
                }
                foreach (string file in files)
                {
                    Console.WriteLine("+ " + file);
                }
                Console.WriteLine(" ");
            }
        
        static void createFile(string[] args)
        {
            
        }
        internal static void createDirectory(String[] args)
        {
            try
            {
                Directory.CreateDirectory(sourceDir + args[0]);

            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            
        }

        /**     ARGS format
         *          [0] : File path extension in the form of C:\...\ProjectClasses + PATH
         *          [1] : Name of file, in the form of FILENAME.extension
         * **/
        internal static void create_newWorldDirectory(String[] args) {
            createDirectory(new string[] { "\\data\\" + args[0]});
            createDirectory(new string[] { "\\data\\" + args[0] + "\\hexdata"});
            createDirectory(new string[] { "\\data\\" + args[0] + "\\hexdata\\hexInfo" });
            createDirectory(new string[] { "\\data\\" + args[0] + "\\hexdata\\hexmaps" });
            createDirectory(new string[] { "\\data\\" + args[0] + "\\dungeondata" });
            createDirectory(new string[] { "\\data\\" + args[0] + "\\dungeondata\\dungeonmaps" });
            createDirectory(new string[] { "\\data\\" + args[0] + "\\dungeondata\\dungeonInfo" });

        }


    }
}