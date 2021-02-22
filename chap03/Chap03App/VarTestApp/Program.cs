using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarTestApp
{
    class Program
    {
        // var i = 100; 지역변수이므로 메인메서드 내부에서만 쓰임 형변환 필요없음
        static void Main(string[] args)
        {
            var i = 100;
            Console.WriteLine($"정수값은 {i}입니다.");
        }
    }
}
