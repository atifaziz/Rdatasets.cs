// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Lawyers' Ratings of State Judges in the US Superior Court
    /// </summary>

    public class USJudgeRatings
    {
        public readonly string κ;
        public readonly double CONT;
        public readonly double INTG;
        public readonly double DMNR;
        public readonly double DILG;
        public readonly double CFMG;
        public readonly double DECI;
        public readonly double PREP;
        public readonly double FAMI;
        public readonly double ORAL;
        public readonly double WRIT;
        public readonly double PHYS;
        public readonly double RTEN;

        public USJudgeRatings(string κ, double CONT, double INTG, double DMNR, double DILG, double CFMG, double DECI, double PREP, double FAMI, double ORAL, double WRIT, double PHYS, double RTEN)
        {
            this.κ = κ;
            this.CONT = CONT;
            this.INTG = INTG;
            this.DMNR = DMNR;
            this.DILG = DILG;
            this.CFMG = CFMG;
            this.DECI = DECI;
            this.PREP = PREP;
            this.FAMI = FAMI;
            this.ORAL = ORAL;
            this.WRIT = WRIT;
            this.PHYS = PHYS;
            this.RTEN = RTEN;
        }

        public static IEnumerable<USJudgeRatings> Data
        {
            get
            {
                yield return new USJudgeRatings("AARONSON,L.H.", 5.7, 7.9, 7.7, 7.3, 7.1, 7.4, 7.1, 7.1, 7.1, 7, 8.3, 7.8);
                yield return new USJudgeRatings("ALEXANDER,J.M.", 6.8, 8.9, 8.8, 8.5, 7.8, 8.1, 8, 8, 7.8, 7.9, 8.5, 8.7);
                yield return new USJudgeRatings("ARMENTANO,A.J.", 7.2, 8.1, 7.8, 7.8, 7.5, 7.6, 7.5, 7.5, 7.3, 7.4, 7.9, 7.8);
                yield return new USJudgeRatings("BERDON,R.I.", 6.8, 8.8, 8.5, 8.8, 8.3, 8.5, 8.7, 8.7, 8.4, 8.5, 8.8, 8.7);
                yield return new USJudgeRatings("BRACKEN,J.J.", 7.3, 6.4, 4.3, 6.5, 6, 6.2, 5.7, 5.7, 5.1, 5.3, 5.5, 4.8);
                yield return new USJudgeRatings("BURNS,E.B.", 6.2, 8.8, 8.7, 8.5, 7.9, 8, 8.1, 8, 8, 8, 8.6, 8.6);
                yield return new USJudgeRatings("CALLAHAN,R.J.", 10.6, 9, 8.9, 8.7, 8.5, 8.5, 8.5, 8.5, 8.6, 8.4, 9.1, 9);
                yield return new USJudgeRatings("COHEN,S.S.", 7, 5.9, 4.9, 5.1, 5.4, 5.9, 4.8, 5.1, 4.7, 4.9, 6.8, 5);
                yield return new USJudgeRatings("DALY,J.J.", 7.3, 8.9, 8.9, 8.7, 8.6, 8.5, 8.4, 8.4, 8.4, 8.5, 8.8, 8.8);
                yield return new USJudgeRatings("DANNEHY,J.F.", 8.2, 7.9, 6.7, 8.1, 7.9, 8, 7.9, 8.1, 7.7, 7.8, 8.5, 7.9);
                yield return new USJudgeRatings("DEAN,H.H.", 7, 8, 7.6, 7.4, 7.3, 7.5, 7.1, 7.2, 7.1, 7.2, 8.4, 7.7);
                yield return new USJudgeRatings("DEVITA,H.J.", 6.5, 8, 7.6, 7.2, 7, 7.1, 6.9, 7, 7, 7.1, 6.9, 7.2);
                yield return new USJudgeRatings("DRISCOLL,P.J.", 6.7, 8.6, 8.2, 6.8, 6.9, 6.6, 7.1, 7.3, 7.2, 7.2, 8.1, 7.7);
                yield return new USJudgeRatings("GRILLO,A.E.", 7, 7.5, 6.4, 6.8, 6.5, 7, 6.6, 6.8, 6.3, 6.6, 6.2, 6.5);
                yield return new USJudgeRatings("HADDEN,W.L.JR.", 6.5, 8.1, 8, 8, 7.9, 8, 7.9, 7.8, 7.8, 7.8, 8.4, 8);
                yield return new USJudgeRatings("HAMILL,E.C.", 7.3, 8, 7.4, 7.7, 7.3, 7.3, 7.3, 7.2, 7.1, 7.2, 8, 7.6);
                yield return new USJudgeRatings("HEALEY.A.H.", 8, 7.6, 6.6, 7.2, 6.5, 6.5, 6.8, 6.7, 6.4, 6.5, 6.9, 6.7);
                yield return new USJudgeRatings("HULL,T.C.", 7.7, 7.7, 6.7, 7.5, 7.4, 7.5, 7.1, 7.3, 7.1, 7.3, 8.1, 7.4);
                yield return new USJudgeRatings("LEVINE,I.", 8.3, 8.2, 7.4, 7.8, 7.7, 7.7, 7.7, 7.8, 7.5, 7.6, 8, 8);
                yield return new USJudgeRatings("LEVISTER,R.L.", 9.6, 6.9, 5.7, 6.6, 6.9, 6.6, 6.2, 6, 5.8, 5.8, 7.2, 6);
                yield return new USJudgeRatings("MARTIN,L.F.", 7.1, 8.2, 7.7, 7.1, 6.6, 6.6, 6.7, 6.7, 6.8, 6.8, 7.5, 7.3);
                yield return new USJudgeRatings("MCGRATH,J.F.", 7.6, 7.3, 6.9, 6.8, 6.7, 6.8, 6.4, 6.3, 6.3, 6.3, 7.4, 6.6);
                yield return new USJudgeRatings("MIGNONE,A.F.", 6.6, 7.4, 6.2, 6.2, 5.4, 5.7, 5.8, 5.9, 5.2, 5.8, 4.7, 5.2);
                yield return new USJudgeRatings("MISSAL,H.M.", 6.2, 8.3, 8.1, 7.7, 7.4, 7.3, 7.3, 7.3, 7.2, 7.3, 7.8, 7.6);
                yield return new USJudgeRatings("MULVEY,H.M.", 7.5, 8.7, 8.5, 8.6, 8.5, 8.4, 8.5, 8.5, 8.4, 8.4, 8.7, 8.7);
                yield return new USJudgeRatings("NARUK,H.J.", 7.8, 8.9, 8.7, 8.9, 8.7, 8.8, 8.9, 9, 8.8, 8.9, 9, 9);
                yield return new USJudgeRatings("O'BRIEN,F.J.", 7.1, 8.5, 8.3, 8, 7.9, 7.9, 7.8, 7.8, 7.8, 7.7, 8.3, 8.2);
                yield return new USJudgeRatings("O'SULLIVAN,T.J.", 7.5, 9, 8.9, 8.7, 8.4, 8.5, 8.4, 8.3, 8.3, 8.3, 8.8, 8.7);
                yield return new USJudgeRatings("PASKEY,L.", 7.5, 8.1, 7.7, 8.2, 8, 8.1, 8.2, 8.4, 8, 8.1, 8.4, 8.1);
                yield return new USJudgeRatings("RUBINOW,J.E.", 7.1, 9.2, 9, 9, 8.4, 8.6, 9.1, 9.1, 8.9, 9, 8.9, 9.2);
                yield return new USJudgeRatings("SADEN.G.A.", 6.6, 7.4, 6.9, 8.4, 8, 7.9, 8.2, 8.4, 7.7, 7.9, 8.4, 7.5);
                yield return new USJudgeRatings("SATANIELLO,A.G.", 8.4, 8, 7.9, 7.9, 7.8, 7.8, 7.6, 7.4, 7.4, 7.4, 8.1, 7.9);
                yield return new USJudgeRatings("SHEA,D.M.", 6.9, 8.5, 7.8, 8.5, 8.1, 8.2, 8.4, 8.5, 8.1, 8.3, 8.7, 8.3);
                yield return new USJudgeRatings("SHEA,J.F.JR.", 7.3, 8.9, 8.8, 8.7, 8.4, 8.5, 8.5, 8.5, 8.4, 8.4, 8.8, 8.8);
                yield return new USJudgeRatings("SIDOR,W.J.", 7.7, 6.2, 5.1, 5.6, 5.6, 5.9, 5.6, 5.6, 5.3, 5.5, 6.3, 5.3);
                yield return new USJudgeRatings("SPEZIALE,J.A.", 8.5, 8.3, 8.1, 8.3, 8.4, 8.2, 8.2, 8.1, 7.9, 8, 8, 8.2);
                yield return new USJudgeRatings("SPONZO,M.J.", 6.9, 8.3, 8, 8.1, 7.9, 7.9, 7.9, 7.7, 7.6, 7.7, 8.1, 8);
                yield return new USJudgeRatings("STAPLETON,J.F.", 6.5, 8.2, 7.7, 7.8, 7.6, 7.7, 7.7, 7.7, 7.5, 7.6, 8.5, 7.7);
                yield return new USJudgeRatings("TESTO,R.J.", 8.3, 7.3, 7, 6.8, 7, 7.1, 6.7, 6.7, 6.7, 6.7, 8, 7);
                yield return new USJudgeRatings("TIERNEY,W.L.JR.", 8.3, 8.2, 7.8, 8.3, 8.4, 8.3, 7.7, 7.6, 7.5, 7.7, 8.1, 7.9);
                yield return new USJudgeRatings("WALL,R.A.", 9, 7, 5.9, 7, 7, 7.2, 6.9, 6.9, 6.5, 6.6, 7.6, 6.6);
                yield return new USJudgeRatings("WRIGHT,D.B.", 7.1, 8.4, 8.4, 7.7, 7.5, 7.7, 7.8, 8.2, 8, 8.1, 8.3, 8.1);
                yield return new USJudgeRatings("ZARRILLI,K.J.", 8.6, 7.4, 7, 7.5, 7.5, 7.7, 7.4, 7.2, 6.9, 7, 7.8, 7.1);
            }
        }
    }
}
