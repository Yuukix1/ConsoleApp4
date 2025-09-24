using System;

namespace Butorgyar
{
    public class Butorlap
    {

        public const int TartolapArNm = 5000;
        public const int HatlapArNm = 500;

        public double HosszM { get; }
        public double SzelessegM { get; }
        public string Tipus { get; }


        public Butorlap(string tipus, double hosszCm, double szelessegCm)
        {
            Tipus = tipus.ToLower();
            HosszM = hosszCm / 100.0;
            SzelessegM = szelessegCm / 100.0;
        }

        public int ArSzamol()
        {
            double terulet = HosszM * SzelessegM;
            int egysegar = (Tipus == "tartolap") ? TartolapArNm : HatlapArNm;
            return (int)Math.Round(terulet * egysegar);
        }
    }
}
