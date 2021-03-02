using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassApp
{
    class Array_Generic<T> // Array_Int 대신 클래스 일반화
    {
        private T[] array;

        public Array_Generic()
        {
            array = new T[10];
        }

        public T GetElement(int index) { return array[index]; }

        public int Lenght { get { return array.Length; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Array_Generic<int> array = new Array_Generic<int>();

            // Array_Generic<string> strArr = new Array_Generic<string>(); string으로 만들면 이렇게도 할 수 있음
        }
    }
}
