using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace p17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 0, count = 0, ch = 0, x = 0, c = 0;
                while (true)
                {
                    Console.Write("кол-во элементов массива: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0) { break; }
                }
                string[] arr = new string[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    while (true)
                    {
                        Console.Write((i + 1) + " элемент: ");
                        string el = Console.ReadLine();
                        if (el != "" || el != " ")
                        {
                            arr[i] = el;
                            break;
                        }
                    }
                }
                Console.WriteLine("\tЗадание А");
                List<string> l = new List<string>();
                foreach (string str in arr)
                {
                    int[] mas = str.Where(Char.IsDigit).Select(x => int.Parse(x.ToString())).ToArray();
                    ch = str.Where(Char.IsDigit).Select(x => int.Parse(x.ToString())).Count();
                    count += ch;
                    Console.Write(string.Join(" ", mas));
                    Console.Write(" ");
                }
                Console.WriteLine("\nвсего чисел: " + count);
                Console.WriteLine("\tЗадание Б");
                IEnumerable<string> ienum = arr.TakeWhile(u => String.Compare("/", u, true) != 0);
                string[] mas1 = new string[ienum.Count() + 1];
                foreach (var item in ienum)
                {
                    Console.Write(item + " ");
                    mas1[c] = item;
                    c++;
                }
                mas1[c] = "/";
                Console.WriteLine("\n\tЗадание В");
                IEnumerable<string> ienum2 = arr.SkipWhile(u => String.Compare("/", u, true) != 0);
                string[] mas2 = new string[ienum2.Count()];
                foreach (var item in ienum2)
                {
                    string s = item;
                    if (s != s.ToUpper())
                    {
                        mas2[x] = s.ToUpper();
                        x++;
                    }
                    else if (s != s.ToLower())
                    {
                        mas2[x] = s.ToLower();
                        x++;
                    }
                }
                for (int i = 0; i < mas2.Length; i++)
                {
                    Console.Write(mas2[i] + " ");
                }
                StreamWriter sw = new StreamWriter("file.txt");
                for (int i = 0; i < mas1.Length; i++)
                {
                    sw.WriteLine(mas1[i]);
                }
                for (int i = 0; i < mas2.Length; i++)
                {
                    sw.WriteLine(mas2[i]);
                }
                sw.Close();
            }
            catch { Console.WriteLine("неверные данные"); }
        }
    }
}
