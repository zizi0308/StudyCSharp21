using System;
using System.Collections;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable 예제");

            Hashtable ht = new Hashtable();
            ht["일"]/*Table컬럼명*/ = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";

            Console.WriteLine(ht["일"]); // One
            Console.WriteLine(ht["이"]); // Two
            Console.WriteLine(ht["사"]); // Four

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}"); // 정렬하는 데이터가 아님(콘솔창에 순서 계속 바뀜)
            }

            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            ArrayList list2 = new ArrayList(new int[] { 123, 456, 789 });
            ArrayList list3 = new ArrayList() { 123, 456, 789 }; // 셋다 같은 결과 나옴
        }
    }
}
