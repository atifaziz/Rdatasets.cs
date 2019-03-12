// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Diabetes in Pima Indian Women
    /// </summary>

    public class Pima_tr
    {
        public readonly int κ;
        public readonly int npreg;
        public readonly int glu;
        public readonly int bp;
        public readonly int skin;
        public readonly double bmi;
        public readonly double ped;
        public readonly int age;
        public readonly string type;

        public Pima_tr(int κ, int npreg, int glu, int bp, int skin, double bmi, double ped, int age, string type)
        {
            this.κ = κ;
            this.npreg = npreg;
            this.glu = glu;
            this.bp = bp;
            this.skin = skin;
            this.bmi = bmi;
            this.ped = ped;
            this.age = age;
            this.type = type;
        }

        public static IEnumerable<Pima_tr> Data
        {
            get
            {
                yield return new Pima_tr(1, 5, 86, 68, 28, 30.2, 0.364, 24, "No");
                yield return new Pima_tr(2, 7, 195, 70, 33, 25.1, 0.163, 55, "Yes");
                yield return new Pima_tr(3, 5, 77, 82, 41, 35.8, 0.156, 35, "No");
                yield return new Pima_tr(4, 0, 165, 76, 43, 47.9, 0.259, 26, "No");
                yield return new Pima_tr(5, 0, 107, 60, 25, 26.4, 0.133, 23, "No");
                yield return new Pima_tr(6, 5, 97, 76, 27, 35.6, 0.378, 52, "Yes");
                yield return new Pima_tr(7, 3, 83, 58, 31, 34.3, 0.336, 25, "No");
                yield return new Pima_tr(8, 1, 193, 50, 16, 25.9, 0.655, 24, "No");
                yield return new Pima_tr(9, 3, 142, 80, 15, 32.4, 0.2, 63, "No");
                yield return new Pima_tr(10, 2, 128, 78, 37, 43.3, 1.224, 31, "Yes");
                yield return new Pima_tr(11, 0, 137, 40, 35, 43.1, 2.288, 33, "Yes");
                yield return new Pima_tr(12, 9, 154, 78, 30, 30.9, 0.164, 45, "No");
                yield return new Pima_tr(13, 1, 189, 60, 23, 30.1, 0.398, 59, "Yes");
                yield return new Pima_tr(14, 12, 92, 62, 7, 27.6, 0.926, 44, "Yes");
                yield return new Pima_tr(15, 1, 86, 66, 52, 41.3, 0.917, 29, "No");
                yield return new Pima_tr(16, 4, 99, 76, 15, 23.2, 0.223, 21, "No");
                yield return new Pima_tr(17, 1, 109, 60, 8, 25.4, 0.947, 21, "No");
                yield return new Pima_tr(18, 11, 143, 94, 33, 36.6, 0.254, 51, "Yes");
                yield return new Pima_tr(19, 1, 149, 68, 29, 29.3, 0.349, 42, "Yes");
                yield return new Pima_tr(20, 0, 139, 62, 17, 22.1, 0.207, 21, "No");
                yield return new Pima_tr(21, 2, 99, 70, 16, 20.4, 0.235, 27, "No");
                yield return new Pima_tr(22, 1, 100, 66, 29, 32, 0.444, 42, "No");
                yield return new Pima_tr(23, 4, 83, 86, 19, 29.3, 0.317, 34, "No");
                yield return new Pima_tr(24, 0, 101, 64, 17, 21, 0.252, 21, "No");
                yield return new Pima_tr(25, 1, 87, 68, 34, 37.6, 0.401, 24, "No");
                yield return new Pima_tr(26, 9, 164, 84, 21, 30.8, 0.831, 32, "Yes");
                yield return new Pima_tr(27, 1, 99, 58, 10, 25.4, 0.551, 21, "No");
                yield return new Pima_tr(28, 0, 140, 65, 26, 42.6, 0.431, 24, "Yes");
                yield return new Pima_tr(29, 5, 108, 72, 43, 36.1, 0.263, 33, "No");
                yield return new Pima_tr(30, 2, 110, 74, 29, 32.4, 0.698, 27, "No");
                yield return new Pima_tr(31, 1, 79, 60, 42, 43.5, 0.678, 23, "No");
                yield return new Pima_tr(32, 3, 148, 66, 25, 32.5, 0.256, 22, "No");
                yield return new Pima_tr(33, 0, 121, 66, 30, 34.3, 0.203, 33, "Yes");
                yield return new Pima_tr(34, 3, 158, 64, 13, 31.2, 0.295, 24, "No");
                yield return new Pima_tr(35, 2, 105, 80, 45, 33.7, 0.711, 29, "Yes");
                yield return new Pima_tr(36, 13, 145, 82, 19, 22.2, 0.245, 57, "No");
                yield return new Pima_tr(37, 1, 79, 80, 25, 25.4, 0.583, 22, "No");
                yield return new Pima_tr(38, 1, 71, 48, 18, 20.4, 0.323, 22, "No");
                yield return new Pima_tr(39, 0, 102, 86, 17, 29.3, 0.695, 27, "No");
                yield return new Pima_tr(40, 0, 119, 66, 27, 38.8, 0.259, 22, "No");
                yield return new Pima_tr(41, 8, 176, 90, 34, 33.7, 0.467, 58, "Yes");
                yield return new Pima_tr(42, 1, 97, 68, 21, 27.2, 1.095, 22, "No");
                yield return new Pima_tr(43, 4, 129, 60, 12, 27.5, 0.527, 31, "No");
                yield return new Pima_tr(44, 1, 97, 64, 19, 18.2, 0.299, 21, "No");
                yield return new Pima_tr(45, 0, 86, 68, 32, 35.8, 0.238, 25, "No");
                yield return new Pima_tr(46, 2, 125, 60, 20, 33.8, 0.088, 31, "No");
                yield return new Pima_tr(47, 5, 123, 74, 40, 34.1, 0.269, 28, "No");
                yield return new Pima_tr(48, 2, 92, 76, 20, 24.2, 1.698, 28, "No");
                yield return new Pima_tr(49, 3, 171, 72, 33, 33.3, 0.199, 24, "Yes");
                yield return new Pima_tr(50, 1, 199, 76, 43, 42.9, 1.394, 22, "Yes");
                yield return new Pima_tr(51, 3, 116, 74, 15, 26.3, 0.107, 24, "No");
                yield return new Pima_tr(52, 2, 83, 66, 23, 32.2, 0.497, 22, "No");
                yield return new Pima_tr(53, 8, 154, 78, 32, 32.4, 0.443, 45, "Yes");
                yield return new Pima_tr(54, 1, 114, 66, 36, 38.1, 0.289, 21, "No");
                yield return new Pima_tr(55, 1, 106, 70, 28, 34.2, 0.142, 22, "No");
                yield return new Pima_tr(56, 4, 127, 88, 11, 34.5, 0.598, 28, "No");
                yield return new Pima_tr(57, 1, 124, 74, 36, 27.8, 0.1, 30, "No");
                yield return new Pima_tr(58, 1, 109, 38, 18, 23.1, 0.407, 26, "No");
                yield return new Pima_tr(59, 2, 123, 48, 32, 42.1, 0.52, 26, "No");
                yield return new Pima_tr(60, 8, 167, 106, 46, 37.6, 0.165, 43, "Yes");
                yield return new Pima_tr(61, 7, 184, 84, 33, 35.5, 0.355, 41, "Yes");
                yield return new Pima_tr(62, 1, 96, 64, 27, 33.2, 0.289, 21, "No");
                yield return new Pima_tr(63, 10, 129, 76, 28, 35.9, 0.28, 39, "No");
                yield return new Pima_tr(64, 6, 92, 62, 32, 32, 0.085, 46, "No");
                yield return new Pima_tr(65, 6, 109, 60, 27, 25, 0.206, 27, "No");
                yield return new Pima_tr(66, 5, 139, 80, 35, 31.6, 0.361, 25, "Yes");
                yield return new Pima_tr(67, 6, 134, 70, 23, 35.4, 0.542, 29, "Yes");
                yield return new Pima_tr(68, 3, 106, 54, 21, 30.9, 0.292, 24, "No");
                yield return new Pima_tr(69, 0, 131, 66, 40, 34.3, 0.196, 22, "Yes");
                yield return new Pima_tr(70, 0, 135, 94, 46, 40.6, 0.284, 26, "No");
                yield return new Pima_tr(71, 5, 158, 84, 41, 39.4, 0.395, 29, "Yes");
                yield return new Pima_tr(72, 3, 112, 74, 30, 31.6, 0.197, 25, "Yes");
                yield return new Pima_tr(73, 8, 181, 68, 36, 30.1, 0.615, 60, "Yes");
                yield return new Pima_tr(74, 2, 121, 70, 32, 39.1, 0.886, 23, "No");
                yield return new Pima_tr(75, 1, 168, 88, 29, 35, 0.905, 52, "Yes");
                yield return new Pima_tr(76, 1, 144, 82, 46, 46.1, 0.335, 46, "Yes");
                yield return new Pima_tr(77, 2, 101, 58, 17, 24.2, 0.614, 23, "No");
                yield return new Pima_tr(78, 2, 96, 68, 13, 21.1, 0.647, 26, "No");
                yield return new Pima_tr(79, 3, 107, 62, 13, 22.9, 0.678, 23, "Yes");
                yield return new Pima_tr(80, 12, 121, 78, 17, 26.5, 0.259, 62, "No");
                yield return new Pima_tr(81, 2, 100, 64, 23, 29.7, 0.368, 21, "No");
                yield return new Pima_tr(82, 4, 154, 72, 29, 31.3, 0.338, 37, "No");
                yield return new Pima_tr(83, 6, 125, 78, 31, 27.6, 0.565, 49, "Yes");
                yield return new Pima_tr(84, 10, 125, 70, 26, 31.1, 0.205, 41, "Yes");
                yield return new Pima_tr(85, 2, 122, 76, 27, 35.9, 0.483, 26, "No");
                yield return new Pima_tr(86, 2, 114, 68, 22, 28.7, 0.092, 25, "No");
                yield return new Pima_tr(87, 1, 115, 70, 30, 34.6, 0.529, 32, "Yes");
                yield return new Pima_tr(88, 7, 114, 76, 17, 23.8, 0.466, 31, "No");
                yield return new Pima_tr(89, 2, 115, 64, 22, 30.8, 0.421, 21, "No");
                yield return new Pima_tr(90, 1, 130, 60, 23, 28.6, 0.692, 21, "No");
                yield return new Pima_tr(91, 1, 79, 75, 30, 32, 0.396, 22, "No");
                yield return new Pima_tr(92, 4, 112, 78, 40, 39.4, 0.236, 38, "No");
                yield return new Pima_tr(93, 7, 150, 78, 29, 35.2, 0.692, 54, "Yes");
                yield return new Pima_tr(94, 1, 91, 54, 25, 25.2, 0.234, 23, "No");
                yield return new Pima_tr(95, 1, 100, 72, 12, 25.3, 0.658, 28, "No");
                yield return new Pima_tr(96, 12, 140, 82, 43, 39.2, 0.528, 58, "Yes");
                yield return new Pima_tr(97, 4, 110, 76, 20, 28.4, 0.118, 27, "No");
                yield return new Pima_tr(98, 2, 94, 76, 18, 31.6, 0.649, 23, "No");
                yield return new Pima_tr(99, 2, 84, 50, 23, 30.4, 0.968, 21, "No");
                yield return new Pima_tr(100, 10, 148, 84, 48, 37.6, 1.001, 51, "Yes");
                yield return new Pima_tr(101, 3, 61, 82, 28, 34.4, 0.243, 46, "No");
                yield return new Pima_tr(102, 4, 117, 62, 12, 29.7, 0.38, 30, "Yes");
                yield return new Pima_tr(103, 3, 99, 80, 11, 19.3, 0.284, 30, "No");
                yield return new Pima_tr(104, 3, 80, 82, 31, 34.2, 1.292, 27, "Yes");
                yield return new Pima_tr(105, 4, 154, 62, 31, 32.8, 0.237, 23, "No");
                yield return new Pima_tr(106, 6, 103, 72, 32, 37.7, 0.324, 55, "No");
                yield return new Pima_tr(107, 6, 111, 64, 39, 34.2, 0.26, 24, "No");
                yield return new Pima_tr(108, 0, 124, 70, 20, 27.4, 0.254, 36, "Yes");
                yield return new Pima_tr(109, 1, 143, 74, 22, 26.2, 0.256, 21, "No");
                yield return new Pima_tr(110, 1, 81, 74, 41, 46.3, 1.096, 32, "No");
                yield return new Pima_tr(111, 4, 189, 110, 31, 28.5, 0.68, 37, "No");
                yield return new Pima_tr(112, 4, 116, 72, 12, 22.1, 0.463, 37, "No");
                yield return new Pima_tr(113, 7, 103, 66, 32, 39.1, 0.344, 31, "Yes");
                yield return new Pima_tr(114, 8, 124, 76, 24, 28.7, 0.687, 52, "Yes");
                yield return new Pima_tr(115, 1, 71, 78, 50, 33.2, 0.422, 21, "No");
                yield return new Pima_tr(116, 0, 137, 84, 27, 27.3, 0.231, 59, "No");
                yield return new Pima_tr(117, 9, 112, 82, 32, 34.2, 0.26, 36, "Yes");
                yield return new Pima_tr(118, 4, 148, 60, 27, 30.9, 0.15, 29, "Yes");
                yield return new Pima_tr(119, 1, 136, 74, 50, 37.4, 0.399, 24, "No");
                yield return new Pima_tr(120, 9, 145, 80, 46, 37.9, 0.637, 40, "Yes");
                yield return new Pima_tr(121, 1, 93, 56, 11, 22.5, 0.417, 22, "No");
                yield return new Pima_tr(122, 1, 107, 72, 30, 30.8, 0.821, 24, "No");
                yield return new Pima_tr(123, 12, 151, 70, 40, 41.8, 0.742, 38, "Yes");
                yield return new Pima_tr(124, 1, 97, 70, 40, 38.1, 0.218, 30, "No");
                yield return new Pima_tr(125, 5, 144, 82, 26, 32, 0.452, 58, "Yes");
                yield return new Pima_tr(126, 2, 112, 86, 42, 38.4, 0.246, 28, "No");
                yield return new Pima_tr(127, 2, 99, 52, 15, 24.6, 0.637, 21, "No");
                yield return new Pima_tr(128, 1, 109, 56, 21, 25.2, 0.833, 23, "No");
                yield return new Pima_tr(129, 1, 120, 80, 48, 38.9, 1.162, 41, "No");
                yield return new Pima_tr(130, 7, 187, 68, 39, 37.7, 0.254, 41, "Yes");
                yield return new Pima_tr(131, 3, 129, 92, 49, 36.4, 0.968, 32, "Yes");
                yield return new Pima_tr(132, 7, 179, 95, 31, 34.2, 0.164, 60, "No");
                yield return new Pima_tr(133, 6, 80, 66, 30, 26.2, 0.313, 41, "No");
                yield return new Pima_tr(134, 2, 105, 58, 40, 34.9, 0.225, 25, "No");
                yield return new Pima_tr(135, 3, 191, 68, 15, 30.9, 0.299, 34, "No");
                yield return new Pima_tr(136, 0, 95, 80, 45, 36.5, 0.33, 26, "No");
                yield return new Pima_tr(137, 4, 99, 72, 17, 25.6, 0.294, 28, "No");
                yield return new Pima_tr(138, 0, 137, 68, 14, 24.8, 0.143, 21, "No");
                yield return new Pima_tr(139, 1, 97, 70, 15, 18.2, 0.147, 21, "No");
                yield return new Pima_tr(140, 0, 100, 88, 60, 46.8, 0.962, 31, "No");
                yield return new Pima_tr(141, 1, 167, 74, 17, 23.4, 0.447, 33, "Yes");
                yield return new Pima_tr(142, 0, 180, 90, 26, 36.5, 0.314, 35, "Yes");
                yield return new Pima_tr(143, 2, 122, 70, 27, 36.8, 0.34, 27, "No");
                yield return new Pima_tr(144, 1, 90, 62, 12, 27.2, 0.58, 24, "No");
                yield return new Pima_tr(145, 3, 120, 70, 30, 42.9, 0.452, 30, "No");
                yield return new Pima_tr(146, 6, 154, 78, 41, 46.1, 0.571, 27, "No");
                yield return new Pima_tr(147, 2, 56, 56, 28, 24.2, 0.332, 22, "No");
                yield return new Pima_tr(148, 0, 177, 60, 29, 34.6, 1.072, 21, "Yes");
                yield return new Pima_tr(149, 3, 124, 80, 33, 33.2, 0.305, 26, "No");
                yield return new Pima_tr(150, 8, 85, 55, 20, 24.4, 0.136, 42, "No");
                yield return new Pima_tr(151, 12, 88, 74, 40, 35.3, 0.378, 48, "No");
                yield return new Pima_tr(152, 9, 152, 78, 34, 34.2, 0.893, 33, "Yes");
                yield return new Pima_tr(153, 0, 198, 66, 32, 41.3, 0.502, 28, "Yes");
                yield return new Pima_tr(154, 0, 188, 82, 14, 32, 0.682, 22, "Yes");
                yield return new Pima_tr(155, 5, 139, 64, 35, 28.6, 0.411, 26, "No");
                yield return new Pima_tr(156, 7, 168, 88, 42, 38.2, 0.787, 40, "Yes");
                yield return new Pima_tr(157, 2, 197, 70, 99, 34.7, 0.575, 62, "Yes");
                yield return new Pima_tr(158, 2, 142, 82, 18, 24.7, 0.761, 21, "No");
                yield return new Pima_tr(159, 8, 126, 74, 38, 25.9, 0.162, 39, "No");
                yield return new Pima_tr(160, 3, 158, 76, 36, 31.6, 0.851, 28, "Yes");
                yield return new Pima_tr(161, 3, 130, 78, 23, 28.4, 0.323, 34, "Yes");
                yield return new Pima_tr(162, 2, 100, 54, 28, 37.8, 0.498, 24, "No");
                yield return new Pima_tr(163, 1, 164, 82, 43, 32.8, 0.341, 50, "No");
                yield return new Pima_tr(164, 4, 95, 60, 32, 35.4, 0.284, 28, "No");
                yield return new Pima_tr(165, 2, 122, 52, 43, 36.2, 0.816, 28, "No");
                yield return new Pima_tr(166, 4, 85, 58, 22, 27.8, 0.306, 28, "No");
                yield return new Pima_tr(167, 0, 151, 90, 46, 42.1, 0.371, 21, "Yes");
                yield return new Pima_tr(168, 6, 144, 72, 27, 33.9, 0.255, 40, "No");
                yield return new Pima_tr(169, 3, 111, 90, 12, 28.4, 0.495, 29, "No");
                yield return new Pima_tr(170, 1, 107, 68, 19, 26.5, 0.165, 24, "No");
                yield return new Pima_tr(171, 6, 115, 60, 39, 33.7, 0.245, 40, "Yes");
                yield return new Pima_tr(172, 5, 105, 72, 29, 36.9, 0.159, 28, "No");
                yield return new Pima_tr(173, 7, 194, 68, 28, 35.9, 0.745, 41, "Yes");
                yield return new Pima_tr(174, 4, 184, 78, 39, 37, 0.264, 31, "Yes");
                yield return new Pima_tr(175, 0, 95, 85, 25, 37.4, 0.247, 24, "Yes");
                yield return new Pima_tr(176, 7, 124, 70, 33, 25.5, 0.161, 37, "No");
                yield return new Pima_tr(177, 1, 111, 62, 13, 24, 0.138, 23, "No");
                yield return new Pima_tr(178, 7, 137, 90, 41, 32, 0.391, 39, "No");
                yield return new Pima_tr(179, 9, 57, 80, 37, 32.8, 0.096, 41, "No");
                yield return new Pima_tr(180, 2, 157, 74, 35, 39.4, 0.134, 30, "No");
                yield return new Pima_tr(181, 2, 95, 54, 14, 26.1, 0.748, 22, "No");
                yield return new Pima_tr(182, 12, 140, 85, 33, 37.4, 0.244, 41, "No");
                yield return new Pima_tr(183, 0, 117, 66, 31, 30.8, 0.493, 22, "No");
                yield return new Pima_tr(184, 8, 100, 74, 40, 39.4, 0.661, 43, "Yes");
                yield return new Pima_tr(185, 9, 123, 70, 44, 33.1, 0.374, 40, "No");
                yield return new Pima_tr(186, 0, 138, 60, 35, 34.6, 0.534, 21, "Yes");
                yield return new Pima_tr(187, 14, 100, 78, 25, 36.6, 0.412, 46, "Yes");
                yield return new Pima_tr(188, 14, 175, 62, 30, 33.6, 0.212, 38, "Yes");
                yield return new Pima_tr(189, 0, 74, 52, 10, 27.8, 0.269, 22, "No");
                yield return new Pima_tr(190, 1, 133, 102, 28, 32.8, 0.234, 45, "Yes");
                yield return new Pima_tr(191, 0, 119, 64, 18, 34.9, 0.725, 23, "No");
                yield return new Pima_tr(192, 5, 155, 84, 44, 38.7, 0.619, 34, "No");
                yield return new Pima_tr(193, 1, 128, 48, 45, 40.5, 0.613, 24, "Yes");
                yield return new Pima_tr(194, 2, 112, 68, 22, 34.1, 0.315, 26, "No");
                yield return new Pima_tr(195, 1, 140, 74, 26, 24.1, 0.828, 23, "No");
                yield return new Pima_tr(196, 2, 141, 58, 34, 25.4, 0.699, 24, "No");
                yield return new Pima_tr(197, 7, 129, 68, 49, 38.5, 0.439, 43, "Yes");
                yield return new Pima_tr(198, 0, 106, 70, 37, 39.4, 0.605, 22, "No");
                yield return new Pima_tr(199, 1, 118, 58, 36, 33.3, 0.261, 23, "No");
                yield return new Pima_tr(200, 8, 155, 62, 26, 34, 0.543, 46, "Yes");
            }
        }
    }
}
