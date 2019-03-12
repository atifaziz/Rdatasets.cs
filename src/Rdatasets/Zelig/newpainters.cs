// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// The Discretized Painter's Data of de Piles
    /// </summary>

    public class newpainters
    {
        public readonly string κ;
        public readonly int Composition;
        public readonly int Drawing;
        public readonly int Colour;
        public readonly int Expression;

        public newpainters(string κ, int Composition, int Drawing, int Colour, int Expression)
        {
            this.κ = κ;
            this.Composition = Composition;
            this.Drawing = Drawing;
            this.Colour = Colour;
            this.Expression = Expression;
        }

        public static IEnumerable<newpainters> Data
        {
            get
            {
                yield return new newpainters("Da Udine", 200, 100, 400, 100);
                yield return new newpainters("Da Vinci", 400, 400, 100, 400);
                yield return new newpainters("Del Piombo", 100, 200, 400, 300);
                yield return new newpainters("Del Sarto", 200, 400, 200, 300);
                yield return new newpainters("Fr. Penni", 100, 400, 200, 100);
                yield return new newpainters("Guilio Romano", 400, 400, 100, 400);
                yield return new newpainters("Michelangelo", 100, 400, 100, 300);
                yield return new newpainters("Perino del Vaga", 400, 400, 100, 300);
                yield return new newpainters("Perugino", 100, 200, 300, 200);
                yield return new newpainters("Raphael", 400, 400, 300, 400);
                yield return new newpainters("F. Zucarro", 200, 200, 200, 300);
                yield return new newpainters("Fr. Salviata", 300, 400, 200, 300);
                yield return new newpainters("Parmigiano", 200, 400, 100, 300);
                yield return new newpainters("Primaticcio", 400, 300, 100, 300);
                yield return new newpainters("T. Zucarro", 300, 300, 300, 300);
                yield return new newpainters("Volterra", 200, 400, 100, 300);
                yield return new newpainters("Barocci", 300, 400, 100, 300);
                yield return new newpainters("Cortona", 400, 300, 300, 300);
                yield return new newpainters("Josepin", 200, 200, 100, 100);
                yield return new newpainters("L. Jordaens", 300, 200, 200, 300);
                yield return new newpainters("Testa", 200, 400, 100, 300);
                yield return new newpainters("Vanius", 400, 400, 300, 400);
                yield return new newpainters("Bassano", 100, 100, 400, 100);
                yield return new newpainters("Bellini", 100, 100, 300, 100);
                yield return new newpainters("Giorgione", 100, 100, 400, 200);
                yield return new newpainters("Murillo", 100, 100, 300, 200);
                yield return new newpainters("Palma Giovane", 200, 100, 300, 300);
                yield return new newpainters("Palma Vecchio", 100, 100, 400, 100);
                yield return new newpainters("Pordenone", 100, 300, 400, 200);
                yield return new newpainters("Tintoretto", 400, 300, 400, 200);
                yield return new newpainters("Titian", 200, 400, 400, 300);
                yield return new newpainters("Veronese", 400, 200, 400, 100);
                yield return new newpainters("Albani", 300, 300, 300, 300);
                yield return new newpainters("Caravaggio", 100, 100, 400, 100);
                yield return new newpainters("Corregio", 300, 200, 300, 400);
                yield return new newpainters("Domenichino", 400, 400, 200, 400);
                yield return new newpainters("Guercino", 400, 200, 300, 200);
                yield return new newpainters("Lanfranco", 300, 200, 300, 200);
                yield return new newpainters("The Carraci", 400, 400, 300, 400);
                yield return new newpainters("Durer", 100, 200, 300, 300);
                yield return new newpainters("Holbein", 200, 200, 400, 400);
                yield return new newpainters("Pourbus", 100, 400, 100, 300);
                yield return new newpainters("Van Leyden", 100, 100, 100, 200);
                yield return new newpainters("Diepenbeck", 200, 200, 300, 300);
                yield return new newpainters("J. Jordaens", 200, 100, 400, 300);
                yield return new newpainters("Otho Venius", 300, 300, 300, 300);
                yield return new newpainters("Rembrandt", 400, 100, 400, 400);
                yield return new newpainters("Rubens", 400, 200, 400, 400);
                yield return new newpainters("Teniers", 400, 200, 300, 300);
                yield return new newpainters("Van Dyck", 400, 200, 400, 400);
                yield return new newpainters("Bourdon", 200, 100, 200, 200);
                yield return new newpainters("Le Brun", 400, 400, 200, 400);
                yield return new newpainters("Le Suer", 400, 400, 100, 400);
                yield return new newpainters("Poussin", 400, 400, 100, 400);
            }
        }
    }
}
