namespace _02ME.Stateless
{
    using System;

    public class Stateless
    {
        public static void Main()
        {
            var state = Console.ReadLine();
            var fiction = Console.ReadLine();

            while (state != "collapse")
            {
                while (fiction.Length > 0)
                {
                    var index = state.IndexOf(fiction);

                    while (index != -1)
                    {
                        state = state.Remove(index, fiction.Length);
                        index = state.IndexOf(fiction, index);
                    }

                    fiction = fiction.Remove(0, 1);

                    if (fiction.Length > 0)
                    {
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                    }
                }

                if (state.Length > 0)
                {
                    Console.WriteLine(state.Trim());
                }
                else
                {
                    Console.WriteLine("(void)");
                }

                state = Console.ReadLine();
                fiction = Console.ReadLine();
            }
        }
    }
}
