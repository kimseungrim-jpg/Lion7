using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_03
{
    internal class Program
    {
        static int GetNumber() //정수반환
        {
            return 42;
        }

        static void Attack(string target, int damage)
        {
            Console.WriteLine($"{target} 기본공격");
            Console.WriteLine($"데미지: {damage}");
        }

        static void Attack(string target, string skillName, int damage)
        {
            Console.WriteLine($"✨ 스킬 발동: {skillName}");
            Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Attack("몬스터", 100);
            Attack("몬스터", "천마일섭", 100000);
        }
    }
}
