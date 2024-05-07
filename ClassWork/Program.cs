using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileWork.ArrayToFile();
            FileWork.PrintRes(FileWork.ArrayFromFile(1));
            FileWork.PrintAllFile("arr.txt");
            Console.ReadKey();
        }
    }
}
