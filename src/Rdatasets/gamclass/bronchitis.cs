// ReSharper disable All

namespace Rdatasets.gamclass
{
    using System.Collections.Generic;

    /// <summary>
    /// Chronic bronchitis in a sample of men in Cardiff
    /// </summary>

    public class bronchitis
    {
        public readonly double cig;
        public readonly double poll;
        public readonly int r;
        public readonly string rfac;

        public bronchitis(double cig, double poll, int r, string rfac)
        {
            this.cig = cig;
            this.poll = poll;
            this.r = r;
            this.rfac = rfac;
        }

        public static IEnumerable<bronchitis> Data
        {
            get
            {
                yield return new bronchitis(5.15, 67.1, 0, "abs");
                yield return new bronchitis(6.75, 64.4, 0, "abs");
                yield return new bronchitis(0, 65.9, 0, "abs");
                yield return new bronchitis(5.15, 67, 1, "pres");
                yield return new bronchitis(5.25, 64.2, 0, "abs");
                yield return new bronchitis(0, 62.7, 0, "abs");
                yield return new bronchitis(0, 63.1, 0, "abs");
                yield return new bronchitis(1.1, 62.4, 0, "abs");
                yield return new bronchitis(1.6, 63, 0, "abs");
                yield return new bronchitis(13.75, 63.8, 1, "pres");
                yield return new bronchitis(0, 62.5, 0, "abs");
                yield return new bronchitis(0, 61.4, 0, "abs");
                yield return new bronchitis(0, 60.9, 0, "abs");
                yield return new bronchitis(12.5, 62.6, 1, "pres");
                yield return new bronchitis(6.75, 62.7, 1, "pres");
                yield return new bronchitis(2.4, 60.6, 0, "abs");
                yield return new bronchitis(5, 61.3, 0, "abs");
                yield return new bronchitis(0.9, 59.7, 0, "abs");
                yield return new bronchitis(6.6, 59.4, 1, "pres");
                yield return new bronchitis(0, 59.7, 0, "abs");
                yield return new bronchitis(0, 60.8, 0, "abs");
                yield return new bronchitis(1.9, 59.4, 0, "abs");
                yield return new bronchitis(6.9, 59, 1, "pres");
                yield return new bronchitis(15, 59.4, 1, "pres");
                yield return new bronchitis(1.4, 54.2, 0, "abs");
                yield return new bronchitis(2.45, 53.7, 0, "abs");
                yield return new bronchitis(10.05, 53.9, 0, "abs");
                yield return new bronchitis(0, 54.9, 0, "abs");
                yield return new bronchitis(10.5, 54, 1, "pres");
                yield return new bronchitis(0, 55.5, 0, "abs");
                yield return new bronchitis(5.25, 56.4, 0, "abs");
                yield return new bronchitis(10.9, 57.6, 1, "pres");
                yield return new bronchitis(2.65, 57.8, 0, "abs");
                yield return new bronchitis(15, 58.1, 0, "abs");
                yield return new bronchitis(0.55, 58.1, 0, "abs");
                yield return new bronchitis(3.2, 57.1, 0, "abs");
                yield return new bronchitis(0, 57.5, 0, "abs");
                yield return new bronchitis(3.7, 57.2, 1, "pres");
                yield return new bronchitis(10.05, 53.1, 0, "abs");
                yield return new bronchitis(0.75, 52.6, 0, "abs");
                yield return new bronchitis(0.55, 52.7, 0, "abs");
                yield return new bronchitis(0.8, 53.7, 0, "abs");
                yield return new bronchitis(0.6, 53, 0, "abs");
                yield return new bronchitis(0.25, 53.2, 0, "abs");
                yield return new bronchitis(20.25, 54.9, 1, "pres");
                yield return new bronchitis(10, 57.4, 0, "abs");
                yield return new bronchitis(0.9, 56.5, 0, "abs");
                yield return new bronchitis(0.95, 56.3, 0, "abs");
                yield return new bronchitis(17.2, 55.9, 0, "abs");
                yield return new bronchitis(0.6, 57, 0, "abs");
                yield return new bronchitis(12.3, 55.2, 1, "pres");
                yield return new bronchitis(10, 55.5, 1, "pres");
                yield return new bronchitis(9, 56.1, 1, "pres");
                yield return new bronchitis(0, 66.9, 1, "pres");
                yield return new bronchitis(0, 64.4, 0, "abs");
                yield return new bronchitis(0.75, 67.1, 0, "abs");
                yield return new bronchitis(30, 66.3, 1, "pres");
                yield return new bronchitis(10.05, 64.6, 0, "abs");
                yield return new bronchitis(0.55, 62.7, 0, "abs");
                yield return new bronchitis(3.4, 63, 0, "abs");
                yield return new bronchitis(1.8, 64.4, 0, "abs");
                yield return new bronchitis(6.2, 62.2, 0, "abs");
                yield return new bronchitis(0, 63.1, 0, "abs");
                yield return new bronchitis(14.8, 61.7, 1, "pres");
                yield return new bronchitis(0.25, 61.4, 0, "abs");
                yield return new bronchitis(5.9, 60.8, 0, "abs");
                yield return new bronchitis(0, 62.1, 0, "abs");
                yield return new bronchitis(0, 62.7, 0, "abs");
                yield return new bronchitis(10.05, 60.4, 0, "abs");
                yield return new bronchitis(0.6, 60.7, 0, "abs");
                yield return new bronchitis(0, 59.5, 0, "abs");
                yield return new bronchitis(1, 58.5, 0, "abs");
                yield return new bronchitis(5, 59.4, 1, "pres");
                yield return new bronchitis(11.25, 60.4, 1, "pres");
                yield return new bronchitis(0.45, 59.8, 0, "abs");
                yield return new bronchitis(2.35, 58.6, 0, "abs");
                yield return new bronchitis(0, 59.4, 0, "abs");
                yield return new bronchitis(0.5, 54, 0, "abs");
                yield return new bronchitis(1.75, 53.1, 0, "abs");
                yield return new bronchitis(0.55, 53.2, 0, "abs");
                yield return new bronchitis(0, 54.5, 0, "abs");
                yield return new bronchitis(0.5, 55.8, 0, "abs");
                yield return new bronchitis(0.96, 54.9, 0, "abs");
                yield return new bronchitis(0, 55.9, 1, "pres");
                yield return new bronchitis(0, 57.7, 0, "abs");
                yield return new bronchitis(0.55, 58.4, 0, "abs");
                yield return new bronchitis(0, 57.9, 0, "abs");
                yield return new bronchitis(10, 57.9, 1, "pres");
                yield return new bronchitis(0, 58.9, 1, "pres");
                yield return new bronchitis(2.35, 57.2, 0, "abs");
                yield return new bronchitis(17.1, 57.3, 0, "abs");
                yield return new bronchitis(1.15, 53, 0, "abs");
                yield return new bronchitis(0, 53.1, 0, "abs");
                yield return new bronchitis(0.95, 52.6, 0, "abs");
                yield return new bronchitis(1.55, 53.1, 0, "abs");
                yield return new bronchitis(0.4, 53.9, 0, "abs");
                yield return new bronchitis(3.6, 53.4, 0, "abs");
                yield return new bronchitis(0.95, 54.6, 0, "abs");
                yield return new bronchitis(3.4, 57.3, 0, "abs");
                yield return new bronchitis(0, 56.8, 0, "abs");
                yield return new bronchitis(1.06, 56.3, 0, "abs");
                yield return new bronchitis(1.65, 56, 0, "abs");
                yield return new bronchitis(8.25, 56.7, 1, "pres");
                yield return new bronchitis(1.15, 56.9, 0, "abs");
                yield return new bronchitis(0.6, 55.3, 0, "abs");
                yield return new bronchitis(0, 55.9, 0, "abs");
                yield return new bronchitis(2.5, 66.7, 0, "abs");
                yield return new bronchitis(0, 65.1, 1, "pres");
                yield return new bronchitis(5.25, 67.9, 0, "abs");
                yield return new bronchitis(0, 65.7, 0, "abs");
                yield return new bronchitis(0, 63.5, 0, "abs");
                yield return new bronchitis(9.5, 62.1, 1, "pres");
                yield return new bronchitis(2.2, 62.7, 0, "abs");
                yield return new bronchitis(0, 64.2, 0, "abs");
                yield return new bronchitis(14.75, 62.3, 0, "abs");
                yield return new bronchitis(7.5, 62.7, 1, "pres");
                yield return new bronchitis(3.5, 61.6, 1, "pres");
                yield return new bronchitis(1.55, 62, 0, "abs");
                yield return new bronchitis(16.45, 60.6, 0, "abs");
                yield return new bronchitis(14.55, 61.7, 0, "abs");
                yield return new bronchitis(0, 61.7, 1, "pres");
                yield return new bronchitis(12.75, 61.7, 1, "pres");
                yield return new bronchitis(0, 60.8, 0, "abs");
                yield return new bronchitis(8.75, 59.6, 1, "pres");
                yield return new bronchitis(0, 60, 0, "abs");
                yield return new bronchitis(2.55, 59.2, 0, "abs");
                yield return new bronchitis(0, 60.2, 0, "abs");
                yield return new bronchitis(0, 59.7, 1, "pres");
                yield return new bronchitis(3.95, 59.7, 0, "abs");
                yield return new bronchitis(0.95, 59.4, 0, "abs");
                yield return new bronchitis(0.6, 53.8, 0, "abs");
                yield return new bronchitis(0, 54.4, 0, "abs");
                yield return new bronchitis(0.85, 53.2, 0, "abs");
                yield return new bronchitis(1.45, 54.2, 0, "abs");
                yield return new bronchitis(9.2, 55.5, 1, "pres");
                yield return new bronchitis(1, 54.6, 0, "abs");
                yield return new bronchitis(9, 55.8, 0, "abs");
                yield return new bronchitis(0, 57.6, 0, "abs");
                yield return new bronchitis(0, 58.2, 0, "abs");
                yield return new bronchitis(0, 57.3, 0, "abs");
                yield return new bronchitis(0, 57.6, 0, "abs");
                yield return new bronchitis(6.8, 58.6, 1, "pres");
                yield return new bronchitis(24.9, 58, 0, "abs");
                yield return new bronchitis(0, 57.5, 0, "abs");
                yield return new bronchitis(18.25, 53, 1, "pres");
                yield return new bronchitis(4.2, 53, 0, "abs");
                yield return new bronchitis(0, 52.1, 0, "abs");
                yield return new bronchitis(0.4, 53.3, 0, "abs");
                yield return new bronchitis(7.5, 53.7, 1, "pres");
                yield return new bronchitis(0.95, 53.2, 0, "abs");
                yield return new bronchitis(4.25, 54.1, 0, "abs");
                yield return new bronchitis(0, 57.3, 0, "abs");
                yield return new bronchitis(0, 56.6, 0, "abs");
                yield return new bronchitis(13.3, 56.2, 0, "abs");
                yield return new bronchitis(5, 55.8, 1, "pres");
                yield return new bronchitis(0.9, 56.4, 0, "abs");
                yield return new bronchitis(2.2, 56.7, 0, "abs");
                yield return new bronchitis(9.5, 56.5, 0, "abs");
                yield return new bronchitis(0.5, 55.5, 0, "abs");
                yield return new bronchitis(1.75, 65.8, 0, "abs");
                yield return new bronchitis(9.5, 66.2, 1, "pres");
                yield return new bronchitis(8, 68.1, 1, "pres");
                yield return new bronchitis(0, 65.2, 0, "abs");
                yield return new bronchitis(3.4, 63, 1, "pres");
                yield return new bronchitis(12.5, 63.7, 1, "pres");
                yield return new bronchitis(6.7, 63.1, 0, "abs");
                yield return new bronchitis(3.6, 64.2, 1, "pres");
                yield return new bronchitis(0.35, 63.7, 0, "abs");
                yield return new bronchitis(1, 62.9, 0, "abs");
                yield return new bronchitis(0, 61.6, 0, "abs");
                yield return new bronchitis(0, 61.8, 1, "pres");
                yield return new bronchitis(2.65, 62.9, 0, "abs");
                yield return new bronchitis(11, 61, 1, "pres");
                yield return new bronchitis(1.75, 60.9, 0, "abs");
                yield return new bronchitis(0, 61.9, 0, "abs");
                yield return new bronchitis(0.85, 60.5, 0, "abs");
                yield return new bronchitis(0.8, 59.1, 0, "abs");
                yield return new bronchitis(8.15, 59.8, 1, "pres");
                yield return new bronchitis(1.2, 58.6, 0, "abs");
                yield return new bronchitis(2, 60, 0, "abs");
                yield return new bronchitis(0, 59, 0, "abs");
                yield return new bronchitis(0.6, 59.6, 0, "abs");
                yield return new bronchitis(0, 59.3, 0, "abs");
                yield return new bronchitis(0, 53.7, 0, "abs");
                yield return new bronchitis(3.1, 54.2, 0, "abs");
                yield return new bronchitis(1.1, 54.9, 0, "abs");
                yield return new bronchitis(2.05, 54.2, 0, "abs");
                yield return new bronchitis(0.55, 55.6, 0, "abs");
                yield return new bronchitis(0, 56.9, 0, "abs");
                yield return new bronchitis(1.6, 55.6, 0, "abs");
                yield return new bronchitis(2.25, 57.8, 0, "abs");
                yield return new bronchitis(4.5, 58, 1, "pres");
                yield return new bronchitis(4.2, 58.3, 0, "abs");
                yield return new bronchitis(7.1, 57.3, 0, "abs");
                yield return new bronchitis(0, 58.7, 0, "abs");
                yield return new bronchitis(2.65, 57.9, 0, "abs");
                yield return new bronchitis(0.95, 57.2, 0, "abs");
                yield return new bronchitis(10, 52.9, 0, "abs");
                yield return new bronchitis(0.8, 52.9, 0, "abs");
                yield return new bronchitis(3.1, 54.1, 0, "abs");
                yield return new bronchitis(6.2, 53, 0, "abs");
                yield return new bronchitis(7.15, 53.4, 0, "abs");
                yield return new bronchitis(2.8, 54.9, 0, "abs");
                yield return new bronchitis(4.15, 54.2, 0, "abs");
                yield return new bronchitis(3.6, 56.7, 0, "abs");
                yield return new bronchitis(6.4, 56.5, 1, "pres");
                yield return new bronchitis(1.1, 56.6, 0, "abs");
                yield return new bronchitis(2.1, 55.7, 0, "abs");
                yield return new bronchitis(0, 56.5, 0, "abs");
                yield return new bronchitis(3.6, 56, 0, "abs");
                yield return new bronchitis(0.7, 56.3, 0, "abs");
                yield return new bronchitis(0.9, 55.4, 0, "abs");
            }
        }
    }
}
