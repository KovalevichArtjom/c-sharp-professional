using System;
using System.IO;
using System.Text;
using System.Xml;

namespace Task_2
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
            Console.ForegroundColor = ConsoleColor.Green;
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

            StreamReader streamReader = new StreamReader(pathToXML);
            var xmlReader = new XmlTextReader(streamReader);

            while (xmlReader.Read())
            {
                Console.WriteLine("{0, -15} {1, -10} {2, 10}",
                    xmlReader.NodeType.ToString(),
                    xmlReader.Name,
                    xmlReader.GetAttribute("value"));
            }

            xmlReader.Close();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress to continue...");

            Console.ReadKey();
        }
    }
}
