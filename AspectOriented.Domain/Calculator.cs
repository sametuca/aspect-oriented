using AspectOriented.Attribute.Logging;
using AspectOriented.Core;

namespace AspectOriented.Domain
{
    public class Calculator : ICalculator
    {
        [LoggingAspect]
        public int Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Sonuç: " + result);
            return result;
        }

        [LoggingAspect]

        public int Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Sonuç: " + result);
            return result;
        }
    }
}
