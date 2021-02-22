using System;

namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}");
            result += 3;
            Console.WriteLine($"현재 숫자는 {result}"); // 29
            result -= 10;
            Console.WriteLine($"현재 숫자는 {result}"); //19
            // result++
            Console.WriteLine($"후치증가 값은 {result++}"); // 19 (현재줄 실행하고 1을 증가시킴 때문에 19) if {++result}, 20이 됨
            // Console.WriteLine($"현재 숫자는 {result}"); result += 1;
            Console.WriteLine($"전치증가 값은 {++result}");
            // result += 1; Console.WriteLine($"현재 숫자는 {result}");
            // result += 1;
            Console.WriteLine($"후치감소 값은 {result--}");
            Console.WriteLine($"전치감소 값은 {--result}");
        }
    }
}
