// ReSharper disable All

namespace Rdatasets.reshape2
{
    using System.Collections.Generic;

    /// <summary>
    /// Demo data describing the Smiths.
    /// </summary>

    public class smiths
    {
        public readonly string subject;
        public readonly int time;
        public readonly string age;
        public readonly string weight;
        public readonly double height;

        public smiths(string subject, int time, string age, string weight, double height)
        {
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
                yield return new smiths("John Smith", 1, "33", "90", 1.87);
                yield return new smiths("Mary Smith", 1, null, null, 1.54);
            }
        }
    }
}
