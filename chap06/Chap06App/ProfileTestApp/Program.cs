using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("조희지", "010-6438-6926");
            if (PrintProfile(null, "010-6438-6926") == -1)
            {
                Console.WriteLine("프로필 출력시 오류가 발생했습니다");
            }

            /* PrintProfile(phone: "010-9999-9999", name: "홍길동");
             PrintProfile(name: "홍길순", phone: "010-8888-8888");*/
            PrintProfile("최백호");
        }

        public static int PrintProfile(string name, string phone = "010-7979-7979") 
        // 디폴트 값 : = "010-7979-7979" !!디폴트값은 맨앞에 못넣는다 (뒤에서부터 지정 가능) 그러므로 정확하게 넣어야하는값은 안쓰는게 좋음
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요");
                return -1;
            }

            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            return 0;
        }
    }
}
