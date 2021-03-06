﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOverrideTestApp
{
    class Mammal  // 포유류
    {
        public string Name { get; set; }
        
        public void Breate()
        {
            Console.WriteLine($"{this.Name}이(가) 숨을 쉰다");
        }

        public virtual void Move() // virtual >> 부모의 행동도 같이함
        {
            Console.WriteLine($"(부모작업) {this.Name}이(가) 이동한다");
        }
    }
    // 자식클래스에서 부모로부터 상속받은 method를 override해서 메서드를 재정의
    class Dog : Mammal
    {
        /* public void Move()
         {
             Console.WriteLine($"{this.Name}이(가) 네발로 달린다");
         }*/
        public override void Move()
        {
            base.Move(); // 부모에 있는 Move실행
            Console.WriteLine($"{this.Name}이(가) 네발로 달린다"); // + alpha 실행
        }
    }
    class Human : Mammal
    {
        public void Move() // 부모의 메서드를 숨긴다
        {
            Console.WriteLine($"{this.Name}이(가) 두발로 움직인다");
        }
    }

    class Whale : Mammal // 고래
    {
        public void Move() // 부모의 메서드를 재정의
        {
            Console.WriteLine($"{this.Name}이(가) 헤엄쳐서 움직인다");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog poppi = new Dog();
            poppi.Name = "poppi";
            poppi.Move();

            Human mansigi = new Human();
            mansigi.Name = "만식이";
            mansigi.Move();

            Whale whale = new Whale();
            whale.Name = "whale";
            whale.Move();
        }
    }
}
