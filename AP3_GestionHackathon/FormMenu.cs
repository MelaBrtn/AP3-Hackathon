using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_GestionHackathon
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void QUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir vous déconnecter ?", "Demande de confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                new FormMenu().Show();
                this.Hide();
            }
        }

        private void ListeDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHackathon());
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formEnfant);
            panelPrincipal.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void GestionDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Create)); // Form de Gestion en ajout (create)
        }

        private void ModificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Update)); // Form de Gestion en modification (update)
        }

        private void dECONNECTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Etes-vous sûr de vouloir vous déconnecter ?", "Demande de confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                new FormMenu().Show();
                this.Hide();
            }
            
        }

        private void supprimerUnHackathonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Delete)); // Form de Gestion en supression (delete)
        }

        private void listeDesÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEquipes());
        }

        private void ajoutDunÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipe(EtatGestion.Create)); // Form de Gestion Equipe en ajoutant(create)
        }

        private void modificationDesÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipe(EtatGestion.Update)); // Form de Gestion Equipe en modifiante (update)
        }

        private void suppressionDuneÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipe(EtatGestion.Delete)); // Form de Gestion Equipe en supression (delete)
        }

        private void listeDesMembresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMembre());
        }

        private void ajoutDunMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionMembre(EtatGestion.Create)); // Form de Gestion Equipe en ajoutant(create)
        }

        private void modificationDunMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionMembre(EtatGestion.Update)); // Form de Gestion Equipe en modifiante (update)
        }

        private void suppressionDunMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionMembre(EtatGestion.Delete)); // Form de Gestion Equipe en supression (delete)
        }
    }
}
