using System;

namespace TryCatchApp
{
    class Program 
    {   /// <summary>
        /// 디버깅, 예외처리가 프로그램 만들기에서 가장 중요함!!!!!! 예외처리하면 비정상적 종료가 됨 but 예외처리하면 시간이 더  많이 걸림
        /// 그래도 예외처리를 꼭 해야함
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int x = 108, y = 0;
            int result = 0;

            try
            {
                for (int i = 0; i < 3; i++) // 컴퓨터가 비정상적인 상태로 멈춰버림(예외발생 지점에서 try-catch씀)
                {
                    Console.WriteLine($"{i}번째 값 : {arr[i]}");
                }

                result = x / y;
                Console.WriteLine($"결과는 {result}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            catch (Exception ex) // 예외가 너무 많아서 뭘 써야할지 모르겠을 때 Exception를 사용
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            Console.WriteLine("나머지 일처리 계속...");

            string strVal = null;
         
            try
            {
                string splitVal = strVal.Substring(6, 5);
                Console.WriteLine($"자른 문자 : {splitVal}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"원본 문자열이 비어있습니다. 값을 입력하세요 : {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"원본 문자열을 초기화 하세요 : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"기타예외발생 : {ex.Message}");
            }
            
            Console.WriteLine("일처리 또 있음...");
        }
    }
}
