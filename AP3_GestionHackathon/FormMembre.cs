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
    public partial class FormMembre : Form
    {
        public FormMembre()
        {
            InitializeComponent();
        }

        private void FormMembre_Load(object sender, EventArgs e)
        {
            bsMembre.DataSource = Modele.listeMembres().Select(x => new { x.idmembre, x.nom, x.prenom, x.email, x.telephone, x.datenaissance, x.lienportfolio, x.EQUIPE.idequipe, x.ENTREPRISE.identreprise });

            dgvMembres.DataSource = bsMembre;
            dgvMembres.Columns[0].HeaderText = "IdMembre";
            dgvMembres.Columns[1].HeaderText = "Nom";
            dgvMembres.Columns[2].HeaderText = "Prénom";
            dgvMembres.Columns[3].HeaderText = "Téléphone";
            dgvMembres.Columns[4].HeaderText = "Date Naissance";
            dgvMembres.Columns[5].HeaderText = "Lien Portfolio";
            dgvMembres.Columns[6].HeaderText = "Id Equipe";
            dgvMembres.Columns[7].HeaderText = "Id Entreprise";
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
