using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap08App
{
    interface ILogger
    {
        void WriteLog(string msg);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"{DateTime.Now} log : {msg}");
        }
    }

    class CustomLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"Log : {msg}\a\a");
        }
    }
    class ClimateLogger
    {
        private ILogger logger;
        public ClimateLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            while (true)
            {
                Console.Write("온도를 입력 : ");
                string temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp)) break;

                logger.WriteLog($"현재온도 : {temp}");
            }
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            // ILogger logger = new ILogger(); >> 인터페이스 자체로는 형변환 못함
            // ILogger를 구현해서 가져와 쓰는것은 가능함 아까 강아지 부모클래스에 자식인스턴스 만들어쓴 것처럼
            //ILogger logger = new ConsoleLogger(); << 아래와 동일하게 쓰임
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그출력"); // 내가 직접 로그를 찍음

            ClimateLogger clogger = new ClimateLogger(new CustomLogger()); //ClimateLogger가 미리 만들어 졌다고 생각해야 함
            clogger.Start();// 우리가 안하고 프레임워크가 실행시켜주는것 IoC(제어의 역흐름)  우리는 Start만 실행시켜주면 됨
        }
    }
}
