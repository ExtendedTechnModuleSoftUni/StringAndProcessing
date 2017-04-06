namespace _01ME.SerializeString
{
    using System;
    using System.Collections.Generic;

    public class SerializeString
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var countetChars = new List<char>();

            for (int i = 0; i < inputLine.Length; i++)
            {
                var indexes = new List<int>();
                char currentChar = inputLine[i];

                if (!countetChars.Contains(currentChar))
                {
                    var index = inputLine.IndexOf(currentChar);

                    while (index != -1)
                    {
                        indexes.Add(index);
                        index = inputLine.IndexOf(currentChar, index + 1);
                    }

                    Console.WriteLine($"{currentChar}:{string.Join("/", indexes)}");
                }

                countetChars.Add(currentChar);
            }
        }
    }
}
