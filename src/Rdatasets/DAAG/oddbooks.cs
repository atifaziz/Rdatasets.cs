// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Measurements on 12 books
    /// </summary>

    public class oddbooks
    {
        public readonly int thick;
        public readonly double height;
        public readonly double breadth;
        public readonly int weight;

        public oddbooks(int thick, double height, double breadth, int weight)
        {
            this.thick = thick;
            this.height = height;
            this.breadth = breadth;
            this.weight = weight;
        }

        public static IEnumerable<oddbooks> Data
        {
            get
            {
                yield return new oddbooks(14, 30.5, 23, 1075);
                yield return new oddbooks(15, 29.1, 20.5, 940);
                yield return new oddbooks(18, 27.5, 18.5, 625);
                yield return new oddbooks(23, 23.2, 15.2, 400);
                yield return new oddbooks(24, 21.6, 14, 550);
                yield return new oddbooks(25, 23.5, 15.5, 600);
                yield return new oddbooks(28, 19.7, 12.6, 450);
                yield return new oddbooks(28, 19.8, 12.6, 450);
                yield return new oddbooks(29, 17.3, 10.5, 300);
                yield return new oddbooks(30, 22.8, 15.4, 690);
                yield return new oddbooks(36, 17.8, 11, 400);
                yield return new oddbooks(44, 13.5, 9.2, 250);
            }
        }
    }
}
