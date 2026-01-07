using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("생성할 몬스터의 수를 입력해주세요: ");
            //int monsterNum = int.Parse(Console.ReadLine());

            //for (int i = 0; i < monsterNum; i++)
            //{
            //    if (i == 0)
            //    {
            //        Console.WriteLine("=== 몬스터 웨이브 시작 ===");
            //        Console.WriteLine($"고블린 #{i + 1} 생성!");
            //    }
            //    else if(i > 0 && i < monsterNum - 1)
            //    {
            //        Console.WriteLine($"고블린 #{i + 1} 생성!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"고블린 #{i + 1} 생성!");
            //        Console.WriteLine($"총 {i + 1}마리 생성 완료!");
            //    }
            //}

            //Console.Write("카운트 다운을 설정: ");
            //int cnt = int.Parse(Console.ReadLine());


            //Console.WriteLine("=== 게임 시작 카운트다운 ===");
            //for (int i = cnt; i > 0; i--)
            //{
            //    Console.WriteLine($"{i}...");
            //}
            //Console.WriteLine("게임 시작!");

            //string sword = "무한의 대검";

            //Console.WriteLine("당신은 20번뽑기가 가능합니다. 지금 실행합니다.");

            //Random rand = new Random();

            //int random = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    random = rand.Next(1, 101);

            //    if (random >= 1 && random <= 10)
            //    {
            //        sword = "무한의 대검";
            //    }
            //    else if (random >= 11 && random <= 30)
            //    {
            //        sword = "카타나";
            //    }
            //    else if (random >= 31 && random <= 60)
            //    {
            //        sword = "엑스칼리버";
            //    }
            //    else if (random >= 61 && random <= 100)
            //    {
            //        sword = "정기정검";
            //    }

            //    Console.WriteLine(sword);
            //    Thread.Sleep(500);
            //}

            Random rnd = new Random();

            string level = "rare"; //시작등급 레어
            int cube = 0; // 레어 업 확률 10% 에픽 업 확률 5% 유니크 업 확률 1%
            int cnt = 0; // 큐브를 돌리면서 시행한 횟수
            int totalCnt = 0;

            while (true)
            {
                Console.WriteLine($"현재 등급: {level}");
                Console.WriteLine($"등급 시행 횟수: {cnt}/ 전체 시행 횟수: {totalCnt}");
                Console.Write("시행하시겠습니까?(y/n/c):"); //y n c 값중 받아서 반복문 진행
                string check = Console.ReadLine(); // check값 받음

                if (check == "n") //n을 입력받으면 반복문 탈출
                {
                    Console.WriteLine("다음에 또 이용해 주세요~!!!(●'ㅅ'●)");
                    break;
                }
                else if (check == "y") //y를 입력받으면 시행
                {
                    cnt++;
                    totalCnt++;
                    cube = rnd.Next(1, 101); //시행시 카운트가 증가하고 랜덤값 부여
                    //Console.WriteLine(cube);
                    if (level == "rare") //큐브의 등급에 따라 등급될 확률을 다르게 설정 후 진행
                    {
                        if (cube > 0 && cube <= 10) //cube가 10보다 아래라면 즉 10프로라면 업
                        {
                            level = "epic";
                            Console.WriteLine($"★★★축하합니다. 등급이 올랐습니다.★★★");
                            Console.WriteLine($"승급한 등급: {level}");
                            Console.WriteLine("____________________________________________");
                            cnt = 0;
                        }
                        else
                        {
                            Console.WriteLine("실패했습니다. 다시 한번 시도해주세요.");
                            Console.WriteLine("____________________________________________");
                        }
                    }
                    else if (level == "epic")
                    {
                        if (cube > 0 && cube <= 5)
                        {
                            level = "unique";
                            Console.WriteLine($"★★★축하합니다. 등급이 올랐습니다.★★★");
                            Console.WriteLine($"승급한 등급: {level}");
                            Console.WriteLine("____________________________________________");
                            cnt = 0;
                        }
                        else
                        {
                            Console.WriteLine("실패했습니다. 다시 한번 시도해주세요.");
                            Console.WriteLine("____________________________________________");
                        }
                    }
                    else if (level == "unique")
                    {
                        if (cube > 0 && cube <= 1)
                        {
                            level = "legendary";
                            Console.WriteLine("★★★최종등급 달성을 축하드립니다!!★★★");
                            Console.WriteLine("=== 최종 LEGENDARY 등급 달성★ ===");
                            Console.WriteLine($"최종 시행 횟수: {cnt}");

                            Console.WriteLine("____________________________________________");
                            Console.Write("다시 시도 하시겠습니까??:(y/n) ");
                            check = Console.ReadLine(); //최종 등급 달성시 다시 할거냐는 문구출력을 해서 입력받아 진행

                            if (check == "y")
                            {
                                level = "rare";
                                cnt = 0;
                                totalCnt = 0;
                                Console.Clear(); //다시 진행할시 출력문과 카운트, 등급을 초기화 해서 처음부터 진행
                            }
                            else
                            {
                                Console.WriteLine("다음에 또 이용해 주세요~!!!(●'ㅅ'●)");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("실패했습니다. 다시 한번 시도해주세요.");
                            Console.WriteLine("____________________________________________");
                        }
                    }

                }
                else if(check == "c") //c입력시 출력문 초기화
                {
                    Console.Clear();
                }
                else // y,n,c 외 다른 문자 입력시 문구 출력 후 반복
                {
                    Console.WriteLine("잘못입력하셨습니다.");
                    Console.WriteLine("____________________________________________");
                }
            }
        }
    }
}
