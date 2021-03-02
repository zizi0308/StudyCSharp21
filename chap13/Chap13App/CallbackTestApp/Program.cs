﻿using System;

namespace CallbackTestApp
{
    delegate int Compare(int a, int b); // a, b 비교 대리자
    class Program
    {
        // 오름차순 a가 b보다 크면 1 리턴, 두개 같으면 0리턴, a < b -1리턴 
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;  // a, b를 순서 바꿀것 >> 오름차순이기 때문
            else if (a == b) return 0;
            else return -1;
        }
        // 내림차순 비교, a < b 1리텬, a == b 0리턴, a > b -1리턴
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1; // b, a를 순서 바꿀것 >> 내림차순이기 때문
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] DataSet, Compare compare)
        {
            int temp = 0;
            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length - (i+1); j++)
                {
                    // 비교하면서 값 위치변경 Swap
                    if (compare(DataSet[j], DataSet[j+1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };
            Console.WriteLine("Sorting...");
            BubbleSort(array, new Compare(DescendCompare)); // 오름(내림)차순 정렬 BubbleSort라는 대리자가 new Compare(DescendCompare)를 호출
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
