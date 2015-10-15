using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("SourceDirectory");

            string file1 = Path.Combine("SourceDirectory", "file1.txt");
            File.Create(file1);

            string subDirectory1 = Path.Combine("SourceDirectory", "subDirectory1");
            Directory.CreateDirectory(subDirectory1);

            string subDirectoryFile1 = Path.Combine("subDirectory1", "file1.txt");
            File.Create(subDirectoryFile1);

            string subDirectoryFile2 = Path.Combine("subDirectory1", "file2.txt");
            File.Create(subDirectoryFile2);

            //level2
            string subDirectory2 = Path.Combine("SourceDirectory", "subDirectory2");
            Directory.CreateDirectory(subDirectory2);

            string subDirectory2File1 = Path.Combine("subDirectory1", "file1.txt");
            File.Create(subDirectory2File1);

            string subDirectory2File2 = Path.Combine("subDirectory1", "file2.txt");
            File.Create(subDirectory2File2);

            //level 2
            string subDirectory1_1 = Path.Combine(subDirectory1, "subDirectory1_1");
            Directory.CreateDirectory(subDirectory1_1);

            string subDirectory1_1file1 = Path.Combine(subDirectory1_1, "file1.txt");
            File.Create(subDirectory1_1file1);

            string subDirectory1_1file2 = Path.Combine(subDirectory1_1, "file2.txt");
            File.Create(subDirectory1_1file2);


            //level 3
            string subDirectory1_1_1 = Path.Combine(subDirectory1_1, "subDirectory1_1_1");
            Directory.CreateDirectory(subDirectory1_1_1);

            string subDirectory1_1_1file1 = Path.Combine(subDirectory1_1_1, "file1.txt");
            File.Create(subDirectory1_1_1file1);

            string subDirectory1_1_1file2 = Path.Combine(subDirectory1_1_1, "file2.txt");
            File.Create(subDirectory1_1_1file2);

            DirectoryCopy("SourceDirectory", "DestinationDirectory", true);
            Console.WriteLine("Copied successfully");
        }


        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

    }
}
