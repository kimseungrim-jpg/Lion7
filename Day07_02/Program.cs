using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_02
{
    internal class Program
    {
        //static void Attack(int att, int def)
        //{
        //    Console.WriteLine("공격력 전달받았다. : " + att);
        //    Console.WriteLine("방어력 : " + def);
        //}

        static void PlayerState(string name, int atk, int def, int dex, int luk)
        {
            Console.WriteLine($"플레이어 이름: {name}");
            Console.WriteLine($"공격력: {atk}");
            Console.WriteLine($"방어력: {def}");
            Console.WriteLine($"민첩: {dex}");
            Console.WriteLine($"운: {luk}");
        }

        static void Main(string[] args)
        {
            Console.Write("플레이어 이름을 입력해주세요: ");
            string pName = Console.ReadLine();
            Console.Write("플레이어 공격력을 입력해주세요: ");
            int pAtk = int.Parse(Console.ReadLine());
            Console.Write("플레이어 방어력을 입력해주세요: ");
            int pDef = int.Parse(Console.ReadLine());
            Console.Write("플레이어 민첩을 입력해주세요: ");
            int pDex = int.Parse(Console.ReadLine());
            Console.Write("플레이어 운을 입력해주세요: ");
            int pLuk = int.Parse(Console.ReadLine());

            Console.WriteLine();

            PlayerState(pName, pAtk, pDef, pDex, pLuk);
        }
    }
}
