using System.Collections.Generic;

namespace VABC.Domain.Prime
{
    public static class Primes
    {
        public static IList<int> GeneratePrimeNumbers(int upUntil)
        {
            bool isPrime = true;
            var primeList = new List<int>();
            for (int i = 2; i <= upUntil; i++)
            {
                for (int j = 2; j < i; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;

                        break;
                    }

                }
                if (isPrime)
                {

                    primeList.Add(i);

                }


                isPrime = true;
            }
            return primeList;
        }
    }
}
