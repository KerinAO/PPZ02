using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerin_Anton_Oliver_PPZ02
{
    internal class Alkoholno
    {
        String naziv, kolicina, pakiranje;
        double postotakAlkohola, cijena;

        public override string ToString()
        {
            string ispis = "Naziv: " + this.naziv + "\nKolicina: " + this.kolicina + "\nPakiranje: " + this.pakiranje + "\nPostotak alkohola: " + this.postotakAlkohola + "%" + "\nCijena: " + this.cijena + " kn";
            return ispis;
        }

        public Alkoholno(string naziv, string kolicina, string pakiranje, double postotakAlkohola, double cijena)
        {
            this.Naziv = naziv;
            this.Kolicina = kolicina;
            this.Pakiranje = pakiranje;
            this.PostotakAlkohola = postotakAlkohola;
            this.Cijena = cijena;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public double PostotakAlkohola { get => postotakAlkohola; set => postotakAlkohola = value; }
        public double Cijena { get => cijena; set => cijena = value; }
    }
}
