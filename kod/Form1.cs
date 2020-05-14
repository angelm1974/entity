using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp59
{
    public partial class Form1 : Form
    {
        //List<Zwierze> listaSsakow = new List<Zwierze>();
        Dictionary<string, Zwierze> listaSsakow = new Dictionary<string, Zwierze>();
        public Form1()
        {
            InitializeComponent();
        }
 
        Pilot klikniety;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            klikniety = new Pilot(this);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(klikniety.KlawiszDol);
            Pilot Vectra = new Pilot(ZnaneKolory.Zielony, 33);
            zaladujZwierzeta();
         }

        private void zaladujZwierzeta()
        {
            Zwierze wielblad = new Zwierze(2, 600, Color.Black,25, "Mustafa", true);
            Zwierze krowa = new Zwierze(2, 800, Color.WhiteSmoke, 18, "Mućka", false);

            listaSsakow.Add("wielbłąd 01", wielblad);
            listaSsakow.Add("krowa 01", krowa);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<Zwierze> zwierzeGrid = new List<Zwierze>();

            foreach (var item in listaSsakow)
            {
                zwierzeGrid.Add(item.Value);
            }
            zwierzeBindingSource.DataSource = zwierzeGrid.ToList();
          //  dataGridView1.DataSource = zwierzeGrid.ToList();
            
            
            //MessageBox.Show(klikniety.key);
        }

    }
}
