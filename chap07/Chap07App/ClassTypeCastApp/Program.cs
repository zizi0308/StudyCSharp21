using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{
    class 포유류
    {

        public void 키우다()
        {
            Console.WriteLine("키우다()");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            포유류 _포유류 = new 포유류();
            _포유류.키우다();

            _포유류 = new 강아지(); // 포유류는 강아지의 상위클래스 >> 자식클래스가 잠시 부모로 바뀌는 것이 가능하다
            _포유류.키우다();
            강아지 쭈쭈;

            if (_포유류 is 강아지)
            {
                쭈쭈 = _포유류 as 강아지;
                쭈쭈.멍멍();
            }

            /*((강아지)_포유류).멍멍();
            //_포유류.멍멍(); // 오류
            _포유류 = new 고양이();
            //_포유류.야옹(): // 오류

            // 강아지 뽀삐 = new 포유류(); >> 자식이 잠시 부모로 바뀌는 것은 가능 하지만 부모가 자식으로 바뀌는 것은 불가능*/


            강아지 뽀삐 = null;
            if (뽀삐 is 포유류)
            {
                Console.WriteLine("이부분이 실행됩니다"); // 자식클래스 인스턴스안에 부모클래스를 넣으면 실행X
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();
            }

        }
    }
}
