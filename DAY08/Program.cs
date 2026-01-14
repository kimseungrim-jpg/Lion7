using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY08
{
    internal class Program
    {
        class Character
        {
            private string name;
            private int level;
            private int hp;
            private int maxHP;
            private int mp;
            private int maxMP;

            public void GetInfo(string getName, int getLevel, int getHp, int getMaxHP, int getMp, int getMaxMp)
            {
                name = getName;
                level = getLevel;
                hp = getHp;
                maxHP = getHp;
                mp = getMaxHP;
                maxMP = getMp;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine($"이름: {name}");
                Console.WriteLine($"레벨: {level}");
                Console.WriteLine($"HP: {hp}/{maxHP}");
                Console.WriteLine($"MP: {mp}/{maxMP}");
                Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            }

            public void TakeDamage(int damage)
            {
                hp -= damage;
                if (hp < 0) hp = 0;

                Console.WriteLine($"⚔️ {name}이(가) {damage} 데미지를 받았습니다!");
                Console.WriteLine($"   남은 HP: {hp}/{maxHP}");
            }

            public void Heal(int amount)
            {
                hp += amount;
                if (hp > maxHP) hp = maxHP;

                Console.WriteLine($"💚 {name}의 HP가 {amount} 회복되었습니다!");
                Console.WriteLine($"   현재 HP: {hp}/{maxHP}");
            }
        }

        class Monster
        {
            // 필드
            public string name;
            public int level;
            public int hp;
            public int attack;
            public int defense;
            public int expReward;

            // 기본 생성자
            public Monster()
            {
                name = "슬라임";
                level = 1;
                hp = 50;
                attack = 10;
                defense = 5;
                expReward = 10;
            }

            // 매개변수가 있는 생성자
            public Monster(string monsterName, int monsterLevel)
            {
                name = monsterName;
                level = monsterLevel;
                hp = 50 * level;
                attack = 10 * level;
                defense = 5 * level;
                expReward = 10 * level;
            }
        }

        static void Main(string[] args)
        {
            Character player1 = new Character();

            //player1.name = "홍길동";
            //player1.level = 10;
            //player1.hp = 150;
            //player1.maxHP = 150;
            //player1.mp = 80;
            //player1.maxMP = 80;

            player1.GetInfo("홍길동", 10, 150, 150, 80, 80);

            player1.ShowInfo();

            player1.TakeDamage(50);

            player1.Heal(30);

            Character player2 = new Character();

            //player2.name = "김철수";
            //player2.level = 13;
            //player2.hp = 180;
            //player2.maxHP = 180;
            //player2.mp = 90;
            //player2.maxMP = 90;

            player2.GetInfo("김철수", 13, 180, 180, 90, 90);

            player2.ShowInfo();

            player2.TakeDamage(90);

            player2.Heal(60);
        }
    }
}
