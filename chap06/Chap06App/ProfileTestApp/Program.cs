﻿using System;
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
        }

        public static int PrintProfile(string name, string phone)
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
