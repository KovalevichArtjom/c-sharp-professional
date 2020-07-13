using System.IO;

namespace Task_3.views
{
    interface IFile
    {
        private string name
        {
            get 
            {
                return this.name;
            }
            set => this.name = value;
        }
        
        private string extension
        {
            get
            {
                return this.extension;
            }
            set => this.extension = value;
        }
        
        private string path
        {
            get
            {
                return this.path;
            }
            set => this.path = value;
        }

        private string pathApp
        {
            get
            {
                return this.pathApp;
            }
            set => this.pathApp = value;
        }
        
        private StreamWriter streamWriter 
        {
            get
            {
                return this.streamWriter;
            }
            set => this.streamWriter = value as StreamWriter;
        }
        
        private StreamReader streamReader
        {
            get
            {
                return this.streamReader;
            }
            set => this.streamReader = value as StreamReader;
        }

        public void write(string content);
        public StreamReader read();
    }
}
