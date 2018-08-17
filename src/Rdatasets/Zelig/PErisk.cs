// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Political Economic Risk Data from 62 Countries in 1987
    /// </summary>

    public class PErisk
    {
        public readonly string country;
        public readonly int courts;
        public readonly double barb2;
        public readonly int prsexp2;
        public readonly int prscorr2;
        public readonly double gdpw2;

        public PErisk(string country, int courts, double barb2, int prsexp2, int prscorr2, double gdpw2)
        {
            this.country = country;
            this.courts = courts;
            this.barb2 = barb2;
            this.prsexp2 = prsexp2;
            this.prscorr2 = prscorr2;
            this.gdpw2 = gdpw2;
        }

        public static IEnumerable<PErisk> Data
        {
            get
            {
                yield return new PErisk("Argentina", 0, -0.7207754, 1, 3, 9.69017);
                yield return new PErisk("Australia", 1, -6.907755, 5, 4, 10.30484);
                yield return new PErisk("Austria", 1, -4.910337, 5, 4, 10.10094);
                yield return new PErisk("Bangladesh", 0, 0.7759748, 1, 0, 8.379768);
                yield return new PErisk("Belgium", 1, -4.617344, 5, 4, 10.25012);
                yield return new PErisk("Bolivia", 0, -2.46144, 0, 0, 8.583543);
                yield return new PErisk("Botswana", 1, -1.244868, 4, 3, 8.77771);
                yield return new PErisk("Brazil", 1, -0.4570337, 4, 3, 9.375601);
                yield return new PErisk("Burma", 0, 1.604343, 3, 1, 7.096721);
                yield return new PErisk("Cameroon", 0, -4.229065, 3, 1, 8.120886);
                yield return new PErisk("Canada", 1, -6.907755, 5, 5, 10.41018);
                yield return new PErisk("Chile", 1, -1.542761, 3, 2, 9.261224);
                yield return new PErisk("Colombia", 0, -2.057821, 3, 2, 9.191973);
                yield return new PErisk("Congo-Kinshasa", 0, -2.323288, 1, 0, 7.095064);
                yield return new PErisk("Costa Rica", 1, -5.090003, 3, 4, 9.167329);
                yield return new PErisk("Cote d'Ivoire", 1, -4.229065, 4, 2, 8.228711);
                yield return new PErisk("Denmark", 1, -6.907755, 5, 5, 10.10651);
                yield return new PErisk("Dominican Republic", 0, -2.378862, 2, 2, 8.899731);
                yield return new PErisk("Ecuador", 1, -1.845337, 3, 2, 9.117786);
                yield return new PErisk("Finland", 1, -6.907755, 5, 5, 10.12367);
                yield return new PErisk("Gambia, The", 0, -1.543332, 4, 2, 7.501082);
                yield return new PErisk("Ghana", 0, -1.011517, 2, 1, 7.597396);
                yield return new PErisk("Greece", 0, -2.073237, 3, 3, 9.701494);
                yield return new PErisk("Hungary", 1, -0.9041942, 4, 3, 9.35184);
                yield return new PErisk("India", 0, -2.105104, 4, 2, 7.970049);
                yield return new PErisk("Indonesia", 0, -2.100232, 3, 0, 8.39231);
                yield return new PErisk("Iran", 0, 2.337425, 0, 2, 9.368114);
                yield return new PErisk("Ireland", 1, -6.907755, 5, 4, 9.891465);
                yield return new PErisk("Israel", 0, -2.319996, 4, 4, 10.06777);
                yield return new PErisk("Italy", 1, -6.907755, 4, 3, 10.26078);
                yield return new PErisk("Japan", 1, -6.907755, 5, 4, 9.892022);
                yield return new PErisk("Kenya", 0, -2.327605, 2, 2, 7.619724);
                yield return new PErisk("Korea, South", 0, -2.655795, 4, 1, 9.422787);
                yield return new PErisk("Malawi", 0, -1.469424, 3, 3, 7.029973);
                yield return new PErisk("Malaysia", 1, -3.927949, 4, 3, 9.178953);
                yield return new PErisk("Mexico", 0, -1.657935, 2, 2, 9.661735);
                yield return new PErisk("Morocco", 0, -3.156958, 3, 1, 8.78048);
                yield return new PErisk("New Zealand", 1, -6.907755, 5, 5, 10.17626);
                yield return new PErisk("Nigeria", 0, 0.3001068, 1, 1, 7.68708);
                yield return new PErisk("Norway", 1, -6.907755, 5, 5, 10.29833);
                yield return new PErisk("Papua New Guinea", 1, -2.636158, 4, 2, 8.126518);
                yield return new PErisk("Paraguay", 0, -0.9707628, 3, 0, 8.727616);
                yield return new PErisk("Philippines", 0, -2.964776, 1, 1, 8.384804);
                yield return new PErisk("Poland", 1, 1.317021, 3, 3, 9.0524);
                yield return new PErisk("Portugal", 1, -2.459625, 4, 3, 9.444543);
                yield return new PErisk("Sierra Leone", 0, 1.406406, 3, 1, 7.759614);
                yield return new PErisk("Singapore", 1, -4.848516, 5, 5, 9.882724);
                yield return new PErisk("South Africa", 0, -2.17582, 3, 4, 9.191871);
                yield return new PErisk("Spain", 1, -6.907755, 5, 3, 10.04733);
                yield return new PErisk("Sri Lanka", 0, -1.864343, 2, 2, 8.627661);
                yield return new PErisk("Sweden", 1, -6.907755, 4, 5, 10.22434);
                yield return new PErisk("Switzerland", 1, -6.907755, 5, 5, 10.3411);
                yield return new PErisk("Syria", 0, 1.725166, 1, 1, 9.664151);
                yield return new PErisk("Thailand", 0, -6.907755, 3, 2, 8.548692);
                yield return new PErisk("Togo", 0, -4.229065, 4, 1, 7.331715);
                yield return new PErisk("Tunisia", 0, -2.585399, 2, 2, 9.047586);
                yield return new PErisk("Turkey", 0, -2.673243, 3, 2, 8.978912);
                yield return new PErisk("United Kingdom", 1, -6.907755, 5, 5, 10.12727);
                yield return new PErisk("Uruguay", 0, -2.127775, 2, 2, 9.414342);
                yield return new PErisk("Venezuela", 1, 0.428845, 3, 2, 9.84882);
                yield return new PErisk("Zambia", 0, 0.9658105, 3, 1, 7.726213);
                yield return new PErisk("Zimbabwe", 0, -0.6403214, 3, 2, 7.965893);
            }
        }
    }
}
