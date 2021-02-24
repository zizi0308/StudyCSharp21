using System;

namespace OverloadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기시작!");

            int x = Calculator.Plus(3, 4); // 여기로 점프해서 int x = 7이 됨
            Console.WriteLine($"3 + 4 = {x}");

            float y = Calculator.Plus(3.14f, 5.6f);
            Console.WriteLine($"3.14 + 5.6 = {y}");

            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, 5.6)}");

            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, "5")}");

            int z = Calculator.Plus(7, 8, 9);

            int total = 0;
            total = Sum(1, 2, 4, 5);

            Console.WriteLine($"합계는 {total}");
            Console.WriteLine($"10 까지의합은 {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");

            int[] arrs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"10 까지의합은 {Sum(arrs)}");
        }

        private static int Sum(params int[] args)
        {
            int result = 0;

            foreach (var arg in args)
            {
                result += arg;
            }
            return result;
        }

        // 메서드 만들었는데 참조가 0개라면 지우면 됨 but 써야할 가능성이 있다면 남겨둠
        private static double Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            double result = v1 + p2;
            return result;
        }

        private static double Plus(double v1, double v2)  //>> double에 대한 return값이 컴퓨터가 뭔지 모름 그러니까 object로 boxing해서 보내버림
        {
            double result = v1 + v2;
            return result;
        }

        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result; // return 자기를 호출한 위치로 점프
        }

        private static int Plus(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }
    }
}
