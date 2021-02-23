using System;

namespace JumpTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 3) continue; // break; << 3찍히기 전에 멈춤

                Console.WriteLine(i);
            }
        }
    }
}
