using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskG
{
    class TaskG
    {
        static void Main(string[] args)
        {
            var size = (int)Math.Pow(10, 5);
            
            var input = ReadInput();
            var queriesCount = input[0];
            var queries = new List<Query>(queriesCount);

            for (int i = 0; i < queriesCount; i++)
            {
                input = ReadInput();
                queries.Add(new Query(input[0], input[1]));
            }

            foreach (var query in queries)
            {
                int maxLeftBorder = size - query.Length;
                int minimalLeftFindedBorder = -1;

                for (int i = 1; i <= maxLeftBorder; i++)
                {
                    var countOnSegment = GetCountOfPrimeOnSegment(i, i + query.Length);
                    if (countOnSegment == query.PrimeNumbersCount)
                    {
                        minimalLeftFindedBorder = i;
                        break;
                    }
                }

                Console.WriteLine(minimalLeftFindedBorder);
            }
        }

        private static int GetCountOfPrimeOnSegment(int first, int last)
        {
            int count = 0;
            for (int i = first; i < last; i++)
            {
                if (IsPrimeNumber(i)) count++;
            }

            return count;
        }

        private static int[] ReadInput()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        public static bool IsPrimeNumber(int n)
        {
            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }

    class Query
    {
        public Query(int length, int primeNumbersCount)
        {
            this.Length = length;
            this.PrimeNumbersCount = primeNumbersCount;
        }

        public int Length { get; set; }

        public int PrimeNumbersCount { get; set; }
    }
}
