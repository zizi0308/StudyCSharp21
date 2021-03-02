using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            for (int i = 0; i < 5; i++) // 컴퓨터가 비정상적인 상태로 멈춰버림(예외발생) << 컴파일러가 못잡음(에러는 잡을 수 있음)
            {
                Console.WriteLine($"{i}번째 값 : {arr[i]}");
            }

            Console.WriteLine("나머지 일처리 계속..."); // 이거 실행안됨
        }
    }
}
