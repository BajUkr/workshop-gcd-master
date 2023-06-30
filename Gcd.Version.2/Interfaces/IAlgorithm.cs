namespace Gcd.Version._2
{
    /// <summary>
    /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue].
    /// </summary>
    internal interface IAlgorithm
    {
        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue].
        /// </summary>
        /// <param name="first">first value.</param>
        /// <param name="second">second value.</param>
        /// <returns>The GCD value.</returns>
        int Calculate(int first, int second);

        /// <summary>
        /// Calculates the GCD of an array of integers and returns the execution time in milliseconds.
        /// </summary>
        /// <param name="milliseconds">The execution time of the method in milliseconds.</param>
        /// <param name="numbers">An array of integers for which the GCD will be calculated.</param>
        /// <returns>The GCD of the input integers.</returns>
        /// <exception cref="ArgumentException">Thrown when the input array is null or contains less than two numbers.</exception>
        int Calculate(out long milliseconds, int[] numbers);

        /// <summary>
        /// Calculates the GCD of an array of integers.
        /// </summary>
        /// <param name="numbers">An array of integers for which the GCD will be calculated.</param>
        /// <returns>The GCD of the input integers.</returns>
        /// <exception cref="ArgumentException">Thrown when the input array is null or contains less than two numbers.</exception>
        int Calculate(int[] numbers);
    }
}
