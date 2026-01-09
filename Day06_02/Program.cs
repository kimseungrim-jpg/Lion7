using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day06_02
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴

        static void Main(string[] args)
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };

            string atk = "->";

            int playerX = 0;
            int playerY = 12;

            int atkX = playerX + 3;
            int atkY = playerY + 1;

            List<(int,int)> atkList = new List<(int,int )>();

            //ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false; // 콘솔창 커서 지우기

            int dwTime = Environment.TickCount; // 1/1000 초 단위로 초가 흐름



            while (true)
            {
                //1초루프
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    //키영역
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
                                atkList.Add((playerX + 3, playerY + 1));
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

                    if (atkList.Count > 0)
                    {
                        for (int i = 0; i < atkList.Count; i++)
                        {
                            Console.SetCursorPosition(atkList[i].Item1, atkList[i].Item2);
                            Console.WriteLine("->");

                            if (atkList[i].Item1 > 75)
                            {
                                atkList.Remove(atkList[i]);
                            }
                            else
                            {
                                atkList[i] = (atkList[i].Item1 + 1, atkList[i].Item2);
                            }
                        }
                    }
                }
            }
        }
    }
}
