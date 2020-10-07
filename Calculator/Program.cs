using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var oneHalf = new Fraction(1, 2);
            var oneFourth = new Fraction(1, 4);

            Console.WriteLine(oneHalf.Add(oneFourth));
            Console.WriteLine(oneHalf + oneFourth);

            Console.WriteLine(oneHalf.Subtract(oneFourth));
            Console.WriteLine(oneHalf - oneFourth);

            Console.WriteLine(oneHalf.Multiply(oneFourth));
            Console.WriteLine(oneHalf * oneFourth);

            Console.WriteLine(oneHalf.Divide(oneFourth));
            Console.WriteLine(oneHalf / oneFourth);
        }
    }
}
