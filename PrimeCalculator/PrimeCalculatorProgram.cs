using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Tran_Duc_Anh_CSharpFundamentals_Day2.PrimeCalculator
{
    public class PrimeCalculatorProgram
    {
        public static async Task Run()
        {
            int lower = 10;
            int upper = 1000;
            await PrintAllPrimes(lower, upper);
        }

        private static async Task PrintAllPrimes(int lower, int upper)
        {
            Stopwatch stopwatch = new Stopwatch();
            var primeNumberList = new List<Int32>();
            stopwatch.Start();
            for (int i = lower; i < upper; i++)
            {
                await Task.Run(() =>
                {
                    if (isPrime(i))
                        primeNumberList.Add(i);
                });
            }
            stopwatch.Stop();
            
            Console.WriteLine($"List of primes from {lower} to {upper}");
            Console.WriteLine(string.Join(",", primeNumberList));
            Console.WriteLine($"Asynchronous way took {stopwatch.ElapsedMilliseconds}ms");
        }

        private static bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}