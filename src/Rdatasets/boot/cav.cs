// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Position of Muscle Caveolae
    /// </summary>

    public class cav
    {
        public readonly int κ;
        public readonly int x;
        public readonly int y;

        public cav(int κ, int x, int y)
        {
            this.κ = κ;
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<cav> Data
        {
            get
            {
                yield return new cav(1, 498, 475);
                yield return new cav(2, 474, 498);
                yield return new cav(3, 473, 449);
                yield return new cav(4, 450, 459);
                yield return new cav(5, 420, 447);
                yield return new cav(6, 401, 430);
                yield return new cav(7, 384, 433);
                yield return new cav(8, 369, 426);
                yield return new cav(9, 359, 435);
                yield return new cav(10, 334, 483);
                yield return new cav(11, 272, 424);
                yield return new cav(12, 294, 445);
                yield return new cav(13, 274, 493);
                yield return new cav(14, 257, 463);
                yield return new cav(15, 225, 488);
                yield return new cav(16, 165, 498);
                yield return new cav(17, 174, 477);
                yield return new cav(18, 155, 480);
                yield return new cav(19, 137, 445);
                yield return new cav(20, 111, 443);
                yield return new cav(21, 133, 486);
                yield return new cav(22, 60, 462);
                yield return new cav(23, 42, 470);
                yield return new cav(24, 38, 416);
                yield return new cav(25, 98, 414);
                yield return new cav(26, 89, 488);
                yield return new cav(27, 86, 395);
                yield return new cav(28, 77, 366);
                yield return new cav(29, 67, 334);
                yield return new cav(30, 47, 325);
                yield return new cav(31, 100, 341);
                yield return new cav(32, 103, 360);
                yield return new cav(33, 116, 372);
                yield return new cav(34, 124, 347);
                yield return new cav(35, 144, 367);
                yield return new cav(36, 180, 390);
                yield return new cav(37, 188, 393);
                yield return new cav(38, 173, 367);
                yield return new cav(39, 196, 349);
                yield return new cav(40, 148, 334);
                yield return new cav(41, 209, 315);
                yield return new cav(42, 228, 316);
                yield return new cav(43, 240, 366);
                yield return new cav(44, 286, 332);
                yield return new cav(45, 269, 313);
                yield return new cav(46, 305, 387);
                yield return new cav(47, 319, 366);
                yield return new cav(48, 328, 389);
                yield return new cav(49, 335, 401);
                yield return new cav(50, 367, 399);
                yield return new cav(51, 350, 376);
                yield return new cav(52, 359, 366);
                yield return new cav(53, 326, 343);
                yield return new cav(54, 338, 320);
                yield return new cav(55, 367, 320);
                yield return new cav(56, 386, 341);
                yield return new cav(57, 407, 406);
                yield return new cav(58, 450, 401);
                yield return new cav(59, 433, 350);
                yield return new cav(60, 485, 266);
                yield return new cav(61, 442, 295);
                yield return new cav(62, 418, 271);
                yield return new cav(63, 431, 245);
                yield return new cav(64, 460, 214);
                yield return new cav(65, 371, 230);
                yield return new cav(66, 358, 278);
                yield return new cav(67, 358, 299);
                yield return new cav(68, 336, 259);
                yield return new cav(69, 292, 281);
                yield return new cav(70, 273, 292);
                yield return new cav(71, 244, 293);
                yield return new cav(72, 258, 284);
                yield return new cav(73, 233, 299);
                yield return new cav(74, 212, 297);
                yield return new cav(75, 225, 273);
                yield return new cav(76, 213, 259);
                yield return new cav(77, 266, 228);
                yield return new cav(78, 185, 286);
                yield return new cav(79, 136, 222);
                yield return new cav(80, 171, 216);
                yield return new cav(81, 85, 209);
                yield return new cav(82, 57, 218);
                yield return new cav(83, 29, 284);
                yield return new cav(84, 22, 266);
                yield return new cav(85, 9, 237);
                yield return new cav(86, 16, 108);
                yield return new cav(87, 16, 126);
                yield return new cav(88, 25, 146);
                yield return new cav(89, 58, 181);
                yield return new cav(90, 38, 173);
                yield return new cav(91, 76, 158);
                yield return new cav(92, 85, 143);
                yield return new cav(93, 96, 128);
                yield return new cav(94, 60, 107);
                yield return new cav(95, 107, 122);
                yield return new cav(96, 111, 191);
                yield return new cav(97, 146, 188);
                yield return new cav(98, 138, 122);
                yield return new cav(99, 185, 141);
                yield return new cav(100, 198, 180);
                yield return new cav(101, 227, 146);
                yield return new cav(102, 240, 154);
                yield return new cav(103, 280, 170);
                yield return new cav(104, 282, 108);
                yield return new cav(105, 365, 161);
                yield return new cav(106, 394, 116);
                yield return new cav(107, 307, 136);
                yield return new cav(108, 320, 126);
                yield return new cav(109, 399, 199);
                yield return new cav(110, 417, 200);
                yield return new cav(111, 497, 177);
                yield return new cav(112, 490, 18);
                yield return new cav(113, 414, 83);
                yield return new cav(114, 443, 104);
                yield return new cav(115, 380, 12);
                yield return new cav(116, 323, 30);
                yield return new cav(117, 332, 42);
                yield return new cav(118, 328, 66);
                yield return new cav(119, 311, 80);
                yield return new cav(120, 318, 92);
                yield return new cav(121, 303, 81);
                yield return new cav(122, 279, 70);
                yield return new cav(123, 270, 22);
                yield return new cav(124, 242, 11);
                yield return new cav(125, 225, 45);
                yield return new cav(126, 182, 17);
                yield return new cav(127, 166, 66);
                yield return new cav(128, 196, 80);
                yield return new cav(129, 154, 35);
                yield return new cav(130, 111, 36);
                yield return new cav(131, 125, 60);
                yield return new cav(132, 112, 93);
                yield return new cav(133, 81, 53);
                yield return new cav(134, 79, 26);
                yield return new cav(135, 48, 43);
                yield return new cav(136, 34, 20);
                yield return new cav(137, 18, 34);
                yield return new cav(138, 54, 76);
            }
        }
    }
}
