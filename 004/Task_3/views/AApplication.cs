using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_3.views
{
    abstract class AApplication
    {
        const string REPLACEMENT_WORD = "ГАВ!";

        private Regex reg;
        private readonly List<string> prepositions;

        public AApplication()
        {
            this.prepositions = new List<string> {
                "на", "под", "за", "к", "из",
                "по", "об", "от", "в", "у",
                "с", "о", "над", "около", "при",
                "перед"
            };
        }

        abstract public void run();
        private void repPrepositions(StringReader stringReader)
        {
            var content = stringReader.ReadToEnd();
            var pattern = new StringBuilder();
            
            pattern.Append('(');
            foreach (string preposition in this.prepositions)
            {
                if (prepositions.IndexOf(preposition) != 0) pattern.Append('|');
                pattern.Append(preposition);
            }
            pattern.Append(')');

            Console.WriteLine("{0}", pattern.ToString());
        }
    }
}
