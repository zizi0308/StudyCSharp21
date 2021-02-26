using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypeCastApp
{
    class Mammal // 포유류
    {
        public string Name { get; set; }
        public void Nurse()
        {
            Console.WriteLine($"{this.Name} 을(를) 키우다");
        }
    }

    class Dog : Mammal // 강아지
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name}, 멍멍!!");
        }
    }

    class Cat : Mammal // 야옹이
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name}, 앩옹!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Name = "포유류";
            mammal.Nurse();

            Dog poppi = null; // new Dog
           /* poppi.Name = "뽀삐";
            poppi.Nurse();
            poppi.Bark();*/

            /*Cat chichi = new Cat();
            chichi.Name = "치치";
            chichi.Nurse();
            chichi.Meow();*/

            if (poppi is Mammal) // 뽀삐는 포유류인가??
            {   // 일반적인 값형식은 long = int값;
                Mammal mammal1 = poppi as Mammal; // 참조형식은 as를 써서 형변환을 해줘야한다
                mammal1.Nurse();
                // mammal1.Bark(); // err
            }

            if (mammal is Dog)
            {
                poppi = mammal as Dog;
                poppi.Nurse();
                poppi.Bark();
            }
        }
    }
}
