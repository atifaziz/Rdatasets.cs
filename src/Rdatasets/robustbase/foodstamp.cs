// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Food Stamp Program Participation
    /// </summary>

    public class foodstamp
    {
        public readonly int κ;
        public readonly int participation;
        public readonly int tenancy;
        public readonly int suppl_income;
        public readonly int income;

        public foodstamp(int κ, int participation, int tenancy, int suppl_income, int income)
        {
            this.κ = κ;
            this.participation = participation;
            this.tenancy = tenancy;
            this.suppl_income = suppl_income;
            this.income = income;
        }

        public static IEnumerable<foodstamp> Data
        {
            get
            {
                yield return new foodstamp(1, 0, 1, 0, 271);
                yield return new foodstamp(2, 0, 1, 0, 287);
                yield return new foodstamp(3, 0, 1, 1, 714);
                yield return new foodstamp(4, 0, 1, 0, 521);
                yield return new foodstamp(5, 0, 0, 0, 0);
                yield return new foodstamp(6, 0, 1, 0, 518);
                yield return new foodstamp(7, 0, 1, 0, 458);
                yield return new foodstamp(8, 0, 1, 0, 1266);
                yield return new foodstamp(9, 0, 0, 0, 350);
                yield return new foodstamp(10, 0, 1, 0, 168);
                yield return new foodstamp(11, 0, 1, 0, 235);
                yield return new foodstamp(12, 0, 0, 0, 450);
                yield return new foodstamp(13, 0, 1, 0, 683);
                yield return new foodstamp(14, 0, 1, 0, 519);
                yield return new foodstamp(15, 0, 1, 0, 477);
                yield return new foodstamp(16, 0, 1, 0, 2697);
                yield return new foodstamp(17, 1, 0, 1, 184);
                yield return new foodstamp(18, 0, 1, 1, 220);
                yield return new foodstamp(19, 0, 0, 0, 581);
                yield return new foodstamp(20, 0, 1, 0, 212);
                yield return new foodstamp(21, 0, 0, 0, 285);
                yield return new foodstamp(22, 1, 1, 1, 188);
                yield return new foodstamp(23, 0, 0, 1, 264);
                yield return new foodstamp(24, 1, 0, 1, 169);
                yield return new foodstamp(25, 0, 0, 1, 198);
                yield return new foodstamp(26, 1, 0, 0, 196);
                yield return new foodstamp(27, 0, 1, 1, 797);
                yield return new foodstamp(28, 0, 1, 0, 435);
                yield return new foodstamp(29, 0, 1, 0, 1202);
                yield return new foodstamp(30, 0, 1, 0, 4533);
                yield return new foodstamp(31, 0, 0, 1, 356);
                yield return new foodstamp(32, 0, 0, 0, 372);
                yield return new foodstamp(33, 0, 0, 1, 453);
                yield return new foodstamp(34, 0, 0, 0, 1427);
                yield return new foodstamp(35, 0, 1, 0, 477);
                yield return new foodstamp(36, 0, 1, 0, 1980);
                yield return new foodstamp(37, 0, 1, 0, 1170);
                yield return new foodstamp(38, 0, 1, 0, 385);
                yield return new foodstamp(39, 0, 1, 0, 1661);
                yield return new foodstamp(40, 1, 0, 0, 885);
                yield return new foodstamp(41, 0, 1, 0, 379);
                yield return new foodstamp(42, 0, 0, 0, 735);
                yield return new foodstamp(43, 0, 1, 0, 580);
                yield return new foodstamp(44, 0, 0, 0, 201);
                yield return new foodstamp(45, 0, 1, 0, 500);
                yield return new foodstamp(46, 0, 1, 0, 449);
                yield return new foodstamp(47, 0, 1, 1, 373);
                yield return new foodstamp(48, 0, 1, 0, 607);
                yield return new foodstamp(49, 0, 1, 0, 211);
                yield return new foodstamp(50, 0, 1, 0, 235);
                yield return new foodstamp(51, 1, 0, 1, 386);
                yield return new foodstamp(52, 1, 0, 0, 176);
                yield return new foodstamp(53, 0, 1, 0, 233);
                yield return new foodstamp(54, 0, 1, 1, 1765);
                yield return new foodstamp(55, 0, 0, 0, 430);
                yield return new foodstamp(56, 0, 1, 0, 1061);
                yield return new foodstamp(57, 0, 0, 1, 534);
                yield return new foodstamp(58, 0, 0, 1, 540);
                yield return new foodstamp(59, 0, 0, 1, 200);
                yield return new foodstamp(60, 0, 1, 0, 3525);
                yield return new foodstamp(61, 0, 1, 1, 2165);
                yield return new foodstamp(62, 1, 0, 1, 177);
                yield return new foodstamp(63, 0, 1, 0, 465);
                yield return new foodstamp(64, 0, 1, 1, 476);
                yield return new foodstamp(65, 0, 1, 0, 589);
                yield return new foodstamp(66, 1, 1, 0, 1200);
                yield return new foodstamp(67, 0, 1, 0, 440);
                yield return new foodstamp(68, 0, 0, 0, 893);
                yield return new foodstamp(69, 0, 1, 0, 471);
                yield return new foodstamp(70, 1, 0, 1, 125);
                yield return new foodstamp(71, 0, 1, 0, 1251);
                yield return new foodstamp(72, 0, 1, 0, 2556);
                yield return new foodstamp(73, 0, 0, 0, 150);
                yield return new foodstamp(74, 0, 1, 0, 429);
                yield return new foodstamp(75, 0, 0, 0, 286);
                yield return new foodstamp(76, 0, 1, 0, 3556);
                yield return new foodstamp(77, 0, 0, 0, 893);
                yield return new foodstamp(78, 0, 1, 1, 230);
                yield return new foodstamp(79, 1, 0, 0, 586);
                yield return new foodstamp(80, 0, 1, 0, 307);
                yield return new foodstamp(81, 0, 1, 0, 482);
                yield return new foodstamp(82, 0, 1, 0, 1504);
                yield return new foodstamp(83, 0, 1, 0, 1680);
                yield return new foodstamp(84, 0, 1, 1, 354);
                yield return new foodstamp(85, 0, 1, 0, 1445);
                yield return new foodstamp(86, 0, 0, 0, 242);
                yield return new foodstamp(87, 0, 0, 0, 613);
                yield return new foodstamp(88, 0, 0, 1, 266);
                yield return new foodstamp(89, 0, 1, 0, 167);
                yield return new foodstamp(90, 0, 1, 0, 426);
                yield return new foodstamp(91, 0, 1, 1, 187);
                yield return new foodstamp(92, 0, 1, 0, 197);
                yield return new foodstamp(93, 0, 1, 0, 346);
                yield return new foodstamp(94, 1, 0, 0, 203);
                yield return new foodstamp(95, 1, 0, 0, 704);
                yield return new foodstamp(96, 0, 1, 0, 107);
                yield return new foodstamp(97, 0, 1, 0, 1578);
                yield return new foodstamp(98, 0, 1, 0, 295);
                yield return new foodstamp(99, 0, 1, 0, 1653);
                yield return new foodstamp(100, 0, 1, 0, 523);
                yield return new foodstamp(101, 0, 1, 0, 1445);
                yield return new foodstamp(102, 0, 0, 1, 443);
                yield return new foodstamp(103, 1, 1, 1, 291);
                yield return new foodstamp(104, 0, 1, 0, 596);
                yield return new foodstamp(105, 0, 1, 1, 476);
                yield return new foodstamp(106, 1, 0, 1, 334);
                yield return new foodstamp(107, 1, 0, 0, 197);
                yield return new foodstamp(108, 0, 0, 1, 575);
                yield return new foodstamp(109, 1, 0, 1, 977);
                yield return new foodstamp(110, 0, 1, 0, 1410);
                yield return new foodstamp(111, 0, 1, 0, 943);
                yield return new foodstamp(112, 0, 1, 0, 697);
                yield return new foodstamp(113, 1, 0, 1, 221);
                yield return new foodstamp(114, 0, 1, 1, 296);
                yield return new foodstamp(115, 0, 1, 1, 489);
                yield return new foodstamp(116, 0, 0, 1, 274);
                yield return new foodstamp(117, 0, 1, 0, 233);
                yield return new foodstamp(118, 0, 1, 0, 992);
                yield return new foodstamp(119, 0, 1, 0, 444);
                yield return new foodstamp(120, 1, 1, 1, 250);
                yield return new foodstamp(121, 0, 1, 0, 260);
                yield return new foodstamp(122, 0, 1, 0, 460);
                yield return new foodstamp(123, 0, 1, 0, 495);
                yield return new foodstamp(124, 0, 1, 0, 260);
                yield return new foodstamp(125, 0, 1, 1, 517);
                yield return new foodstamp(126, 0, 0, 0, 520);
                yield return new foodstamp(127, 0, 0, 0, 512);
                yield return new foodstamp(128, 0, 1, 1, 285);
                yield return new foodstamp(129, 0, 1, 0, 664);
                yield return new foodstamp(130, 0, 0, 0, 462);
                yield return new foodstamp(131, 0, 0, 0, 685);
                yield return new foodstamp(132, 0, 0, 0, 452);
                yield return new foodstamp(133, 0, 1, 0, 1143);
                yield return new foodstamp(134, 0, 1, 0, 1715);
                yield return new foodstamp(135, 1, 0, 1, 248);
                yield return new foodstamp(136, 0, 1, 0, 459);
                yield return new foodstamp(137, 1, 1, 0, 499);
                yield return new foodstamp(138, 0, 1, 1, 273);
                yield return new foodstamp(139, 0, 0, 0, 611);
                yield return new foodstamp(140, 0, 1, 0, 84);
                yield return new foodstamp(141, 1, 0, 0, 205);
                yield return new foodstamp(142, 0, 1, 0, 2331);
                yield return new foodstamp(143, 0, 1, 0, 1228);
                yield return new foodstamp(144, 0, 1, 1, 1179);
                yield return new foodstamp(145, 0, 1, 0, 1170);
                yield return new foodstamp(146, 0, 1, 0, 2995);
                yield return new foodstamp(147, 1, 1, 0, 273);
                yield return new foodstamp(148, 0, 1, 0, 196);
                yield return new foodstamp(149, 0, 1, 1, 1644);
                yield return new foodstamp(150, 1, 0, 0, 214);
            }
        }
    }
}
