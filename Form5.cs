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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void racuniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racuniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bnkDataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bnkDataSet1.racuni' table. You can move, or remove it, as needed.
            this.racuniTableAdapter.Fill(this.bnkDataSet1.racuni);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.racuniBindingSource.AddNew();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
          this.racuniBindingSource.RemoveCurrent();
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
            this.racuniBindingSource.EndEdit();
        }
    }
}
