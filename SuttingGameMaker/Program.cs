using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SuttingGameMaker
{
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int playerX;
        public int playerY;

        public BULLET[] playerBullet = new BULLET[20];
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public int Score = 100;

        public Item item = new Item();
        public int ItemCount = 0;

        public Player()
        {
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++)
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }
        }

        public void GameMain()
        {
            keyControl();

            PlayerDraw();

            UIscore();

            if (item.ItemLife)
            {
                item.ItemDraw();

                CrashItem();
            }
        }

        public void CrashItem()
        {
            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;

                    if (ItemCount < 3)
                    {
                        ItemCount++;

                        for (int i = 0; i < 20; i++)
                        {
                            playerBullet[i] = new BULLET();
                            playerBullet[i].x = 0;
                            playerBullet[i].y = 0;
                            playerBullet[i].fire = false;

                            playerBullet2[i] = new BULLET();
                            playerBullet2[i].x = 0;
                            playerBullet2[i].y = 0;
                            playerBullet2[i].fire = false;

                            playerBullet3[i] = new BULLET();
                            playerBullet3[i].x = 0;
                            playerBullet3[i].y = 0;
                            playerBullet3[i].fire = false;
                        }
                    }
                }
            }
        }

        public void keyControl()
        {
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
                    case 72:
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 75:
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case 77:
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case 80:
                        playerY++;
                        if(playerY > 21)
                            playerY = 21;
                        break;
                    case 32:
                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;

                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;

                                break;
                            }
                        }

                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;

                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY;

                                break;
                            }
                        }

                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;

                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 2;

                                break;
                            }
                        }
                        break;
                }
            }
        }

        public void BulletDraw()
        {
            string bullt = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);

                    Console.Write(bullt);

                    playerBullet[i].x++;

                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false;
                    }
                }
            }
        }

        public void BulletDraw2()
        {
            string bullt = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);

                    Console.Write(bullt);

                    playerBullet2[i].x++;

                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false;
                    }
                }
            }
        }

        public void BulletDraw3()
        {
            string bullt = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);

                    Console.Write(bullt);

                    playerBullet3[i].x++;

                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            string[] player = new string[]
                {
                    "->",
                    ">>>",
                    "->"
                };

            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);

                Console.WriteLine(player[i]);
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        public void ClashEnemyAndBullet(Enemy enemy)
        {
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1) && playerBullet[i].x <= (enemy.enemyX + 1))
                        {
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false;

                            Score += 100;
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1) && playerBullet2[i].x <= (enemy.enemyX + 1))
                        {
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false;

                            Score += 100;
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        if (playerBullet3[i].x >= (enemy.enemyX - 1) && playerBullet3[i].x <= (enemy.enemyX + 1))
                        {
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet3[i].fire = false;

                            Score += 100;
                        }
                    }
                }
            }
        }
    }

    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "Item★";
            Console.Write(ItemSprite);
        }
    }

    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            string enemy = "JoL";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write(enemy);
        }

        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--;

            if (enemyX < 2)
            {
                enemyX = 75;
                enemyY = rand.Next(2, 22);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Player player = new Player();
            Enemy enemy = new Enemy();

            int dwTime = Environment.TickCount;

            while (true)
            {
                if (dwTime + 50 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    player.GameMain();

                    if (player.ItemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else
                    if (player.ItemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }

                    enemy.EnemyMove();
                    enemy.EnemyDraw();


                    player.ClashEnemyAndBullet(enemy);
                }
            }
        }
    }
}
