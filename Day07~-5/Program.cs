using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day07__5
{
    internal class Program
    {
        static double Avg(int[] score)
        {
            double scoreAvg = 0;
            double totalScore = 0;
            for (int i = 0; i < score.Length; i++)
            {
                totalScore += (double)score[i];
            }

            scoreAvg = totalScore / score.Length;
            return scoreAvg;
        }

        static string Level(int checkLevel)
        {
            string yourLevel = "";
            if (checkLevel > 80 && checkLevel <= 100)
            {
                yourLevel = "A";
            }
            else if (checkLevel > 60 && checkLevel <= 80)
            {
                yourLevel = "B";
            }
            else if (checkLevel > 40 && checkLevel <= 60)
            {
                yourLevel = "C";
            }
            else if (checkLevel > 20 && checkLevel <= 40)
            {
                yourLevel = "D";
            }
            else
            {
                yourLevel = "E";
            }
            
            return yourLevel;
        }

        static bool sosuCheck(int sosuOk)
        {
            int cnt = 0;

            for (int i = 1; i <= sosuOk; i++)
            {
                if (sosuOk % i == 0)
                {
                    cnt++;
                }
            }

            if (cnt > 2)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        static void CheckExp(int a, int b, out int exp2, out bool chkUp, out int levelNum)
        {
            int maxExp = 100;
            int recentExp = a + b;
            int levelCnt = 0;
            exp2 = 0;
            chkUp = false;
            levelNum = 0;

            if (recentExp < maxExp)
            {
                exp2 = recentExp;
                chkUp = false;
                levelNum = 0;
            }
            else if(recentExp > maxExp)
            {
                levelNum = recentExp / maxExp;
                exp2 = recentExp - (maxExp * levelNum);
                chkUp = true;
            }

        }

        static void Upgrade(ref int level, ref int nowSuccess, ref int nowFail, ref bool upSuccess)
        {
            Random rand = new Random();

            int rnd = rand.Next(1, 101);
            if (level > 96)
            {

            }

            if (rnd <= 100 && rnd > level)
            {
                level++;
                nowSuccess = 100 - level;
                nowFail = level;
                upSuccess = true;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== 평균 계산기 ===");
            Console.Write("과목 수를 입력하십시오: ");
            int scoreNum = int.Parse(Console.ReadLine());
            int[] score = new int[scoreNum];
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write($"{i + 1}번 과목 점수를 입력하시오: ");
                score[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"평균 점수: {Avg(score):F2}");

            Console.WriteLine("___________________________________");
            Console.WriteLine();

            Console.WriteLine("=== 등급 판별기 ===");
            Console.Write("점수를 입력 하십시오: ");
            int levelScore = int.Parse(Console.ReadLine());

            Console.WriteLine(Level(levelScore));
            Console.WriteLine("___________________________________");
            Console.WriteLine();

            Console.WriteLine("=== 소수 판별기 ===");
            Console.Write("수를 입력하십시오: ");
            int sosu = int.Parse(Console.ReadLine());

            Console.WriteLine(sosuCheck(sosu));
            Console.WriteLine("___________________________________");
            Console.WriteLine();

            Console.WriteLine("=== 경험치 시스템 ===");
            Console.Write("현재 경험치를 입력해 주십시오: ");
            int exp = int.Parse(Console.ReadLine());
            Console.Write("흭득 경험치를 입력해 주십시오: ");
            int comeExp = int.Parse(Console.ReadLine());

            int exp2;
            bool chkUp;
            int levelNum;

            CheckExp(exp, comeExp, out exp2, out chkUp, out levelNum);
            if (chkUp == true)
            {
                Console.WriteLine($"{levelNum}레벨업 성공!");
                Console.WriteLine($"현재 경험치 {exp2}");
            }
            else
            {
                Console.WriteLine("경험치 부족레벨업 실패!");
                Console.WriteLine($"현재 경험치 {exp2}");
            }
            Console.WriteLine(sosuCheck(sosu));
            Console.WriteLine("___________________________________");

            Console.WriteLine("=== 강화소 ===");
            int nowLevel = 1;
            int success = 100;
            int fail = 0;
            while (true)
            {
                Console.Write("강화 하기(끝내려면 n을 입력해주세요!):");
                string upgKey = Console.ReadLine();
                bool upSuccess = false;

                if (nowLevel == 100)
                {
                    Console.WriteLine($"현재 레벨: {nowLevel}");
                    Console.WriteLine("최고 레벨에 도달해서 더이상 레벨을 올릴 수 없습니다.");
                    break;
                }

                if (upgKey == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"현재 레벨: {nowLevel}");
                    Console.WriteLine($"현재 성공 확률 {success}% / 실패 확률 {fail}%");
                    Upgrade(ref nowLevel, ref success, ref fail, ref upSuccess);                    

                    if (upSuccess == true)
                    {
                        Console.WriteLine($"강화에 성공했습니다!!! {nowLevel}달성!!!");
                        upSuccess = false;
                    }
                    else
                    {
                        Console.WriteLine("강화에 실패했습니다....");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
