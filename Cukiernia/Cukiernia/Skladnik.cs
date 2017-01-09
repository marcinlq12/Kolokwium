using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Skladnik
    {
        private string nazwaSkladnika;
        private string ilosc;
        private double cenaSkladnika;
        public Skladnik()
        {
            nazwaSkladnika = "nazwa";
            ilosc = "";
            cenaSkladnika = 0;
        }
        public Skladnik(string _nazwaSkladnika, string _ilosc, double _cenaSkladnika)
        {
            this.nazwaSkladnika = _nazwaSkladnika;
            this.ilosc = _ilosc;
            this.cenaSkladnika = _cenaSkladnika;
        }


        public override string ToString()
        {
            return "Nazwa: " + nazwaSkladnika + " , ilość: " + ilosc + " , cena: " + cenaSkladnika;
        }

        private double CenaSkladnika()
        {
            return cenaSkladnika;
        }


    }
}