using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            var FileUrl = @"D:\Opensource\ConsoleApp1\oneImages.txt";
            string[] lines = File.ReadAllLines(FileUrl);

            string picturesFile = @"D:\MY-WEDDING\Anuradha-Selaka\02\";
            string destFile = @"D:\Opensource\ConsoleApp1\Album\two\";
            foreach (string item in lines)
            {
                Console.WriteLine(item);
                var src = Path.Combine(picturesFile) + item + ".jpg";
                var dest = destFile + Path.GetFileName(item) + ".jpg";
                Console.WriteLine("Source File Path : " + src);
                Console.WriteLine("Destination File Path : " + dest);
                File.Copy(src, dest, true);
            }
        }
    }
}
