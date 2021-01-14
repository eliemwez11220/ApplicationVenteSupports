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
    public partial class ListingEnseignants : Form
    {
        public ListingEnseignants()
        {
            InitializeComponent();
        }

        private void tb_enseignantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_enseignantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iss_vente_supportsDataSet);

        }

        private void ListingEnseignants_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'iss_vente_supportsDataSet.tb_enseignants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tb_enseignantsTableAdapter.Fill(this.iss_vente_supportsDataSet.tb_enseignants);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment enregistrer ce support de cours avec ses details ?", "Enregistrement support",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    tb_enseignantsTableAdapter.Insert(matriculeEnseignantTextBox .Text, nomCompletTextBox .Text,gradeEnseignantTextBox.Text,
                       fonctionEnseignantTextBox .Text,numeroTelephoneTextBox .Text,adresseMaisonTextBox .Text, 
                       adresseBureauTextBox .Text ,departementIDComboBox.Text);
                    this.tb_enseignantsTableAdapter.Fill(this.iss_vente_supportsDataSet.tb_enseignants);
                    MessageBox.Show("Enregistrement effectué", "Enregistrement",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Modifier cet Enregistrement ?", "Modification",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Validate();
                    this.tb_enseignantsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.iss_vente_supportsDataSet);
                    MessageBox.Show("Modification des informations effectuée avec succès", "Modification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
        }
    }
}
