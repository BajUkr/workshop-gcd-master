using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcd.Version._3
{
    /// <summary>
    /// Creates gcd multiply logic methods.
    /// </summary>
    internal static class AlgorithmMultipleLogic
    {
        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by Euclidean.
        /// </summary>
        /// <param name="algorithm">algorithm.</param>
        /// <param name="numbers">array of numbers.</param>
        /// <returns>The GCD value.</returns>
        internal static int Calculate(IAlgorithm algorithm, params int[] numbers)
        {
            int result = algorithm.Calculate(numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                result = algorithm.Calculate(result, numbers[i]);
            }

            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by Eucledian.
        /// </summary>
        /// <param name="algorithm">algorithm.</param>
        /// <param name="milliseconds">time in miliseconds.</param>
        /// <param name="numbers">array of numbers.</param>
        /// <returns>The GCD value.</returns>
        internal static int Calculate(IAlgorithm algorithm, out long milliseconds, params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = Calculate(algorithm, numbers);
            stopwatch.Stop();
            milliseconds = (stopwatch.ElapsedTicks * 1000) / Stopwatch.Frequency;
            return result;
        }
    }
}
