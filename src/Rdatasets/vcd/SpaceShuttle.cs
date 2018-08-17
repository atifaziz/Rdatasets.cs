// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Space Shuttle O-ring Failures
    /// </summary>

    public class SpaceShuttle
    {
        public readonly string FlightNumber;
        public readonly int Temperature;
        public readonly int Pressure;
        public readonly string Fail;
        public readonly string nFailures;
        public readonly string Damage;

        public SpaceShuttle(string FlightNumber, int Temperature, int Pressure, string Fail, string nFailures, string Damage)
        {
            this.FlightNumber = FlightNumber;
            this.Temperature = Temperature;
            this.Pressure = Pressure;
            this.Fail = Fail;
            this.nFailures = nFailures;
            this.Damage = Damage;
        }

        public static IEnumerable<SpaceShuttle> Data
        {
            get
            {
                yield return new SpaceShuttle("1", 66, 50, "no", "0", "0");
                yield return new SpaceShuttle("2", 70, 50, "yes", "1", "4");
                yield return new SpaceShuttle("3", 69, 50, "no", "0", "0");
                yield return new SpaceShuttle("4", 80, 50, null, null, null);
                yield return new SpaceShuttle("5", 68, 50, "no", "0", "0");
                yield return new SpaceShuttle("6", 67, 50, "no", "0", "0");
                yield return new SpaceShuttle("7", 72, 50, "no", "0", "0");
                yield return new SpaceShuttle("8", 73, 50, "no", "0", "0");
                yield return new SpaceShuttle("9", 70, 100, "no", "0", "0");
                yield return new SpaceShuttle("41B", 57, 100, "yes", "1", "4");
                yield return new SpaceShuttle("41C", 63, 200, "yes", "1", "2");
                yield return new SpaceShuttle("41D", 70, 200, "yes", "1", "4");
                yield return new SpaceShuttle("41G", 78, 200, "no", "0", "0");
                yield return new SpaceShuttle("51A", 67, 200, "no", "0", "0");
                yield return new SpaceShuttle("51C", 53, 200, "yes", "2", "11");
                yield return new SpaceShuttle("51D", 67, 200, "no", "0", "0");
                yield return new SpaceShuttle("51B", 75, 200, "no", "0", "0");
                yield return new SpaceShuttle("51G", 70, 200, "no", "0", "0");
                yield return new SpaceShuttle("51F", 81, 200, "no", "0", "0");
                yield return new SpaceShuttle("51I", 76, 200, "no", "0", "0");
                yield return new SpaceShuttle("51J", 79, 200, "no", "0", "0");
                yield return new SpaceShuttle("61A", 75, 200, "yes", "2", "4");
                yield return new SpaceShuttle("61C", 58, 200, "yes", "1", "4");
                yield return new SpaceShuttle("61I", 76, 200, "no", "0", "4");
            }
        }
    }
}
