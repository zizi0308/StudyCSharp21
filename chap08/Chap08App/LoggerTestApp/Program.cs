﻿using System;

namespace LoggerTestApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }

    interface IFormattalbeLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleFormatLogger : IFormattalbeLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args); // ?
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleLogger Test");
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그메세지");

            IFormattalbeLogger logger2 = new ConsoleFormatLogger();
            logger2.WriteLog("{0} * {1} = {2}", 3, 4, 12); // IFormattalbeLogger.WriteLog(format, args)
        }
    }
}
