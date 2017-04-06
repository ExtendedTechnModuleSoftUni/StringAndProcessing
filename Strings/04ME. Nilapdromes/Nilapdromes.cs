namespace _04ME.Nilapdromes
{
    using System;
    using System.Text;

    public class Nilapdromes
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var leftString = new StringBuilder();
            var rightString = new StringBuilder();

            while (inputLine != "end")
            {
                var isNilapdromes = false;

                if (inputLine.Length % 2 == 0)
                {
                    leftString.Append(inputLine.Substring(0, inputLine.Length / 2));
                    rightString.Append(inputLine.Substring(inputLine.Length / 2));
                }
                else
                {
                    leftString.Append(inputLine.Substring(0, inputLine.Length / 2));
                    rightString.Append(inputLine.Substring((inputLine.Length / 2) + 1));
                }

                for (int i = rightString.Length - 1; i >= 0; i--)
                {
                    if (inputLine.Length == 4)
                    {
                        if (leftString[0] == rightString[rightString.Length - 1])
                        {
                            leftString.Remove(1, 1);
                            rightString.Remove(0, 1);

                            isNilapdromes = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (leftString.ToString() == rightString.ToString())
                    {
                        isNilapdromes = true;
                        break;
                    }
                    else
                    {
                        leftString.Remove(leftString.Length - 1, 1);
                        rightString.Remove(0, 1);
                    }
                }

                if (isNilapdromes)
                {
                    var core = inputLine.Substring(leftString.Length, (inputLine.Length - (leftString.Length * 2)));

                    Console.WriteLine(core + leftString + core);
                }

                leftString.Clear();
                rightString.Clear();

                inputLine = Console.ReadLine();
            }
        }
    }
}