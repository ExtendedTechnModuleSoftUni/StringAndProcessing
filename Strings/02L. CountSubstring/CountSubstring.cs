namespace _02L.CountSubstring
{
    using System;

    public class CountSubstring
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            int counter = 0;

            var index = text.IndexOf(pattern);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
