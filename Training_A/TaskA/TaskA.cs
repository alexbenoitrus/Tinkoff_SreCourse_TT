namespace TaskA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TaskA
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var start = int.Parse(input[0]);
            var stop = int.Parse(input[1]);

            var result = new List<int>();

            for (int i = start; i <= stop; i++)
            {
                result.Add(P(i));
            }

            Console.WriteLine(result.Sum());
        }

        private static int P(int num)
        {
            int count = 0;

            while (num != 1)
            {
                count++;

                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num *= 3;
                    num++;
                }
            }

            return count;
        }
    }
}
