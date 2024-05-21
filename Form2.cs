using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void karticeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.karticeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bnkDataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bnkDataSet1.kartice' table. You can move, or remove it, as needed.
            this.karticeTableAdapter.Fill(this.bnkDataSet1.kartice);

        }

        private void kartice_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Potvrdite ako zelite izlazak!", "Izlazak", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.karticeBindingSource.AddNew();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            this.karticeBindingSource.RemoveCurrent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.karticeBindingSource.EndEdit();
            ///this.tableAdapterManager.UpdateAll(this.karticeDataSet);
        }
    }
}
