using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{
    class Program
    {
        class Test
        {

        }
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34 }; /*new int[5];*/ // 값을 할당 + var보다는 변수의 타입을 지정하는게 좋음
            /*array[0] = 80;
            array[1] = 74;
            array[2] = 81;
            array[3] = 90;
            array[4] = 34;
            */

            Console.WriteLine($"Type fo array : {array.GetType()}");
            Console.WriteLine($"Base Type fo array : {array.GetType().BaseType}");

            for (int i = 0; i < array.Length; i++) // for문
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            var idx = 0;
            foreach (var item in array) // foreach
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");
            }

            Console.WriteLine("오름차순 정렬");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++) // for문
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("내림차순 정렬");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++) // for문
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            idx = Array.IndexOf(array, 34);
            Console.WriteLine($"34의 인덱스 : {idx}");

            idx = Array.IndexOf(array, 100);
            Console.WriteLine($"100의 인덱스 : {idx}");

            Console.WriteLine("배열 삭제");
            Array.Clear(array, 3, 2); // 3번째부터 2개 지운다
            for (int i = 0; i < array.Length; i++) // for문
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

        }
    }
}
