// ReSharper disable All

namespace Rdatasets.ISLR
{
    using System.Collections.Generic;

    /// <summary>
    /// Portfolio Data
    /// </summary>

    public class Portfolio
    {
        public readonly double X;
        public readonly double Y;

        public Portfolio(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static IEnumerable<Portfolio> Data
        {
            get
            {
                yield return new Portfolio(-0.895250889141557, -0.234923525765402);
                yield return new Portfolio(-1.5624543274753, -0.885175993044695);
                yield return new Portfolio(-0.417089883126492, 0.271888018049829);
                yield return new Portfolio(1.04435572526951, -0.734197504067649);
                yield return new Portfolio(-0.315568406681027, 0.841983429961188);
                yield return new Portfolio(-1.73712384902476, -2.03719104074984);
                yield return new Portfolio(1.96641315717111, 1.45295666192369);
                yield return new Portfolio(2.1528678980109, -0.434138628179502);
                yield return new Portfolio(-0.0812080267602958, 1.45080850218963);
                yield return new Portfolio(-0.891781794029037, 0.821016234539977);
                yield return new Portfolio(-0.293201702010266, -1.04239112183501);
                yield return new Portfolio(0.50577917106943, 0.608477825846609);
                yield return new Portfolio(0.52675125409276, -0.222493343282789);
                yield return new Portfolio(1.06646932095091, 1.2313566752569);
                yield return new Portfolio(0.294015895063748, 0.628589480036184);
                yield return new Portfolio(0.0425492997633765, -1.26757361755317);
                yield return new Portfolio(1.83096958062302, -0.572751605498511);
                yield return new Portfolio(-0.32693749887808, -0.487472465045569);
                yield return new Portfolio(0.521480415807099, 2.56598528732423);
                yield return new Portfolio(1.39986834733422, -0.35783612748179);
                yield return new Portfolio(-0.645447596468841, -1.41243138949505);
                yield return new Portfolio(-0.904351878449744, -0.568304791041892);
                yield return new Portfolio(-1.76458606961956, -0.746272562068363);
                yield return new Portfolio(-1.81048463818975, 0.493747359351401);
                yield return new Portfolio(-1.16989891378141, -2.72528149494243);
                yield return new Portfolio(-0.685375735369436, -0.457615734339251);
                yield return new Portfolio(1.09091803183517, 0.0144945075275287);
                yield return new Portfolio(-0.432340114040807, -0.399831023509433);
                yield return new Portfolio(0.268814775370724, -0.201608350198064);
                yield return new Portfolio(-0.851840753541132, -1.74182928585454);
                yield return new Portfolio(-1.49708417203583, -0.826033329437587);
                yield return new Portfolio(0.0887747459974043, -0.887360712723633);
                yield return new Portfolio(-1.60172430963135, -0.695299045952921);
                yield return new Portfolio(-1.24685724025742, -1.52958488449121);
                yield return new Portfolio(-1.06298912830654, -0.110637447363915);
                yield return new Portfolio(-0.26628305530967, 0.0451634696288592);
                yield return new Portfolio(1.67658383263088, 2.5200528826286);
                yield return new Portfolio(0.119572571440877, 0.535542781034257);
                yield return new Portfolio(-0.0860079872690871, 1.36359582805839);
                yield return new Portfolio(0.368080289748909, 1.72937250996995);
                yield return new Portfolio(-0.271494206939639, 1.37926732742329);
                yield return new Portfolio(-0.0859264618788124, -0.127662573750838);
                yield return new Portfolio(-0.190750153683344, -0.461333357787814);
                yield return new Portfolio(-0.781679768391051, 1.02239787730549);
                yield return new Portfolio(0.792436346460761, -0.814298088654853);
                yield return new Portfolio(-0.28286988623389, -1.03846880699277);
                yield return new Portfolio(-0.236625531902745, 0.928450553143057);
                yield return new Portfolio(1.17183009101022, 1.72983145002732);
                yield return new Portfolio(0.496942768505321, -0.925139825948684);
                yield return new Portfolio(-0.887370979477135, -2.2834979593885);
                yield return new Portfolio(-1.30695315836496, -2.38160058115405);
                yield return new Portfolio(-2.43276412040427, -2.02554558512495);
                yield return new Portfolio(-0.407188960959958, -0.335098643325459);
                yield return new Portfolio(-0.285665299455223, -1.30878131266949);
                yield return new Portfolio(1.52221488310337, 1.20100315334525);
                yield return new Portfolio(-0.998106907437742, -0.946268900068486);
                yield return new Portfolio(-0.289973726127379, 0.206256579940999);
                yield return new Portfolio(-1.23683924300474, -0.675447507316727);
                yield return new Portfolio(-0.359506962064002, -2.70015447021752);
                yield return new Portfolio(0.543559153033075, 0.42254755209331);
                yield return new Portfolio(-0.403647282894893, -0.0543899228706378);
                yield return new Portfolio(1.30330893265591, 1.32896747385231);
                yield return new Portfolio(-0.717117243405944, 1.33137979803966);
                yield return new Portfolio(-1.01270788405516, -0.92476923081864);
                yield return new Portfolio(0.831992902158869, 2.24774586894653);
                yield return new Portfolio(1.33764359604195, 0.868256457487716);
                yield return new Portfolio(0.601693509867379, -0.198217563055149);
                yield return new Portfolio(1.30285098047145, 1.10466637601686);
                yield return new Portfolio(-0.881700578927026, -1.54068478518396);
                yield return new Portfolio(-0.824529071304578, -1.33700787719544);
                yield return new Portfolio(-0.984356518466055, -1.1391602659206);
                yield return new Portfolio(-1.38499150721135, 0.70269993294853);
                yield return new Portfolio(-0.358842560435759, -1.69451276977832);
                yield return new Portfolio(-0.226618229456359, 0.801938547570983);
                yield return new Portfolio(-0.941077436691343, -0.733188708932247);
                yield return new Portfolio(2.4603359481276, -0.048372817002224);
                yield return new Portfolio(0.716797281412897, 0.602336759898045);
                yield return new Portfolio(-0.248087023209405, -1.01849037378952);
                yield return new Portfolio(1.01077288944297, 0.0529780222228798);
                yield return new Portfolio(2.31304863448491, 1.75235887915611);
                yield return new Portfolio(0.835179797449368, 0.98571487565829);
                yield return new Portfolio(-1.07190333913753, -1.24729787324372);
                yield return new Portfolio(-1.6505261438491, 0.215464529577012);
                yield return new Portfolio(-0.60048569030458, -0.420940526974254);
                yield return new Portfolio(-0.0585293830470613, 0.127620874053089);
                yield return new Portfolio(0.0757267446338611, -0.522149221026395);
                yield return new Portfolio(-1.15783156137448, 0.590893742238611);
                yield return new Portfolio(1.67360608794112, 0.114623316085095);
                yield return new Portfolio(-1.04398823978305, -0.418944284341397);
                yield return new Portfolio(0.0146874765920298, -0.558746620672602);
                yield return new Portfolio(0.675321970429067, 1.48262978763307);
                yield return new Portfolio(1.77834230986132, 0.942774111448264);
                yield return new Portfolio(-1.29576363940663, -1.0852038131022);
                yield return new Portfolio(0.0796020218474959, -0.539100814053817);
                yield return new Portfolio(2.2608577144194, 0.673224840266669);
                yield return new Portfolio(0.479090923233913, 1.45477446090542);
                yield return new Portfolio(-0.535019997432816, -0.399174811276031);
                yield return new Portfolio(-0.773129330645406, -0.957174849520677);
                yield return new Portfolio(0.403634339015336, 1.39603816898688);
                yield return new Portfolio(-0.58849643871802, -0.497285090817856);
            }
        }
    }
}
