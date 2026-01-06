using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=== 캐릭터 생성 ===");
            //Console.Write($"캐릭터 이름을 입력하세요: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"환영합니다, {name}님!");
            //Console.Write("시작 레벨을 입력하세요: ");
            //int level = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{name}님의 시작 레벨은 {level}입니다.");

            //int a = 5;
            //int b = 4;

            //a += b;
            //Console.WriteLine($"합계: {a}");
            //a = 5;         
            //a -= b;
            //Console.WriteLine($"합계: {a}");
            //a = 5;
            //a *= b;
            //Console.WriteLine($"합계: {a}");
            //a = 5;
            //a /= b;
            //Console.WriteLine($"합계: {a}");
            //a = 5;

            //int killCnt = 0;
            //int bullet = 30;
            //int cntDown = 3;

            //Console.WriteLine("=== 몬스터 처치 ===");
            //Console.WriteLine($"고블린 처치! (킬 카운트: {++killCnt})");
            //Console.WriteLine($"오크 처치! (킬 카운트: {++killCnt})");
            //Console.WriteLine($"드래곤 처치! (킬 카운트: {++killCnt})");
            //Console.WriteLine($"총 처치 수: {killCnt}");

            //Console.WriteLine("\n=== 사격 ===");
            //Console.WriteLine($"남은 탄약: {bullet}");
            //Console.WriteLine($"발사! 남은 탄약: {bullet--}");
            //Console.WriteLine($"발사! 남은 탄약: {bullet--}");
            //Console.WriteLine($"발사! 남은 탄약: {bullet--}");

            //Console.WriteLine("\n=== 카운트다운 ===");
            //Console.WriteLine(cntDown--);
            //Console.WriteLine(cntDown--);
            //Console.WriteLine(cntDown);
            //Console.WriteLine("발사!");

            Console.WriteLine("문제 1번");
            int playNowHp = 80;
            int maxHp = 100;

            int monsterAtk = 25;
            int hpPotion = 30;
            int posion = 5;

            Console.WriteLine($"초기 체력: {playNowHp}/{maxHp}");
            playNowHp -= monsterAtk;
            Console.WriteLine($"데미지 -25: {playNowHp}/{maxHp}");
            playNowHp += hpPotion;
            Console.WriteLine($"회복 +30: {playNowHp}/{maxHp}");
            playNowHp -= posion;
            Console.WriteLine($"독 데미지 -5: {playNowHp}/{maxHp}\n");

            Console.WriteLine("문제 2번");
            int expMonster = 150;
            int Kill = 3;
            int expForLevelUp = 500;

            int totalKillExp = expMonster * Kill;
            int nowFillExp = expForLevelUp - totalKillExp;

            Console.WriteLine($"처치한 몬스터: {Kill}");
            Console.WriteLine($"흭득 경험치: {totalKillExp}");
            Console.WriteLine($"레벨업까지 필요: {nowFillExp}\n");

            Console.WriteLine("문제 3번");
            int totalGold = 1234;
            int partyMember = 5;

            int distriMoney = totalGold / partyMember;
            int nowTotalGold = totalGold % partyMember;

            Console.WriteLine($"총 골드: {totalGold}");
            Console.WriteLine($"파티원: {partyMember}");
            Console.WriteLine($"1인당 골드: {distriMoney}");
            Console.WriteLine($"남은 골드: {nowTotalGold}\n");

            Console.WriteLine("문제 4번");
            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            double currentHP = 60;
            double maxHP = 100;

            double perHp = (currentHP / maxHP) * 100;

            bool canPlay = playerLevel > requiredLevel;
            bool canHasKey = hasKey == true;
            bool canHp = perHp >= 50;

            Console.WriteLine($"레벨 조건 (30 이상): {canPlay}");
            Console.WriteLine($"열쇠 보유: {canHasKey}");
            Console.WriteLine($"체력 조건 (50% 이상): {canHp}");
            Console.WriteLine($"입장 가능: {canPlay && canHasKey && canHp}\n");

            Console.WriteLine("문제 5번");
            int originalPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;

            Console.WriteLine($"원가: {originalPrice}");

            if (isVIP)
            {
                double vipPrice = originalPrice * 0.8;
                originalPrice = (int)vipPrice;
                Console.WriteLine($"vip 할인 (20%): {originalPrice}");
            }

            if (hasCoupon)
            {
                originalPrice -= 500;
                Console.WriteLine($"쿠폰 할인 (-500): {originalPrice}");
            }

            Console.WriteLine($"최종 가격: {originalPrice}\n");
        }
    }
}
