// ReSharper disable All

namespace Rdatasets.reshape2
{
    using System.Collections.Generic;

    /// <summary>
    /// Demo data describing the Smiths.
    /// </summary>

    public class smiths
    {
        public readonly int κ;
        public readonly string subject;
        public readonly int time;
        public readonly int? age;
        public readonly int? weight;
        public readonly double height;

        public smiths(int κ, string subject, int time, int? age, int? weight, double height)
        {
            this.κ = κ;
            this.subject = subject;
            this.time = time;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public static IEnumerable<smiths> Data
        {
            get
            {
                yield return new smiths(1, "John Smith", 1, 33, 90, 1.87);
                yield return new smiths(2, "Mary Smith", 1, null, null, 1.54);
            }
        }
    }
}
