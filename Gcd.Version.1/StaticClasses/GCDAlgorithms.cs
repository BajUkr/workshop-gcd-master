using System;
#pragma warning disable CA1707

namespace Gcd.Version._1
{
    /// <summary>
    /// Provide methods to calculates GCD.
    /// </summary>
    public static class GcdAlgorithms
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int first, int second)
        {
            ThrowExceptionWhenMinValueOrAllZeros(first, second);
            return Gcd(new EuclideanAlgorithm(), first, second);
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int first, int second, int third)
        {
            ThrowExceptionWhenMinValueOrAllZeros(first, second, third);
            return Gcd(new EuclideanAlgorithm(), first, second, third);
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="numbers">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int first, int second, params int[] numbers)
        {
            ThrowExceptionWhenMinValueOrAllZeros(new int[] { first, second }.Concat(numbers).ToArray());
            return Gcd(new EuclideanAlgorithm(), first, second, numbers);
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long milliseconds, int first, int second)
        {
            ThrowExceptionWhenMinValueOrAllZeros(first, second);
            return Gcd(new EuclideanAlgorithm(), out milliseconds, first, second);
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long milliseconds, int first, int second, int third)
        {
            ThrowExceptionWhenMinValueOrAllZeros(first, second, third);
            return Gcd(new EuclideanAlgorithm(), out milliseconds, first, second, third);
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="numbers">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long milliseconds, int first, int second, params int[] numbers)
        {
            ThrowExceptionWhenMinValueOrAllZeros(new int[] { first, second }.Concat(numbers).ToArray());
            return Gcd(new EuclideanAlgorithm(), out milliseconds, first, second, numbers);
        }

        /// <summary>
        /// Calculates GCD of two integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int first, int second)
        {
            ThrowExceptionWhenMinValueOrAllZeros(first, second);
            return Gcd(new SteinAlgorithm(), first, second);
        }

        /// <summary>
        /// Calculates GCD of three integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int first, int second, int third)
        {
            ThrowExceptionWhenMinValueOrAllZeros(first, second, third);
            return Gcd(new SteinAlgorithm(), first, second, third);
        }

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="numbers">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int first, int second, params int[] numbers)
        {
            ThrowExceptionWhenMinValueOrAllZeros(new int[] { first, second }.Concat(numbers).ToArray());
            return Gcd(new SteinAlgorithm(), first, second, numbers);
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long milliseconds, int first, int second)
        {
            ThrowExceptionWhenMinValueOrAllZeros(first, second);
            return Gcd(new SteinAlgorithm(), out milliseconds, first, second);
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="third">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long milliseconds, int first, int second, int third)
        {
            ThrowExceptionWhenMinValueOrAllZeros(first, second, third);
            return Gcd(new SteinAlgorithm(), out milliseconds, first, second, third);
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with milliseconds time.
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <param name="numbers">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long milliseconds, int first, int second, params int[] numbers)
        {
            ThrowExceptionWhenMinValueOrAllZeros(new int[] { first, second }.Concat(numbers).ToArray());
            return Gcd(new SteinAlgorithm(), out milliseconds, first, second, numbers);
        }

        private static int Gcd(Algorithm algorithm, int first, int second) => algorithm.Calculate(first, second);

        private static int Gcd(Algorithm algorithm, out long milliseconds, int first, int second) =>
            algorithm.Calculate(first, second, out milliseconds);

        private static int Gcd(Algorithm algorithm, int first, int second, int third) =>
            algorithm.Calculate(algorithm.Calculate(first, second), third);

        private static int Gcd(Algorithm algorithm, out long milliseconds, int first, int second, int third)
        {
            long firstResult, secondResult;
            int firstgcd = algorithm.Calculate(first, second, out firstResult);
            int result = algorithm.Calculate(firstgcd, third, out secondResult);
            milliseconds = firstResult + secondResult;
            return result;
        }

        private static int Gcd(Algorithm algorithm, int first, int second, params int[] numbers)
        {
            int result = algorithm.Calculate(first, second);
            for (int i = 0; i < numbers.Length; i++)
            {
                result = algorithm.Calculate(result, numbers[i]);
            }

            return result;
        }

        private static int Gcd(Algorithm algorithm, out long milliseconds, int first, int second, params int[] numbers)
        {
            long millisecondsCounter;
            int result = algorithm.Calculate(first, second, out millisecondsCounter);
            for (int i = 0; i < numbers.Length; i++)
            {
                result = algorithm.Calculate(result, numbers[i], out milliseconds);
                millisecondsCounter += milliseconds;
            }

            milliseconds = millisecondsCounter;
            return result;
        }

        /// <summary>
        /// Throws an exception when any of the numbers is int.MinValue or all numbers are zero.
        /// </summary>
        private static void ThrowExceptionWhenMinValueOrAllZeros(params int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == int.MinValue)
                {
                    throw new ArgumentOutOfRangeException($"Algorithm doesn't support int.MinValue {int.MinValue}.");
                }

                if (numbers[i] == 0)
                {
                    count++;
                }
            }

            if (count == numbers.Length)
            {
                throw new ArgumentException("All arguments are zeros.");
            }
        }
    }
}
