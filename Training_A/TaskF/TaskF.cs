using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskF
{
    class TaskF
    {
        static void Main(string[] args)
        {
            var x = uint.Parse(Console.ReadLine());
            Console.WriteLine(F(x));
        }

        static uint F(uint x)
        {
            if (IsPrimeNumber(x))
            {
                return 1;
            }

            var pairs = Split(x);
            var results = new List<uint>();

            foreach (var pair in pairs)
            {
                results.Add(F(pair.A) + F(pair.B));
            }

            return results.Min();
        }

        public static bool IsPrimeNumber(uint n)
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

        private static List<NumPair> Split(uint num)
        {
            var pairs = new List<NumPair>();

            for (uint i = 2; i <= num - 2; i++)
            {
                var a = i;
                var b = num - a;

                if (a + b == num && b>=2)
                {
                    var pair = new NumPair(i, b);
                    bool isNewPair = !pairs.Any(p => p.Equals(pair));

                    if (isNewPair)
                    {
                        pairs.Add(pair);
                    }
                }
            }

            return pairs;
        }
    }

    class NumPair
    {
        public NumPair(uint a, uint b)
        {
            this.A = a;
            this.B = b;
        }

        public uint A { get; set; }

        public uint B { get; set; }

        public bool Equals(NumPair obj)
        {
            return (this.A == obj.A && this.B == obj.B)
                || (this.A == obj.B && this.B == obj.A);
        }
    }
}
