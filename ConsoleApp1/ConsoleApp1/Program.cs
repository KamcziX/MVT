using System;
namespace LocalHost
{
    public class Program
    {
        public static void Main()
        {
            var sampleClass = new Sample(10);
            DoSomething(sampleClass);

            Console.WriteLine(sampleClass?.Value);

            void DoSomething(Sample sampleClasss)
            {
                sampleClass = null;
            }
        }
    }

    public class Sample
    {
        public int Value { get; set; }
        public Sample(int value) { Value = value; }
    }
}

