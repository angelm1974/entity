using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp59
{
    class Pilot
    {
        public Pilot()
        {
            Power = false;
        }

        public Pilot(Control control)
        {
            _control = control;

            _control.KeyPress += KlawiszDol;
        }

        public Pilot(bool Baterie) :this()
        {

        }

        public Pilot(Color kolor, int waga)
        {
            Kolor = kolor;
            Waga = waga;
        }

        public Pilot(ZnaneKolory znanykolor, int waga)
        {
            ZnanyKolor = znanykolor;
            Waga = waga;
        }

        /// <summary>
        /// Metoda pozwalająca na włączenie pilota
        /// </summary>
        public void PowerToggle()
        {
            Power = !Power;
        }

        public void KlawiszDol(object sender, KeyPressEventArgs e)
        {
            key = e.KeyChar.ToString();
        }

        public string key = "";
        private Control _control;
        public ZnaneKolory ZnanyKolor { get; set; }
        public Color Kolor { get; set; }
        public int Waga { get; set; }
        bool Power { get; set; }
    }

    enum ZnaneKolory
    {
        Biały,
        Zielony,
        Czerwony,
        Żółty,
        Różowy
    }
}
