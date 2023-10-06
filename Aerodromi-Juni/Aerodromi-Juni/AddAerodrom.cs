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
    public partial class AddAerodrom : Form
    {

        public Aerodrom aerodrom;
        ErrorProvider errorProvider;
        public AddAerodrom()
        {
            InitializeComponent();
        }

        private void btnZacuvaj_Click(object sender, EventArgs e)
        {
            if(tbIme.Text.Length > 0 && tbGrad.Text.Length>0 && tbKratenka.Text.Length==3) {
            aerodrom = new Aerodrom(tbGrad.Text, tbIme.Text, tbKratenka.Text);
            this.DialogResult= DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbGrad_Validating(object sender, CancelEventArgs e)
        {
            if(tbGrad.Text.Length== 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbGrad, "Внеси град!");
            }
            else
            {
                errorProvider1.SetError(tbGrad, null);
            }
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIme, "Внеси име!");
            }
            else
            {
                errorProvider1.SetError(tbGrad, null);
            }
        }

        private void tbKratenka_Validating(object sender, CancelEventArgs e)
        {
            if (tbKratenka.Text.Length != 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbKratenka, "Кратенката мора да содржи 3 букви!");
            }
            else
            {
                errorProvider1.SetError(tbKratenka, null);
            }
        }
    }
}
