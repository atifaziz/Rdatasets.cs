// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Volts
    /// </summary>

    public class Volts
    {
        public readonly double Voltage;
        public readonly double Time;

        public Volts(double Voltage, double Time)
        {
            this.Voltage = Voltage;
            this.Time = Time;
        }

        public static IEnumerable<Volts> Data
        {
            get
            {
                yield return new Volts(9.2128, 0);
                yield return new Volts(8.7952, 0.02);
                yield return new Volts(8.4175, 0.04);
                yield return new Volts(8.0795, 0.06);
                yield return new Volts(7.7018, 0.08);
                yield return new Volts(7.3836, 0.1);
                yield return new Volts(7.0655, 0.12);
                yield return new Volts(6.7474, 0.14);
                yield return new Volts(6.4691, 0.16);
                yield return new Volts(6.1908, 0.18);
                yield return new Volts(5.9323, 0.2);
                yield return new Volts(5.6738, 0.22);
                yield return new Volts(5.4353, 0.24);
                yield return new Volts(5.2166, 0.26);
                yield return new Volts(4.9979, 0.28);
                yield return new Volts(4.7792, 0.3);
                yield return new Volts(4.5803, 0.32);
                yield return new Volts(4.3815, 0.34);
                yield return new Volts(4.2026, 0.36);
                yield return new Volts(4.0237, 0.38);
                yield return new Volts(3.8646, 0.4);
                yield return new Volts(3.7056, 0.42);
                yield return new Volts(3.5465, 0.44);
                yield return new Volts(3.4073, 0.46);
                yield return new Volts(3.2682, 0.48);
                yield return new Volts(3.129, 0.5);
                yield return new Volts(3.0097, 0.52);
                yield return new Volts(2.8904, 0.54);
                yield return new Volts(2.7711, 0.56);
                yield return new Volts(2.6518, 0.58);
                yield return new Volts(2.5524, 0.6);
                yield return new Volts(2.453, 0.62);
                yield return new Volts(2.3735, 0.64);
                yield return new Volts(2.2542, 0.66);
                yield return new Volts(2.1747, 0.68);
                yield return new Volts(2.0951, 0.7);
                yield return new Volts(2.0156, 0.72);
                yield return new Volts(1.9361, 0.74);
                yield return new Volts(1.8566, 0.76);
                yield return new Volts(1.7969, 0.78);
                yield return new Volts(1.7174, 0.8);
                yield return new Volts(1.6577, 0.82);
                yield return new Volts(1.5981, 0.84);
                yield return new Volts(1.5385, 0.86);
                yield return new Volts(1.4788, 0.88);
                yield return new Volts(1.4192, 0.9);
                yield return new Volts(1.3794, 0.92);
                yield return new Volts(1.3198, 0.94);
                yield return new Volts(1.28, 0.96);
                yield return new Volts(1.2402, 0.98);
            }
        }
    }
}
