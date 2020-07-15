using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace Additional_Task
{
    class Program
    {
        private const string NAME_FILE = "TelephoneBook";
        private const string EXTENSION_FILE = "xml";
        private const string ROOT_FILE = "files";

        private static readonly string pathApp = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private static string pathToXML;
        static void Main(string[] args)
        {
            pathToXML = (new StringBuilder())
                .Append(pathApp)
                .Append(@"\")
                .Append(ROOT_FILE)
                .Append(@"\")
                .Append(NAME_FILE)
                .Append(@".")
                .Append(EXTENSION_FILE)
                .ToString()
                ;

            var xmlWriter = new XmlTextWriter(pathToXML, null) 
            { 
                Formatting  = Formatting.Indented,
                IndentChar  = ' ',
                Indentation = 4,
                QuoteChar   = '\''
            };

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");
                xmlWriter.WriteStartElement("Contact");
                    xmlWriter.WriteStartAttribute("value");
                    xmlWriter.WriteString("contact");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("TelephoneNumber");
                    xmlWriter.WriteStartAttribute("value");
                    xmlWriter.WriteString("+375(33)688-94-09");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.Close();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(50, 25);
            Console.WriteLine("File \"{0}\" was created successfully!", NAME_FILE);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }
    }
}
