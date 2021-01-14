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
    public partial class ListingSupports : Form
    {
        public ListingSupports()
        {
            InitializeComponent();
        }

        private void tb_supportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_supportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iss_vente_supportsDataSet);

        }

        private void ListingSupports_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'iss_vente_supportsDataSet.tb_enseignants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tb_enseignantsTableAdapter.Fill(this.iss_vente_supportsDataSet.tb_enseignants);
            // TODO: cette ligne de code charge les données dans la table 'iss_vente_supportsDataSet.tb_supports'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tb_supportsTableAdapter.Fill(this.iss_vente_supportsDataSet.tb_supports);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment enregistrer ce support de cours avec ses details ?", "Enregistrement support",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    tb_supportsTableAdapter.Insert(codeSupportTextBox.Text, prixSupportTextBox .Text , resumeSupportRichTextBox .Text , 
                        pourcSuppTextBox .Text, montantPourcTextBox .Text , Convert.ToDateTime( dateDepotSupportDateTimePicker.Text) , intituleCoursTextBox .Text ,
                        volumeHoraireTextBox .Text , enseignantIDComboBox .Text , promotionIDComboBox .Text , 
                        departementIDComboBox .Text , optionIDComboBox .Text, nomEtudiantAcheteurTextBox .Text  );
                    this.tb_supportsTableAdapter.Fill(this.iss_vente_supportsDataSet.tb_supports);
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
                    this.tb_supportsBindingSource.EndEdit();
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

        private void button3_Click(object sender, EventArgs e)
        {
            double montant, prix, pourcentage;
            prix = Convert.ToDouble(prixSupportTextBox.Text);
            pourcentage = Convert.ToDouble(pourcSuppTextBox.Text);
             try
             {
                 montant = prix * pourcentage / 100;
                 montantPourcTextBox.Text = montant.ToString();
             }
             catch (Exception erreur)
             {
                 MessageBox.Show(erreur.Message);
             }
        }
    }
}
