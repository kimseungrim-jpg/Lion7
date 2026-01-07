using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int level = 45;
            //string result = (level > 50) ? "고급" : (level <= 50 && level >= 30) ? "중급" : "초급";

            //Console.WriteLine("플레이어등급");
            //Console.WriteLine($"레벨: {level}");
            //Console.WriteLine($"등급: {result}");

            //int health = 30;
            //int maxhealth = 100;

            //string result = (health > 70) ? "안전" : (health >= 30) ? "주의" : "위험";

            //Console.WriteLine("===플레이어 상태===");
            //Console.WriteLine($"체력: {health}/{maxhealth}");
            //Console.WriteLine($"상태: {result}");

            //int baseDamage = 50;
            //int bonusDamage = 20;
            //double criticalMultiplier = 1.5;

            //// 잘못된 계산
            //double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            //// 올바른 계산
            //double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            //Console.WriteLine($"기본 데미지: {baseDamage}");
            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0

            //double health = 30.0;
            //double maxHealth = 100.0;

            //double healthPer = (health / maxHealth) * 100;
            //Console.WriteLine($"현재 체력: {health}/{maxHealth}");

            //if (healthPer <=30 && healthPer > 0)
            //{
            //    Console.WriteLine("경고: 체력이 위험합니다!");
            //    Console.WriteLine("체력 아이템을 사용하세요!");
            //    Console.WriteLine("체력이 50% 이하입니다.");
            //}
            //else if (healthPer > 30 && healthPer <= 50)
            //{
            //    Console.WriteLine( "체력이 50% 이하입니다.");
            //}
            //else if(healthPer == 0)
            //{
            //    Console.WriteLine("게임 오버!");
            //    Console.WriteLine("부활 지점에서 다시 시작합니다.");
            //}

            //Console.WriteLine();

            //int enemyDistance = 5;
            //int attackRange = 3;

            //if (attackRange <= enemyDistance)
            //{
            //    Console.WriteLine("적이 사거리 안에 있습니다.");
            //    Console.WriteLine("공격 가능!");
            //}

            //Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("=== 캐릭터 상태 ===");
            //int health = int.Parse(Console.ReadLine());

            //if (health >= 80)
            //{
            //    Console.WriteLine("💚 상태: 매우 좋음");
            //}
            //else if (health >= 60)
            //{
            //    Console.WriteLine("🟢 상태: 좋음");
            //}
            //else if (health >= 40)
            //{
            //    Console.WriteLine("🟡 상태: 보통");
            //}
            //else if (health >= 20)
            //{
            //    Console.WriteLine("🟠 상태: 위험");
            //}
            //else
            //{
            //    Console.WriteLine("🔴 상태: 매우 위험!");
            //}

            Console.WriteLine("=== 캐릭터 직업을 고르시오===");
            Console.WriteLine("1. 전사       | 2. 궁수       | 3.마법사");
            Console.WriteLine("클래스: 전사  | 클래스: 궁수  | 클래스: 마법사");
            Console.WriteLine("공격력: 3     | 공격력: 4     | 공격력: 5");
            Console.WriteLine("방어력: 5     | 방어력: 2     | 방어력: 1");
            Console.WriteLine("스피드: 2     | 스피드: 4     | 스피드: 1");
            Console.WriteLine("사거리: 1     | 사거리: 5     | 사거리: 4");

            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("=== 캐릭터 생성 완료 ===");
                    Console.WriteLine("클래스: 전사");
                    break;
                case 2:
                    Console.WriteLine("=== 캐릭터 생성 완료 ===");
                    Console.WriteLine("클래스: 궁수");
                    break;
                case 3:
                    Console.WriteLine("=== 캐릭터 생성 완료 ===");
                    Console.WriteLine("클래스: 마법사");
                    break;
                default:
                    break;
            }

        }
    }
}
