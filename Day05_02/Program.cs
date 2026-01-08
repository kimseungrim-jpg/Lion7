using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day05_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int shopX = 20;
            const int shopY = 10;
            const int mineX = 50;
            const int mineY = 10;
            const int guildX = 35;
            const int guildY = 5;
            const int resxX = 35;
            const int restY = 15;

            int x = 35;
            int y = 10;
            string level = "초급 광부";
            int money = 5000;
            int health = 100;
            int maxhealth = 100;
            int levelPoint = 0;

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();

                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"등급 : {level}/{levelPoint}");
                Console.WriteLine($"소지금 : {money}");
                Console.WriteLine($"체력 : {health}/{maxhealth}");
               
                Console.SetCursorPosition(x, y);
                Console.Write("§");

                Console.SetCursorPosition(shopX - 3, shopY - 1);
                Console.Write("㈜상점㈜");
                Console.SetCursorPosition(shopX, shopY);
                Console.Write("○");

                Console.SetCursorPosition(mineX - 3, mineY - 1);
                Console.Write("↑광산↑");
                Console.SetCursorPosition(mineX, mineY);
                Console.Write("○");

                Console.SetCursorPosition(guildX - 3, guildY - 1);
                Console.Write("※길드※");
                Console.SetCursorPosition(guildX, guildY);
                Console.Write("○");

                Console.SetCursorPosition(resxX - 4, restY + 1);
                Console.Write("♨휴식터♨");
                Console.SetCursorPosition(resxX, restY);
                Console.Write("○");

                Console.SetCursorPosition(0, restY + 2);
                Console.Write("________________________________________________________________________________");

                Random rand = new Random();

                if (x == shopX && y == shopY)
                {
                    Console.SetCursorPosition(0, restY + 4);
                    Console.WriteLine("재련하기 위해 필요한 골드 요구량 ↓");
                    Console.WriteLine("초급 광부 : 500골드 / 중급 광부 : 1500골드 / 고급 광부 : 3000골드");
                    
                    if (level == "초급 광부")
                    {
                        if (money >= 500 && levelPoint != 100)
                        {
                            Console.SetCursorPosition(0, restY + 8);
                            Console.WriteLine("승급 점수 10점 상승!!!!");
                            levelPoint += 10;
                            money -= 500;
                            Console.WriteLine($"남은 승급 점수 {100 - levelPoint}점");
                        }
                        else if (money < 500)
                        {
                            Console.SetCursorPosition(0, restY + 8);
                            Console.WriteLine("골드가 부족합니다! 골드를 모아오십시오.");
                        }
                        else if (levelPoint == 100)
                        {
                            Console.SetCursorPosition(0, restY + 8);
                            Console.WriteLine("이미 승급 점수가 충분합니다! 길드로 가서 승급하십시오!");
                        }
                    }
                    else if (level == "중급 광부")
                    {
                        if (money >= 1500 && levelPoint != 100)
                        {
                            Console.SetCursorPosition(0, restY + 8);
                            Console.WriteLine("승급 점수 10점 상승!!!!");
                            levelPoint += 10;
                            money -= 500;
                            Console.WriteLine($"남은 승급 점수 {100 - levelPoint}점");
                        }
                        else if (money < 500)
                        {
                            Console.SetCursorPosition(0, restY + 8);
                            Console.WriteLine("골드가 부족합니다! 골드를 모아오십시오.");
                        }
                        else if (levelPoint == 100)
                        {
                            Console.SetCursorPosition(0, restY + 8);
                            Console.WriteLine("이미 승급 점수가 충분합니다! 길드로 가서 승급하십시오!");
                        }
                    }
                    else if (level == "고급 광부")
                    {
                        if (money >= 3000 && levelPoint != 100)
                        {
                            Console.SetCursorPosition(0, restY + 8);
                            Console.WriteLine("승급 점수 10점 상승!!!!");
                            levelPoint += 10;
                            money -= 500;
                            Console.WriteLine($"남은 승급 점수 {100 - levelPoint}점");
                        }
                        else if (money < 500)
                        {
                            Console.SetCursorPosition(0, restY + 8);
                            Console.WriteLine("골드가 부족합니다! 골드를 모아오십시오.");
                        }
                        else if (levelPoint == 100)
                        {
                            Console.SetCursorPosition(0, restY + 8);
                            Console.WriteLine("이미 승급 점수가 충분합니다! 길드로 가서 승급하십시오!");
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(0, restY + 8);
                        Console.WriteLine("전문가는 승급 포인트가 오르지 않습니다.");
                    }
                    x++;
                }
                else if (x == mineX && y == mineY)
                {
                    if (health > 30)
                    {
                        int rnd = rand.Next(1, 101);
                        if (level == "초급 광부")
                        {
                            if (rnd == 1)
                            {
                                money += 2000;
                                health -= 30;
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("다이아몬드 발견!★");
                                Console.WriteLine("소지금 2000골드 흭득!");
                            }
                            else if (rnd > 1 && rnd <= 60)
                            {
                                money += 50;
                                health -= 30;
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("동 발견...");
                                Console.WriteLine("소지금 50골드 흭득!");
                            }
                            else if (rnd > 60 && rnd <= 90)
                            {
                                money += 150;
                                health -= 30;
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("은 발견");
                                Console.WriteLine("소지금 150골드 흭득!");
                            }
                            else if (rnd > 90 && rnd <= 100)
                            {
                                money += 2000;
                                health -= 30;
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("금 발견!");
                                Console.WriteLine("소지금 400골드 흭득!");
                            }
                        }
                        else if (level == "중급 광부")
                        {
                            if (rnd > 0 && rnd <= 3)
                            {
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("다이아몬드 발견!★");
                                Console.WriteLine("소지금 2000골드 흭득!");
                                money += 2000;
                                health -= 30;
                            }
                            else if (rnd > 3 && rnd <= 50)
                            {
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("동 발견...");
                                Console.WriteLine("소지금 50골드 흭득!");
                                money += 50;
                                health -= 30;
                            }
                            else if (rnd > 50 && rnd <= 85)
                            {
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("은 발견");
                                Console.WriteLine("소지금 150골드 흭득!");
                                money += 150;
                                health -= 30;
                            }
                            else if (rnd > 85 && rnd <= 100)
                            {
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("금 발견!");
                                Console.WriteLine("소지금 400골드 흭득!");
                                money += 2000;
                                health -= 30;
                            }
                        }
                        else if (level == "고급 광부")
                        {
                            if (rnd > 0 && rnd <= 5)
                            {
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("다이아몬드 발견!★");
                                Console.WriteLine("소지금 2000골드 흭득!");
                                money += 2000;
                                health -= 30;
                            }
                            else if (rnd > 1 && rnd <= 40)
                            {
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("동 발견...");
                                Console.WriteLine("소지금 50골드 흭득!");
                                money += 50;
                                health -= 30;
                            }
                            else if (rnd > 40 && rnd <= 80)
                            {
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("은 발견");
                                Console.WriteLine("소지금 150골드 흭득!");
                                money += 150;
                                health -= 30;
                            }
                            else if (rnd > 80 && rnd <= 100)
                            {
                                Console.SetCursorPosition(0, restY + 4);
                                Console.WriteLine("금 발견!");
                                Console.WriteLine("소지금 400골드 흭득!");
                                money += 2000;
                                health -= 30;
                            }
                        }
                        else if (level == "전문가")
                        {
                            Console.SetCursorPosition(0, restY + 4);
                            Console.WriteLine("다이아몬드 발견!★");
                            Console.WriteLine("소지금 2000골드 흭득!");
                            money += 2000;
                            health -= 30;
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(0, restY + 4);
                        Console.WriteLine("체력이 부족하여 광산에 들어갈 수 없습니다!");
                        Console.WriteLine("체력을 회복해 주세요!");
                    }
                    x--;
                }
                else if (x == guildX && y == guildY)
                {
                    if (levelPoint == 100)
                    {
                        if (level == "초급 광부")
                        {
                            level = "중급 광부";
                            Console.SetCursorPosition(0, restY + 4);
                            Console.WriteLine("축하합니다 중급 광부로 승급하셨습니다!");
                            levelPoint = 0;
                        }
                        else if (level == "중급 광부")
                        {
                            level = "고급 광부";
                            Console.SetCursorPosition(0, restY + 4);
                            Console.WriteLine("축하합니다 고급 광부로 승급하셨습니다!");
                            levelPoint = 0;
                        }
                        else if(level == "고급 광부")
                        {
                            level = "전문가";
                            Console.SetCursorPosition(0, restY + 4);
                            Console.WriteLine("축하합니다 고급 광부로 승급하셨습니다!");
                            levelPoint = 0;
                        }
                        else
                        {
                            Console.SetCursorPosition(0, restY + 4);
                            Console.WriteLine("죄송합니다. 이미 최고 등급의 광부입니다.");
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(0, restY + 4);
                        Console.WriteLine("승급에 필요한 점수가 모자릅니다!");
                    }
                        y++;
                }
                else if(x == resxX && y == restY)
                {
                    if (health != maxhealth)
                    {
                        health = maxhealth;
                        Console.SetCursorPosition(0, restY + 4);
                        Console.WriteLine("휴식을 취해 체력을 가득 채웠습니다!");
                    }
                    else
                    {
                        Console.SetCursorPosition(0, restY + 4);
                        Console.WriteLine("체력이 이미 가득 차있습니다!");
                    }
                    y--;
                }

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
                    case ConsoleKey.LeftArrow: if (x > 0) x--; break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
                    case ConsoleKey.Escape: break;

                }

            }

        }
    }
}
