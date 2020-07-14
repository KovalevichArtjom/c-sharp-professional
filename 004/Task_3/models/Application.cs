using System;
using System.IO;
using System.Text;
using Task_3.views;

namespace Task_3
{
    class Application : AApplication
    {
        public override void run()
        {
            var str = new StringBuilder();
            str.Append("Тестовый текст от и удаление предлогов из строк.");
            Console.WriteLine( this.repPrepositions((new StringReader(str.ToString()))));
        }
    }
}
