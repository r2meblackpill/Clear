using System;
using System.IO;

namespace Clear
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";

            Console.WriteLine("AUTORIÕIGUSED ANTON ETTEVÕTTED 2020");

            FileDel();
            
            DirectoryInfo rootDirectory = new DirectoryInfo(rootPath);
            foreach (DirectoryInfo dir in rootDirectory.GetDirectories())
            {
                FolderDel(dir.FullName, true);
            }
        }
        public static void FileDel()
        { 
            string rootPath = @"C:\Users\opilane\samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);
            
            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }

        }
        public static void FolderDel(string directoryName, bool ifExists)
        {
            if(Directory.Exists(directoryName))
            {
                Directory.Delete(directoryName, true);
            }
            else if(ifExists)
            {
                throw new SystemException("No such directory.");
            }

        }
    }
}
