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
    public partial class AddDestinacija : Form
    {

       public Destinacija destinacija;
        ErrorProvider errorProvider;
        public AddDestinacija()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if(tbGrad.Text.Length > 0) {
            
                destinacija = new Destinacija(tbGrad.Text, (int)nudDolzina.Value, (int) nudCena.Value );
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult= DialogResult.Cancel;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbGrad_Validating(object sender, CancelEventArgs e)
        {
            if(tbGrad.Text.Length == 0) { 
            
            e.Cancel = true;
                errorProvider1.SetError(tbGrad, "Внеси име!");
            }
            else
            {
                errorProvider1.SetError(tbGrad, null);
            }
        }
    }
}
