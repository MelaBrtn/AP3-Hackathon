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
    public partial class FormEquipes : Form
    {
        private DateTime idE;

        public FormEquipes()
        {
            InitializeComponent();
        }

        private void FormEquipes_Load(object sender, EventArgs e)
        {
            BSEquipe.DataSource = Modele.listeEquipes().Select(x => new { x.idequipe, x.nomequipe, x.lienprototype, x.nbparticipants, x.login})
                           .OrderBy(x => x.idequipe);

            dgvEquipes.DataSource = BSEquipe;
            dgvEquipes.Columns[0].HeaderText = "IdEquipe";
            dgvEquipes.Columns[1].HeaderText = "Nom Equipe";
            dgvEquipes.Columns[2].HeaderText = "Lien Prototype";
            dgvEquipes.Columns[3].HeaderText = "Nb Participants";
            dgvEquipes.Columns[4].HeaderText = "Login";
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btndesinscrire_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir désinscrire cette équipe ?", "Demande de confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Modele.DesinscrireEquipe();
            }
            else
            {
                new FormEquipes().Show();
                this.Hide();
            }
        }
    }
}
