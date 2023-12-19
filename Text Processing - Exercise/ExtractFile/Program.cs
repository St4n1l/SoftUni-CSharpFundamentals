using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine().Split(new char[] { '.', '\\' });
            string extension = filePath[filePath.Length - 1];
            string fileName = filePath[filePath.Length - 2];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
