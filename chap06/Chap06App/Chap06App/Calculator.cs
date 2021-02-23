using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap06App
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int x = Calculator.Plus(3, 4); // 1.메서드 호출 (호출자)
            int y = Calculator.Plus(5, 6);
            int z = Calculator.Plus(7, 8);

            int result = x + y + z;
            Console.WriteLine($"결과는 {result}"); 
        }

        private static int Plus(int p1, int p2) // 2.호출된거 여기로 점프
        {
            // throw new NotImplementedException();
            Console.WriteLine($"Input : {p1}, {p2}"); //("Input : {0}, {1}", p1, p2);
            int result = p1 + p2;
            Console.WriteLine($"Output : {result}");
            return result; // 3.다시 불렀던 곳(1)으로 점프(호출자에게로 돌려놓음)
        }
    }
}
