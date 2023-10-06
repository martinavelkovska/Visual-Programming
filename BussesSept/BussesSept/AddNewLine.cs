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
    public partial class AddNewLine : Form
    {
        public Linija linija { get; set ; }
        public AddNewLine()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if(tbDestinacija.Text.Length > 0 && nudCena.Value !=0 ) { 
                linija = new Linija(tbDestinacija.Text, (int)nudCas.Value, (int)nudMinuta.Value, (int)nudCena.Value);
                DialogResult = DialogResult.OK;

            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.Cancel;
        }
    }
}
