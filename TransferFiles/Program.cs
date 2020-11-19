using System;
using System.IO;

namespace TransferFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File from where?");
            string sourceFolder = Console.ReadLine();

            Console.WriteLine("File?");
            string sourceFile = Console.ReadLine();
            string fullSourceFile = @"C:\Users\opilane\samples\" + sourceFolder + @"\" + sourceFile + ".txt";

            Console.WriteLine("To?");
            string fullDestinationFile = @"C:\Users\opilane\samples\" + Console.ReadLine() + @"\" + sourceFile + ".txt";

            //Console.WriteLine(fullSourceFile);
            //Console.WriteLine(fullDestinationFile);

            MoveFile(fullSourceFile, fullDestinationFile);

        }
        public static void MoveFile(string sourceFile, string destinationFile)
        {
            File.Move(sourceFile, destinationFile);
        }
    }
}
