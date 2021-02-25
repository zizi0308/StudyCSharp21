using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassApp
{
    partial class MyClass
    {
        public void method1() { Console.WriteLine("method1"); }
        public void method2() { Console.WriteLine("method2"); }
    }
}
