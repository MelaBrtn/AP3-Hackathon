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
    public partial class FormGestionEquipe : Form
    {
        private EtatGestion etat;
        public FormGestionEquipe(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat;
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RemplirListeEquipes()
        {
            cbListe.ValueMember = "idequipe";//permet de stocker l'identifiant
            bsListeE.DataSource = Modele.listeEquipes();
            cbListe.DataSource = bsListeE;
            cbListe.SelectedIndex = -1;
        }

        private void FormGestionEquipe_Load(object sender, EventArgs e)
        {
            RemplirListeEquipes();
            if (etat == EtatGestion.Create) // cas etat create
            {
                label1.Text = "Ajout d'une équipe";
                BtnAction.Text = "AJOUTER";
                gbInfo.Visible = true;
                cbListe.Visible = false;

            }
            if (etat == EtatGestion.Update) // cas etat update
            {
                label1.Text = "Modification d'une équipe";
                BtnAction.Text = "MODIFIER";
                gbInfo.Visible = false;
                cbListe.Visible = true;
                RemplirListeEquipes();
            }
            if (etat == EtatGestion.Delete)// cas etat delete
            {
                label1.Text = "Suppression d'une équipe";
                BtnAction.Text = "Supprimer";
                gbInfo.Visible = false;
                cbListe.Visible = true;
                RemplirListeEquipes();
            }
        }

          private void Annuler()
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }


        private void BtnAction_Click(object sender, EventArgs e)
        {
            string login, nomequipe, lienprototype, password;
            int nbparticipants;

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                nomequipe = textBox1.Text;
                login = textBox3.Text;
                lienprototype = textBox2.Text;
                password = textBox4.Text;
                nbparticipants = Convert.ToInt32(textBox5.Text.ToString());
                if(etat == EtatGestion.Create) // cas de l'ajout
                {
                    if (Modele.AjoutEquipe(nomequipe, login, lienprototype, password, nbparticipants))
                    {
                        MessageBox.Show("Equipe ajouté " + Modele.RetourneDerniereEquipeSaisie());
                        Annuler();
                    }
                }

                if(etat == EtatGestion.Update) //cas de la modification
                {
                    EQUIPE E= (EQUIPE)bsListeE.Current;
                    if (Modele.ModificationEquipe(E.idequipe, nomequipe, login, lienprototype, password, nbparticipants))
                    {
                        MessageBox.Show("Equipe modifié");
                        gbInfo.Visible = false;
                        cbListe.SelectedIndex = -1;
                        Annuler();
                    }
                }

                if (etat == EtatGestion.Delete) // cas de la suppression
                {
                    EQUIPE E = (EQUIPE)bsListeE.Current;
                    if (Modele.SupressionEquipe(E.idequipe, nomequipe, login, lienprototype, password, nbparticipants))
                    {
                        MessageBox.Show("Equipe supprimé");
                        gbInfo.Visible = false;
                        cbListe.SelectedIndex = -1;
                        Annuler();
                    }
                }
            }

            else
            {
                MessageBox.Show("Ajout impossible : Il faut saisir au moins le nom de l'équipe, le lien prototype, le login et le password", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bsListeE_CurrentChanged(object sender, EventArgs e)
        {
            // si un hackathon est sélectionné dans la liste des hackathons
            if (cbListe.SelectedIndex != -1)
            {
                // récupération de l'hackathon sélectionné
                EQUIPE E = (EQUIPE)bsListeE.Current;

                // mise à jour des champs de l'hackathon sélectionné
                textBox1.Text = E.nomequipe;
                textBox2.Text = E.lienprototype;
                textBox3.Text = E.login;
                textBox4.Text = E.password;

                if (E.nbparticipants > 0)
                {
                    textBox5.Text = E.nbparticipants.ToString();
                }
                gbInfo.Visible = true;
            }
            else
                gbInfo.Visible = false;
        }

        private void cbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsListeE_CurrentChanged(sender, e);
        }

        private void gbInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}