// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Vapor Pressure of Mercury as a Function of Temperature
    /// </summary>

    public class pressure
    {
        public readonly int κ;
        public readonly int temperature;
        public readonly string pressure_;

        public pressure(int κ, int temperature, string pressure_)
        {
            this.κ = κ;
            this.temperature = temperature;
            this.pressure_ = pressure_;
        }

        public static IEnumerable<pressure> Data
        {
            get
            {
                yield return new pressure(1, 0, "2e-04");
                yield return new pressure(2, 20, "0.0012");
                yield return new pressure(3, 40, "0.006");
                yield return new pressure(4, 60, "0.03");
                yield return new pressure(5, 80, "0.09");
                yield return new pressure(6, 100, "0.27");
                yield return new pressure(7, 120, "0.75");
                yield return new pressure(8, 140, "1.85");
                yield return new pressure(9, 160, "4.2");
                yield return new pressure(10, 180, "8.8");
                yield return new pressure(11, 200, "17.3");
                yield return new pressure(12, 220, "32.1");
                yield return new pressure(13, 240, "57");
                yield return new pressure(14, 260, "96");
                yield return new pressure(15, 280, "157");
                yield return new pressure(16, 300, "247");
                yield return new pressure(17, 320, "376");
                yield return new pressure(18, 340, "558");
                yield return new pressure(19, 360, "806");
            }
        }
    }
}
