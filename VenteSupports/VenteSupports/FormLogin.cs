using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenteSupports
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bureau formation, service comptabilite, Service technique
            if (textBox1.Text == "KANU" && textBox2.Text == "2020")
            {
                MenuGeneralParent accueil_form = new MenuGeneralParent();
                accueil_form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vous devez saisir des identifiants valides.","Erreur connexion", 
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application?", "fermeture", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
