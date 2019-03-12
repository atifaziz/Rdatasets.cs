// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Measurements on 12 books
    /// </summary>

    public class oddbooks
    {
        public readonly int κ;
        public readonly int thick;
        public readonly double height;
        public readonly double breadth;
        public readonly int weight;

        public oddbooks(int κ, int thick, double height, double breadth, int weight)
        {
            this.κ = κ;
            this.thick = thick;
            this.height = height;
            this.breadth = breadth;
            this.weight = weight;
        }

        public static IEnumerable<oddbooks> Data
        {
            get
            {
                yield return new oddbooks(1, 14, 30.5, 23, 1075);
                yield return new oddbooks(2, 15, 29.1, 20.5, 940);
                yield return new oddbooks(3, 18, 27.5, 18.5, 625);
                yield return new oddbooks(4, 23, 23.2, 15.2, 400);
                yield return new oddbooks(5, 24, 21.6, 14, 550);
                yield return new oddbooks(6, 25, 23.5, 15.5, 600);
                yield return new oddbooks(7, 28, 19.7, 12.6, 450);
                yield return new oddbooks(8, 28, 19.8, 12.6, 450);
                yield return new oddbooks(9, 29, 17.3, 10.5, 300);
                yield return new oddbooks(10, 30, 22.8, 15.4, 690);
                yield return new oddbooks(11, 36, 17.8, 11, 400);
                yield return new oddbooks(12, 44, 13.5, 9.2, 250);
            }
        }
    }
}
