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
    public partial class FormGestionMembre : Form
    {
        private EtatGestion etat;
        public FormGestionMembre(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat;
        }
        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RemplirListeMembres()
        {
            cbListe.ValueMember = "idmembre"; //permet de stocker l'identifiant
            bsMembre.DataSource = Modele.listeMembres();
            cbListe.DataSource = bsMembre;
            cbListe.SelectedIndex = -1;
        }
        private void FormGestionMembre_Load(object sender, EventArgs e)
        {
            RemplirListeMembres();
            if (etat == EtatGestion.Create) // cas etat create
            {
                label1.Text = "Ajout d'un membre";
                BtnAction.Text = "AJOUTER";
                gbInfo.Visible = true;
                cbListe.Visible = false;
            }

            if (etat == EtatGestion.Update) // cas etat update
            {
                label1.Text = "Modification d'un membre";
                BtnAction.Text = "MODIFIER";
                gbInfo.Visible = false;
                cbListe.Visible = true;
                RemplirListeMembres();
            }
            if (etat == EtatGestion.Delete)// cas etat delete
            {
                label1.Text = "Suppression d'un membre";
                BtnAction.Text = "Supprimer";
                gbInfo.Visible = false;
                cbListe.Visible = true;
                RemplirListeMembres();
            }
        }

        private void Annuler()
        {
            tbNom.Clear();
            tbPrenom.Clear();
            tbEmail.Clear();
            tbTel.Clear();
            tbLien.Clear();
            dtDateNaiss.Value = DateTime.Now;
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            string nom, prenom, email, telephone, lienportfolio;
            int identreprise, idequipe;
            DateTime datenaissance;

            if (tbNom.Text !="" && tbPrenom.Text !="" && tbEmail.Text !="" && tbTel.Text !="")
            {
                nom = tbNom.Text;
                prenom = tbPrenom.Text;
                email = tbEmail.Text;
                telephone = tbTel.Text;
                lienportfolio = tbLien.Text;
                datenaissance = dtDateNaiss.Value;
                identreprise = Convert.ToInt32(textBox1.Text.ToString());
                idequipe = Convert.ToInt32(textBox2.Text.ToString());

                if (etat == EtatGestion.Create) // cas de l'ajout
                {
                    if (Modele.AjoutMembre(nom, prenom, telephone, datenaissance, lienportfolio, idequipe, identreprise))
                    {
                        MessageBox.Show("Membre ajouté " + Modele.RetourneDernierMembreSaisi());
                        Annuler();
                    }
                }
                if (etat == EtatGestion.Update) // cas de la mise à jour
                {
                    MEMBRE M = (MEMBRE)bsMembre.Current;
                    if (Modele.ModificationMembre(M.idmembre, nom, prenom, telephone, datenaissance, lienportfolio, idequipe, identreprise))
                    {
                        MessageBox.Show("Membre Modifié");
                        gbInfo.Visible = false;
                        cbListe.SelectedIndex = -1;
                        Annuler();
                    }
                }
                if (etat == EtatGestion.Delete) // cas de la suppression
                {
                    MEMBRE M = (MEMBRE)bsMembre.Current;
                    if (Modele.SupressionMembre(M.idmembre, nom, prenom, telephone, datenaissance, lienportfolio, idequipe, identreprise))
                    {
                        MessageBox.Show("Membre supprimé");
                        gbInfo.Visible = false;
                        cbListe.SelectedIndex = -1;
                        Annuler();
                    }
                }

            }
            else
            {
                MessageBox.Show("Ajout impossible : Il faut saisir au moins le nom, le prénom, l'email et le téléphone", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bsMembre_CurrentChanged(object sender, EventArgs e)
        {
            // si un hackathon est sélectionné dans la liste des hackathons
            if (cbListe.SelectedIndex != -1)
            {
                // récupération du membre sélectionné
                MEMBRE M = (MEMBRE)bsMembre.Current;

                // mise à jour des champs du membre sélectionné
                tbNom.Text = M.nom;
                tbPrenom.Text = M.prenom;
                tbEmail.Text = M.email;
                tbTel.Text = M.telephone;
                tbLien.Text = M.lienportfolio;
                dtDateNaiss.Value = (DateTime)M.datenaissance;

                gbInfo.Visible = true;
            }
            else
                gbInfo.Visible = false;
        }

        private void cbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsMembre_CurrentChanged(sender, e);
        }

        private void gbInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
