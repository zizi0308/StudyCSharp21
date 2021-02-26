using System;

namespace NewInheritTestApp
{
    class Animal // 동물클래스
    {
        public string Name { get; set; } // 프로퍼티 // 값을 넣을 수 있고 가져올 수 도 있는 것이라 생각, 클래스에서 멤버변수를 지정하기 위한방법
        public int Age { get; set; } // 속성은 get, set 기능은 method를 쓴다.

        public void Breath()
        {
            Console.WriteLine($"{this.Name} 이 숨을 쉽니다.");
        }
    }
}
