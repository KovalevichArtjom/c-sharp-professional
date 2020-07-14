using System;
using System.IO;
using Task_3.views;

namespace Task_3.models
{
    class File : IFile
    {
        public StreamReader read()
        {
            throw new NotImplementedException();
        }

        public void write(string content)
        {
            throw new NotImplementedException();
        }
    }
}
