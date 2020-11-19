using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples\playerOne";

            Console.WriteLine("Enter a file name:");
            string userInput = Console.ReadLine();
            
            //CreateNewFile(rootPath, userInput);
            CreateWExtension(rootPath, userInput);
            
            Console.WriteLine("Written!!");
        
        }
        public static void CreateNewFile(string rootPath, string fileName)
        {
            File.Create(Path.Combine(rootPath, fileName));
        }
        public static void CreateWExtension(string rootPath, string fileName)
        {
            string fullFileName = fileName + ".txt";
            File.Create(Path.Combine(rootPath, fullFileName));
        }
    }
}
