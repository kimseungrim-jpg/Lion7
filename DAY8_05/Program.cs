using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_05
{
    class Character
    {
        //static: 모든 캐릭터가 공유
        public static int totalCount = 0;

        //일반: 각 캐릭터마다 다름
        public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Character c1 = new Character();
            Character c2 = new Character();

            c1.name = "전사";
            c2.name = "마법사";

            Character.totalCount = 1;

            Console.WriteLine(c1.name);
            Console.WriteLine(c2.name);

            Console.WriteLine("카운트 : " + Character.totalCount);
        }
    }
}
