// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Acifluorfen and diquat tested on Lemna minor.
    /// </summary>

    public class acidiq
    {
        public readonly double dose;
        public readonly int pct;
        public readonly double rgr;

        public acidiq(double dose, int pct, double rgr)
        {
            this.dose = dose;
            this.pct = pct;
            this.rgr = rgr;
        }

        public static IEnumerable<acidiq> Data
        {
            get
            {
                yield return new acidiq(0, 999, 0.290467984);
                yield return new acidiq(0, 999, 0.283475624);
                yield return new acidiq(0, 999, 0.29253338);
                yield return new acidiq(0, 999, 0.314109909);
                yield return new acidiq(0, 999, 0.30953829);
                yield return new acidiq(0, 999, 0.319992837);
                yield return new acidiq(0, 999, 0.265553029);
                yield return new acidiq(0, 999, 0.318376138);
                yield return new acidiq(0, 999, 0.298720086);
                yield return new acidiq(0, 999, 0.276370347);
                yield return new acidiq(0, 999, 0.276255277);
                yield return new acidiq(0, 999, 0.270715249);
                yield return new acidiq(39.0625, 100, 0.259036329);
                yield return new acidiq(39.0625, 100, 0.285518054);
                yield return new acidiq(39.0625, 100, 0.271805602);
                yield return new acidiq(78.125, 100, 0.281821544);
                yield return new acidiq(78.125, 100, 0.234175935);
                yield return new acidiq(78.125, 100, 0.261342864);
                yield return new acidiq(156.25, 100, 0.218456403);
                yield return new acidiq(156.25, 100, 0.230292765);
                yield return new acidiq(156.25, 100, 0.22246914);
                yield return new acidiq(312.5, 100, 0.154055007);
                yield return new acidiq(312.5, 100, 0.187270535);
                yield return new acidiq(312.5, 100, 0.189738158);
                yield return new acidiq(625, 100, 0.090941847);
                yield return new acidiq(625, 100, 0.108145294);
                yield return new acidiq(625, 100, 0.116076679);
                yield return new acidiq(1250, 100, 0.056437084);
                yield return new acidiq(1250, 100, 0.081985013);
                yield return new acidiq(1250, 100, 0.04966931);
                yield return new acidiq(2500, 100, 0.037874736);
                yield return new acidiq(2500, 100, 0.026204847);
                yield return new acidiq(2500, 100, 0.022453113);
                yield return new acidiq(5000, 100, 0.02214316);
                yield return new acidiq(5000, 100, 0.020332109);
                yield return new acidiq(5000, 100, 0.030188223);
                yield return new acidiq(39.0625, 83, 0.278315079);
                yield return new acidiq(39.0625, 83, 0.289837301);
                yield return new acidiq(39.0625, 83, 0.293765597);
                yield return new acidiq(78.125, 83, 0.284101801);
                yield return new acidiq(78.125, 83, 0.283384642);
                yield return new acidiq(78.125, 83, 0.300034762);
                yield return new acidiq(156.25, 83, 0.25110808);
                yield return new acidiq(156.25, 83, 0.261114213);
                yield return new acidiq(156.25, 83, 0.268208565);
                yield return new acidiq(312.5, 83, 0.17397585);
                yield return new acidiq(312.5, 83, 0.171768159);
                yield return new acidiq(312.5, 83, 0.202132575);
                yield return new acidiq(625, 83, 0.099932326);
                yield return new acidiq(625, 83, 0.103277413);
                yield return new acidiq(625, 83, 0.118973553);
                yield return new acidiq(1250, 83, 0.11141658);
                yield return new acidiq(1250, 83, 0.02574627);
                yield return new acidiq(1250, 83, 0.083735566);
                yield return new acidiq(2500, 83, 0.019397237);
                yield return new acidiq(2500, 83, 0.043032753);
                yield return new acidiq(2500, 83, 0.017457478);
                yield return new acidiq(5000, 83, 0.011764666);
                yield return new acidiq(5000, 83, 0.011584757);
                yield return new acidiq(5000, 83, 0.020011234);
                yield return new acidiq(39.0625, 67, 0.300678062);
                yield return new acidiq(39.0625, 67, 0.312884914);
                yield return new acidiq(39.0625, 67, 0.308872745);
                yield return new acidiq(78.125, 67, 0.32110467);
                yield return new acidiq(78.125, 67, 0.291186886);
                yield return new acidiq(78.125, 67, 0.280994239);
                yield return new acidiq(156.25, 67, 0.291512326);
                yield return new acidiq(156.25, 67, 0.297225017);
                yield return new acidiq(156.25, 67, 0.304125299);
                yield return new acidiq(312.5, 67, 0.211052337);
                yield return new acidiq(312.5, 67, 0.216344616);
                yield return new acidiq(312.5, 67, 0.225835507);
                yield return new acidiq(625, 67, 0.113616238);
                yield return new acidiq(625, 67, 0.13408326);
                yield return new acidiq(625, 67, 0.134673713);
                yield return new acidiq(1250, 67, 0.06506023);
                yield return new acidiq(1250, 67, 0.080058477);
                yield return new acidiq(1250, 67, 0.077481904);
                yield return new acidiq(2500, 67, 0.037083976);
                yield return new acidiq(2500, 67, 0.034250686);
                yield return new acidiq(2500, 67, 0.030730321);
                yield return new acidiq(5000, 67, 0.010843363);
                yield return new acidiq(5000, 67, 0.031313118);
                yield return new acidiq(5000, 67, 0.010645795);
                yield return new acidiq(39.0625, 50, 0.272104539);
                yield return new acidiq(39.0625, 50, 0.3079467);
                yield return new acidiq(39.0625, 50, 0.299144117);
                yield return new acidiq(78.125, 50, 0.269976506);
                yield return new acidiq(78.125, 50, 0.291972761);
                yield return new acidiq(78.125, 50, 0.282067792);
                yield return new acidiq(156.25, 50, 0.295620125);
                yield return new acidiq(156.25, 50, 0.29275099);
                yield return new acidiq(156.25, 50, 0.310167675);
                yield return new acidiq(312.5, 50, 0.217014363);
                yield return new acidiq(312.5, 50, 0.22793056);
                yield return new acidiq(312.5, 50, 0.239729327);
                yield return new acidiq(625, 50, 0.133773242);
                yield return new acidiq(625, 50, 0.135058105);
                yield return new acidiq(625, 50, 0.160295886);
                yield return new acidiq(1250, 50, 0.057919359);
                yield return new acidiq(1250, 50, 0.053316121);
                yield return new acidiq(1250, 50, 0.058452336);
                yield return new acidiq(2500, 50, 0.038003937);
                yield return new acidiq(2500, 50, 0.027589929);
                yield return new acidiq(2500, 50, 0.046945164);
                yield return new acidiq(5000, 50, 0.027082467);
                yield return new acidiq(5000, 50, 0.025127816);
                yield return new acidiq(5000, 50, 0.024469267);
                yield return new acidiq(39.0625, 33, 0.289102351);
                yield return new acidiq(39.0625, 33, 0.2983662);
                yield return new acidiq(39.0625, 33, 0.292892127);
                yield return new acidiq(78.125, 33, 0.309115286);
                yield return new acidiq(78.125, 33, 0.298838559);
                yield return new acidiq(78.125, 33, 0.331045491);
                yield return new acidiq(156.25, 33, 0.290185156);
                yield return new acidiq(156.25, 33, 0.322843774);
                yield return new acidiq(156.25, 33, 0.310423137);
                yield return new acidiq(312.5, 33, 0.235231529);
                yield return new acidiq(312.5, 33, 0.251748083);
                yield return new acidiq(312.5, 33, 0.220797685);
                yield return new acidiq(625, 33, 0.121511303);
                yield return new acidiq(625, 33, 0.134170119);
                yield return new acidiq(625, 33, 0.116780067);
                yield return new acidiq(1250, 33, 0.076877744);
                yield return new acidiq(1250, 33, 0.084922618);
                yield return new acidiq(1250, 33, 0.064126677);
                yield return new acidiq(2500, 33, 0.059573413);
                yield return new acidiq(2500, 33, 0.069787225);
                yield return new acidiq(2500, 33, 0.068984776);
                yield return new acidiq(5000, 33, 0.051689902);
                yield return new acidiq(5000, 33, 0.044425983);
                yield return new acidiq(5000, 33, 0.039024271);
                yield return new acidiq(39.0625, 17, 0.313129794);
                yield return new acidiq(39.0625, 17, 0.323524444);
                yield return new acidiq(39.0625, 17, 0.343172147);
                yield return new acidiq(78.125, 17, 0.309051085);
                yield return new acidiq(78.125, 17, 0.294035697);
                yield return new acidiq(78.125, 17, 0.3325016);
                yield return new acidiq(156.25, 17, 0.268173281);
                yield return new acidiq(156.25, 17, 0.280556349);
                yield return new acidiq(156.25, 17, 0.277619762);
                yield return new acidiq(312.5, 17, 0.203762698);
                yield return new acidiq(312.5, 17, 0.189458671);
                yield return new acidiq(312.5, 17, 0.195584682);
                yield return new acidiq(625, 17, 0.071840667);
                yield return new acidiq(625, 17, 0.091307609);
                yield return new acidiq(625, 17, 0.096469138);
                yield return new acidiq(1250, 17, 0.059388044);
                yield return new acidiq(1250, 17, 0.063104773);
                yield return new acidiq(1250, 17, 0.050418023);
                yield return new acidiq(2500, 17, 0.024468817);
                yield return new acidiq(2500, 17, 0.029067908);
                yield return new acidiq(2500, 17, 0.056979058);
                yield return new acidiq(5000, 17, 0.028291717);
                yield return new acidiq(5000, 17, 0.017038951);
                yield return new acidiq(5000, 17, 0.022771332);
                yield return new acidiq(39.0625, 0, 0.298005508);
                yield return new acidiq(39.0625, 0, 0.297947914);
                yield return new acidiq(39.0625, 0, 0.282882775);
                yield return new acidiq(78.125, 0, 0.291885573);
                yield return new acidiq(78.125, 0, 0.284005748);
                yield return new acidiq(78.125, 0, 0.276349646);
                yield return new acidiq(156.25, 0, 0.291809317);
                yield return new acidiq(156.25, 0, 0.277442329);
                yield return new acidiq(156.25, 0, 0.273606045);
                yield return new acidiq(312.5, 0, 0.194129594);
                yield return new acidiq(312.5, 0, 0.153751375);
                yield return new acidiq(312.5, 0, 0.172239563);
                yield return new acidiq(625, 0, 0.084272996);
                yield return new acidiq(625, 0, 0.084304599);
                yield return new acidiq(625, 0, 0.093925348);
                yield return new acidiq(1250, 0, 0.051524061);
                yield return new acidiq(1250, 0, 0.030212237);
                yield return new acidiq(1250, 0, 0.069233027);
                yield return new acidiq(2500, 0, 0.044029152);
                yield return new acidiq(2500, 0, 0.041268609);
                yield return new acidiq(2500, 0, 0.036995349);
                yield return new acidiq(5000, 0, 0.034293853);
                yield return new acidiq(5000, 0, 0.020447511);
                yield return new acidiq(5000, 0, 0.014347152);
            }
        }
    }
}
