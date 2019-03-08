// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Australian Beer production
    /// </summary>

    public class ausbeer
    {
        public readonly double time;
        public readonly int value;

        public ausbeer(double time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<ausbeer> Data
        {
            get
            {
                yield return new ausbeer(1956, 284);
                yield return new ausbeer(1956.25, 213);
                yield return new ausbeer(1956.5, 227);
                yield return new ausbeer(1956.75, 308);
                yield return new ausbeer(1957, 262);
                yield return new ausbeer(1957.25, 228);
                yield return new ausbeer(1957.5, 236);
                yield return new ausbeer(1957.75, 320);
                yield return new ausbeer(1958, 272);
                yield return new ausbeer(1958.25, 233);
                yield return new ausbeer(1958.5, 237);
                yield return new ausbeer(1958.75, 313);
                yield return new ausbeer(1959, 261);
                yield return new ausbeer(1959.25, 227);
                yield return new ausbeer(1959.5, 250);
                yield return new ausbeer(1959.75, 314);
                yield return new ausbeer(1960, 286);
                yield return new ausbeer(1960.25, 227);
                yield return new ausbeer(1960.5, 260);
                yield return new ausbeer(1960.75, 311);
                yield return new ausbeer(1961, 295);
                yield return new ausbeer(1961.25, 233);
                yield return new ausbeer(1961.5, 257);
                yield return new ausbeer(1961.75, 339);
                yield return new ausbeer(1962, 279);
                yield return new ausbeer(1962.25, 250);
                yield return new ausbeer(1962.5, 270);
                yield return new ausbeer(1962.75, 346);
                yield return new ausbeer(1963, 294);
                yield return new ausbeer(1963.25, 255);
                yield return new ausbeer(1963.5, 278);
                yield return new ausbeer(1963.75, 363);
                yield return new ausbeer(1964, 313);
                yield return new ausbeer(1964.25, 273);
                yield return new ausbeer(1964.5, 300);
                yield return new ausbeer(1964.75, 370);
                yield return new ausbeer(1965, 331);
                yield return new ausbeer(1965.25, 288);
                yield return new ausbeer(1965.5, 306);
                yield return new ausbeer(1965.75, 386);
                yield return new ausbeer(1966, 335);
                yield return new ausbeer(1966.25, 288);
                yield return new ausbeer(1966.5, 308);
                yield return new ausbeer(1966.75, 402);
                yield return new ausbeer(1967, 353);
                yield return new ausbeer(1967.25, 316);
                yield return new ausbeer(1967.5, 325);
                yield return new ausbeer(1967.75, 405);
                yield return new ausbeer(1968, 393);
                yield return new ausbeer(1968.25, 319);
                yield return new ausbeer(1968.5, 327);
                yield return new ausbeer(1968.75, 442);
                yield return new ausbeer(1969, 383);
                yield return new ausbeer(1969.25, 332);
                yield return new ausbeer(1969.5, 361);
                yield return new ausbeer(1969.75, 446);
                yield return new ausbeer(1970, 387);
                yield return new ausbeer(1970.25, 357);
                yield return new ausbeer(1970.5, 374);
                yield return new ausbeer(1970.75, 466);
                yield return new ausbeer(1971, 410);
                yield return new ausbeer(1971.25, 370);
                yield return new ausbeer(1971.5, 379);
                yield return new ausbeer(1971.75, 487);
                yield return new ausbeer(1972, 419);
                yield return new ausbeer(1972.25, 378);
                yield return new ausbeer(1972.5, 393);
                yield return new ausbeer(1972.75, 506);
                yield return new ausbeer(1973, 458);
                yield return new ausbeer(1973.25, 387);
                yield return new ausbeer(1973.5, 427);
                yield return new ausbeer(1973.75, 565);
                yield return new ausbeer(1974, 465);
                yield return new ausbeer(1974.25, 445);
                yield return new ausbeer(1974.5, 450);
                yield return new ausbeer(1974.75, 556);
                yield return new ausbeer(1975, 500);
                yield return new ausbeer(1975.25, 452);
                yield return new ausbeer(1975.5, 435);
                yield return new ausbeer(1975.75, 554);
                yield return new ausbeer(1976, 510);
                yield return new ausbeer(1976.25, 433);
                yield return new ausbeer(1976.5, 453);
                yield return new ausbeer(1976.75, 548);
                yield return new ausbeer(1977, 486);
                yield return new ausbeer(1977.25, 453);
                yield return new ausbeer(1977.5, 457);
                yield return new ausbeer(1977.75, 566);
                yield return new ausbeer(1978, 515);
                yield return new ausbeer(1978.25, 464);
                yield return new ausbeer(1978.5, 431);
                yield return new ausbeer(1978.75, 588);
                yield return new ausbeer(1979, 503);
                yield return new ausbeer(1979.25, 443);
                yield return new ausbeer(1979.5, 448);
                yield return new ausbeer(1979.75, 555);
                yield return new ausbeer(1980, 513);
                yield return new ausbeer(1980.25, 427);
                yield return new ausbeer(1980.5, 473);
                yield return new ausbeer(1980.75, 526);
                yield return new ausbeer(1981, 548);
                yield return new ausbeer(1981.25, 440);
                yield return new ausbeer(1981.5, 469);
                yield return new ausbeer(1981.75, 575);
                yield return new ausbeer(1982, 493);
                yield return new ausbeer(1982.25, 433);
                yield return new ausbeer(1982.5, 480);
                yield return new ausbeer(1982.75, 576);
                yield return new ausbeer(1983, 475);
                yield return new ausbeer(1983.25, 405);
                yield return new ausbeer(1983.5, 435);
                yield return new ausbeer(1983.75, 535);
                yield return new ausbeer(1984, 453);
                yield return new ausbeer(1984.25, 430);
                yield return new ausbeer(1984.5, 417);
                yield return new ausbeer(1984.75, 552);
                yield return new ausbeer(1985, 464);
                yield return new ausbeer(1985.25, 417);
                yield return new ausbeer(1985.5, 423);
                yield return new ausbeer(1985.75, 554);
                yield return new ausbeer(1986, 459);
                yield return new ausbeer(1986.25, 428);
                yield return new ausbeer(1986.5, 429);
                yield return new ausbeer(1986.75, 534);
                yield return new ausbeer(1987, 481);
                yield return new ausbeer(1987.25, 416);
                yield return new ausbeer(1987.5, 440);
                yield return new ausbeer(1987.75, 538);
                yield return new ausbeer(1988, 474);
                yield return new ausbeer(1988.25, 440);
                yield return new ausbeer(1988.5, 447);
                yield return new ausbeer(1988.75, 598);
                yield return new ausbeer(1989, 467);
                yield return new ausbeer(1989.25, 439);
                yield return new ausbeer(1989.5, 446);
                yield return new ausbeer(1989.75, 567);
                yield return new ausbeer(1990, 485);
                yield return new ausbeer(1990.25, 441);
                yield return new ausbeer(1990.5, 429);
                yield return new ausbeer(1990.75, 599);
                yield return new ausbeer(1991, 464);
                yield return new ausbeer(1991.25, 424);
                yield return new ausbeer(1991.5, 436);
                yield return new ausbeer(1991.75, 574);
                yield return new ausbeer(1992, 443);
                yield return new ausbeer(1992.25, 410);
                yield return new ausbeer(1992.5, 420);
                yield return new ausbeer(1992.75, 532);
                yield return new ausbeer(1993, 433);
                yield return new ausbeer(1993.25, 421);
                yield return new ausbeer(1993.5, 410);
                yield return new ausbeer(1993.75, 512);
                yield return new ausbeer(1994, 449);
                yield return new ausbeer(1994.25, 381);
                yield return new ausbeer(1994.5, 423);
                yield return new ausbeer(1994.75, 531);
                yield return new ausbeer(1995, 426);
                yield return new ausbeer(1995.25, 408);
                yield return new ausbeer(1995.5, 416);
                yield return new ausbeer(1995.75, 520);
                yield return new ausbeer(1996, 409);
                yield return new ausbeer(1996.25, 398);
                yield return new ausbeer(1996.5, 398);
                yield return new ausbeer(1996.75, 507);
                yield return new ausbeer(1997, 432);
                yield return new ausbeer(1997.25, 398);
                yield return new ausbeer(1997.5, 406);
                yield return new ausbeer(1997.75, 526);
                yield return new ausbeer(1998, 428);
                yield return new ausbeer(1998.25, 397);
                yield return new ausbeer(1998.5, 403);
                yield return new ausbeer(1998.75, 517);
                yield return new ausbeer(1999, 435);
                yield return new ausbeer(1999.25, 383);
                yield return new ausbeer(1999.5, 424);
                yield return new ausbeer(1999.75, 521);
                yield return new ausbeer(2000, 421);
                yield return new ausbeer(2000.25, 402);
                yield return new ausbeer(2000.5, 414);
                yield return new ausbeer(2000.75, 500);
                yield return new ausbeer(2001, 451);
                yield return new ausbeer(2001.25, 380);
                yield return new ausbeer(2001.5, 416);
                yield return new ausbeer(2001.75, 492);
                yield return new ausbeer(2002, 428);
                yield return new ausbeer(2002.25, 408);
                yield return new ausbeer(2002.5, 406);
                yield return new ausbeer(2002.75, 506);
                yield return new ausbeer(2003, 435);
                yield return new ausbeer(2003.25, 380);
                yield return new ausbeer(2003.5, 421);
                yield return new ausbeer(2003.75, 490);
                yield return new ausbeer(2004, 435);
                yield return new ausbeer(2004.25, 390);
                yield return new ausbeer(2004.5, 412);
                yield return new ausbeer(2004.75, 454);
                yield return new ausbeer(2005, 416);
                yield return new ausbeer(2005.25, 403);
                yield return new ausbeer(2005.5, 408);
                yield return new ausbeer(2005.75, 482);
                yield return new ausbeer(2006, 438);
                yield return new ausbeer(2006.25, 386);
                yield return new ausbeer(2006.5, 405);
                yield return new ausbeer(2006.75, 491);
                yield return new ausbeer(2007, 427);
                yield return new ausbeer(2007.25, 383);
                yield return new ausbeer(2007.5, 394);
                yield return new ausbeer(2007.75, 473);
                yield return new ausbeer(2008, 420);
                yield return new ausbeer(2008.25, 390);
                yield return new ausbeer(2008.5, 410);
                yield return new ausbeer(2008.75, 488);
                yield return new ausbeer(2009, 415);
                yield return new ausbeer(2009.25, 398);
                yield return new ausbeer(2009.5, 419);
                yield return new ausbeer(2009.75, 488);
                yield return new ausbeer(2010, 414);
                yield return new ausbeer(2010.25, 374);
            }
        }
    }
}
