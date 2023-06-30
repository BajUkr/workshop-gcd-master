using System;
using System.Diagnostics;

namespace Gcd.Version._2
{
    /// <inheritdoc/>
    internal class EuclideanAlgorithm : IAlgorithm
    {
        /// <inheritdoc/>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public int Calculate(int first, int second)
        {
            if (first == 0)
            {
                return Math.Abs(second);
            }

            if (second == 0)
            {
                return Math.Abs(first);
            }

            while (second != 0)
            {
                int remainder = first % second;
                first = second;
                second = remainder;
            }

            return Math.Abs(first);
        }

        /// <summary>
        /// Calculates the GCD of an array of integers using the Euclidean algorithm and returns the execution time in milliseconds.
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
        /// Calculates the GCD of an array of integers using the Euclidean algorithm.
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
