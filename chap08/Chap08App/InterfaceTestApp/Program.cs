using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    /*class Ridable
    {
        public virtual void Ride()
        {
            Console.WriteLine("탈것");
        }
    }*/

    interface ICar
    {
        void Run();
        void Ride();

    }

    interface IPlain
    {
        void Fly();

        void Ride(); // ICar, IPlain의 중복되는 void Ride();는 내용이 있지 않기때문에 구현만 하면 된다는 약속을 함 << 다중상속의 문제 해결

    }

    class DroneCar : ICar, IPlain
    {
        public void Fly()
        {
            Console.WriteLine("드론카 날다!");
        }

        public void Ride()
        {
            Run();
            Fly();
        }

        public void Run()
        {
            Console.WriteLine("드론카 달리다!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DroneCar droneCar = new DroneCar();
            droneCar.Ride();
        }
    }
}

