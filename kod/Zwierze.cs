using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp59
{
    class Zwierze
    {
        
        public Zwierze()
        {

        }

        public Zwierze(int wysokosc,Single masa, Color kolor, int wiek,string nazwa,bool plec)
        {
            Wysokosc = wysokosc;
            Masa = masa;
            Kolor = kolor;
            Wiek = wiek;
            Nazwa = nazwa;
            Plec = plec;

        }

        public int Wysokosc { get; set; }
        public Single Masa { get; set; }
        public Color Kolor { get; set; }
        public int Wiek { get; set; }
        public string Nazwa { get; set; }
        public bool Plec { get; set; }
        public List<Pozywienie> jedzenie = new List<Pozywienie>();  
    }


}
