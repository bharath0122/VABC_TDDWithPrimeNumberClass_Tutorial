using System;
using VABC.Domain.Prime;

namespace VABC.Tutorials.Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Primes.GeneratePrimeNumbers(1000);
            foreach (var prime in list)
            {
                Console.WriteLine(prime);
            }
        }
    }
}
