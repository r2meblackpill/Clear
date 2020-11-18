using System;
using System.IO;

namespace CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFolderOne();
            CreateFolderTwo();
        }
        public static void CreateFolderOne()
        {
            string rootPath = @"C:\Users\opilane\samples\";
            string folderName = "playerOne";
            string fullFolderPath = rootPath + folderName;
            
            // debug
            //Console.WriteLine(fullFolderPath);

            if (Directory.Exists(fullFolderPath))
            {
                Console.WriteLine("Folder already exists.");
            }
            else
            {
                Directory.CreateDirectory(fullFolderPath);
                Console.WriteLine("Directory created.");
            }
        }
        public static void CreateFolderTwo()
        {
            string rootPath = @"C:\Users\opilane\samples\";
            string folderName = "playerTwo";
            string fullFolderPath = rootPath + folderName;

            // debug
            //Console.WriteLine(fullFolderPath);

            if (Directory.Exists(fullFolderPath))
            {
                Console.WriteLine("Folder already exists.");
            }
            else
            {
                Directory.CreateDirectory(fullFolderPath);
                Console.WriteLine("Directory created.");
            }
        }
    }
}
