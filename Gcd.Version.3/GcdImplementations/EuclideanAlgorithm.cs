using System;

namespace Gcd.Version._3
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
    }
}
