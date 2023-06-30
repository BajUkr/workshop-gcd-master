using System;

namespace Gcd.Version._1
{
    /// <summary>
    /// Calculates the GCD by the Euclidean algorithm.
    /// </summary>
    internal class EuclideanAlgorithm : Algorithm
    {
        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        protected override int Func(int first, int second)
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
    }
}
