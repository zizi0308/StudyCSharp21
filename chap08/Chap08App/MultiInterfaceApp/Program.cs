using System;

namespace MultiInterfaceApp
{

    interface IRunnable // 자동차 종류
    {
        void Run();
    }

    interface IFlyable // 비행기 종류
    {
        void Fly();
    }

    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아!");
        }

        public void Run()
        {
            Console.WriteLine("달려!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar dreamCar = new DroneCar();
            dreamCar.Run();
            dreamCar.Fly();


            Console.WriteLine("자동차로 변경(Interface)");
            IRunnable car = dreamCar;
            car.Run();
            // car.Fly(); << err 부모가 자식으로 바뀔 수없다


            Console.WriteLine("비행기로 변경(Interface)");
            IFlyable plain = dreamCar;
            plain.Fly();
            // plain.Run(); << err 부모가 자식으로 바뀔 수없다

        }
    }
}
