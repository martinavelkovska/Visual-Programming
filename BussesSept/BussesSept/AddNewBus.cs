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
    public partial class AddNewBus : Form
    {
        public Bus avtobus { get; set; }
        public ErrorProvider errorprovider { get; set; }
        public AddNewBus()
        {
            InitializeComponent();
        }

        private void btnZacuvaj_Click(object sender, EventArgs e)
        {
            if(tbIme.Text.Length > 0 && tbRegistracija.Text.Length ==4)
            {
                int r = int.Parse(tbRegistracija.Text);
                bool k = cbLokalen.Checked;
                avtobus = new Bus(tbIme.Text, r, k);

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

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if(tbIme.Text.Length <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIme, "Внеси Име!");
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
            }
        }

        private void tbRegistracija_Validating(object sender, CancelEventArgs e)
        {
            if (tbRegistracija.Text.Length <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbRegistracija, "Внеси Регистрација!");
            }
            else
            {
                errorProvider1.SetError(tbRegistracija, null);
            }
        }
    }
}
