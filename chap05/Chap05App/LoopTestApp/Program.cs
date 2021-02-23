using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("while문 ");
            int a = 10;
            while (a > 0)
            {
                Console.WriteLine($"숫자는 {a}");
                a -= 2; // 중괄호 하나에 다 넣지말고 밑에 넣기
            }
            Console.WriteLine("출력종료!");

            // a = 10;
            do
            {
                Console.WriteLine($"숫자 {a}");
                a++;
            } while (a < 10);

            Console.WriteLine("For문 ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i 값은 {i}");
            }

            Console.WriteLine("Forr문 ");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"i 값은 {i}");
            }*/

            Console.WriteLine("구구단 시작!");
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine("2단 시작!");
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                   // Console.WriteLine($"{i} * {j} = {i * j}\t");
                }
                Console.WriteLine($"{i}단 끝!");
                // Console.WriteLine($"\n{i}단 끝!");
            }
        }
    }
}
