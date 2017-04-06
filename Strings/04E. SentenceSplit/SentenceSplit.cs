namespace _04E.SentenceSplit
{
    using System;
    using System.Linq;
    
    public class SentenceSplit
    {
        public static void Main()
        {
            var sentense = Console.ReadLine();

            var delimeter = Console.ReadLine();

            string[] arrDelimeter = new string[1];

            arrDelimeter[0] = delimeter;

            var splittedSentense = sentense.Split(arrDelimeter, StringSplitOptions.None).ToArray();

            Console.WriteLine("[" + string.Join(", ", splittedSentense) + "]");
        }
    }
}
