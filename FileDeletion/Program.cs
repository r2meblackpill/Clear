using System;
using System.IO;

namespace FileDeletion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File from where?");
            string sourceFolder = Console.ReadLine();

            Console.WriteLine("File?");
            string sourceFile = Console.ReadLine();
            string fullFile = @"C:\Users\opilane\samples\" + sourceFolder + @"\" + sourceFile + ".txt";

            DeleteFile(fullFile);
            Console.WriteLine("Complete!!");
        }
        public static void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }
    }
}
