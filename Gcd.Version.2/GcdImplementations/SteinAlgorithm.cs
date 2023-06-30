using System;
using System.Diagnostics;

namespace Gcd.Version._2
{
    /// <inheritdoc/>
    internal class SteinAlgorithm : IAlgorithm
    {
        /// <inheritdoc/>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public int Calculate(int first, int second)
        {
            first = Math.Abs(first);
            second = Math.Abs(second);

            if (first == 0)
            {
                return second;
            }

            if (second == 0)
            {
                return first;
            }

            int shift;
            for (shift = 0; ((first | second) & 1) == 0; ++shift)
            {
                first >>= 1;
                second >>= 1;
            }

            while ((first & 1) == 0)
            {
                first >>= 1;
            }

            do
            {
                while ((second & 1) == 0)
                {
                    second >>= 1;
                }

                if (first > second)
                {
                    int temp = first;
                    first = second;
                    second = temp;
                }

                second -= first;
            }
            while (second != 0);

            return first << shift;
        }

        /// <summary>
        /// Calculates the GCD of an array of integers using Stein's algorithm and returns the execution time in milliseconds.
        /// </summary>
        /// <param name="milliseconds">The execution time of the method in milliseconds.</param>
        /// <param name="numbers">An array of integers for which the GCD will be calculated.</param>
        /// <returns>The GCD of the input integers.</returns>
        /// <exception cref="ArgumentException">Thrown when the input array is null or contains less than two numbers.</exception>
        public int Calculate(out long milliseconds, int[] numbers)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = this.Calculate(numbers);
            stopwatch.Stop();
            milliseconds = stopwatch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>
        /// Calculates the GCD of an array of integers using Stein's algorithm.
        /// </summary>
        /// <param name="numbers">An array of integers for which the GCD will be calculated.</param>
        /// <returns>The GCD of the input integers.</returns>
        /// <exception cref="ArgumentException">Thrown when the input array is null or contains less than two numbers.</exception>
        public int Calculate(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                throw new ArgumentException("At least two numbers are required for GCD calculation.");
            }

            int result = this.Calculate(numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                result = this.Calculate(result, numbers[i]);
            }

            return result;
        }
    }
}
