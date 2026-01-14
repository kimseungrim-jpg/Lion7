using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAY08_03
{
    internal class Program
    {
        class Player
        {
            private string name;
            private int gold;
            private int maxHP;

            //프로퍼티
            public string Name { get { return name; } set { name = value; } }
            public int Gold
            {
                get { return gold; }

                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    else
                    {
                        gold = value;
                    }
                }
            }

            public int MaxHp
            {
                get
                {
                    return maxHP;
                }
                private set
                {
                    maxHP = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            player.Name = "홍길동";
            player.Gold = -100;

            Console.WriteLine($"이름 : {player.Name}");
            Console.WriteLine($"골드 : {player.Gold}");

        }
    }
}
