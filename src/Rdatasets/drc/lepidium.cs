// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Dose-response profile of degradation of agrochemical using lepidium
    /// </summary>

    public class lepidium
    {
        public readonly double conc;
        public readonly double weight;

        public lepidium(double conc, double weight)
        {
            this.conc = conc;
            this.weight = weight;
        }

        public static IEnumerable<lepidium> Data
        {
            get
            {
                yield return new lepidium(0, 11.8);
                yield return new lepidium(0, 10.6);
                yield return new lepidium(0, 10.6);
                yield return new lepidium(0, 11.8);
                yield return new lepidium(0, 9.7);
                yield return new lepidium(0, 10.8);
                yield return new lepidium(0.625, 10.2);
                yield return new lepidium(0.625, 9.4);
                yield return new lepidium(0.625, 12);
                yield return new lepidium(0.625, 10.2);
                yield return new lepidium(0.625, 10.3);
                yield return new lepidium(0.625, 10.7);
                yield return new lepidium(1.25, 10.3);
                yield return new lepidium(1.25, 9.9);
                yield return new lepidium(1.25, 10.1);
                yield return new lepidium(1.25, 9.9);
                yield return new lepidium(1.25, 11);
                yield return new lepidium(1.25, 8.1);
                yield return new lepidium(2.5, 8);
                yield return new lepidium(2.5, 9);
                yield return new lepidium(2.5, 8.1);
                yield return new lepidium(2.5, 8.6);
                yield return new lepidium(2.5, 8.9);
                yield return new lepidium(2.5, 8.1);
                yield return new lepidium(7.5, 4.4);
                yield return new lepidium(7.5, 4.7);
                yield return new lepidium(7.5, 5.1);
                yield return new lepidium(7.5, 4.9);
                yield return new lepidium(7.5, 5.1);
                yield return new lepidium(7.5, 5);
                yield return new lepidium(10, 4.2);
                yield return new lepidium(10, 4.1);
                yield return new lepidium(10, 3.5);
                yield return new lepidium(10, 4.1);
                yield return new lepidium(10, 4.9);
                yield return new lepidium(10, 4.3);
                yield return new lepidium(20, 3.4);
                yield return new lepidium(20, 3.9);
                yield return new lepidium(20, 3.8);
                yield return new lepidium(20, 3.9);
                yield return new lepidium(20, 3.7);
                yield return new lepidium(20, 3.5);
            }
        }
    }
}
