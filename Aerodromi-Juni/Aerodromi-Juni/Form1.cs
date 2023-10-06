using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodromi_Juni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Aerodrom aerodrom = new Aerodrom("Мадрид", "Spanish Airline", "MAD");
            aerodrom.addDestination(new Destinacija("Мароко", 1233, 3223));
          //  Destinacija destinacija = new Destinacija("Мароко", 1233, 3223);
             lbAerodromi.Items.Add(aerodrom); 
           // lbDestinacii.Items.Add(destinacija);
           // lbDestinacii.Items
        }

        private void btnDodadiAerdrom_Click(object sender, EventArgs e)
        {
            AddAerodrom addAerodrom = new AddAerodrom();

            if(addAerodrom.ShowDialog() == DialogResult.OK )
            {
                lbAerodromi.Items.Add(addAerodrom.aerodrom);
            }
        }

        private void btnIzbrisiAerodrom_Click(object sender, EventArgs e)
        {
            List<Object> itemsToBeDeleted = new List<Object>();
            DialogResult dialogResult = MessageBox.Show("Дали сакате да го избришете селектираниот аеродром?", "Дали сте сигурни?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            if(lbAerodromi.SelectedItems.Count > 0 )
            {
               foreach(var item in  lbAerodromi.SelectedItems)
                {
                    itemsToBeDeleted.Add(item);
                }
            }
            if (dialogResult == DialogResult.Yes)
            {
                itemsToBeDeleted.ForEach(item => { lbAerodromi.Items.Remove(item); });
            }
           
        }

        private void btnDodadiDestinacija_Click(object sender, EventArgs e)
        {

            AddDestinacija addDestinacija = new AddDestinacija();
            List<Object> destinacii = new List<object>();
            if(lbAerodromi.SelectedItems.Count > 0 )
            {

                if(addDestinacija.ShowDialog() == DialogResult.OK)
                {
                    Aerodrom aerodrom = lbAerodromi.SelectedItem as Aerodrom;
                    aerodrom.addDestination(addDestinacija.destinacija);
                    lbDestinacii.Items.Add(addDestinacija.destinacija);
                }


            }
        }

        private void total()
        {
            int max = 0;
            double prosek = 0.0;
            int dolzina = 0;
            int counter = 0;
            Destinacija maxDestinacija = null; 
            if(lbDestinacii.Items.Count > 0) { 
            
            foreach(var item in lbDestinacii.Items)
                {
                    Destinacija destinacija = item as Destinacija;
                    int cena = destinacija.Cena;
                     dolzina += destinacija .Dolzina;
                    counter++;
                    if (cena > max)
                    {
                        max = cena;
                        maxDestinacija = destinacija;
                    }
                }
            
            }

            if(maxDestinacija!=null)
            {

                tbNajskapaDestinacija.Text = maxDestinacija.ToString();
                prosek = dolzina / counter;
                tbProsecnaDolzina.Text = prosek.ToString();


            }
            else
            {
                tbProsecnaDolzina.Text = string.Empty;
                tbNajskapaDestinacija.Text = string .Empty;
            }

        }

        private void lbAerodromi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbAerodromi.SelectedItems.Count>0 )
            {
                lbDestinacii.Items.Clear();
                Aerodrom aerodrom = lbAerodromi.SelectedItem as Aerodrom;

                foreach(Destinacija destinacija in aerodrom.destinacii)
                {
                    lbDestinacii.Items.Add(destinacija);

                }
                total();
            }
        }
    }
}
