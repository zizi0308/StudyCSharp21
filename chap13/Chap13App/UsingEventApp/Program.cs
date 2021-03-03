using System;

namespace UsingEventApp
{
    delegate void EventHandler(string message);

    class CustomNotifier
    {// 이벤트 선언, 사용하는 객체
        public event EventHandler SomethingHappend; //(대리자의 인스턴스 이벤트)

        public void DoSomething(int number) // CustomNotifier에서 하나의 실행되는 기능
        {
            int temp = number % 10; // 15 % 10 = 5 % 3 == 0 

            if (temp != 0 && temp % 3 == 0) // 3, 6, 9 로 떨어지는 값
            {
                SomethingHappend($"{number} : 짝!"); // 이벤트 사용 But, SomethingHappend(이벤트)에 대한 로직이 없음
            }
            else
            {
                SomethingHappend($"{number}");
            }
        }
    }
    class Program
    {
        /// <summary>
        /// 이벤트가 발생했을 때 실행되는 메서드(이벤트 핸들러)
        /// </summary>
        /// <param name="message"></param>
        public static void MyHandler(string message) //SomethingHappend가 Myhandler를 실행함
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");  // 모르겠으면 여기서 브레이크포인트 걸고 디버깅 해보기
            CustomNotifier notifier = new CustomNotifier();  // notifier가 있으니까 DoSomething을 위한 인스턴스를 만듦
            notifier.SomethingHappend += new EventHandler(MyHandler);// 이 이벤트를 내가 만든 로직이 있는 메서드랑 연결, 어떤 일이 발생했을때 실행

            for (int i = 1; i < 100; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
