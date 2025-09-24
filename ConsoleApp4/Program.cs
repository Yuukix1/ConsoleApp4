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

    public class Butor
    {
        private readonly Butorlap[] lapok;
        private int lapokSzama;

        public Butor(int kapacitas = 100)
        {
            lapok = new Butorlap[kapacitas];
            lapokSzama = 0;
        }

        public bool LapHozzaad(Butorlap lap)
        {
            if (lapokSzama >= lapok.Length) return false;
            lapok[lapokSzama++] = lap;
            return true;
        }

        public int ArSzamol()
        {
            int osszes = 0;
            for (int i = 0; i < lapokSzama; i++)
                osszes += lapok[i].ArSzamol();
            return osszes;
        }

        public override string ToString()
        {
            return $"Butor - lapok: {lapokSzama}, ar {ArSzamol()} Ft";
        }
    }
}