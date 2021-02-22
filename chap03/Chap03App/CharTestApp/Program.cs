using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자
            char ch1 = 't', ch2 = '\t', ch3 = '\n', ch4 = '0';
            Console.WriteLine($"{ch1}, {ch2}, {ch3}, {ch4}");
            char ch5 = '\\';
            Console.WriteLine($"{ch5}");
            // 문자열 \t = tap, \n = 줄바꾸기 이외에도 다양한 이스케이프 문자 있음
            string str1 = "\tHello, \nWorld!";
            // Console.WriteLine(str1);
            Console.WriteLine($"{str1}");

            bool isCorrect = false; // true, false와 true는 소문자로 써야함
            if (isCorrect)
            {
                Console.WriteLine("참입니다");
            }
            else
            {
                Console.WriteLine("거짓입니다");
            }
            Console.WriteLine(isCorrect); // 영어로 찍힘
        }
    }
}
