using System;

namespace ConstTestApp
{
    class Program
    {
        enum Season // 변수명(시즌타입)
        {
            봄,
            여름,
            가을,
            겨울

        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double PI = 3.141592;
            Console.WriteLine($"원주율의 값은 {PI}");
            // PI = 6.345; 실행부터 오류남

            Season mySeason = Season.겨울; //(Season) 3; 할 수도 있지만 위에 열거형 값이 변경된다면(겨울 = 200) 3을 쓸 수 없다
            Console.WriteLine($"지금 계절은 {mySeason}입니다");

            int a = 0; // null;
            Console.WriteLine($"a는 {a}");
            int? b = null;
            Console.WriteLine($"b는 {b}");
        }
    }
}
