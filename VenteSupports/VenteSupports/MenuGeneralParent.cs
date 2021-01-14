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
    public partial class MenuGeneralParent : Form
    {
        private int childFormNumber = 0;

        public MenuGeneralParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application?", "fermeture", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void aproposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ce systeme de mise en place d’une application informatique de gestion du processus de vente de supports de cours dans une institution universitaire a ete concue par l'etudiante DVKanu", "A propos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void supportCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListingSupports formateur = new ListingSupports();
            formateur.MdiParent = this;
            formateur.Show();
        }

        private void enseignantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListingEnseignants ens = new ListingEnseignants();
            ens.MdiParent = this;
            ens.Show();
        }

        private void aProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ce systeme de mise en place d’une application informatique de gestion du processus de vente de supports de cours dans une institution universitaire a ete concue par l'etudiante DVKanu", "A propos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pour tout contact, Appelez l'auteur au +243 977 090 011 ouu ecrivez-nous par mail contact@trecazad.com", "Guide", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void nouvelEnseignantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListingEnseignants ens = new ListingEnseignants();
            ens.MdiParent = this;
            ens.Show();
        }

        private void listingEnseignantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListingEnseignants ens = new ListingEnseignants();
            ens.MdiParent = this;
            ens.Show();
        }

        private void nouvelleDistributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListingSupports formateur = new ListingSupports();
            formateur.MdiParent = this;
            formateur.Show();
        }

        private void listeDesSupportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListingSupports formateur = new ListingSupports();
            formateur.MdiParent = this;
            formateur.Show();
        }
    }
}
