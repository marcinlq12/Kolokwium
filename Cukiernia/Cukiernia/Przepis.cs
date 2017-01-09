using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Przepis : Skladnik
    {
        private string nazwa;
        private double suma = 0;
        private int czasPrzygotowania;
        private List<Skladnik> skladniki = new List<Skladnik>();
        private void DodajSkladnik(string nazwa, string ilosc, double cena)
        {
            skladniki.Add(new Skladnik(nazwa, ilosc, cena));
            suma += cena;
        }

        private void UstawNazweICzas(string nazwa, int czas)
        {
            this.nazwa = nazwa;
            this.czasPrzygotowania = czas;
        }

        public override string ToString()
        {
            Console.WriteLine("Przepis:: \n");

            if (skladniki.Any())
            {
                foreach (var x in skladniki)
                {
                    Console.WriteLine(x.ToString());

                }
                Console.WriteLine("Suma: " + suma);
            }
            else
            {
                return "";
            }
            return "";


        }
        private bool CzyCzas()
        {
            if (czasPrzygotowania > 0)
            {
                return true;
            }
            else return false;
        }

        //doskończenia!
        private int IleSkladnikow()
        {
            return skladniki.Count();
        }
    }
}