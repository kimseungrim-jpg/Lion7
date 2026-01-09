using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string[] inventory = new string[5];

            //    Console.WriteLine("=== 인벤토리 ===");

            //    for (int i = 0; i < inventory.Length; i++)
            //    {
            //        inventory[i] = Console.ReadLine();
            //    }
            //    for (int i = 0; i < inventory.Length; i++)
            //    {
            //        Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //    }

            //int[] character = new int[5];
            //string[] state = { "HP", "MP", "공격력", "방어력", "민첩" };

            //for (int i = 0; i < character.Length; i++)
            //{
            //    Console.Write($"스탯 입력 [{state[i]}]:");
            //    character[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("=== 캐릭터 스텟===");
            //for (int i = 0; i < character.Length; i++)
            //{
            //    Console.WriteLine($"{state[i]}: {character[i]}");
            //}

            //string[] monsterName = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            //int[] recentNum = { 5, 3, 8, 2, 7 };
            //int[] maxNum = { 5, 5, 5, 5, 5 };

            //for (int i = 0; i < monsterName.Length; i++)
            //{
            //    Console.Write($"{monsterName[i]}: {recentNum[i]} / {maxNum[i]}");
            //    if (recentNum[i] >= maxNum[i])
            //    {
            //        Console.WriteLine("● 완료");
            //    }
            //    else
            //    {
            //        Console.WriteLine("○ 진행중");
            //    }
            //}

            //int[] scores = { 85, 92, 78, 95, 88 };

            ////배열 길이
            //Console.WriteLine("총 점수 개수: " + scores.Length);

            ////배열 순회
            //Console.WriteLine("개별 점수");
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"플레이어 {i + 1} : {scores[i]}점");
            //}


            ////합계 계산
            //int sum = 0;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    sum += scores[i];
            //}

            //Console.WriteLine($"총점 : {sum}점");
            //Console.WriteLine($"평균 : {(float)sum / (float)scores.Length}점");

            //int max = scores[0];
            //int min = scores[0];

            //for (int i = 1; i < scores.Length; i++)
            //{
            //    if (max < scores[i])
            //    {
            //        max = scores[i];
            //    }
            //    if (min > scores[i])
            //    {
            //        min = scores[i];
            //    }
            //}

            //Console.WriteLine($"최고점: {max} / 최저점: {min}");

            //string[,] number = { { "A1", "A2", "A3" }, { "B1", "B2", "B3" }, { "C1", "C2", "C3" } };

            //for (int i = 0; i < number.GetLength(0); i++)
            //{
            //    for (int j = 0; j < number.GetLength(1); j++)
            //    {
            //        Console.Write($"[{number[i, j]}]");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine($"첫 번째 좌석: {number[0, 0]}");

           //Dictionary<string, int> item = new Dictionary<string, int>();

           // item.Add("회복 포션", 50);
           // item.Add("마나 포션", 40);
           // item.Add("강철 검", 500);
           // item.Add("가죽 갑옷", 300);
           // item.Add("마법 반지", 1000);

           // Console.WriteLine("=== 상점 아이템 ===");
           // foreach (KeyValuePair<string, int> sell in item)
           // {
           //     Console.WriteLine($"{sell.Key}: {sell.Value}");
           // }

           // string searchItem = "강철 검";
           // Console.WriteLine();

           // if (item.ContainsKey(searchItem))
           // {
           //     Console.WriteLine($"'{searchItem}'구매 성공!");
           //     Console.WriteLine("남은 골드: 100");
           // }
           // else
           // {
           //     Console.WriteLine("해당 아이템이 존재하지 않습니다.");
           // }


        }
    }
}
