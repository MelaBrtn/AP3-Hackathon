using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace AP3_GestionHackathon
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {

            if (Modele.Authentification(tbEmail.Text, tbPassword.Text))
            {

                new FormMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Votre email ou mot de passe est incorrecte !");
                tbEmail.Clear();
                tbPassword.Clear();
                tbEmail.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEmail.Clear();
            tbPassword.Clear();
            tbEmail.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
