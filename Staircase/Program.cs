using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        public static void staircase(int n)
        {
            int sayac = n;
            string[] arr = new string[n]; // 0 1 2 3 4 5
            for (int i = 0; i < n; i++)
            {
                sayac--;
                for (int j = 0; j < n; j++)
                {
                    arr[j] = "#";
                    if (j + 1 == n)
                    {
                        for (int k = 0; k < sayac; k++)
                        {
                            arr[k] = " ";
                        }
                        foreach (string a in arr)
                        {
                            Console.Write(a);
                        }

                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("--------------------------------------------");
            staircase(n);
            Console.ReadLine();
        }
    }
}
