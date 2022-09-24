using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.IO;

namespace IntroductionLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\windows";
            ShowLargeFilesWithoutLinq(path);
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;

            foreach(var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name, -20} : {file.Length, 10:N0}");
            }
        }
           
    }
   
}
