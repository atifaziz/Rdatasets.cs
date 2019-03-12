// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Non-Response Survey Data
    /// </summary>

    public class NonResponse
    {
        public readonly int κ;
        public readonly int Freq;
        public readonly string residence;
        public readonly string response;
        public readonly string gender;

        public NonResponse(int κ, int Freq, string residence, string response, string gender)
        {
            this.κ = κ;
            this.Freq = Freq;
            this.residence = residence;
            this.response = response;
            this.gender = gender;
        }

        public static IEnumerable<NonResponse> Data
        {
            get
            {
                yield return new NonResponse(1, 306, "Copenhagen", "yes", "male");
                yield return new NonResponse(2, 264, "Copenhagen", "yes", "female");
                yield return new NonResponse(3, 49, "Copenhagen", "no", "male");
                yield return new NonResponse(4, 76, "Copenhagen", "no", "female");
                yield return new NonResponse(5, 609, "City", "yes", "male");
                yield return new NonResponse(6, 627, "City", "yes", "female");
                yield return new NonResponse(7, 77, "City", "no", "male");
                yield return new NonResponse(8, 79, "City", "no", "female");
                yield return new NonResponse(9, 978, "Country", "yes", "male");
                yield return new NonResponse(10, 947, "Country", "yes", "female");
                yield return new NonResponse(11, 103, "Country", "no", "male");
                yield return new NonResponse(12, 114, "Country", "no", "female");
            }
        }
    }
}
