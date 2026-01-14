using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY09
{
    internal class Program
    {
        class Player
        {
            private int hp;
            private int att;

            public void SetHp(int hp)
            {
                this.hp = hp;
            }

            public int GetHp() 
            { 
                return hp; 
            }

            public void SetAtt(int att)
            {
                this.att = att;
            }

            public int GetAtt()
            {
                return att;
            }

            public void Render()
            {
                Console.WriteLine("플레이어");
                Console.WriteLine("체력 : " + hp);
                Console.WriteLine("공격력 : " + att);
            }

        }

        class Monster
        {
            private int hp;
            private int att;

            public void SetHp(int hp)
            {
                this.hp = hp;
            }

            public int GetHp()
            {
                return hp;
            }

            public void SetAtt(int att)
            {
                this.att = att;
            }

            public int GetAtt()
            {
                return att;
            }


            public void Render()
            {
                Console.WriteLine("몬스터");
                Console.WriteLine("체력 : " + hp);
                Console.WriteLine("공격력 : " + att);
            }

        }

        static void Main(string[] args)
        {
            Player player = new Player();
            player.SetAtt(10);
            player.SetHp(100);

            Monster monster = new Monster();
            monster.SetAtt(5);
            monster.SetHp(100);

            monster.SetHp(monster.GetHp() - player.GetAtt());
            player.SetHp(player.GetHp() - monster.GetAtt());
            
            player.Render();
            monster.Render();
        }
    }
}
