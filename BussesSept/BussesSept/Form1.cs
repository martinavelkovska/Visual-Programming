using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussesSept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            prosecnaCena();
        }

        private void btnDodadiAvtobus_Click(object sender, EventArgs e)
        {
            AddNewBus addNewBus = new AddNewBus();
            if (addNewBus.ShowDialog() == DialogResult.OK)
            {
                lbAvtobusi.Items.Add(addNewBus.avtobus);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Object> itemsToBeDeleted = new List<Object>();
            DialogResult dialog = MessageBox.Show("Дали сте сигурни дека сакате да го избришете автобусот?", "100% ЛИ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                if (lbAvtobusi.SelectedItems.Count > 0)
                {
                    foreach (var item in lbAvtobusi.SelectedItems)
                    {
                        Bus bus = lbAvtobusi.SelectedItem as Bus;
                        itemsToBeDeleted.Add(bus);

                    }
                    itemsToBeDeleted.ForEach(item => { lbAvtobusi.Items.Remove(item); });
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (lbAvtobusi.SelectedItems.Count > 0)
            {
               
                    Bus bus = lbAvtobusi.SelectedItem as Bus;
                    AddNewLine addNewLine = new AddNewLine();
                    if (addNewLine.ShowDialog() == DialogResult.OK)
                    {
                        bus.linii.Add(addNewLine.linija);
                        lbLinii.Items.Add(addNewLine.linija);
                        prosecnaCena();
                        najskapaLinija();
                }

                
            }
        }

        private void lbAvtobusi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAvtobusi.SelectedItems.Count > 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                lbLinii.Items.Clear();

                Bus bus = lbAvtobusi.SelectedItem as Bus;

                foreach(Linija linii in bus.linii)
                {
                    lbLinii.Items.Add(linii);
                  
                }
                prosecnaCena();
                najskapaLinija();

            }
            else
            {
                lbLinii.Items.Clear();
               button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        public void prosecnaCena()
        {
            int cena = 0;
            int prosek = 0;
            int counter = 0;
            int suma = 0;
            if(lbLinii.Items.Count>0)
            {
               foreach(var item in lbLinii.Items)
                {
                    Linija linija = item as Linija;

                    cena= linija.Cena;
                    counter++;
                    suma += cena;

                }
                 

            }
            if (suma != 0)

            {
                prosek = suma / counter;
                tbProsecnaCenaNaLinii.Text = prosek.ToString();
            }
            else
            {
                tbProsecnaCenaNaLinii.Text = string.Empty;

            }

        }

        public void najskapaLinija()
        {
            Linija najskapaLinija = null; 
            int max = 0;

            if(lbLinii.Items.Count>0)
            {
                foreach(var item in lbLinii.Items)
                {
                    Linija l = item as Linija;

                    if(l.Cena > max)
                    {
                        max = l.Cena;
                        najskapaLinija = l;
                    }

                }

            }

            if (najskapaLinija != null)
            {
                tbNajskapaLinija.Text = najskapaLinija.ToString();


            }
            else
            {
                tbNajskapaLinija.Text = string.Empty;
            }
        }

        private void tbProsecnaCenaNaLinii_TextChanged(object sender, EventArgs e)
        {
            prosecnaCena();
        }

        private void tbNajskapaLinija_TextChanged(object sender, EventArgs e)
        {
            najskapaLinija();
        }
    }
}
