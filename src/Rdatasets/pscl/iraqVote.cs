// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// U.S. Senate vote on the use of force against Iraq, 2002.
    /// </summary>

    public class iraqVote
    {
        public readonly int y;
        public readonly string state_abb;
        public readonly string name;
        public readonly bool rep;
        public readonly string state_name;
        public readonly double gorevote;

        public iraqVote(int y, string state_abb, string name, bool rep, string state_name, double gorevote)
        {
            this.y = y;
            this.state_abb = state_abb;
            this.name = name;
            this.rep = rep;
            this.state_name = state_name;
            this.gorevote = gorevote;
        }

        public static IEnumerable<iraqVote> Data
        {
            get
            {
                yield return new iraqVote(1, "AL", "SESSIONS (R AL)", true, "Alabama", 41.59);
                yield return new iraqVote(1, "AL", "SHELBY (R AL)", true, "Alabama", 41.59);
                yield return new iraqVote(1, "AK", "MURKOWSKI (R AK)", true, "Alaska", 27.67);
                yield return new iraqVote(1, "AK", "STEVENS (R AK)", true, "Alaska", 27.67);
                yield return new iraqVote(1, "AZ", "KYL (R AZ)", true, "Arizona", 44.67);
                yield return new iraqVote(1, "AZ", "MCCAIN (R AZ)", true, "Arizona", 44.67);
                yield return new iraqVote(1, "AR", "HUTCHINSON (R AR)", true, "Arkansas", 45.86);
                yield return new iraqVote(1, "AR", "LINCOLN (D AR)", false, "Arkansas", 45.86);
                yield return new iraqVote(0, "CA", "BOXER (D CA)", false, "California", 53.45);
                yield return new iraqVote(1, "CA", "FEINSTEIN (D CA)", false, "California", 53.45);
                yield return new iraqVote(1, "CO", "ALLARD (R CO)", true, "Colorado", 42.39);
                yield return new iraqVote(1, "CO", "CAMPBELL (R CO)", true, "Colorado", 42.39);
                yield return new iraqVote(1, "CT", "DODD (D CT)", false, "Connecticut", 55.91);
                yield return new iraqVote(1, "CT", "LIEBERMAN (D CT)", false, "Connecticut", 55.91);
                yield return new iraqVote(1, "DE", "BIDEN (D DE)", false, "Delaware", 54.96);
                yield return new iraqVote(1, "DE", "CARPER (D DE)", false, "Delaware", 54.96);
                yield return new iraqVote(0, "FL", "GRAHAM (D FL)", false, "Florida", 48.84);
                yield return new iraqVote(1, "FL", "NELSON (D FL)", false, "Florida", 48.84);
                yield return new iraqVote(1, "GA", "CLELAND (D GA)", false, "Georgia", 42.98);
                yield return new iraqVote(1, "GA", "MILLER (D GA)", false, "Georgia", 42.98);
                yield return new iraqVote(0, "HI", "AKAKA (D HI)", false, "Hawaii", 55.79);
                yield return new iraqVote(0, "HI", "INOUYE (D HI)", false, "Hawaii", 55.79);
                yield return new iraqVote(1, "ID", "CRAIG (R ID)", true, "Idaho", 27.64);
                yield return new iraqVote(1, "ID", "CRAPO (R ID)", true, "Idaho", 27.64);
                yield return new iraqVote(0, "IL", "DURBIN (D IL)", false, "Illinois", 54.6);
                yield return new iraqVote(1, "IL", "FITZGERALD (R IL)", true, "Illinois", 54.6);
                yield return new iraqVote(1, "IN", "BAYH (D IN)", false, "Indiana", 41.01);
                yield return new iraqVote(1, "IN", "LUGAR (R IN)", true, "Indiana", 41.01);
                yield return new iraqVote(1, "IA", "GRASSLEY (R IA)", true, "Iowa", 48.54);
                yield return new iraqVote(1, "IA", "HARKIN (D IA)", false, "Iowa", 48.54);
                yield return new iraqVote(1, "KS", "BROWNBACK (R KS)", true, "Kansas", 37.24);
                yield return new iraqVote(1, "KS", "ROBERTS (R KS)", true, "Kansas", 37.24);
                yield return new iraqVote(1, "KY", "BUNNING (R KY)", true, "Kentucky", 41.37);
                yield return new iraqVote(1, "KY", "MCCONNELL (R KY)", true, "Kentucky", 41.37);
                yield return new iraqVote(1, "LA", "BREAUX (D LA)", false, "Louisiana", 44.88);
                yield return new iraqVote(1, "LA", "LANDRIEU (D LA)", false, "Louisiana", 44.88);
                yield return new iraqVote(1, "ME", "COLLINS (R ME)", true, "Maine", 49.09);
                yield return new iraqVote(1, "ME", "SNOWE (R ME)", true, "Maine", 49.09);
                yield return new iraqVote(0, "MD", "MIKULSKI (D MD)", false, "Maryland", 56.57);
                yield return new iraqVote(0, "MD", "SARBANES (D MD)", false, "Maryland", 56.57);
                yield return new iraqVote(0, "MA", "KENNEDY (D MA)", false, "Massachusetts", 59.8);
                yield return new iraqVote(1, "MA", "KERRY (D MA)", false, "Massachusetts", 59.8);
                yield return new iraqVote(0, "MI", "STABENOW (D MI)", false, "Michigan", 51.28);
                yield return new iraqVote(0, "MI", "LEVIN (D MI)", false, "Michigan", 51.28);
                yield return new iraqVote(0, "MN", "DAYTON (D MN)", false, "Minnesota", 47.91);
                yield return new iraqVote(0, "MN", "WELLSTONE (D MN)", false, "Minnesota", 47.91);
                yield return new iraqVote(1, "MS", "COCHRAN (R MS)", true, "Mississippi", 40.7);
                yield return new iraqVote(1, "MS", "LOTT (R MS)", true, "Mississippi", 40.7);
                yield return new iraqVote(1, "MO", "CARNAHAN (D MO)", false, "Missouri", 47.08);
                yield return new iraqVote(1, "MO", "BOND (R MO)", true, "Missouri", 47.08);
                yield return new iraqVote(1, "MT", "BAUCUS (D MT)", false, "Montana", 33.36);
                yield return new iraqVote(1, "MT", "BURNS (R MT)", true, "Montana", 33.36);
                yield return new iraqVote(1, "NE", "HAGEL (R NE)", true, "Nebraska", 33.25);
                yield return new iraqVote(1, "NE", "NELSON (D NE)", false, "Nebraska", 33.25);
                yield return new iraqVote(1, "NV", "ENSIGN (R NV)", true, "Nevada", 45.98);
                yield return new iraqVote(1, "NV", "REID (D NV)", false, "Nevada", 45.98);
                yield return new iraqVote(1, "NH", "GREGG (R NH)", true, "New Hampshire", 46.8);
                yield return new iraqVote(1, "NH", "SMITH (R NH)", true, "New Hampshire", 46.8);
                yield return new iraqVote(0, "NJ", "CORZINE (D NJ)", false, "New Jersey", 56.13);
                yield return new iraqVote(1, "NJ", "TORRICELLI (D NJ)", false, "New Jersey", 56.13);
                yield return new iraqVote(0, "NM", "BINGAMAN (D NM)", false, "New Mexico", 47.91);
                yield return new iraqVote(1, "NM", "DOMENICI (R NM)", true, "New Mexico", 47.91);
                yield return new iraqVote(1, "NY", "CLINTON (D NY)", false, "New York", 60.21);
                yield return new iraqVote(1, "NY", "SCHUMER (D NY)", false, "New York", 60.21);
                yield return new iraqVote(1, "NC", "EDWARDS (D NC)", false, "North Carolina", 43.2);
                yield return new iraqVote(1, "NC", "HELMS (R NC)", true, "North Carolina", 43.2);
                yield return new iraqVote(0, "ND", "CONRAD (D ND)", false, "North Dakota", 33.05);
                yield return new iraqVote(1, "ND", "DORGAN (D ND)", false, "North Dakota", 33.05);
                yield return new iraqVote(1, "OH", "DEWINE (R OH)", true, "Ohio", 46.46);
                yield return new iraqVote(1, "OH", "VOINOVICH (R OH)", true, "Ohio", 46.46);
                yield return new iraqVote(1, "OK", "INHOFE (R OK)", true, "Oklahoma", 38.43);
                yield return new iraqVote(1, "OK", "NICKLES (R OK)", true, "Oklahoma", 38.43);
                yield return new iraqVote(1, "OR", "SMITH (R OR)", true, "Oregon", 46.96);
                yield return new iraqVote(0, "OR", "WYDEN (D OR)", false, "Oregon", 46.96);
                yield return new iraqVote(1, "PA", "SANTORUM (R PA)", true, "Pennsylvania", 50.6);
                yield return new iraqVote(1, "PA", "SPECTER (R PA)", true, "Pennsylvania", 50.6);
                yield return new iraqVote(0, "RI", "CHAFEE (R RI)", true, "Rhode Island", 60.99);
                yield return new iraqVote(0, "RI", "REED (D RI)", false, "Rhode Island", 60.99);
                yield return new iraqVote(1, "SC", "HOLLINGS (D SC)", false, "South Carolina", 40.91);
                yield return new iraqVote(1, "SC", "THURMOND (R SC)", true, "South Carolina", 40.91);
                yield return new iraqVote(1, "SD", "DASCHLE (D SD)", false, "South Dakota", 37.56);
                yield return new iraqVote(1, "SD", "JOHNSON (D SD)", false, "South Dakota", 37.56);
                yield return new iraqVote(1, "TN", "FRIST (R TN)", true, "Tennessee", 47.28);
                yield return new iraqVote(1, "TN", "THOMPSON (R TN)", true, "Tennessee", 47.28);
                yield return new iraqVote(1, "TX", "GRAMM (R TX)", true, "Texas", 37.98);
                yield return new iraqVote(1, "TX", "HUTCHISON (R TX)", true, "Texas", 37.98);
                yield return new iraqVote(1, "UT", "BENNETT (R UT)", true, "Utah", 26.34);
                yield return new iraqVote(1, "UT", "HATCH (R UT)", true, "Utah", 26.34);
                yield return new iraqVote(0, "VT", "JEFFORDS (Indep VT)", false, "Vermont", 50.63);
                yield return new iraqVote(0, "VT", "LEAHY (D VT)", false, "Vermont", 50.63);
                yield return new iraqVote(1, "VA", "ALLEN (R VA)", true, "Virginia", 44.44);
                yield return new iraqVote(1, "VA", "WARNER (R VA)", true, "Virginia", 44.44);
                yield return new iraqVote(1, "WA", "CANTWELL (D WA)", false, "Washington", 50.13);
                yield return new iraqVote(0, "WA", "MURRAY (D WA)", false, "Washington", 50.13);
                yield return new iraqVote(0, "WV", "BYRD (D WV)", false, "West Virginia", 45.59);
                yield return new iraqVote(1, "WV", "ROCKEFELLER (D WV)", false, "West Virginia", 45.59);
                yield return new iraqVote(0, "WI", "FEINGOLD (D WI)", false, "Wisconsin", 47.83);
                yield return new iraqVote(1, "WI", "KOHL (D WI)", false, "Wisconsin", 47.83);
                yield return new iraqVote(1, "WY", "ENZI (R WY)", true, "Wyoming", 27.7);
                yield return new iraqVote(1, "WY", "THOMAS (R WY)", true, "Wyoming", 27.7);
            }
        }
    }
}
