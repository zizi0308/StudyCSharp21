using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13App  // WinForm 작업시 이벤트를 처리하기 위해 Delegate를 사용한다.
{
    delegate int MyDelegate(int a, int b); // 대리자 >> 대신호출 // 호출할 메서드와 파라미터 타입 개수가 일치해야한다.
    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate Callback;  // 호출자가 콜백을 호출

            Callback = new MyDelegate(calc.Plus); // 대리자가 calc.Plus라는 메서드를 호출함
            Console.WriteLine($"result = {Callback(3, 4)}");

            Callback = new MyDelegate(calc.Minus);
            Console.WriteLine($"result = {Callback(5, 2)}");
        }
    }
}
