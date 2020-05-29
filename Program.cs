using System;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Fraction a = new Fraction(1, 2);
                Fraction b = new Fraction(1, 2);
            

                Console.WriteLine(a + b);
                Console.WriteLine(a - b);
                Console.WriteLine(a.Equals(b));
                Console.WriteLine(a * b);
                Console.WriteLine(a / b);
                Console.WriteLine(a > b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);

            }

        }
    }
}
