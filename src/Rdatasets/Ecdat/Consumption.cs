// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Data on Consumption and Expenditure
    /// </summary>

    public class Consumption
    {
        public readonly double yd;
        public readonly int ce;

        public Consumption(double yd, int ce)
        {
            this.yd = yd;
            this.ce = ce;
        }

        public static IEnumerable<Consumption> Data
        {
            get
            {
                yield return new Consumption(59505, 57168);
                yield return new Consumption(59717.4, 55464);
                yield return new Consumption(59039.1, 56332);
                yield return new Consumption(61342.6, 55836);
                yield return new Consumption(60544.6, 54488);
                yield return new Consumption(60324.6, 53676);
                yield return new Consumption(62120.7, 54208);
                yield return new Consumption(62249.1, 56704);
                yield return new Consumption(61856.1, 54872);
                yield return new Consumption(62070.3, 58588);
                yield return new Consumption(64244.8, 59200);
                yield return new Consumption(65451.5, 59972);
                yield return new Consumption(65269, 60400);
                yield return new Consumption(65625.2, 62100);
                yield return new Consumption(66221.2, 63196);
                yield return new Consumption(67101.6, 62080);
                yield return new Consumption(69809.8, 65220);
                yield return new Consumption(70714.2, 62212);
                yield return new Consumption(68644.1, 61156);
                yield return new Consumption(69660.4, 61464);
                yield return new Consumption(72556.4, 63684);
                yield return new Consumption(74153.8, 66124);
                yield return new Consumption(75353.8, 67764);
                yield return new Consumption(77089.2, 69796);
                yield return new Consumption(77918.8, 70680);
                yield return new Consumption(78343, 71328);
                yield return new Consumption(78300.9, 71216);
                yield return new Consumption(78995.4, 72456);
                yield return new Consumption(77061.9, 72052);
                yield return new Consumption(77282, 73592);
                yield return new Consumption(78457.6, 73876);
                yield return new Consumption(79486.5, 76456);
                yield return new Consumption(81880.4, 76128);
                yield return new Consumption(83789.2, 79412);
                yield return new Consumption(84963.1, 81704);
                yield return new Consumption(87108.9, 83864);
                yield return new Consumption(89626.2, 84768);
                yield return new Consumption(91517.3, 86140);
                yield return new Consumption(92076.4, 87448);
                yield return new Consumption(93325.1, 87296);
                yield return new Consumption(93118.4, 88420);
                yield return new Consumption(93269.7, 89292);
                yield return new Consumption(95712.8, 90600);
                yield return new Consumption(96211.4, 89840);
                yield return new Consumption(96777.7, 90960);
                yield return new Consumption(98713.9, 91160);
                yield return new Consumption(99070, 93424);
                yield return new Consumption(100335.4, 95572);
                yield return new Consumption(100827.3, 96708);
                yield return new Consumption(102557, 97336);
                yield return new Consumption(102169.4, 98512);
                yield return new Consumption(102915.3, 99216);
                yield return new Consumption(104896.4, 99832);
                yield return new Consumption(104643.9, 100816);
                yield return new Consumption(106650.4, 102092);
                yield return new Consumption(106559.4, 103080);
                yield return new Consumption(104125.4, 99956);
                yield return new Consumption(105826.8, 101956);
                yield return new Consumption(108432.6, 104220);
                yield return new Consumption(110003.6, 104544);
                yield return new Consumption(113936.7, 106940);
                yield return new Consumption(114388.5, 107708);
                yield return new Consumption(115628.8, 107528);
                yield return new Consumption(116902.7, 109860);
                yield return new Consumption(117506.3, 110412);
                yield return new Consumption(120332.7, 112264);
                yield return new Consumption(120153.8, 113148);
                yield return new Consumption(122429.7, 115384);
                yield return new Consumption(124412.3, 117572);
                yield return new Consumption(124750.5, 117572);
                yield return new Consumption(127026.9, 120292);
                yield return new Consumption(128805.1, 121376);
                yield return new Consumption(133141.6, 122756);
                yield return new Consumption(133748.9, 125584);
                yield return new Consumption(137019.2, 127312);
                yield return new Consumption(139720.2, 130048);
                yield return new Consumption(142512.2, 131392);
                yield return new Consumption(143373.3, 131600);
                yield return new Consumption(144705.2, 134532);
                yield return new Consumption(146109.8, 134844);
                yield return new Consumption(146772.5, 135840);
                yield return new Consumption(150464.3, 138572);
                yield return new Consumption(150185.9, 138528);
                yield return new Consumption(151640.8, 140760);
                yield return new Consumption(150448.4, 142280);
                yield return new Consumption(155323.3, 142768);
                yield return new Consumption(156915, 145592);
                yield return new Consumption(158460.6, 147928);
                yield return new Consumption(160792.9, 151284);
                yield return new Consumption(159488.2, 150556);
                yield return new Consumption(163144.1, 152184);
                yield return new Consumption(164654.6, 154276);
                yield return new Consumption(165829.2, 152612);
                yield return new Consumption(162454.1, 153492);
                yield return new Consumption(167685.1, 156424);
                yield return new Consumption(169535.3, 157936);
                yield return new Consumption(174154.4, 157592);
                yield return new Consumption(175649.1, 163024);
                yield return new Consumption(180979.4, 166428);
                yield return new Consumption(183541, 170264);
                yield return new Consumption(189300.6, 171548);
                yield return new Consumption(193304.7, 175672);
                yield return new Consumption(196418.8, 177472);
                yield return new Consumption(204243.6, 181996);
                yield return new Consumption(207167.2, 187012);
                yield return new Consumption(213371.2, 188440);
                yield return new Consumption(217382.8, 189900);
                yield return new Consumption(223392.4, 194236);
                yield return new Consumption(228819.2, 199700);
                yield return new Consumption(224779.3, 201256);
                yield return new Consumption(232784.7, 202512);
                yield return new Consumption(233024.7, 200088);
                yield return new Consumption(238731.4, 204548);
                yield return new Consumption(241565.5, 207584);
                yield return new Consumption(247014.3, 212328);
                yield return new Consumption(250142.3, 217016);
                yield return new Consumption(252983.4, 216952);
                yield return new Consumption(259446, 223824);
                yield return new Consumption(255486.5, 225200);
                yield return new Consumption(263228.4, 230444);
                yield return new Consumption(261105.1, 230084);
                yield return new Consumption(264296.8, 228680);
                yield return new Consumption(264354.5, 232224);
                yield return new Consumption(268321.1, 233772);
                yield return new Consumption(275039.6, 235736);
                yield return new Consumption(276962.9, 238704);
                yield return new Consumption(276875.3, 240620);
                yield return new Consumption(280757.4, 241192);
                yield return new Consumption(281301.5, 245224);
                yield return new Consumption(290890.8, 245208);
                yield return new Consumption(287004.6, 246416);
                yield return new Consumption(294106.3, 247012);
                yield return new Consumption(294546, 248772);
                yield return new Consumption(297832.7, 248328);
                yield return new Consumption(296630.8, 252864);
                yield return new Consumption(298747.5, 255412);
                yield return new Consumption(306943.6, 257040);
                yield return new Consumption(312165.4, 258168);
                yield return new Consumption(312312.8, 256876);
                yield return new Consumption(314286.6, 256432);
                yield return new Consumption(319395.5, 250980);
                yield return new Consumption(314758.3, 250728);
                yield return new Consumption(311855, 250196);
                yield return new Consumption(304723.2, 249360);
                yield return new Consumption(302439.8, 253872);
                yield return new Consumption(302710.4, 256972);
                yield return new Consumption(317634.2, 261324);
                yield return new Consumption(312185.9, 263448);
                yield return new Consumption(312089.2, 267200);
                yield return new Consumption(324138.1, 269888);
                yield return new Consumption(325388.5, 270764);
                yield return new Consumption(331381.2, 275564);
                yield return new Consumption(331899.2, 278476);
                yield return new Consumption(333844.3, 281948);
                yield return new Consumption(332679.5, 287884);
                yield return new Consumption(335886.8, 291384);
                yield return new Consumption(338675.6, 292228);
                yield return new Consumption(338714.4, 295672);
                yield return new Consumption(336283.7, 300944);
                yield return new Consumption(338852.8, 301068);
                yield return new Consumption(343951.8, 303672);
                yield return new Consumption(346179.8, 308976);
                yield return new Consumption(348980.7, 312704);
                yield return new Consumption(351556.4, 316460);
                yield return new Consumption(355789.6, 318824);
                yield return new Consumption(360264.2, 323428);
                yield return new Consumption(370116.9, 325408);
                yield return new Consumption(375081.8, 329544);
                yield return new Consumption(382897.6, 332280);
                yield return new Consumption(380608.1, 336640);
                yield return new Consumption(380867, 334884);
                yield return new Consumption(385132.5, 337332);
                yield return new Consumption(388543.1, 342368);
                yield return new Consumption(378841.8, 337888);
                yield return new Consumption(384585.1, 337860);
                yield return new Consumption(381534.1, 336752);
                yield return new Consumption(375007.3, 328636);
                yield return new Consumption(379163.8, 334360);
                yield return new Consumption(377642.9, 334280);
                yield return new Consumption(376542.2, 336308);
                yield return new Consumption(376583.5, 336344);
                yield return new Consumption(384921, 336656);
                yield return new Consumption(384765.4, 338628);
                yield return new Consumption(382044.7, 338848);
                yield return new Consumption(385102.3, 340452);
                yield return new Consumption(387173, 342192);
                yield return new Consumption(382785.7, 343356);
                yield return new Consumption(379566, 345432);
                yield return new Consumption(384796.9, 350636);
                yield return new Consumption(386014.1, 351876);
                yield return new Consumption(386136.2, 352972);
                yield return new Consumption(388264.5, 356168);
                yield return new Consumption(391548.2, 355476);
                yield return new Consumption(390850.3, 357112);
                yield return new Consumption(388239.8, 359348);
                yield return new Consumption(390576.6, 359372);
                yield return new Consumption(391381.5, 363896);
                yield return new Consumption(389502.6, 364428);
                yield return new Consumption(388282.1, 366224);
                yield return new Consumption(388804.1, 371236);
            }
        }
    }
}
