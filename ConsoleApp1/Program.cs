using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            int[,] arrA = new int[a, b];
            int[,] arrB = new int[a, b];
            int[,] arrC = new int[a, b];


            for (int i = 0; i < a; i++)
            {
                string[] s2 = Console.ReadLine().Split();
                for (int j = 0; j < b; j++)
                {
                    arrA[i, j] = int.Parse(s2[j]);
                }
            }

            for (int i = 0; i < a; i++)
            {
                string[] s2 = Console.ReadLine().Split();
                for (int j = 0; j < b; j++)
                {
                    arrB[i, j] = arrA[i, j] + int.Parse(s2[j]);
                }
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(arrB[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
