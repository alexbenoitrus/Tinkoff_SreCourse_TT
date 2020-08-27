namespace Training_A
{
    using System;

    public class TrainingA
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine() ?? "0");
            var b = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine(a + b);
        }
    }
}