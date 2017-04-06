namespace _05E.CapitalizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CapitalizeWords
    {
        public static void Main()
        {
            var inputSentense = Console.ReadLine();

            while (inputSentense != "end")
            {
                var pattern = @"[A-Za-z'\d]+";
                var regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(inputSentense);
                var words = new List<string>();

                foreach (var match in matches)
                {
                    var currentWord = match.ToString();
                    var sb = new StringBuilder();

                    for (int i = 0; i < currentWord.Length; i++)
                    {
                        if (i != 0)
                        {
                            sb.Append(currentWord[i].ToString().ToLower());
                        }
                        else
                        {
                            sb.Append(currentWord[i].ToString().ToUpper());
                        }
                    }

                    words.Add(sb.ToString());
                }

                Console.WriteLine(string.Join(", ", words));

                inputSentense = Console.ReadLine();
            }
        }
    }
}
