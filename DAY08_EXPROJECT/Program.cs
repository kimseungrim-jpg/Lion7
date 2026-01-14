using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAY08_EXPROJECT
{
    class RPGCharacter
    {
        // Private 필드
        private string name;
        private string job;
        private int level;
        private int nowHP;
        private int maxHP;
        private int nowMP;
        private int maxMP;
        private int atk;
        private int def;
        private int exp;
        private int gold;

        //public 프로퍼티


        public void ShowStatus()
        {
            Console.WriteLine("╔═══════════════════════════════╗");
            Console.WriteLine("      === 캐릭터 정보 === ");
            Console.WriteLine($"  {name} - {job}");
            Console.WriteLine($"  레벨: {level}");
            Console.WriteLine("╠═══════════════════════════════╣");
            Console.WriteLine($"  HP: {nowHP}/{maxHP}");
            Console.WriteLine($"  MP: {nowMP}/{maxMP}");
            Console.WriteLine($"  공격력: {atk}");
            Console.WriteLine($"  방어력: {def}");
            Console.WriteLine($"  경험치: {exp}/100");
            Console.WriteLine($"  골드: {gold}");
            Console.WriteLine($"╚══════════════════════════════╝");
        }
    }

    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int dwTime = Environment.TickCount;

            string player = "↑";

            int playerX = 0;
            int playerY = 13;

            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                if (dwTime + 100 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;

                    

                    Console.SetCursorPosition(50, 1);
                    Console.WriteLine("몬스터 선택");

                    Console.SetCursorPosition(40, 3);
                    Console.Write("고블린");

                    Console.SetCursorPosition(65, 3);
                    Console.Write("슬라임");

                    RPGCharacter character = new RPGCharacter();
                    Console.SetCursorPosition(0, 1);
                    character.ShowStatus();

                    int pressKey;

                    if (Console.KeyAvailable)
                    {
                        pressKey = _getch();

                        if (pressKey == 224)
                        {
                            pressKey = _getch();
                        }

                        switch (pressKey)
                        {
                            case 72:  //위쪽방향 아스키코드                    
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:
                                //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:
                                //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80: //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32:
                                
                                break;
                        }
                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }
                }
            }
        }
    }
}
