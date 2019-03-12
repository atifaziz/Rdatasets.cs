// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Australian Beer production
    /// </summary>

    public class ausbeer
    {
        public readonly int κ;
        public readonly double time;
        public readonly int value;

        public ausbeer(int κ, double time, int value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<ausbeer> Data
        {
            get
            {
                yield return new ausbeer(1, 1956, 284);
                yield return new ausbeer(2, 1956.25, 213);
                yield return new ausbeer(3, 1956.5, 227);
                yield return new ausbeer(4, 1956.75, 308);
                yield return new ausbeer(5, 1957, 262);
                yield return new ausbeer(6, 1957.25, 228);
                yield return new ausbeer(7, 1957.5, 236);
                yield return new ausbeer(8, 1957.75, 320);
                yield return new ausbeer(9, 1958, 272);
                yield return new ausbeer(10, 1958.25, 233);
                yield return new ausbeer(11, 1958.5, 237);
                yield return new ausbeer(12, 1958.75, 313);
                yield return new ausbeer(13, 1959, 261);
                yield return new ausbeer(14, 1959.25, 227);
                yield return new ausbeer(15, 1959.5, 250);
                yield return new ausbeer(16, 1959.75, 314);
                yield return new ausbeer(17, 1960, 286);
                yield return new ausbeer(18, 1960.25, 227);
                yield return new ausbeer(19, 1960.5, 260);
                yield return new ausbeer(20, 1960.75, 311);
                yield return new ausbeer(21, 1961, 295);
                yield return new ausbeer(22, 1961.25, 233);
                yield return new ausbeer(23, 1961.5, 257);
                yield return new ausbeer(24, 1961.75, 339);
                yield return new ausbeer(25, 1962, 279);
                yield return new ausbeer(26, 1962.25, 250);
                yield return new ausbeer(27, 1962.5, 270);
                yield return new ausbeer(28, 1962.75, 346);
                yield return new ausbeer(29, 1963, 294);
                yield return new ausbeer(30, 1963.25, 255);
                yield return new ausbeer(31, 1963.5, 278);
                yield return new ausbeer(32, 1963.75, 363);
                yield return new ausbeer(33, 1964, 313);
                yield return new ausbeer(34, 1964.25, 273);
                yield return new ausbeer(35, 1964.5, 300);
                yield return new ausbeer(36, 1964.75, 370);
                yield return new ausbeer(37, 1965, 331);
                yield return new ausbeer(38, 1965.25, 288);
                yield return new ausbeer(39, 1965.5, 306);
                yield return new ausbeer(40, 1965.75, 386);
                yield return new ausbeer(41, 1966, 335);
                yield return new ausbeer(42, 1966.25, 288);
                yield return new ausbeer(43, 1966.5, 308);
                yield return new ausbeer(44, 1966.75, 402);
                yield return new ausbeer(45, 1967, 353);
                yield return new ausbeer(46, 1967.25, 316);
                yield return new ausbeer(47, 1967.5, 325);
                yield return new ausbeer(48, 1967.75, 405);
                yield return new ausbeer(49, 1968, 393);
                yield return new ausbeer(50, 1968.25, 319);
                yield return new ausbeer(51, 1968.5, 327);
                yield return new ausbeer(52, 1968.75, 442);
                yield return new ausbeer(53, 1969, 383);
                yield return new ausbeer(54, 1969.25, 332);
                yield return new ausbeer(55, 1969.5, 361);
                yield return new ausbeer(56, 1969.75, 446);
                yield return new ausbeer(57, 1970, 387);
                yield return new ausbeer(58, 1970.25, 357);
                yield return new ausbeer(59, 1970.5, 374);
                yield return new ausbeer(60, 1970.75, 466);
                yield return new ausbeer(61, 1971, 410);
                yield return new ausbeer(62, 1971.25, 370);
                yield return new ausbeer(63, 1971.5, 379);
                yield return new ausbeer(64, 1971.75, 487);
                yield return new ausbeer(65, 1972, 419);
                yield return new ausbeer(66, 1972.25, 378);
                yield return new ausbeer(67, 1972.5, 393);
                yield return new ausbeer(68, 1972.75, 506);
                yield return new ausbeer(69, 1973, 458);
                yield return new ausbeer(70, 1973.25, 387);
                yield return new ausbeer(71, 1973.5, 427);
                yield return new ausbeer(72, 1973.75, 565);
                yield return new ausbeer(73, 1974, 465);
                yield return new ausbeer(74, 1974.25, 445);
                yield return new ausbeer(75, 1974.5, 450);
                yield return new ausbeer(76, 1974.75, 556);
                yield return new ausbeer(77, 1975, 500);
                yield return new ausbeer(78, 1975.25, 452);
                yield return new ausbeer(79, 1975.5, 435);
                yield return new ausbeer(80, 1975.75, 554);
                yield return new ausbeer(81, 1976, 510);
                yield return new ausbeer(82, 1976.25, 433);
                yield return new ausbeer(83, 1976.5, 453);
                yield return new ausbeer(84, 1976.75, 548);
                yield return new ausbeer(85, 1977, 486);
                yield return new ausbeer(86, 1977.25, 453);
                yield return new ausbeer(87, 1977.5, 457);
                yield return new ausbeer(88, 1977.75, 566);
                yield return new ausbeer(89, 1978, 515);
                yield return new ausbeer(90, 1978.25, 464);
                yield return new ausbeer(91, 1978.5, 431);
                yield return new ausbeer(92, 1978.75, 588);
                yield return new ausbeer(93, 1979, 503);
                yield return new ausbeer(94, 1979.25, 443);
                yield return new ausbeer(95, 1979.5, 448);
                yield return new ausbeer(96, 1979.75, 555);
                yield return new ausbeer(97, 1980, 513);
                yield return new ausbeer(98, 1980.25, 427);
                yield return new ausbeer(99, 1980.5, 473);
                yield return new ausbeer(100, 1980.75, 526);
                yield return new ausbeer(101, 1981, 548);
                yield return new ausbeer(102, 1981.25, 440);
                yield return new ausbeer(103, 1981.5, 469);
                yield return new ausbeer(104, 1981.75, 575);
                yield return new ausbeer(105, 1982, 493);
                yield return new ausbeer(106, 1982.25, 433);
                yield return new ausbeer(107, 1982.5, 480);
                yield return new ausbeer(108, 1982.75, 576);
                yield return new ausbeer(109, 1983, 475);
                yield return new ausbeer(110, 1983.25, 405);
                yield return new ausbeer(111, 1983.5, 435);
                yield return new ausbeer(112, 1983.75, 535);
                yield return new ausbeer(113, 1984, 453);
                yield return new ausbeer(114, 1984.25, 430);
                yield return new ausbeer(115, 1984.5, 417);
                yield return new ausbeer(116, 1984.75, 552);
                yield return new ausbeer(117, 1985, 464);
                yield return new ausbeer(118, 1985.25, 417);
                yield return new ausbeer(119, 1985.5, 423);
                yield return new ausbeer(120, 1985.75, 554);
                yield return new ausbeer(121, 1986, 459);
                yield return new ausbeer(122, 1986.25, 428);
                yield return new ausbeer(123, 1986.5, 429);
                yield return new ausbeer(124, 1986.75, 534);
                yield return new ausbeer(125, 1987, 481);
                yield return new ausbeer(126, 1987.25, 416);
                yield return new ausbeer(127, 1987.5, 440);
                yield return new ausbeer(128, 1987.75, 538);
                yield return new ausbeer(129, 1988, 474);
                yield return new ausbeer(130, 1988.25, 440);
                yield return new ausbeer(131, 1988.5, 447);
                yield return new ausbeer(132, 1988.75, 598);
                yield return new ausbeer(133, 1989, 467);
                yield return new ausbeer(134, 1989.25, 439);
                yield return new ausbeer(135, 1989.5, 446);
                yield return new ausbeer(136, 1989.75, 567);
                yield return new ausbeer(137, 1990, 485);
                yield return new ausbeer(138, 1990.25, 441);
                yield return new ausbeer(139, 1990.5, 429);
                yield return new ausbeer(140, 1990.75, 599);
                yield return new ausbeer(141, 1991, 464);
                yield return new ausbeer(142, 1991.25, 424);
                yield return new ausbeer(143, 1991.5, 436);
                yield return new ausbeer(144, 1991.75, 574);
                yield return new ausbeer(145, 1992, 443);
                yield return new ausbeer(146, 1992.25, 410);
                yield return new ausbeer(147, 1992.5, 420);
                yield return new ausbeer(148, 1992.75, 532);
                yield return new ausbeer(149, 1993, 433);
                yield return new ausbeer(150, 1993.25, 421);
                yield return new ausbeer(151, 1993.5, 410);
                yield return new ausbeer(152, 1993.75, 512);
                yield return new ausbeer(153, 1994, 449);
                yield return new ausbeer(154, 1994.25, 381);
                yield return new ausbeer(155, 1994.5, 423);
                yield return new ausbeer(156, 1994.75, 531);
                yield return new ausbeer(157, 1995, 426);
                yield return new ausbeer(158, 1995.25, 408);
                yield return new ausbeer(159, 1995.5, 416);
                yield return new ausbeer(160, 1995.75, 520);
                yield return new ausbeer(161, 1996, 409);
                yield return new ausbeer(162, 1996.25, 398);
                yield return new ausbeer(163, 1996.5, 398);
                yield return new ausbeer(164, 1996.75, 507);
                yield return new ausbeer(165, 1997, 432);
                yield return new ausbeer(166, 1997.25, 398);
                yield return new ausbeer(167, 1997.5, 406);
                yield return new ausbeer(168, 1997.75, 526);
                yield return new ausbeer(169, 1998, 428);
                yield return new ausbeer(170, 1998.25, 397);
                yield return new ausbeer(171, 1998.5, 403);
                yield return new ausbeer(172, 1998.75, 517);
                yield return new ausbeer(173, 1999, 435);
                yield return new ausbeer(174, 1999.25, 383);
                yield return new ausbeer(175, 1999.5, 424);
                yield return new ausbeer(176, 1999.75, 521);
                yield return new ausbeer(177, 2000, 421);
                yield return new ausbeer(178, 2000.25, 402);
                yield return new ausbeer(179, 2000.5, 414);
                yield return new ausbeer(180, 2000.75, 500);
                yield return new ausbeer(181, 2001, 451);
                yield return new ausbeer(182, 2001.25, 380);
                yield return new ausbeer(183, 2001.5, 416);
                yield return new ausbeer(184, 2001.75, 492);
                yield return new ausbeer(185, 2002, 428);
                yield return new ausbeer(186, 2002.25, 408);
                yield return new ausbeer(187, 2002.5, 406);
                yield return new ausbeer(188, 2002.75, 506);
                yield return new ausbeer(189, 2003, 435);
                yield return new ausbeer(190, 2003.25, 380);
                yield return new ausbeer(191, 2003.5, 421);
                yield return new ausbeer(192, 2003.75, 490);
                yield return new ausbeer(193, 2004, 435);
                yield return new ausbeer(194, 2004.25, 390);
                yield return new ausbeer(195, 2004.5, 412);
                yield return new ausbeer(196, 2004.75, 454);
                yield return new ausbeer(197, 2005, 416);
                yield return new ausbeer(198, 2005.25, 403);
                yield return new ausbeer(199, 2005.5, 408);
                yield return new ausbeer(200, 2005.75, 482);
                yield return new ausbeer(201, 2006, 438);
                yield return new ausbeer(202, 2006.25, 386);
                yield return new ausbeer(203, 2006.5, 405);
                yield return new ausbeer(204, 2006.75, 491);
                yield return new ausbeer(205, 2007, 427);
                yield return new ausbeer(206, 2007.25, 383);
                yield return new ausbeer(207, 2007.5, 394);
                yield return new ausbeer(208, 2007.75, 473);
                yield return new ausbeer(209, 2008, 420);
                yield return new ausbeer(210, 2008.25, 390);
                yield return new ausbeer(211, 2008.5, 410);
                yield return new ausbeer(212, 2008.75, 488);
                yield return new ausbeer(213, 2009, 415);
                yield return new ausbeer(214, 2009.25, 398);
                yield return new ausbeer(215, 2009.5, 419);
                yield return new ausbeer(216, 2009.75, 488);
                yield return new ausbeer(217, 2010, 414);
                yield return new ausbeer(218, 2010.25, 374);
            }
        }
    }
}
