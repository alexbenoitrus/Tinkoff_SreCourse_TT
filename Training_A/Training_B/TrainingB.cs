namespace Training_B
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrainingB
    {
        public static void Main(string[] args)
        {
            var numbers = new List<long>();

            for (int i = 0; i < 40; i++)
            {
                try
                {
                    numbers.Add(long.Parse(Console.ReadLine()));
                }
                catch
                {
                    // IGNORED
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
