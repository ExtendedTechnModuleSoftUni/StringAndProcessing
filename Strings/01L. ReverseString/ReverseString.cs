namespace _01L.ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            var resultString = inputString.Reverse().ToArray();

            Console.WriteLine(string.Join("", resultString));
        }
    }
}
