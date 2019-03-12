// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Dose-response profile of degradation of agrochemical using lepidium
    /// </summary>

    public class lepidium
    {
        public readonly int κ;
        public readonly double conc;
        public readonly double weight;

        public lepidium(int κ, double conc, double weight)
        {
            this.κ = κ;
            this.conc = conc;
            this.weight = weight;
        }

        public static IEnumerable<lepidium> Data
        {
            get
            {
                yield return new lepidium(1, 0, 11.8);
                yield return new lepidium(2, 0, 10.6);
                yield return new lepidium(3, 0, 10.6);
                yield return new lepidium(4, 0, 11.8);
                yield return new lepidium(5, 0, 9.7);
                yield return new lepidium(6, 0, 10.8);
                yield return new lepidium(7, 0.625, 10.2);
                yield return new lepidium(8, 0.625, 9.4);
                yield return new lepidium(9, 0.625, 12);
                yield return new lepidium(10, 0.625, 10.2);
                yield return new lepidium(11, 0.625, 10.3);
                yield return new lepidium(12, 0.625, 10.7);
                yield return new lepidium(13, 1.25, 10.3);
                yield return new lepidium(14, 1.25, 9.9);
                yield return new lepidium(15, 1.25, 10.1);
                yield return new lepidium(16, 1.25, 9.9);
                yield return new lepidium(17, 1.25, 11);
                yield return new lepidium(18, 1.25, 8.1);
                yield return new lepidium(19, 2.5, 8);
                yield return new lepidium(20, 2.5, 9);
                yield return new lepidium(21, 2.5, 8.1);
                yield return new lepidium(22, 2.5, 8.6);
                yield return new lepidium(23, 2.5, 8.9);
                yield return new lepidium(24, 2.5, 8.1);
                yield return new lepidium(25, 7.5, 4.4);
                yield return new lepidium(26, 7.5, 4.7);
                yield return new lepidium(27, 7.5, 5.1);
                yield return new lepidium(28, 7.5, 4.9);
                yield return new lepidium(29, 7.5, 5.1);
                yield return new lepidium(30, 7.5, 5);
                yield return new lepidium(31, 10, 4.2);
                yield return new lepidium(32, 10, 4.1);
                yield return new lepidium(33, 10, 3.5);
                yield return new lepidium(34, 10, 4.1);
                yield return new lepidium(35, 10, 4.9);
                yield return new lepidium(36, 10, 4.3);
                yield return new lepidium(37, 20, 3.4);
                yield return new lepidium(38, 20, 3.9);
                yield return new lepidium(39, 20, 3.8);
                yield return new lepidium(40, 20, 3.9);
                yield return new lepidium(41, 20, 3.7);
                yield return new lepidium(42, 20, 3.5);
            }
        }
    }
}
