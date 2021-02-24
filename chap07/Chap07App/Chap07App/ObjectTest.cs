using System;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체사용");

            /*//Cat cat1 = new Cat();
            *//*기본적인 값형식은 그냥쓰면 끝남 but 참조형식은 객체의 인스턴스를 생성하는 new를 써야함 
            생성자체는 행위이므로메서드는 행위 그러므로 괄호를 써야함*//*
            Cat cat1 = new Cat(_name: "야옹이", _color: "흰색", _gender: "땅콩o");
            //cat1.Name = "야옹이";
            //cat1.Color = "흰색";
            cat1.Meow();

            Cat kitty = new Cat();
            kitty.Name = "헬로키티";
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat();
            nero.Name = "검은고양이 네로";
            nero.Color = "검은색";
            nero.Meow();*/

            Cat yomi = new Cat("요미", "흰색", "공주님");
            yomi.Meow();

        }
    }

    class Cat
    {
        public Cat() { } // 사용자정의 생성자를 쓸 경우에는 기본생성자가 일을 안하므로 꼭 이걸 적어줘야함

        // ~Cat() { } //더이상 필요없는 소멸자
        public Cat(string Name) 
        {
            this.Name = Name; // this(Name)이 여기서 호출됨 this.Name은 파라미터안의 Name을 나타냄
        }


        public Cat(string Name, string Color) : this(Name)// 사용자정의 생성자 this(Name, Color)이 여기서 호출됨
        {
            // this.Name = Name;
            this.Color = Color;
        }

        // 매개변수
        public Cat(string Name, string Color, string Gender) : this(Name, Color) // _ 파라미터에 변수이름을 쓰기위해 넣음 ex)string _name
        {
            this.Gender = Gender; // Gender은 위에 파라미터를 의미함 
        }
        // 멤버변수(멤버필드)
        public string Name; // 이름 >>
        public string Color; // 색상 >> 특성속성 변수
        public string Gender;

        public void Meow()
        {
            Console.WriteLine($"{this.Name}(색상{this.Color}/ 성별{this.Gender}) : 야옹!");  // 행위기능 메서드 얘는 굳이 this안써도 식별 가능
        }
    }
}
