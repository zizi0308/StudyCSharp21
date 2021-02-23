using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자더하기");
            var p2 = 456;
            Console.WriteLine(123 + 456); // 579
            // 문자열이 하나라도 있으면 문자열결합으로 봄
            Console.WriteLine("123" + p2); // 123456
            Console.WriteLine($"123{p2}"); // 위와 동일 (C# 6.0이후 문자열 만드는 방법)
            Console.WriteLine(123 + "456"); // 123456
            Console.WriteLine($"123{456}"); // 123456

            // 관계연산자
            Console.WriteLine("관계연산자");
            int a = 30, b = 30;
            Console.WriteLine(a < b); // False
            Console.WriteLine(a > b); // False
            Console.WriteLine(a <= b); // True
            Console.WriteLine(a >= b); // True
            Console.WriteLine(a == b); // True
            Console.WriteLine(a != b); // False

            // 논리연산자
            Console.WriteLine("논리연산자");
            Console.WriteLine(10 > 9 && a > 0); // True, and조건절 둘 다 참이어야 참
            Console.WriteLine(a > b || b > 0); // True, or조건절 둘 중 하나가 참이면 참
            Console.WriteLine(!(a < b)); // True, (a < b)가 거짓이 아니다(!)

            // 조건(삼항)연산자는 단항 if문 대체가능
            int c = 30;
            string result = c == 30 ? "삼십" : "삼십아님";
            /*if (c == 30)
                result = "삼십";
            else
                result = "삼십아님";*/
            Console.WriteLine(result);

            Console.WriteLine($"NULL병합연산자");
            int? d = null;
            Console.WriteLine($"{d ?? 0}"); // null이면 0값으로 대체해라 (SQL의 isnull과 같은 개념)

        }
    }
}
