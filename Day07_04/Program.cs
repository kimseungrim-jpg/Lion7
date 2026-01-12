using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day07_04
{
    internal class Program
    {
        //static void CastFireBall(string target, int damage = 100, int manaCost = 30)
        //{
        //    Console.WriteLine($" 파이어볼 시전!");
        //    Console.WriteLine($" 대상: {target}");
        //    Console.WriteLine($" 데미지: {damage}");
        //    Console.WriteLine($" 마나 소모: {manaCost}");
        //}

        static void UseItem(string potionName, int potionUp = 50)
        {
            Console.WriteLine($"{potionName} 사용!");
            Console.WriteLine($"회복량: {potionUp} HP");
        }

        static void SummonMst(string monster, int level = 1, int num = 1)
        {
            Console.WriteLine($"✨ {monster} 소환!");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"수량: {num}");
        }
        static void Main(string[] args)
        {
            //CastFireBall("고블린", 150, 40);
            //Console.WriteLine();
            //CastFireBall("오크", 20);
            //Console.WriteLine();
            //CastFireBall("드래곤");
            //Console.WriteLine();

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== 아이템 사용 ===");
            Console.WriteLine();
            UseItem("회복 포션");
            Console.WriteLine();
            UseItem("고급 회복 포션");
            Console.WriteLine();

            Console.WriteLine("=== 소환 마법 ===");

            Console.WriteLine();
            SummonMst("슬라임");
            Console.WriteLine();
            SummonMst("고블린", 5);
            Console.WriteLine();
            SummonMst("드래곤", 50, 3);
        }
    }
}
