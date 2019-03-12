// ReSharper disable All

namespace Rdatasets.lme4
{
    using System.Collections.Generic;

    /// <summary>
    /// Reaction times in a sleep deprivation study
    /// </summary>

    public class sleepstudy
    {
        public readonly int κ;
        public readonly double Reaction;
        public readonly int Days;
        public readonly int Subject;

        public sleepstudy(int κ, double Reaction, int Days, int Subject)
        {
            this.κ = κ;
            this.Reaction = Reaction;
            this.Days = Days;
            this.Subject = Subject;
        }

        public static IEnumerable<sleepstudy> Data
        {
            get
            {
                yield return new sleepstudy(1, 249.56, 0, 308);
                yield return new sleepstudy(2, 258.7047, 1, 308);
                yield return new sleepstudy(3, 250.8006, 2, 308);
                yield return new sleepstudy(4, 321.4398, 3, 308);
                yield return new sleepstudy(5, 356.8519, 4, 308);
                yield return new sleepstudy(6, 414.6901, 5, 308);
                yield return new sleepstudy(7, 382.2038, 6, 308);
                yield return new sleepstudy(8, 290.1486, 7, 308);
                yield return new sleepstudy(9, 430.5853, 8, 308);
                yield return new sleepstudy(10, 466.3535, 9, 308);
                yield return new sleepstudy(11, 222.7339, 0, 309);
                yield return new sleepstudy(12, 205.2658, 1, 309);
                yield return new sleepstudy(13, 202.9778, 2, 309);
                yield return new sleepstudy(14, 204.707, 3, 309);
                yield return new sleepstudy(15, 207.7161, 4, 309);
                yield return new sleepstudy(16, 215.9618, 5, 309);
                yield return new sleepstudy(17, 213.6303, 6, 309);
                yield return new sleepstudy(18, 217.7272, 7, 309);
                yield return new sleepstudy(19, 224.2957, 8, 309);
                yield return new sleepstudy(20, 237.3142, 9, 309);
                yield return new sleepstudy(21, 199.0539, 0, 310);
                yield return new sleepstudy(22, 194.3322, 1, 310);
                yield return new sleepstudy(23, 234.32, 2, 310);
                yield return new sleepstudy(24, 232.8416, 3, 310);
                yield return new sleepstudy(25, 229.3074, 4, 310);
                yield return new sleepstudy(26, 220.4579, 5, 310);
                yield return new sleepstudy(27, 235.4208, 6, 310);
                yield return new sleepstudy(28, 255.7511, 7, 310);
                yield return new sleepstudy(29, 261.0125, 8, 310);
                yield return new sleepstudy(30, 247.5153, 9, 310);
                yield return new sleepstudy(31, 321.5426, 0, 330);
                yield return new sleepstudy(32, 300.4002, 1, 330);
                yield return new sleepstudy(33, 283.8565, 2, 330);
                yield return new sleepstudy(34, 285.133, 3, 330);
                yield return new sleepstudy(35, 285.7973, 4, 330);
                yield return new sleepstudy(36, 297.5855, 5, 330);
                yield return new sleepstudy(37, 280.2396, 6, 330);
                yield return new sleepstudy(38, 318.2613, 7, 330);
                yield return new sleepstudy(39, 305.3495, 8, 330);
                yield return new sleepstudy(40, 354.0487, 9, 330);
                yield return new sleepstudy(41, 287.6079, 0, 331);
                yield return new sleepstudy(42, 285, 1, 331);
                yield return new sleepstudy(43, 301.8206, 2, 331);
                yield return new sleepstudy(44, 320.1153, 3, 331);
                yield return new sleepstudy(45, 316.2773, 4, 331);
                yield return new sleepstudy(46, 293.3187, 5, 331);
                yield return new sleepstudy(47, 290.075, 6, 331);
                yield return new sleepstudy(48, 334.8177, 7, 331);
                yield return new sleepstudy(49, 293.7469, 8, 331);
                yield return new sleepstudy(50, 371.5811, 9, 331);
                yield return new sleepstudy(51, 234.8606, 0, 332);
                yield return new sleepstudy(52, 242.8118, 1, 332);
                yield return new sleepstudy(53, 272.9613, 2, 332);
                yield return new sleepstudy(54, 309.7688, 3, 332);
                yield return new sleepstudy(55, 317.4629, 4, 332);
                yield return new sleepstudy(56, 309.9976, 5, 332);
                yield return new sleepstudy(57, 454.1619, 6, 332);
                yield return new sleepstudy(58, 346.8311, 7, 332);
                yield return new sleepstudy(59, 330.3003, 8, 332);
                yield return new sleepstudy(60, 253.8644, 9, 332);
                yield return new sleepstudy(61, 283.8424, 0, 333);
                yield return new sleepstudy(62, 289.555, 1, 333);
                yield return new sleepstudy(63, 276.7693, 2, 333);
                yield return new sleepstudy(64, 299.8097, 3, 333);
                yield return new sleepstudy(65, 297.171, 4, 333);
                yield return new sleepstudy(66, 338.1665, 5, 333);
                yield return new sleepstudy(67, 332.0265, 6, 333);
                yield return new sleepstudy(68, 348.8399, 7, 333);
                yield return new sleepstudy(69, 333.36, 8, 333);
                yield return new sleepstudy(70, 362.0428, 9, 333);
                yield return new sleepstudy(71, 265.4731, 0, 334);
                yield return new sleepstudy(72, 276.2012, 1, 334);
                yield return new sleepstudy(73, 243.3647, 2, 334);
                yield return new sleepstudy(74, 254.6723, 3, 334);
                yield return new sleepstudy(75, 279.0244, 4, 334);
                yield return new sleepstudy(76, 284.1912, 5, 334);
                yield return new sleepstudy(77, 305.5248, 6, 334);
                yield return new sleepstudy(78, 331.5229, 7, 334);
                yield return new sleepstudy(79, 335.7469, 8, 334);
                yield return new sleepstudy(80, 377.299, 9, 334);
                yield return new sleepstudy(81, 241.6083, 0, 335);
                yield return new sleepstudy(82, 273.9472, 1, 335);
                yield return new sleepstudy(83, 254.4907, 2, 335);
                yield return new sleepstudy(84, 270.8021, 3, 335);
                yield return new sleepstudy(85, 251.4519, 4, 335);
                yield return new sleepstudy(86, 254.6362, 5, 335);
                yield return new sleepstudy(87, 245.4523, 6, 335);
                yield return new sleepstudy(88, 235.311, 7, 335);
                yield return new sleepstudy(89, 235.7541, 8, 335);
                yield return new sleepstudy(90, 237.2466, 9, 335);
                yield return new sleepstudy(91, 312.3666, 0, 337);
                yield return new sleepstudy(92, 313.8058, 1, 337);
                yield return new sleepstudy(93, 291.6112, 2, 337);
                yield return new sleepstudy(94, 346.1222, 3, 337);
                yield return new sleepstudy(95, 365.7324, 4, 337);
                yield return new sleepstudy(96, 391.8385, 5, 337);
                yield return new sleepstudy(97, 404.2601, 6, 337);
                yield return new sleepstudy(98, 416.6923, 7, 337);
                yield return new sleepstudy(99, 455.8643, 8, 337);
                yield return new sleepstudy(100, 458.9167, 9, 337);
                yield return new sleepstudy(101, 236.1032, 0, 349);
                yield return new sleepstudy(102, 230.3167, 1, 349);
                yield return new sleepstudy(103, 238.9256, 2, 349);
                yield return new sleepstudy(104, 254.922, 3, 349);
                yield return new sleepstudy(105, 250.7103, 4, 349);
                yield return new sleepstudy(106, 269.7744, 5, 349);
                yield return new sleepstudy(107, 281.5648, 6, 349);
                yield return new sleepstudy(108, 308.102, 7, 349);
                yield return new sleepstudy(109, 336.2806, 8, 349);
                yield return new sleepstudy(110, 351.6451, 9, 349);
                yield return new sleepstudy(111, 256.2968, 0, 350);
                yield return new sleepstudy(112, 243.4543, 1, 350);
                yield return new sleepstudy(113, 256.2046, 2, 350);
                yield return new sleepstudy(114, 255.5271, 3, 350);
                yield return new sleepstudy(115, 268.9165, 4, 350);
                yield return new sleepstudy(116, 329.7247, 5, 350);
                yield return new sleepstudy(117, 379.4445, 6, 350);
                yield return new sleepstudy(118, 362.9184, 7, 350);
                yield return new sleepstudy(119, 394.4872, 8, 350);
                yield return new sleepstudy(120, 389.0527, 9, 350);
                yield return new sleepstudy(121, 250.5265, 0, 351);
                yield return new sleepstudy(122, 300.0576, 1, 351);
                yield return new sleepstudy(123, 269.8939, 2, 351);
                yield return new sleepstudy(124, 280.5891, 3, 351);
                yield return new sleepstudy(125, 271.8274, 4, 351);
                yield return new sleepstudy(126, 304.6336, 5, 351);
                yield return new sleepstudy(127, 287.7466, 6, 351);
                yield return new sleepstudy(128, 266.5955, 7, 351);
                yield return new sleepstudy(129, 321.5418, 8, 351);
                yield return new sleepstudy(130, 347.5655, 9, 351);
                yield return new sleepstudy(131, 221.6771, 0, 352);
                yield return new sleepstudy(132, 298.1939, 1, 352);
                yield return new sleepstudy(133, 326.8785, 2, 352);
                yield return new sleepstudy(134, 346.8555, 3, 352);
                yield return new sleepstudy(135, 348.7402, 4, 352);
                yield return new sleepstudy(136, 352.8287, 5, 352);
                yield return new sleepstudy(137, 354.4266, 6, 352);
                yield return new sleepstudy(138, 360.4326, 7, 352);
                yield return new sleepstudy(139, 375.6406, 8, 352);
                yield return new sleepstudy(140, 388.5417, 9, 352);
                yield return new sleepstudy(141, 271.9235, 0, 369);
                yield return new sleepstudy(142, 268.4369, 1, 369);
                yield return new sleepstudy(143, 257.2424, 2, 369);
                yield return new sleepstudy(144, 277.6566, 3, 369);
                yield return new sleepstudy(145, 314.8222, 4, 369);
                yield return new sleepstudy(146, 317.2135, 5, 369);
                yield return new sleepstudy(147, 298.1353, 6, 369);
                yield return new sleepstudy(148, 348.1229, 7, 369);
                yield return new sleepstudy(149, 340.28, 8, 369);
                yield return new sleepstudy(150, 366.5131, 9, 369);
                yield return new sleepstudy(151, 225.264, 0, 370);
                yield return new sleepstudy(152, 234.5235, 1, 370);
                yield return new sleepstudy(153, 238.9008, 2, 370);
                yield return new sleepstudy(154, 240.473, 3, 370);
                yield return new sleepstudy(155, 267.5373, 4, 370);
                yield return new sleepstudy(156, 344.1937, 5, 370);
                yield return new sleepstudy(157, 281.1481, 6, 370);
                yield return new sleepstudy(158, 347.5855, 7, 370);
                yield return new sleepstudy(159, 365.163, 8, 370);
                yield return new sleepstudy(160, 372.2288, 9, 370);
                yield return new sleepstudy(161, 269.8804, 0, 371);
                yield return new sleepstudy(162, 272.4428, 1, 371);
                yield return new sleepstudy(163, 277.8989, 2, 371);
                yield return new sleepstudy(164, 281.7895, 3, 371);
                yield return new sleepstudy(165, 279.1705, 4, 371);
                yield return new sleepstudy(166, 284.512, 5, 371);
                yield return new sleepstudy(167, 259.2658, 6, 371);
                yield return new sleepstudy(168, 304.6306, 7, 371);
                yield return new sleepstudy(169, 350.7807, 8, 371);
                yield return new sleepstudy(170, 369.4692, 9, 371);
                yield return new sleepstudy(171, 269.4117, 0, 372);
                yield return new sleepstudy(172, 273.474, 1, 372);
                yield return new sleepstudy(173, 297.5968, 2, 372);
                yield return new sleepstudy(174, 310.6316, 3, 372);
                yield return new sleepstudy(175, 287.1726, 4, 372);
                yield return new sleepstudy(176, 329.6076, 5, 372);
                yield return new sleepstudy(177, 334.4818, 6, 372);
                yield return new sleepstudy(178, 343.2199, 7, 372);
                yield return new sleepstudy(179, 369.1417, 8, 372);
                yield return new sleepstudy(180, 364.1236, 9, 372);
            }
        }
    }
}
