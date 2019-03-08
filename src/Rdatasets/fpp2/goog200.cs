// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Daily closing stock prices of Google Inc
    /// </summary>

    public class goog200
    {
        public readonly int time;
        public readonly double value;

        public goog200(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<goog200> Data
        {
            get
            {
                yield return new goog200(1, 392.830017);
                yield return new goog200(2, 392.512085);
                yield return new goog200(3, 397.305908);
                yield return new goog200(4, 398.011322);
                yield return new goog200(5, 400.490204);
                yield return new goog200(6, 408.095734);
                yield return new goog200(7, 416.590485);
                yield return new goog200(8, 413.003815);
                yield return new goog200(9, 413.609863);
                yield return new goog200(10, 413.073364);
                yield return new goog200(11, 414.712708);
                yield return new goog200(12, 411.130981);
                yield return new goog200(13, 409.988434);
                yield return new goog200(14, 408.115601);
                yield return new goog200(15, 404.518982);
                yield return new goog200(16, 401.285034);
                yield return new goog200(17, 403.038635);
                yield return new goog200(18, 404.722656);
                yield return new goog200(19, 403.00882);
                yield return new goog200(20, 402.536896);
                yield return new goog200(21, 402.204041);
                yield return new goog200(22, 403.585083);
                yield return new goog200(23, 398.736603);
                yield return new goog200(24, 394.528961);
                yield return new goog200(25, 398.006348);
                yield return new goog200(26, 403.893066);
                yield return new goog200(27, 400.495178);
                yield return new goog200(28, 394.966125);
                yield return new goog200(29, 388.994965);
                yield return new goog200(30, 384.921448);
                yield return new goog200(31, 386.312408);
                yield return new goog200(32, 392.536926);
                yield return new goog200(33, 392.641235);
                yield return new goog200(34, 392.472351);
                yield return new goog200(35, 388.438568);
                yield return new goog200(36, 394.121613);
                yield return new goog200(37, 388.751556);
                yield return new goog200(38, 380.480347);
                yield return new goog200(39, 397.350616);
                yield return new goog200(40, 397.469849);
                yield return new goog200(41, 401.339661);
                yield return new goog200(42, 404.096741);
                yield return new goog200(43, 401.935791);
                yield return new goog200(44, 398.120605);
                yield return new goog200(45, 406.883606);
                yield return new goog200(46, 409.620819);
                yield return new goog200(47, 407.564178);
                yield return new goog200(48, 412.124542);
                yield return new goog200(49, 420.127472);
                yield return new goog200(50, 427.991333);
                yield return new goog200(51, 425.845276);
                yield return new goog200(52, 433.99231);
                yield return new goog200(53, 432.924255);
                yield return new goog200(54, 437.270966);
                yield return new goog200(55, 435.929688);
                yield return new goog200(56, 440.683777);
                yield return new goog200(57, 454.985748);
                yield return new goog200(58, 449.014587);
                yield return new goog200(59, 451.652435);
                yield return new goog200(60, 451.329529);
                yield return new goog200(61, 450.554565);
                yield return new goog200(62, 441.836273);
                yield return new goog200(63, 438.542694);
                yield return new goog200(64, 433.838287);
                yield return new goog200(65, 437.787628);
                yield return new goog200(66, 431.349487);
                yield return new goog200(67, 432.566559);
                yield return new goog200(68, 432.795074);
                yield return new goog200(69, 431.011688);
                yield return new goog200(70, 426.774231);
                yield return new goog200(71, 427.072296);
                yield return new goog200(72, 429.526337);
                yield return new goog200(73, 437.022583);
                yield return new goog200(74, 442.233704);
                yield return new goog200(75, 437.062317);
                yield return new goog200(76, 433.172638);
                yield return new goog200(77, 435.666412);
                yield return new goog200(78, 434.692749);
                yield return new goog200(79, 440.261536);
                yield return new goog200(80, 447.400085);
                yield return new goog200(81, 447.429901);
                yield return new goog200(82, 439.511414);
                yield return new goog200(83, 437.618713);
                yield return new goog200(84, 432.084717);
                yield return new goog200(85, 430.3013);
                yield return new goog200(86, 434.002228);
                yield return new goog200(87, 435.701172);
                yield return new goog200(88, 437.340515);
                yield return new goog200(89, 441.071259);
                yield return new goog200(90, 438.30426);
                yield return new goog200(91, 440.350952);
                yield return new goog200(92, 443.858124);
                yield return new goog200(93, 449.620636);
                yield return new goog200(94, 449.69516);
                yield return new goog200(95, 450.067749);
                yield return new goog200(96, 457.146698);
                yield return new goog200(97, 458.517792);
                yield return new goog200(98, 459.35733);
                yield return new goog200(99, 456.83374);
                yield return new goog200(100, 456.307159);
                yield return new goog200(101, 452.397583);
                yield return new goog200(102, 445.403076);
                yield return new goog200(103, 452.407532);
                yield return new goog200(104, 448.979828);
                yield return new goog200(105, 448.532715);
                yield return new goog200(106, 440.981842);
                yield return new goog200(107, 439.814423);
                yield return new goog200(108, 438.284393);
                yield return new goog200(109, 442.581421);
                yield return new goog200(110, 441.006683);
                yield return new goog200(111, 449.188477);
                yield return new goog200(112, 450.355865);
                yield return new goog200(113, 449.575928);
                yield return new goog200(114, 445.388184);
                yield return new goog200(115, 442.447296);
                yield return new goog200(116, 443.445801);
                yield return new goog200(117, 442.328094);
                yield return new goog200(118, 439.893921);
                yield return new goog200(119, 437.777679);
                yield return new goog200(120, 432.094635);
                yield return new goog200(121, 427.052429);
                yield return new goog200(122, 425.68631);
                yield return new goog200(123, 430.028076);
                yield return new goog200(124, 429.913818);
                yield return new goog200(125, 431.856201);
                yield return new goog200(126, 434.032043);
                yield return new goog200(127, 432.293335);
                yield return new goog200(128, 430.395691);
                yield return new goog200(129, 422.328156);
                yield return new goog200(130, 421.533325);
                yield return new goog200(131, 424.951111);
                yield return new goog200(132, 420.713654);
                yield return new goog200(133, 427.410095);
                yield return new goog200(134, 432.998749);
                yield return new goog200(135, 436.938141);
                yield return new goog200(136, 436.948059);
                yield return new goog200(137, 441.155701);
                yield return new goog200(138, 441.463715);
                yield return new goog200(139, 445.199402);
                yield return new goog200(140, 443.644531);
                yield return new goog200(141, 441.662415);
                yield return new goog200(142, 441.011658);
                yield return new goog200(143, 440.191986);
                yield return new goog200(144, 448.741364);
                yield return new goog200(145, 446.292297);
                yield return new goog200(146, 448.637054);
                yield return new goog200(147, 440.385712);
                yield return new goog200(148, 440.554626);
                yield return new goog200(149, 435.78067);
                yield return new goog200(150, 436.24762);
                yield return new goog200(151, 435.363373);
                yield return new goog200(152, 435.124939);
                yield return new goog200(153, 440.634094);
                yield return new goog200(154, 441.125916);
                yield return new goog200(155, 435.214355);
                yield return new goog200(156, 433.356445);
                yield return new goog200(157, 430.072784);
                yield return new goog200(158, 424.076782);
                yield return new goog200(159, 425.164703);
                yield return new goog200(160, 431.314728);
                yield return new goog200(161, 433.177612);
                yield return new goog200(162, 435.224274);
                yield return new goog200(163, 438.155212);
                yield return new goog200(164, 446.113464);
                yield return new goog200(165, 441.523315);
                yield return new goog200(166, 502.437134);
                yield return new goog200(167, 498.408325);
                yield return new goog200(168, 500.246368);
                yield return new goog200(169, 512.372498);
                yield return new goog200(170, 509.461456);
                yield return new goog200(171, 504.319885);
                yield return new goog200(172, 504.22052);
                yield return new goog200(173, 514.771912);
                yield return new goog200(174, 511.880707);
                yield return new goog200(175, 511.960205);
                yield return new goog200(176, 510.20163);
                yield return new goog200(177, 509.739624);
                yield return new goog200(178, 507.459473);
                yield return new goog200(179, 508.070496);
                yield return new goog200(180, 500.718323);
                yield return new goog200(181, 504.732208);
                yield return new goog200(182, 502.029785);
                yield return new goog200(183, 502.620941);
                yield return new goog200(184, 512.899109);
                yield return new goog200(185, 514.270142);
                yield return new goog200(186, 513.440552);
                yield return new goog200(187, 512.442078);
                yield return new goog200(188, 509.287567);
                yield return new goog200(189, 507.851898);
                yield return new goog200(190, 513.693909);
                yield return new goog200(191, 512.610962);
                yield return new goog200(192, 519.585571);
                yield return new goog200(193, 525.785278);
                yield return new goog200(194, 528.120117);
                yield return new goog200(195, 526.37146);
                yield return new goog200(196, 523.832947);
                yield return new goog200(197, 523.226929);
                yield return new goog200(198, 525.671021);
                yield return new goog200(199, 525.253723);
                yield return new goog200(200, 531.478271);
            }
        }
    }
}
