// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Food Stamp Program Participation
    /// </summary>

    public class foodstamp
    {
        public readonly int participation;
        public readonly int tenancy;
        public readonly int suppl_income;
        public readonly int income;

        public foodstamp(int participation, int tenancy, int suppl_income, int income)
        {
            this.participation = participation;
            this.tenancy = tenancy;
            this.suppl_income = suppl_income;
            this.income = income;
        }

        public static IEnumerable<foodstamp> Data
        {
            get
            {
                yield return new foodstamp(0, 1, 0, 271);
                yield return new foodstamp(0, 1, 0, 287);
                yield return new foodstamp(0, 1, 1, 714);
                yield return new foodstamp(0, 1, 0, 521);
                yield return new foodstamp(0, 0, 0, 0);
                yield return new foodstamp(0, 1, 0, 518);
                yield return new foodstamp(0, 1, 0, 458);
                yield return new foodstamp(0, 1, 0, 1266);
                yield return new foodstamp(0, 0, 0, 350);
                yield return new foodstamp(0, 1, 0, 168);
                yield return new foodstamp(0, 1, 0, 235);
                yield return new foodstamp(0, 0, 0, 450);
                yield return new foodstamp(0, 1, 0, 683);
                yield return new foodstamp(0, 1, 0, 519);
                yield return new foodstamp(0, 1, 0, 477);
                yield return new foodstamp(0, 1, 0, 2697);
                yield return new foodstamp(1, 0, 1, 184);
                yield return new foodstamp(0, 1, 1, 220);
                yield return new foodstamp(0, 0, 0, 581);
                yield return new foodstamp(0, 1, 0, 212);
                yield return new foodstamp(0, 0, 0, 285);
                yield return new foodstamp(1, 1, 1, 188);
                yield return new foodstamp(0, 0, 1, 264);
                yield return new foodstamp(1, 0, 1, 169);
                yield return new foodstamp(0, 0, 1, 198);
                yield return new foodstamp(1, 0, 0, 196);
                yield return new foodstamp(0, 1, 1, 797);
                yield return new foodstamp(0, 1, 0, 435);
                yield return new foodstamp(0, 1, 0, 1202);
                yield return new foodstamp(0, 1, 0, 4533);
                yield return new foodstamp(0, 0, 1, 356);
                yield return new foodstamp(0, 0, 0, 372);
                yield return new foodstamp(0, 0, 1, 453);
                yield return new foodstamp(0, 0, 0, 1427);
                yield return new foodstamp(0, 1, 0, 477);
                yield return new foodstamp(0, 1, 0, 1980);
                yield return new foodstamp(0, 1, 0, 1170);
                yield return new foodstamp(0, 1, 0, 385);
                yield return new foodstamp(0, 1, 0, 1661);
                yield return new foodstamp(1, 0, 0, 885);
                yield return new foodstamp(0, 1, 0, 379);
                yield return new foodstamp(0, 0, 0, 735);
                yield return new foodstamp(0, 1, 0, 580);
                yield return new foodstamp(0, 0, 0, 201);
                yield return new foodstamp(0, 1, 0, 500);
                yield return new foodstamp(0, 1, 0, 449);
                yield return new foodstamp(0, 1, 1, 373);
                yield return new foodstamp(0, 1, 0, 607);
                yield return new foodstamp(0, 1, 0, 211);
                yield return new foodstamp(0, 1, 0, 235);
                yield return new foodstamp(1, 0, 1, 386);
                yield return new foodstamp(1, 0, 0, 176);
                yield return new foodstamp(0, 1, 0, 233);
                yield return new foodstamp(0, 1, 1, 1765);
                yield return new foodstamp(0, 0, 0, 430);
                yield return new foodstamp(0, 1, 0, 1061);
                yield return new foodstamp(0, 0, 1, 534);
                yield return new foodstamp(0, 0, 1, 540);
                yield return new foodstamp(0, 0, 1, 200);
                yield return new foodstamp(0, 1, 0, 3525);
                yield return new foodstamp(0, 1, 1, 2165);
                yield return new foodstamp(1, 0, 1, 177);
                yield return new foodstamp(0, 1, 0, 465);
                yield return new foodstamp(0, 1, 1, 476);
                yield return new foodstamp(0, 1, 0, 589);
                yield return new foodstamp(1, 1, 0, 1200);
                yield return new foodstamp(0, 1, 0, 440);
                yield return new foodstamp(0, 0, 0, 893);
                yield return new foodstamp(0, 1, 0, 471);
                yield return new foodstamp(1, 0, 1, 125);
                yield return new foodstamp(0, 1, 0, 1251);
                yield return new foodstamp(0, 1, 0, 2556);
                yield return new foodstamp(0, 0, 0, 150);
                yield return new foodstamp(0, 1, 0, 429);
                yield return new foodstamp(0, 0, 0, 286);
                yield return new foodstamp(0, 1, 0, 3556);
                yield return new foodstamp(0, 0, 0, 893);
                yield return new foodstamp(0, 1, 1, 230);
                yield return new foodstamp(1, 0, 0, 586);
                yield return new foodstamp(0, 1, 0, 307);
                yield return new foodstamp(0, 1, 0, 482);
                yield return new foodstamp(0, 1, 0, 1504);
                yield return new foodstamp(0, 1, 0, 1680);
                yield return new foodstamp(0, 1, 1, 354);
                yield return new foodstamp(0, 1, 0, 1445);
                yield return new foodstamp(0, 0, 0, 242);
                yield return new foodstamp(0, 0, 0, 613);
                yield return new foodstamp(0, 0, 1, 266);
                yield return new foodstamp(0, 1, 0, 167);
                yield return new foodstamp(0, 1, 0, 426);
                yield return new foodstamp(0, 1, 1, 187);
                yield return new foodstamp(0, 1, 0, 197);
                yield return new foodstamp(0, 1, 0, 346);
                yield return new foodstamp(1, 0, 0, 203);
                yield return new foodstamp(1, 0, 0, 704);
                yield return new foodstamp(0, 1, 0, 107);
                yield return new foodstamp(0, 1, 0, 1578);
                yield return new foodstamp(0, 1, 0, 295);
                yield return new foodstamp(0, 1, 0, 1653);
                yield return new foodstamp(0, 1, 0, 523);
                yield return new foodstamp(0, 1, 0, 1445);
                yield return new foodstamp(0, 0, 1, 443);
                yield return new foodstamp(1, 1, 1, 291);
                yield return new foodstamp(0, 1, 0, 596);
                yield return new foodstamp(0, 1, 1, 476);
                yield return new foodstamp(1, 0, 1, 334);
                yield return new foodstamp(1, 0, 0, 197);
                yield return new foodstamp(0, 0, 1, 575);
                yield return new foodstamp(1, 0, 1, 977);
                yield return new foodstamp(0, 1, 0, 1410);
                yield return new foodstamp(0, 1, 0, 943);
                yield return new foodstamp(0, 1, 0, 697);
                yield return new foodstamp(1, 0, 1, 221);
                yield return new foodstamp(0, 1, 1, 296);
                yield return new foodstamp(0, 1, 1, 489);
                yield return new foodstamp(0, 0, 1, 274);
                yield return new foodstamp(0, 1, 0, 233);
                yield return new foodstamp(0, 1, 0, 992);
                yield return new foodstamp(0, 1, 0, 444);
                yield return new foodstamp(1, 1, 1, 250);
                yield return new foodstamp(0, 1, 0, 260);
                yield return new foodstamp(0, 1, 0, 460);
                yield return new foodstamp(0, 1, 0, 495);
                yield return new foodstamp(0, 1, 0, 260);
                yield return new foodstamp(0, 1, 1, 517);
                yield return new foodstamp(0, 0, 0, 520);
                yield return new foodstamp(0, 0, 0, 512);
                yield return new foodstamp(0, 1, 1, 285);
                yield return new foodstamp(0, 1, 0, 664);
                yield return new foodstamp(0, 0, 0, 462);
                yield return new foodstamp(0, 0, 0, 685);
                yield return new foodstamp(0, 0, 0, 452);
                yield return new foodstamp(0, 1, 0, 1143);
                yield return new foodstamp(0, 1, 0, 1715);
                yield return new foodstamp(1, 0, 1, 248);
                yield return new foodstamp(0, 1, 0, 459);
                yield return new foodstamp(1, 1, 0, 499);
                yield return new foodstamp(0, 1, 1, 273);
                yield return new foodstamp(0, 0, 0, 611);
                yield return new foodstamp(0, 1, 0, 84);
                yield return new foodstamp(1, 0, 0, 205);
                yield return new foodstamp(0, 1, 0, 2331);
                yield return new foodstamp(0, 1, 0, 1228);
                yield return new foodstamp(0, 1, 1, 1179);
                yield return new foodstamp(0, 1, 0, 1170);
                yield return new foodstamp(0, 1, 0, 2995);
                yield return new foodstamp(1, 1, 0, 273);
                yield return new foodstamp(0, 1, 0, 196);
                yield return new foodstamp(0, 1, 1, 1644);
                yield return new foodstamp(1, 0, 0, 214);
            }
        }
    }
}
