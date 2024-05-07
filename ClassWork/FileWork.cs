using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class FileWork
    {
        public static void ArrayToFile()
        {
            Console.Write("Enter the List length: ");
            int count = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Arr[{i}]: ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            using (StreamWriter sw = new StreamWriter("arr.txt", true))
            {
                sw.WriteLine(ArrayToString(list));
            }
            Console.WriteLine("Array was appended to the file!");
            Console.ReadKey();
        }

        public static List<int> ArrayFromFile(int row)
        {
            string line;
            using (StreamReader sr = new StreamReader("arr.txt")) //here i need to catch exeption
            {
                for (int i = 1; i < row; i++)
                {
                    if (sr.EndOfStream)
                    {
                        sr.Close(); //
                    }
                    sr.ReadLine();
                }

                line = sr.ReadLine();
            }
            string[] elements = line.Split(new char[] { ' ' });

            List<int> list = new List<int>();
            foreach (string element in elements)
            {
                if(element != "")
                {
                    list.Add(int.Parse(element));
                }
            }
            return list;
        }

        public static string ArrayToString(List<int> list)
        {
            string sb = "";
            foreach (int i in list)
            {
                sb += $"{i.ToString() + " "}";
            }
            return sb;
        }
        public static void PrintRes(List<int> list)
        {
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
        }
        public static void PrintAllFile(string reff)
        {
            Console.WriteLine("All file");
            using (StreamReader sr = new StreamReader(reff))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

        }
    }
}
