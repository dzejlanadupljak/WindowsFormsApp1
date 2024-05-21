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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void kreditiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kreditiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bnkDataSet1);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bnkDataSet1.krediti' table. You can move, or remove it, as needed.
            this.kreditiTableAdapter.Fill(this.bnkDataSet1.krediti);

        }

        private void klijenat_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void klijenat_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void krediti_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kolicina_kreditaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.kreditiBindingSource.AddNew();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            this.kreditiBindingSource.RemoveCurrent();
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

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kreditiBindingSource.EndEdit();
        }
    }
}
