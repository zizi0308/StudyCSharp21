using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTestApp // 부모메서드 재정의(부모가 가지고 있는 것을 수정)
{
    class Program
    {
        class ArmorSuite
        {
            public virtual void Initialize() // 자식클래스에서 재정의 virtual이 되어야 override됨
            {
                Console.WriteLine("ArmorSuite 초기화!");
            }
        }

        class IronMan : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("IronMan 생산!");
            }
        }

        class WarMachine : ArmorSuite
        {
            public override void Initialize()
            {
                // base.Initialize(); // 주석을 풀면 부모의 Initialize를 먼저함 (부모것을 물려받아 개선하는 것이기 때문에)
                Console.WriteLine("ArmorSuite개량 WarMachine 초기화!"); // 부모 Initialize 생략가능 실무에서는 대부분 생략함
                Console.WriteLine("Double-Barral 캐논 장착!");
                Console.WriteLine("Micro-Rocket 런처 장착!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            WarMachine machine = new WarMachine();
            machine.Initialize();

            Console.WriteLine("IronMan 생산");
            IronMan ironMan = new IronMan();
            ironMan.Initialize();

        }
    }
}
