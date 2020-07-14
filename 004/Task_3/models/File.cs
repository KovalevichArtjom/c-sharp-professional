using System;
using System.IO;
using System.Text;
using Task_3.views;

namespace Task_3.models
{
    class File : IFile
    {
        private string name { get; set; }
        private string extension { get; set; }
        private string path { get; set; }
        private string pathFile { get; set; }
        private StreamReader streamReader { get; set; }
        public File(string name, string extension)
        {
            this.name       = name;
            this.extension  = extension;
            this.pathFile   = string.Format(
                @"{0}\files\{1}.{2}",
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                this.name,
                this.extension
                );
        } 

        public string read()
        {
            string content = "";
            try
            {
                this.streamReader = new StreamReader(this.pathFile, Encoding.Default);
                content = this.streamReader.ReadToEnd();
                this.streamReader.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return content;
        }

        public void write(string content)
        {
            if (!String.IsNullOrEmpty(content))
            {
                System.IO.File.WriteAllText(this.pathFile, content);
            }
        }
    }
}
