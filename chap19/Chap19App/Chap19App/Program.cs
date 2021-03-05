using System;
using System.Threading;

namespace Chap19App
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Dosomething : {i}");
                Thread.Sleep(10); // 1/100초동안 멈춤
            }
        }
        static void SomethingHappened()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"SomethingHappened : {i}");
                Thread.Sleep(10); // 1/100초동안 멈춤
            }
        }


        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(DoSomething));
            Thread thread1 = new Thread(SomethingHappened); 

            try
            {
                Console.WriteLine("스레드시작!");
                thread.Start();
                thread1.Start();

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Main thread : {i}");
                    Thread.Sleep(10);

                    if (i == 10)
                        thread.Abort(); // 트랜잭션의 예와 비슷함 >> 일처리하고 있는 도중에 함부로 종료하면 오류발생함
                }


                Console.WriteLine("스레드 종료 대기...");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            finally
            {
                thread.Join();
                thread1.Join();

                Console.WriteLine("프로세스 종료...");
            }
        }
    }
}
