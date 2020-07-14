using System;
using System.IO;
using System.Text;
using Task_3.views;
using Task_3.models;

namespace Task_3
{
    class Application : AApplication
    {
        private string content;
        public override void run()
        {
            Task_3.models.File file = new Task_3.models.File("text", "txt");
            this.content = file.read();
           
            if (!String.IsNullOrEmpty(this.content))
            {
                file.write(this.repPrepositions(this.content));
                Console.WriteLine("Successfully...");
            }
            else
            {
                Console.WriteLine("Not successful...");
            }
        }
    }
}
