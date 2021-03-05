using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowApp
{
    class MainApp : Form
    {
        
        public MainApp(string title)
        {
            this.Text = title;
            this.MouseClick += MainApp_MouseClick;  // 이벤트가 발생하는 부분 << 이벤트를 실행하려면 이 부분이 꼭 있어야함
        }

        private void MainApp_MouseClick(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            var result = $"sender : {sender} \r\ne : {e}\r\n" +
                         $"e.X : {e.X}, e.Y : {e.Y}" +
                         $"Button : {e.Button}, Clicks : {e.Clicks}";
            MessageBox.Show(result);
        }

        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event App"));
        }
    }
}
