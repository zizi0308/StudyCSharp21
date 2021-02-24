using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierApp
{
    class Boiler
    {
        private int temp = 5; // 사용자가 잘못된 작동을 하지 않도록 막아줌  // public, protected, private, internal(빈도낮음)

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의온도가 일정온도를 벗어났습니다. 59도로 맞춥니다");
                this.temp = 59;
                return;
            }
            else
            {
                this.temp = temp;
            }
            
            this.temp = temp;
        }

        public int GetTemp()
        {
            return this.temp;
        }

        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 켭니다.");
        }

        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 끕니다.");
        }
    }
    class MainApp
    {
        static void Main(string[] args) // static void Main => entry point는 한 프로그램 당 하나밖에 없다
        {
            Boiler kitturami = new Boiler();
            var currTemp = kitturami.GetTemp();
            Console.WriteLine($"현재온도는 {currTemp}℃ 입니다");
            kitturami.SetTemp(40);
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);

            if (kitturami.GetTemp() >= 59)
            {
                kitturami.TurnOffBoiler();
            }
            
            /* kitturami.TurnOnBoiler();

             kitturami.TurnOffBoiler();*/
        }
    }
}
