using System;
using System.IO;

namespace dotNetDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
    }
}
