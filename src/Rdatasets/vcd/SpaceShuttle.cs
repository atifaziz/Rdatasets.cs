// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Space Shuttle O-ring Failures
    /// </summary>

    public class SpaceShuttle
    {
        public readonly int κ;
        public readonly string FlightNumber;
        public readonly int Temperature;
        public readonly int Pressure;
        public readonly string Fail;
        public readonly int? nFailures;
        public readonly int? Damage;

        public SpaceShuttle(int κ, string FlightNumber, int Temperature, int Pressure, string Fail, int? nFailures, int? Damage)
        {
            this.κ = κ;
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
                yield return new SpaceShuttle(1, "1", 66, 50, "no", 0, 0);
                yield return new SpaceShuttle(2, "2", 70, 50, "yes", 1, 4);
                yield return new SpaceShuttle(3, "3", 69, 50, "no", 0, 0);
                yield return new SpaceShuttle(4, "4", 80, 50, null, null, null);
                yield return new SpaceShuttle(5, "5", 68, 50, "no", 0, 0);
                yield return new SpaceShuttle(6, "6", 67, 50, "no", 0, 0);
                yield return new SpaceShuttle(7, "7", 72, 50, "no", 0, 0);
                yield return new SpaceShuttle(8, "8", 73, 50, "no", 0, 0);
                yield return new SpaceShuttle(9, "9", 70, 100, "no", 0, 0);
                yield return new SpaceShuttle(10, "41B", 57, 100, "yes", 1, 4);
                yield return new SpaceShuttle(11, "41C", 63, 200, "yes", 1, 2);
                yield return new SpaceShuttle(12, "41D", 70, 200, "yes", 1, 4);
                yield return new SpaceShuttle(13, "41G", 78, 200, "no", 0, 0);
                yield return new SpaceShuttle(14, "51A", 67, 200, "no", 0, 0);
                yield return new SpaceShuttle(15, "51C", 53, 200, "yes", 2, 11);
                yield return new SpaceShuttle(16, "51D", 67, 200, "no", 0, 0);
                yield return new SpaceShuttle(17, "51B", 75, 200, "no", 0, 0);
                yield return new SpaceShuttle(18, "51G", 70, 200, "no", 0, 0);
                yield return new SpaceShuttle(19, "51F", 81, 200, "no", 0, 0);
                yield return new SpaceShuttle(20, "51I", 76, 200, "no", 0, 0);
                yield return new SpaceShuttle(21, "51J", 79, 200, "no", 0, 0);
                yield return new SpaceShuttle(22, "61A", 75, 200, "yes", 2, 4);
                yield return new SpaceShuttle(23, "61C", 58, 200, "yes", 1, 4);
                yield return new SpaceShuttle(24, "61I", 76, 200, "no", 0, 4);
            }
        }
    }
}
