using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTestApp
{
    class Parent
    {
        protected string Name;

        public Parent(string Name) 
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Parent() 생성자");
        }

        /*~Parent()
        {
            Console.WriteLine($"{this.Name}.Parent 소멸자"); 소멸될때 자식부터 소멸된다.
        }*/

        public void ParentMethod()
        {
            // ...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }
    }

    class Child : Parent
    {
        public string Color; // 색상 // 클래스에서 public으로 만드는것은 가장 안좋은 방법임(보안상의 이유로) 



        public Child(string Name) : base(Name) // 내(Child)가 실행되려면 부모생성자 먼저 실행되고 자식클래스가 실행됨
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");
        }

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod(); // 부모클래스 메서드 실행

            Child c = new Child("자식");
            c.Color = "황색"; // 자식클래스에 메서드를 추가하면 부모클래스에는 영향을 받지 않는다
            c.ParentMethod(); // 자식은 부모의 것을 물려받기때문에 부모클래스 메서드 실행
            c.ChildMethod(); // 자식클래스 메서드 실행
            
        }
    }
}
