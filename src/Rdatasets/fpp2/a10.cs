// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Monthly anti-diabetic drug sales in Australia from 1991 to 2008.
    /// </summary>

    public class a10
    {
        public readonly double time;
        public readonly double value;

        public a10(double time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<a10> Data
        {
            get
            {
                yield return new a10(1991.5, 3.526591);
                yield return new a10(1991.58333333333, 3.180891);
                yield return new a10(1991.66666666667, 3.252221);
                yield return new a10(1991.75, 3.611003);
                yield return new a10(1991.83333333333, 3.565869);
                yield return new a10(1991.91666666667, 4.306371);
                yield return new a10(1992, 5.088335);
                yield return new a10(1992.08333333333, 2.81452);
                yield return new a10(1992.16666666667, 2.985811);
                yield return new a10(1992.25, 3.20478);
                yield return new a10(1992.33333333333, 3.127578);
                yield return new a10(1992.41666666667, 3.270523);
                yield return new a10(1992.5, 3.73785082);
                yield return new a10(1992.58333333333, 3.55877609);
                yield return new a10(1992.66666666667, 3.77720173);
                yield return new a10(1992.75, 3.92449042);
                yield return new a10(1992.83333333333, 4.38653092);
                yield return new a10(1992.91666666667, 5.81054917);
                yield return new a10(1993, 6.19206769);
                yield return new a10(1993.08333333333, 3.45085699);
                yield return new a10(1993.16666666667, 3.77230686);
                yield return new a10(1993.25, 3.7343029);
                yield return new a10(1993.33333333333, 3.90539892);
                yield return new a10(1993.41666666667, 4.04968714);
                yield return new a10(1993.5, 4.31556552);
                yield return new a10(1993.58333333333, 4.56218455);
                yield return new a10(1993.66666666667, 4.60866203);
                yield return new a10(1993.75, 4.66785129);
                yield return new a10(1993.83333333333, 5.09384145);
                yield return new a10(1993.91666666667, 7.1799622);
                yield return new a10(1994, 6.73147308);
                yield return new a10(1994.08333333333, 3.84127758);
                yield return new a10(1994.16666666667, 4.39407557);
                yield return new a10(1994.25, 4.07534073);
                yield return new a10(1994.33333333333, 4.5406449);
                yield return new a10(1994.41666666667, 4.64561508);
                yield return new a10(1994.5, 4.75260653);
                yield return new a10(1994.58333333333, 5.35060467);
                yield return new a10(1994.66666666667, 5.20445484);
                yield return new a10(1994.75, 5.3016513);
                yield return new a10(1994.83333333333, 5.77374216);
                yield return new a10(1994.91666666667, 6.20459348);
                yield return new a10(1995, 6.74948382);
                yield return new a10(1995.08333333333, 4.21606735);
                yield return new a10(1995.16666666667, 4.94934946);
                yield return new a10(1995.25, 4.8230449);
                yield return new a10(1995.33333333333, 5.19475419);
                yield return new a10(1995.41666666667, 5.17078711);
                yield return new a10(1995.5, 5.25674157);
                yield return new a10(1995.58333333333, 5.85527729);
                yield return new a10(1995.66666666667, 5.49072901);
                yield return new a10(1995.75, 6.11529323);
                yield return new a10(1995.83333333333, 6.08847284);
                yield return new a10(1995.91666666667, 7.41659792);
                yield return new a10(1996, 8.32945212);
                yield return new a10(1996.08333333333, 5.06979585);
                yield return new a10(1996.16666666667, 5.26255667);
                yield return new a10(1996.25, 5.59712628);
                yield return new a10(1996.33333333333, 6.110296);
                yield return new a10(1996.41666666667, 5.68916084);
                yield return new a10(1996.5, 6.48684933);
                yield return new a10(1996.58333333333, 6.30056933);
                yield return new a10(1996.66666666667, 6.46747574);
                yield return new a10(1996.75, 6.82862939);
                yield return new a10(1996.83333333333, 6.64907826);
                yield return new a10(1996.91666666667, 8.60693721);
                yield return new a10(1997, 8.52447101);
                yield return new a10(1997.08333333333, 5.27791837);
                yield return new a10(1997.16666666667, 5.71430345);
                yield return new a10(1997.25, 6.21452908);
                yield return new a10(1997.33333333333, 6.41192919);
                yield return new a10(1997.41666666667, 6.66771564);
                yield return new a10(1997.5, 7.05083102);
                yield return new a10(1997.58333333333, 6.70491861);
                yield return new a10(1997.66666666667, 7.25098761);
                yield return new a10(1997.75, 7.81973318);
                yield return new a10(1997.83333333333, 7.39810106);
                yield return new a10(1997.91666666667, 10.09623339);
                yield return new a10(1998, 8.79851303);
                yield return new a10(1998.08333333333, 5.91826076);
                yield return new a10(1998.16666666667, 6.53449298);
                yield return new a10(1998.25, 6.67573561);
                yield return new a10(1998.33333333333, 7.06420058);
                yield return new a10(1998.41666666667, 7.38338118);
                yield return new a10(1998.5, 7.81349587);
                yield return new a10(1998.58333333333, 7.43189221);
                yield return new a10(1998.66666666667, 8.27511722);
                yield return new a10(1998.75, 8.26044138);
                yield return new a10(1998.83333333333, 8.59615575);
                yield return new a10(1998.91666666667, 10.55893902);
                yield return new a10(1999, 10.3914156);
                yield return new a10(1999.08333333333, 6.42153456);
                yield return new a10(1999.16666666667, 8.06261937);
                yield return new a10(1999.25, 7.2977391);
                yield return new a10(1999.33333333333, 7.93691594);
                yield return new a10(1999.41666666667, 8.16532298);
                yield return new a10(1999.5, 8.71742046);
                yield return new a10(1999.58333333333, 9.07096378);
                yield return new a10(1999.66666666667, 9.17711337);
                yield return new a10(1999.75, 9.25188674);
                yield return new a10(1999.83333333333, 9.93313643);
                yield return new a10(1999.91666666667, 11.53297428);
                yield return new a10(2000, 12.51146235);
                yield return new a10(2000.08333333333, 7.45719853);
                yield return new a10(2000.16666666667, 8.59119084);
                yield return new a10(2000.25, 8.47400037);
                yield return new a10(2000.33333333333, 9.3868026);
                yield return new a10(2000.41666666667, 9.56039945);
                yield return new a10(2000.5, 10.8342948);
                yield return new a10(2000.58333333333, 10.64375083);
                yield return new a10(2000.66666666667, 9.90816186);
                yield return new a10(2000.75, 11.7100413);
                yield return new a10(2000.83333333333, 11.34015074);
                yield return new a10(2000.91666666667, 12.07913184);
                yield return new a10(2001, 14.49758109);
                yield return new a10(2001.08333333333, 8.04927477);
                yield return new a10(2001.16666666667, 10.31289116);
                yield return new a10(2001.25, 9.75335821);
                yield return new a10(2001.33333333333, 10.85038183);
                yield return new a10(2001.41666666667, 9.96171916);
                yield return new a10(2001.5, 11.44360144);
                yield return new a10(2001.58333333333, 11.65923889);
                yield return new a10(2001.66666666667, 10.64705979);
                yield return new a10(2001.75, 12.65213444);
                yield return new a10(2001.83333333333, 13.67446631);
                yield return new a10(2001.91666666667, 12.96573509);
                yield return new a10(2002, 16.30026927);
                yield return new a10(2002.08333333333, 9.05348536);
                yield return new a10(2002.16666666667, 10.00244879);
                yield return new a10(2002.25, 10.78875007);
                yield return new a10(2002.33333333333, 12.10670515);
                yield return new a10(2002.41666666667, 10.95410107);
                yield return new a10(2002.5, 12.84456587);
                yield return new a10(2002.58333333333, 12.19649985);
                yield return new a10(2002.66666666667, 12.85474787);
                yield return new a10(2002.75, 13.54200436);
                yield return new a10(2002.83333333333, 13.28764);
                yield return new a10(2002.91666666667, 15.13491784);
                yield return new a10(2003, 16.82834968);
                yield return new a10(2003.08333333333, 9.80021461);
                yield return new a10(2003.16666666667, 10.81699371);
                yield return new a10(2003.25, 10.65422256);
                yield return new a10(2003.33333333333, 12.51232269);
                yield return new a10(2003.41666666667, 12.16120969);
                yield return new a10(2003.5, 12.9980462);
                yield return new a10(2003.58333333333, 12.51727568);
                yield return new a10(2003.66666666667, 13.26865761);
                yield return new a10(2003.75, 14.73362169);
                yield return new a10(2003.83333333333, 13.66938174);
                yield return new a10(2003.91666666667, 16.50396561);
                yield return new a10(2004, 18.00376795);
                yield return new a10(2004.08333333333, 11.93802987);
                yield return new a10(2004.16666666667, 12.9979001);
                yield return new a10(2004.25, 12.88264507);
                yield return new a10(2004.33333333333, 13.94344681);
                yield return new a10(2004.41666666667, 13.9894722);
                yield return new a10(2004.5, 15.33909742);
                yield return new a10(2004.58333333333, 15.37076394);
                yield return new a10(2004.66666666667, 16.142005);
                yield return new a10(2004.75, 16.685754);
                yield return new a10(2004.83333333333, 17.636728);
                yield return new a10(2004.91666666667, 18.869325);
                yield return new a10(2005, 20.778723);
                yield return new a10(2005.08333333333, 12.154552);
                yield return new a10(2005.16666666667, 13.402392);
                yield return new a10(2005.25, 14.459239);
                yield return new a10(2005.33333333333, 14.795102);
                yield return new a10(2005.41666666667, 15.705248);
                yield return new a10(2005.5, 15.82955);
                yield return new a10(2005.58333333333, 17.554701);
                yield return new a10(2005.66666666667, 18.100864);
                yield return new a10(2005.75, 17.496668);
                yield return new a10(2005.83333333333, 19.347265);
                yield return new a10(2005.91666666667, 20.031291);
                yield return new a10(2006, 23.486694);
                yield return new a10(2006.08333333333, 12.536987);
                yield return new a10(2006.16666666667, 15.467018);
                yield return new a10(2006.25, 14.233539);
                yield return new a10(2006.33333333333, 17.783058);
                yield return new a10(2006.41666666667, 16.291602);
                yield return new a10(2006.5, 16.980282);
                yield return new a10(2006.58333333333, 18.612189);
                yield return new a10(2006.66666666667, 16.623343);
                yield return new a10(2006.75, 21.430241);
                yield return new a10(2006.83333333333, 23.575517);
                yield return new a10(2006.91666666667, 23.334206);
                yield return new a10(2007, 28.038383);
                yield return new a10(2007.08333333333, 16.763869);
                yield return new a10(2007.16666666667, 19.792754);
                yield return new a10(2007.25, 16.427305);
                yield return new a10(2007.33333333333, 21.000742);
                yield return new a10(2007.41666666667, 20.681002);
                yield return new a10(2007.5, 21.83489);
                yield return new a10(2007.58333333333, 23.93020353);
                yield return new a10(2007.66666666667, 22.93035694);
                yield return new a10(2007.75, 23.26333992);
                yield return new a10(2007.83333333333, 25.25003022);
                yield return new a10(2007.91666666667, 25.80609);
                yield return new a10(2008, 29.665356);
                yield return new a10(2008.08333333333, 21.654285);
                yield return new a10(2008.16666666667, 18.264945);
                yield return new a10(2008.25, 23.107677);
                yield return new a10(2008.33333333333, 22.91251);
                yield return new a10(2008.41666666667, 19.43174);
            }
        }
    }
}
