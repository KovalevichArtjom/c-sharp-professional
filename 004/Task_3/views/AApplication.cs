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
        private readonly RegexOptions options;
        private readonly List<string> prepositions;
        private readonly string template;

        public AApplication()
        {
            this.prepositions = new List<string> {
                "на", "под", "за", "к", "из",
                "по", "об", "от", "в", "у",
                "с", "о", "над", "около", "при",
                "перед"
            };
            this.options = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;
            this.template = @"\b({0})\b";
    }

        abstract public void run();
        protected string repPrepositions(string content)
        {
            if (!String.IsNullOrEmpty(content))
            {
                dynamic pattern = new StringBuilder();

                foreach (string preposition in this.prepositions)
                {
                    if (prepositions.IndexOf(preposition) != 0) pattern.Append('|');

                    pattern.Append(preposition);
                }
                pattern = String.Format(
                    this.template,
                    pattern.ToString()
                );

                foreach (var match in Regex.Matches(content, pattern, this.options))
                {
                    content = Regex.Replace(
                        content,
                        String.Format(
                            this.template,
                            match.ToString()
                            ),
                        REPLACEMENT_WORD
                        );
                }
            }
            
            return content.ToString();
        }
    }
}
