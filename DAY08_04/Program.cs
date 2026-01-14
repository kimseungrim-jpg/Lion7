using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAY08_04
{
    class Student
    {
        // TODO: 필드 선언
        private string name;
        private int score;
        // TODO: Name 프로퍼티 (읽기 전용)
        public string Name
        {
            get;
        }
        // TODO: Score 프로퍼티 (0~100 검증)
        public int Score
        {
            get
            {
                return score;
            }
            set 
            { 

                if (value < 0)
                {
                    Console.WriteLine($"점수는 0~100사이여야 합니다.(입력값 : {value})");
                    score = 0;                   
                }
                else if(value >100)
                {
                    Console.WriteLine($"점수는 0~100사이여야 합니다.(입력값 : {value})");
                    score = 100;
                }
                else
                {
                    score = value;
                }
            }
        }
        // TODO: Grade 프로퍼티 (자동 계산, 읽기 전용)
        public string Grade
        {
            get
            {
                if (score <= 100 && score >= 90)
                {
                    return "A";
                }
                else if (score < 90 && score >= 80)
                {
                    return "B";
                }
                else if (score < 80 && score >= 70)
                {
                    return "C";
                }
                else if (score < 70 && score >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }
        // 생성자
        public Student(string studentName)
        {
            // TODO: 구현
            name = studentName;
        }

        // 정보 출력
        public void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"점수: {score}점");
            Console.WriteLine($"등급: {Grade}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
        }
    }
    internal class Program
    {  
        static void Main(string[] args)
        {
            Student student = new Student("홍길동");

            student.Score = 95;
            student.ShowInfo();

            Console.WriteLine();

            student.Score = 75;
            student.ShowInfo();

            Console.WriteLine();

            // 잘못된 값 입력 시도
            student.Score = 150;  // 100으로 제한되어야 함
            student.Score = -10;  // 0으로 제한되어야 함
            student.ShowInfo();
        }
    }
}
