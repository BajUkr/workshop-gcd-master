using System;

namespace Gcd.Version._3
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
    }
}
