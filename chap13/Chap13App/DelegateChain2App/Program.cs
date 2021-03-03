using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain2App // Delegate만 있으면 한꺼번에 여러 일 처리할 수 있고 이벤트 순서 바꿀수 있음 + WinForm에 있는 이벤트들이 이걸로 작성됨 
{
    class Program
    {
        delegate void ThereIsAFire(string location);  // 대리자 선언

        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? 불났어요! 주소는 {location} 에요!");
        }

        static void ShotOut(string location)
        {
            Console.WriteLine($"불이야!! {location}에 불났어요!");
        }

        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나갑시다!!");
        }
        static void Main(string[] args)
        {
            ThereIsAFire fire = new ThereIsAFire(ShotOut);
            fire += Call119;  // new ThereIsAFire(Call119); <<기본문법 앞에는 약식
            fire += Escape;

            fire("문현동 전광빌라");
        }
    }
}
