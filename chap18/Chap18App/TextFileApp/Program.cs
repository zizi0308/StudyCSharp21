using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Sources\Gitrepository\StudyCSharp21\SampleDir\SubFolder\a.dat"; // 텍스트파일 생성위치

            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write)); // 최초에는 create 나중에 추가는 Append
                sw.WriteLine($"int.MaxValue = {int.MaxValue}");
                sw.WriteLine("Hello, World!");
                sw.WriteLine($"uint.MaxValue = {uint.MaxValue}");
                sw.WriteLine("안녕하세요");
                sw.WriteLine($"double.MaxValue = {double.MaxValue}");

                Console.WriteLine("파일생성");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"파일쓰기 예외발생 : {ex.Message}");
            }
            finally
            {   
                if(sw != null)
                sw.Close(); // 열었으면 꼭 닫기!!! Close 안하면 에러남
            }

            StreamReader sr = null;
            
            try
            {
                sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)); // Open과 같은 역할
                Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

                while (sr.EndOfStream == false)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"파일읽기 예외발생 : {ex.Message}");
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
    }
}
