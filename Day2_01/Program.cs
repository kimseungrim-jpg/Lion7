using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const double Pi = 3.14159;
            //const int MaxScore = 100;

            //Console.WriteLine("Pi: " + Pi);
            //Console.WriteLine("MaxScore: " + MaxScore);

            const int Player = 4;
            const int Gold = 1000;
            const string version = "1.0.0";

            Console.WriteLine("=== 게임 설정 ===");
            Console.WriteLine("최대 플레이어: " + Player + "명");
            Console.WriteLine("시작 골드: " + Gold + "G");
            Console.WriteLine("버전: " + version);
        }
    }
}
