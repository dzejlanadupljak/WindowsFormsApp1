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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Button1(object sender, EventArgs e)
        {
            Form2 Kartice = new Form2();
            Kartice.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Klijenti = new Form3();
            Klijenti.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Krediti = new Form4();
            Krediti.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Racuni = new Form5();
            Racuni.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Potvrdite ako zelite izlazak!", "Izlazak", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();

            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "1" && txtPassword.Text == "2")
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Unesite podatke!", "Login");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
              
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
