using System;

namespace Chap05App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // while문은 종료x
            {
                Console.Write("수를 입력하세요 : ");
                string line = Console.ReadLine(); // 콘솔에서 입력값을 변수할당

                if (line == "quit") break; // quit 입력하면 프로그램 종료.

                int number = 0; // int.Parse(line); >> int아닌 값을 썼을 때 에러남
                int.TryParse(line, out number); // TryParse는 line값이 변환안될때 대신 0을 넣어줌 >> Parse보다는 TryParse를 써서 처리하는게 좋음
                // Console.WriteLine(number);
               
                // todo 아래 로직을 수정하세요 이거 진짜 많이쓰임
                if (number > 0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine("0보다 큰 짝수");
                    else
                        Console.WriteLine("0보다 큰 홀수");
                }
                else
                {
                    Console.WriteLine("0보다 작은수");
                }
                // todo 마지막 
            }

            Console.WriteLine("계산종료!");
        }
    }
}
