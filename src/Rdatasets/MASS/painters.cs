// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// The Painter's Data of de Piles
    /// </summary>

    public class painters
    {
        public readonly string κ;
        public readonly int Composition;
        public readonly int Drawing;
        public readonly int Colour;
        public readonly int Expression;
        public readonly string School;

        public painters(string κ, int Composition, int Drawing, int Colour, int Expression, string School)
        {
            this.κ = κ;
            this.Composition = Composition;
            this.Drawing = Drawing;
            this.Colour = Colour;
            this.Expression = Expression;
            this.School = School;
        }

        public static IEnumerable<painters> Data
        {
            get
            {
                yield return new painters("Da Udine", 10, 8, 16, 3, "A");
                yield return new painters("Da Vinci", 15, 16, 4, 14, "A");
                yield return new painters("Del Piombo", 8, 13, 16, 7, "A");
                yield return new painters("Del Sarto", 12, 16, 9, 8, "A");
                yield return new painters("Fr. Penni", 0, 15, 8, 0, "A");
                yield return new painters("Guilio Romano", 15, 16, 4, 14, "A");
                yield return new painters("Michelangelo", 8, 17, 4, 8, "A");
                yield return new painters("Perino del Vaga", 15, 16, 7, 6, "A");
                yield return new painters("Perugino", 4, 12, 10, 4, "A");
                yield return new painters("Raphael", 17, 18, 12, 18, "A");
                yield return new painters("F. Zucarro", 10, 13, 8, 8, "B");
                yield return new painters("Fr. Salviata", 13, 15, 8, 8, "B");
                yield return new painters("Parmigiano", 10, 15, 6, 6, "B");
                yield return new painters("Primaticcio", 15, 14, 7, 10, "B");
                yield return new painters("T. Zucarro", 13, 14, 10, 9, "B");
                yield return new painters("Volterra", 12, 15, 5, 8, "B");
                yield return new painters("Barocci", 14, 15, 6, 10, "C");
                yield return new painters("Cortona", 16, 14, 12, 6, "C");
                yield return new painters("Josepin", 10, 10, 6, 2, "C");
                yield return new painters("L. Jordaens", 13, 12, 9, 6, "C");
                yield return new painters("Testa", 11, 15, 0, 6, "C");
                yield return new painters("Vanius", 15, 15, 12, 13, "C");
                yield return new painters("Bassano", 6, 8, 17, 0, "D");
                yield return new painters("Bellini", 4, 6, 14, 0, "D");
                yield return new painters("Giorgione", 8, 9, 18, 4, "D");
                yield return new painters("Murillo", 6, 8, 15, 4, "D");
                yield return new painters("Palma Giovane", 12, 9, 14, 6, "D");
                yield return new painters("Palma Vecchio", 5, 6, 16, 0, "D");
                yield return new painters("Pordenone", 8, 14, 17, 5, "D");
                yield return new painters("Tintoretto", 15, 14, 16, 4, "D");
                yield return new painters("Titian", 12, 15, 18, 6, "D");
                yield return new painters("Veronese", 15, 10, 16, 3, "D");
                yield return new painters("Albani", 14, 14, 10, 6, "E");
                yield return new painters("Caravaggio", 6, 6, 16, 0, "E");
                yield return new painters("Corregio", 13, 13, 15, 12, "E");
                yield return new painters("Domenichino", 15, 17, 9, 17, "E");
                yield return new painters("Guercino", 18, 10, 10, 4, "E");
                yield return new painters("Lanfranco", 14, 13, 10, 5, "E");
                yield return new painters("The Carraci", 15, 17, 13, 13, "E");
                yield return new painters("Durer", 8, 10, 10, 8, "F");
                yield return new painters("Holbein", 9, 10, 16, 13, "F");
                yield return new painters("Pourbus", 4, 15, 6, 6, "F");
                yield return new painters("Van Leyden", 8, 6, 6, 4, "F");
                yield return new painters("Diepenbeck", 11, 10, 14, 6, "G");
                yield return new painters("J. Jordaens", 10, 8, 16, 6, "G");
                yield return new painters("Otho Venius", 13, 14, 10, 10, "G");
                yield return new painters("Rembrandt", 15, 6, 17, 12, "G");
                yield return new painters("Rubens", 18, 13, 17, 17, "G");
                yield return new painters("Teniers", 15, 12, 13, 6, "G");
                yield return new painters("Van Dyck", 15, 10, 17, 13, "G");
                yield return new painters("Bourdon", 10, 8, 8, 4, "H");
                yield return new painters("Le Brun", 16, 16, 8, 16, "H");
                yield return new painters("Le Suer", 15, 15, 4, 15, "H");
                yield return new painters("Poussin", 15, 17, 6, 15, "H");
            }
        }
    }
}
