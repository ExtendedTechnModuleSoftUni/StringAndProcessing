namespace _03ME.Pyramidic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Pyramidic
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var strings = new List<string>();
            var resultPyramid = new StringBuilder();
            var maxLength = 0;

            for (int i = 0; i < n; i++)
            {
                strings.Add(Console.ReadLine());
            }

            BuildPyramids(strings, resultPyramid, maxLength);

            Console.WriteLine(resultPyramid.ToString());
        }

        private static void BuildPyramids(List<string> strings, StringBuilder resultPyramid, int maxLength)
        {
            for (int a = 0; a < strings.Count; a++)
            {
                var currentString = strings[a];

                for (int b = 0; b < currentString.Length; b++)
                {
                    var currentChar = currentString[b];
                    var layer = 1;
                    var currentPyramid = "";

                    for (int c = a; c < strings.Count; c++)
                    {
                        string stringLayer = new string(currentChar, layer);

                        if (strings[c].Contains(stringLayer))
                        {
                            currentPyramid += stringLayer + "\r\n";
                        }
                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    var length = currentPyramid.Trim().Length;

                    if (length > maxLength)
                    {
                        maxLength = length;
                        resultPyramid.Clear();
                        resultPyramid.Append(currentPyramid.Trim());
                    }
                }
            }
        }
    }
}
