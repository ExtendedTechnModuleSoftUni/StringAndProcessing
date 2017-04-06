namespace _01E.Placeholders
{
    using System;
    using System.Text;

    public class Placeholders
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var sb = new StringBuilder();

            while (inputLine != "end")
            {
                var textLine = inputLine
                    .Split(new char[] { '-', '>' }
                    , StringSplitOptions.RemoveEmptyEntries);

                sb.Append(textLine[0].Trim());

                var placeHolders = textLine[1]
                    .Trim()
                    .Split(new char[] { ' ', ',' }
                    , StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < placeHolders.Length; i++)
                {
                    var currentPlaceHolder = i.ToString();

                    sb.Replace("{" + currentPlaceHolder + "}", placeHolders[i]);
                }

                Console.WriteLine(sb.ToString());
                sb.Clear();

                inputLine = Console.ReadLine();
            }
        }
    }
}
