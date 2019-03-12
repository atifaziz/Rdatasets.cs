// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Data on Consumption and Expenditure
    /// </summary>

    public class Consumption
    {
        public readonly int κ;
        public readonly double yd;
        public readonly int ce;

        public Consumption(int κ, double yd, int ce)
        {
            this.κ = κ;
            this.yd = yd;
            this.ce = ce;
        }

        public static IEnumerable<Consumption> Data
        {
            get
            {
                yield return new Consumption(1, 59505, 57168);
                yield return new Consumption(2, 59717.4, 55464);
                yield return new Consumption(3, 59039.1, 56332);
                yield return new Consumption(4, 61342.6, 55836);
                yield return new Consumption(5, 60544.6, 54488);
                yield return new Consumption(6, 60324.6, 53676);
                yield return new Consumption(7, 62120.7, 54208);
                yield return new Consumption(8, 62249.1, 56704);
                yield return new Consumption(9, 61856.1, 54872);
                yield return new Consumption(10, 62070.3, 58588);
                yield return new Consumption(11, 64244.8, 59200);
                yield return new Consumption(12, 65451.5, 59972);
                yield return new Consumption(13, 65269, 60400);
                yield return new Consumption(14, 65625.2, 62100);
                yield return new Consumption(15, 66221.2, 63196);
                yield return new Consumption(16, 67101.6, 62080);
                yield return new Consumption(17, 69809.8, 65220);
                yield return new Consumption(18, 70714.2, 62212);
                yield return new Consumption(19, 68644.1, 61156);
                yield return new Consumption(20, 69660.4, 61464);
                yield return new Consumption(21, 72556.4, 63684);
                yield return new Consumption(22, 74153.8, 66124);
                yield return new Consumption(23, 75353.8, 67764);
                yield return new Consumption(24, 77089.2, 69796);
                yield return new Consumption(25, 77918.8, 70680);
                yield return new Consumption(26, 78343, 71328);
                yield return new Consumption(27, 78300.9, 71216);
                yield return new Consumption(28, 78995.4, 72456);
                yield return new Consumption(29, 77061.9, 72052);
                yield return new Consumption(30, 77282, 73592);
                yield return new Consumption(31, 78457.6, 73876);
                yield return new Consumption(32, 79486.5, 76456);
                yield return new Consumption(33, 81880.4, 76128);
                yield return new Consumption(34, 83789.2, 79412);
                yield return new Consumption(35, 84963.1, 81704);
                yield return new Consumption(36, 87108.9, 83864);
                yield return new Consumption(37, 89626.2, 84768);
                yield return new Consumption(38, 91517.3, 86140);
                yield return new Consumption(39, 92076.4, 87448);
                yield return new Consumption(40, 93325.1, 87296);
                yield return new Consumption(41, 93118.4, 88420);
                yield return new Consumption(42, 93269.7, 89292);
                yield return new Consumption(43, 95712.8, 90600);
                yield return new Consumption(44, 96211.4, 89840);
                yield return new Consumption(45, 96777.7, 90960);
                yield return new Consumption(46, 98713.9, 91160);
                yield return new Consumption(47, 99070, 93424);
                yield return new Consumption(48, 100335.4, 95572);
                yield return new Consumption(49, 100827.3, 96708);
                yield return new Consumption(50, 102557, 97336);
                yield return new Consumption(51, 102169.4, 98512);
                yield return new Consumption(52, 102915.3, 99216);
                yield return new Consumption(53, 104896.4, 99832);
                yield return new Consumption(54, 104643.9, 100816);
                yield return new Consumption(55, 106650.4, 102092);
                yield return new Consumption(56, 106559.4, 103080);
                yield return new Consumption(57, 104125.4, 99956);
                yield return new Consumption(58, 105826.8, 101956);
                yield return new Consumption(59, 108432.6, 104220);
                yield return new Consumption(60, 110003.6, 104544);
                yield return new Consumption(61, 113936.7, 106940);
                yield return new Consumption(62, 114388.5, 107708);
                yield return new Consumption(63, 115628.8, 107528);
                yield return new Consumption(64, 116902.7, 109860);
                yield return new Consumption(65, 117506.3, 110412);
                yield return new Consumption(66, 120332.7, 112264);
                yield return new Consumption(67, 120153.8, 113148);
                yield return new Consumption(68, 122429.7, 115384);
                yield return new Consumption(69, 124412.3, 117572);
                yield return new Consumption(70, 124750.5, 117572);
                yield return new Consumption(71, 127026.9, 120292);
                yield return new Consumption(72, 128805.1, 121376);
                yield return new Consumption(73, 133141.6, 122756);
                yield return new Consumption(74, 133748.9, 125584);
                yield return new Consumption(75, 137019.2, 127312);
                yield return new Consumption(76, 139720.2, 130048);
                yield return new Consumption(77, 142512.2, 131392);
                yield return new Consumption(78, 143373.3, 131600);
                yield return new Consumption(79, 144705.2, 134532);
                yield return new Consumption(80, 146109.8, 134844);
                yield return new Consumption(81, 146772.5, 135840);
                yield return new Consumption(82, 150464.3, 138572);
                yield return new Consumption(83, 150185.9, 138528);
                yield return new Consumption(84, 151640.8, 140760);
                yield return new Consumption(85, 150448.4, 142280);
                yield return new Consumption(86, 155323.3, 142768);
                yield return new Consumption(87, 156915, 145592);
                yield return new Consumption(88, 158460.6, 147928);
                yield return new Consumption(89, 160792.9, 151284);
                yield return new Consumption(90, 159488.2, 150556);
                yield return new Consumption(91, 163144.1, 152184);
                yield return new Consumption(92, 164654.6, 154276);
                yield return new Consumption(93, 165829.2, 152612);
                yield return new Consumption(94, 162454.1, 153492);
                yield return new Consumption(95, 167685.1, 156424);
                yield return new Consumption(96, 169535.3, 157936);
                yield return new Consumption(97, 174154.4, 157592);
                yield return new Consumption(98, 175649.1, 163024);
                yield return new Consumption(99, 180979.4, 166428);
                yield return new Consumption(100, 183541, 170264);
                yield return new Consumption(101, 189300.6, 171548);
                yield return new Consumption(102, 193304.7, 175672);
                yield return new Consumption(103, 196418.8, 177472);
                yield return new Consumption(104, 204243.6, 181996);
                yield return new Consumption(105, 207167.2, 187012);
                yield return new Consumption(106, 213371.2, 188440);
                yield return new Consumption(107, 217382.8, 189900);
                yield return new Consumption(108, 223392.4, 194236);
                yield return new Consumption(109, 228819.2, 199700);
                yield return new Consumption(110, 224779.3, 201256);
                yield return new Consumption(111, 232784.7, 202512);
                yield return new Consumption(112, 233024.7, 200088);
                yield return new Consumption(113, 238731.4, 204548);
                yield return new Consumption(114, 241565.5, 207584);
                yield return new Consumption(115, 247014.3, 212328);
                yield return new Consumption(116, 250142.3, 217016);
                yield return new Consumption(117, 252983.4, 216952);
                yield return new Consumption(118, 259446, 223824);
                yield return new Consumption(119, 255486.5, 225200);
                yield return new Consumption(120, 263228.4, 230444);
                yield return new Consumption(121, 261105.1, 230084);
                yield return new Consumption(122, 264296.8, 228680);
                yield return new Consumption(123, 264354.5, 232224);
                yield return new Consumption(124, 268321.1, 233772);
                yield return new Consumption(125, 275039.6, 235736);
                yield return new Consumption(126, 276962.9, 238704);
                yield return new Consumption(127, 276875.3, 240620);
                yield return new Consumption(128, 280757.4, 241192);
                yield return new Consumption(129, 281301.5, 245224);
                yield return new Consumption(130, 290890.8, 245208);
                yield return new Consumption(131, 287004.6, 246416);
                yield return new Consumption(132, 294106.3, 247012);
                yield return new Consumption(133, 294546, 248772);
                yield return new Consumption(134, 297832.7, 248328);
                yield return new Consumption(135, 296630.8, 252864);
                yield return new Consumption(136, 298747.5, 255412);
                yield return new Consumption(137, 306943.6, 257040);
                yield return new Consumption(138, 312165.4, 258168);
                yield return new Consumption(139, 312312.8, 256876);
                yield return new Consumption(140, 314286.6, 256432);
                yield return new Consumption(141, 319395.5, 250980);
                yield return new Consumption(142, 314758.3, 250728);
                yield return new Consumption(143, 311855, 250196);
                yield return new Consumption(144, 304723.2, 249360);
                yield return new Consumption(145, 302439.8, 253872);
                yield return new Consumption(146, 302710.4, 256972);
                yield return new Consumption(147, 317634.2, 261324);
                yield return new Consumption(148, 312185.9, 263448);
                yield return new Consumption(149, 312089.2, 267200);
                yield return new Consumption(150, 324138.1, 269888);
                yield return new Consumption(151, 325388.5, 270764);
                yield return new Consumption(152, 331381.2, 275564);
                yield return new Consumption(153, 331899.2, 278476);
                yield return new Consumption(154, 333844.3, 281948);
                yield return new Consumption(155, 332679.5, 287884);
                yield return new Consumption(156, 335886.8, 291384);
                yield return new Consumption(157, 338675.6, 292228);
                yield return new Consumption(158, 338714.4, 295672);
                yield return new Consumption(159, 336283.7, 300944);
                yield return new Consumption(160, 338852.8, 301068);
                yield return new Consumption(161, 343951.8, 303672);
                yield return new Consumption(162, 346179.8, 308976);
                yield return new Consumption(163, 348980.7, 312704);
                yield return new Consumption(164, 351556.4, 316460);
                yield return new Consumption(165, 355789.6, 318824);
                yield return new Consumption(166, 360264.2, 323428);
                yield return new Consumption(167, 370116.9, 325408);
                yield return new Consumption(168, 375081.8, 329544);
                yield return new Consumption(169, 382897.6, 332280);
                yield return new Consumption(170, 380608.1, 336640);
                yield return new Consumption(171, 380867, 334884);
                yield return new Consumption(172, 385132.5, 337332);
                yield return new Consumption(173, 388543.1, 342368);
                yield return new Consumption(174, 378841.8, 337888);
                yield return new Consumption(175, 384585.1, 337860);
                yield return new Consumption(176, 381534.1, 336752);
                yield return new Consumption(177, 375007.3, 328636);
                yield return new Consumption(178, 379163.8, 334360);
                yield return new Consumption(179, 377642.9, 334280);
                yield return new Consumption(180, 376542.2, 336308);
                yield return new Consumption(181, 376583.5, 336344);
                yield return new Consumption(182, 384921, 336656);
                yield return new Consumption(183, 384765.4, 338628);
                yield return new Consumption(184, 382044.7, 338848);
                yield return new Consumption(185, 385102.3, 340452);
                yield return new Consumption(186, 387173, 342192);
                yield return new Consumption(187, 382785.7, 343356);
                yield return new Consumption(188, 379566, 345432);
                yield return new Consumption(189, 384796.9, 350636);
                yield return new Consumption(190, 386014.1, 351876);
                yield return new Consumption(191, 386136.2, 352972);
                yield return new Consumption(192, 388264.5, 356168);
                yield return new Consumption(193, 391548.2, 355476);
                yield return new Consumption(194, 390850.3, 357112);
                yield return new Consumption(195, 388239.8, 359348);
                yield return new Consumption(196, 390576.6, 359372);
                yield return new Consumption(197, 391381.5, 363896);
                yield return new Consumption(198, 389502.6, 364428);
                yield return new Consumption(199, 388282.1, 366224);
                yield return new Consumption(200, 388804.1, 371236);
            }
        }
    }
}
