// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Tip Joke
    /// </summary>

    public class TipJoke
    {
        public readonly int κ;
        public readonly string Card;
        public readonly int Tip;
        public readonly int Ad;
        public readonly int Joke;
        public readonly int None;

        public TipJoke(int κ, string Card, int Tip, int Ad, int Joke, int None)
        {
            this.κ = κ;
            this.Card = Card;
            this.Tip = Tip;
            this.Ad = Ad;
            this.Joke = Joke;
            this.None = None;
        }

        public static IEnumerable<TipJoke> Data
        {
            get
            {
                yield return new TipJoke(1, "None", 1, 0, 0, 1);
                yield return new TipJoke(2, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(3, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(4, "None", 0, 0, 0, 1);
                yield return new TipJoke(5, "None", 1, 0, 0, 1);
                yield return new TipJoke(6, "None", 0, 0, 0, 1);
                yield return new TipJoke(7, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(8, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(9, "None", 0, 0, 0, 1);
                yield return new TipJoke(10, "None", 0, 0, 0, 1);
                yield return new TipJoke(11, "None", 1, 0, 0, 1);
                yield return new TipJoke(12, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(13, "None", 0, 0, 0, 1);
                yield return new TipJoke(14, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(15, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(16, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(17, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(18, "None", 0, 0, 0, 1);
                yield return new TipJoke(19, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(20, "None", 0, 0, 0, 1);
                yield return new TipJoke(21, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(22, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(23, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(24, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(25, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(26, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(27, "None", 1, 0, 0, 1);
                yield return new TipJoke(28, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(29, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(30, "None", 1, 0, 0, 1);
                yield return new TipJoke(31, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(32, "None", 1, 0, 0, 1);
                yield return new TipJoke(33, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(34, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(35, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(36, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(37, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(38, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(39, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(40, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(41, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(42, "None", 0, 0, 0, 1);
                yield return new TipJoke(43, "None", 0, 0, 0, 1);
                yield return new TipJoke(44, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(45, "None", 0, 0, 0, 1);
                yield return new TipJoke(46, "None", 0, 0, 0, 1);
                yield return new TipJoke(47, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(48, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(49, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(50, "None", 1, 0, 0, 1);
                yield return new TipJoke(51, "None", 0, 0, 0, 1);
                yield return new TipJoke(52, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(53, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(54, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(55, "None", 1, 0, 0, 1);
                yield return new TipJoke(56, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(57, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(58, "None", 0, 0, 0, 1);
                yield return new TipJoke(59, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(60, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(61, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(62, "None", 1, 0, 0, 1);
                yield return new TipJoke(63, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(64, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(65, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(66, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(67, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(68, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(69, "None", 0, 0, 0, 1);
                yield return new TipJoke(70, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(71, "None", 1, 0, 0, 1);
                yield return new TipJoke(72, "None", 0, 0, 0, 1);
                yield return new TipJoke(73, "None", 0, 0, 0, 1);
                yield return new TipJoke(74, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(75, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(76, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(77, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(78, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(79, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(80, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(81, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(82, "None", 0, 0, 0, 1);
                yield return new TipJoke(83, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(84, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(85, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(86, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(87, "None", 1, 0, 0, 1);
                yield return new TipJoke(88, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(89, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(90, "None", 0, 0, 0, 1);
                yield return new TipJoke(91, "None", 0, 0, 0, 1);
                yield return new TipJoke(92, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(93, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(94, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(95, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(96, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(97, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(98, "None", 0, 0, 0, 1);
                yield return new TipJoke(99, "None", 0, 0, 0, 1);
                yield return new TipJoke(100, "None", 1, 0, 0, 1);
                yield return new TipJoke(101, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(102, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(103, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(104, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(105, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(106, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(107, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(108, "None", 0, 0, 0, 1);
                yield return new TipJoke(109, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(110, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(111, "None", 0, 0, 0, 1);
                yield return new TipJoke(112, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(113, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(114, "None", 0, 0, 0, 1);
                yield return new TipJoke(115, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(116, "None", 0, 0, 0, 1);
                yield return new TipJoke(117, "None", 0, 0, 0, 1);
                yield return new TipJoke(118, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(119, "None", 1, 0, 0, 1);
                yield return new TipJoke(120, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(121, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(122, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(123, "None", 0, 0, 0, 1);
                yield return new TipJoke(124, "None", 0, 0, 0, 1);
                yield return new TipJoke(125, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(126, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(127, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(128, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(129, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(130, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(131, "None", 0, 0, 0, 1);
                yield return new TipJoke(132, "None", 0, 0, 0, 1);
                yield return new TipJoke(133, "None", 0, 0, 0, 1);
                yield return new TipJoke(134, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(135, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(136, "None", 0, 0, 0, 1);
                yield return new TipJoke(137, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(138, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(139, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(140, "None", 0, 0, 0, 1);
                yield return new TipJoke(141, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(142, "None", 0, 0, 0, 1);
                yield return new TipJoke(143, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(144, "None", 1, 0, 0, 1);
                yield return new TipJoke(145, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(146, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(147, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(148, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(149, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(150, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(151, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(152, "None", 0, 0, 0, 1);
                yield return new TipJoke(153, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(154, "None", 0, 0, 0, 1);
                yield return new TipJoke(155, "None", 0, 0, 0, 1);
                yield return new TipJoke(156, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(157, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(158, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(159, "None", 0, 0, 0, 1);
                yield return new TipJoke(160, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(161, "None", 1, 0, 0, 1);
                yield return new TipJoke(162, "Ad", 1, 1, 0, 0);
                yield return new TipJoke(163, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(164, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(165, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(166, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(167, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(168, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(169, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(170, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(171, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(172, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(173, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(174, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(175, "None", 0, 0, 0, 1);
                yield return new TipJoke(176, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(177, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(178, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(179, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(180, "None", 0, 0, 0, 1);
                yield return new TipJoke(181, "None", 0, 0, 0, 1);
                yield return new TipJoke(182, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(183, "None", 0, 0, 0, 1);
                yield return new TipJoke(184, "None", 0, 0, 0, 1);
                yield return new TipJoke(185, "None", 0, 0, 0, 1);
                yield return new TipJoke(186, "None", 0, 0, 0, 1);
                yield return new TipJoke(187, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(188, "None", 1, 0, 0, 1);
                yield return new TipJoke(189, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(190, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(191, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(192, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(193, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(194, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(195, "None", 0, 0, 0, 1);
                yield return new TipJoke(196, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(197, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(198, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(199, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(200, "None", 0, 0, 0, 1);
                yield return new TipJoke(201, "Joke", 1, 0, 1, 0);
                yield return new TipJoke(202, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(203, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(204, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(205, "None", 0, 0, 0, 1);
                yield return new TipJoke(206, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(207, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(208, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(209, "Ad", 0, 1, 0, 0);
                yield return new TipJoke(210, "Joke", 0, 0, 1, 0);
                yield return new TipJoke(211, "None", 0, 0, 0, 1);
            }
        }
    }
}
