// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Vapor Pressure of Mercury as a Function of Temperature
    /// </summary>

    public class pressure
    {
        public readonly int temperature;
        public readonly string pressure_;

        public pressure(int temperature, string pressure_)
        {
            this.temperature = temperature;
            this.pressure_ = pressure_;
        }

        public static IEnumerable<pressure> Data
        {
            get
            {
                yield return new pressure(0, "2e-04");
                yield return new pressure(20, "0.0012");
                yield return new pressure(40, "0.006");
                yield return new pressure(60, "0.03");
                yield return new pressure(80, "0.09");
                yield return new pressure(100, "0.27");
                yield return new pressure(120, "0.75");
                yield return new pressure(140, "1.85");
                yield return new pressure(160, "4.2");
                yield return new pressure(180, "8.8");
                yield return new pressure(200, "17.3");
                yield return new pressure(220, "32.1");
                yield return new pressure(240, "57");
                yield return new pressure(260, "96");
                yield return new pressure(280, "157");
                yield return new pressure(300, "247");
                yield return new pressure(320, "376");
                yield return new pressure(340, "558");
                yield return new pressure(360, "806");
            }
        }
    }
}
