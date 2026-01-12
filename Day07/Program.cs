using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Day07
{
    internal class Program
    {
        //1단계 기본함수
        static void SayHello()
        {
            Console.WriteLine("안녕하세요, 모험을 시작합니다.");
        }

        static void ShowGameStart()
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║       ⚔ RPG 게임 시작 ⚔        ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
        }

        static void PrintSepatator()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }


        static void Main(string[] args)
        {           
            Console.OutputEncoding = Encoding.UTF8;
            //SayHello(); //기능한다라는 위주로 함수를 구현하면 좋다.
            //SayHello(); //재사용성 가독성 유지보수 <- cshap의 최대장점들

            ShowGameStart();
            PrintSepatator();

            Console.WriteLine("게임 메뉴를 불러옵니다.");

            PrintSepatator();

            Console.WriteLine("게임종료");

            PrintSepatator();
        }
    }
}
