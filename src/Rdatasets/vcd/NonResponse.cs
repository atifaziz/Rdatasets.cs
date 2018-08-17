// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Non-Response Survey Data
    /// </summary>

    public class NonResponse
    {
        public readonly int Freq;
        public readonly string residence;
        public readonly string response;
        public readonly string gender;

        public NonResponse(int Freq, string residence, string response, string gender)
        {
            this.Freq = Freq;
            this.residence = residence;
            this.response = response;
            this.gender = gender;
        }

        public static IEnumerable<NonResponse> Data
        {
            get
            {
                yield return new NonResponse(306, "Copenhagen", "yes", "male");
                yield return new NonResponse(264, "Copenhagen", "yes", "female");
                yield return new NonResponse(49, "Copenhagen", "no", "male");
                yield return new NonResponse(76, "Copenhagen", "no", "female");
                yield return new NonResponse(609, "City", "yes", "male");
                yield return new NonResponse(627, "City", "yes", "female");
                yield return new NonResponse(77, "City", "no", "male");
                yield return new NonResponse(79, "City", "no", "female");
                yield return new NonResponse(978, "Country", "yes", "male");
                yield return new NonResponse(947, "Country", "yes", "female");
                yield return new NonResponse(103, "Country", "no", "male");
                yield return new NonResponse(114, "Country", "no", "female");
            }
        }
    }
}
