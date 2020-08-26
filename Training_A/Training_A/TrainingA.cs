using System;

namespace Training_A
{
    public class TrainingA
    {
        public static void Main(string[] args)
        {
            var aStr = Console.ReadLine();
            var bStr = Console.ReadLine();

            var a = int.Parse(aStr);
            var b = int.Parse(bStr);

            Console.WriteLine(a+b);
        }
    }
}
