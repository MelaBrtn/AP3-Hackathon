
namespace AP3_GestionHackathon
{
    partial class FormGestionMembre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbListe = new System.Windows.Forms.ComboBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNomMembre = new System.Windows.Forms.Label();
            this.tbLien = new System.Windows.Forms.TextBox();
            this.lblien = new System.Windows.Forms.Label();
            this.dtDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.BtnAction = new System.Windows.Forms.Button();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.bsMembre = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbIdEntreprise = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ajout d\'un membre";
            // 
            // cbListe
            // 
            this.cbListe.FormattingEnabled = true;
            this.cbListe.Location = new System.Drawing.Point(580, 39);
            this.cbListe.Name = "cbListe";
            this.cbListe.Size = new System.Drawing.Size(323, 24);
            this.cbListe.TabIndex = 28;
            this.cbListe.SelectedIndexChanged += new System.EventHandler(this.cbListe_SelectedIndexChanged);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.textBox2);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.textBox1);
            this.gbInfo.Controls.Add(this.lbIdEntreprise);
            this.gbInfo.Controls.Add(this.dtDateNaiss);
            this.gbInfo.Controls.Add(this.tbLien);
            this.gbInfo.Controls.Add(this.lblien);
            this.gbInfo.Controls.Add(this.tbTel);
            this.gbInfo.Controls.Add(this.lbTel);
            this.gbInfo.Controls.Add(this.lbPassword);
            this.gbInfo.Controls.Add(this.tbPrenom);
            this.gbInfo.Controls.Add(this.lbPrenom);
            this.gbInfo.Controls.Add(this.tbEmail);
            this.gbInfo.Controls.Add(this.lbEmail);
            this.gbInfo.Controls.Add(this.tbNom);
            this.gbInfo.Controls.Add(this.lbNomMembre);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.White;
            this.gbInfo.Location = new System.Drawing.Point(78, 109);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(778, 298);
            this.gbInfo.TabIndex = 29;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informations du membre";
            this.gbInfo.Enter += new System.EventHandler(this.gbInfo_Enter);
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(241, 165);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(126, 24);
            this.tbTel.TabIndex = 10;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(238, 133);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(96, 23);
            this.lbTel.TabIndex = 9;
            this.lbTel.Text = "Téléphone";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(419, 51);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(163, 23);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Date de naissance";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(241, 77);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(117, 24);
            this.tbPrenom.TabIndex = 5;
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(238, 51);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(76, 23);
            this.lbPrenom.TabIndex = 4;
            this.lbPrenom.Text = "Prenom";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(43, 165);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(123, 24);
            this.tbEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(40, 133);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 23);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(43, 77);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(123, 24);
            this.tbNom.TabIndex = 1;
            // 
            // lbNomMembre
            // 
            this.lbNomMembre.AutoSize = true;
            this.lbNomMembre.Location = new System.Drawing.Point(40, 51);
            this.lbNomMembre.Name = "lbNomMembre";
            this.lbNomMembre.Size = new System.Drawing.Size(56, 23);
            this.lbNomMembre.TabIndex = 0;
            this.lbNomMembre.Text = "Nom ";
            // 
            // tbLien
            // 
            this.tbLien.Location = new System.Drawing.Point(422, 165);
            this.tbLien.Name = "tbLien";
            this.tbLien.Size = new System.Drawing.Size(126, 24);
            this.tbLien.TabIndex = 12;
            // 
            // lblien
            // 
            this.lblien.AutoSize = true;
            this.lblien.Location = new System.Drawing.Point(419, 133);
            this.lblien.Name = "lblien";
            this.lblien.Size = new System.Drawing.Size(119, 23);
            this.lblien.TabIndex = 11;
            this.lblien.Text = "Lien Portfolio";
            // 
            // dtDateNaiss
            // 
            this.dtDateNaiss.Location = new System.Drawing.Point(422, 77);
            this.dtDateNaiss.Name = "dtDateNaiss";
            this.dtDateNaiss.Size = new System.Drawing.Size(236, 24);
            this.dtDateNaiss.TabIndex = 13;
            // 
            // BtnAction
            // 
            this.BtnAction.BackColor = System.Drawing.Color.Black;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAction.Location = new System.Drawing.Point(580, 424);
            this.BtnAction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(127, 63);
            this.BtnAction.TabIndex = 30;
            this.BtnAction.Text = "AJOUTER";
            this.BtnAction.UseVisualStyleBackColor = false;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(729, 424);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(127, 63);
            this.BtnFermer.TabIndex = 31;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // bsMembre
            // 
            this.bsMembre.CurrentChanged += new System.EventHandler(this.bsMembre_CurrentChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 24);
            this.textBox1.TabIndex = 15;
            // 
            // lbIdEntreprise
            // 
            this.lbIdEntreprise.AutoSize = true;
            this.lbIdEntreprise.Location = new System.Drawing.Point(40, 220);
            this.lbIdEntreprise.Name = "lbIdEntreprise";
            this.lbIdEntreprise.Size = new System.Drawing.Size(113, 23);
            this.lbIdEntreprise.TabIndex = 14;
            this.lbIdEntreprise.Text = "Id Entreprise";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 246);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 24);
            this.textBox2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Id Equipe";
            // 
            // FormGestionMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(935, 516);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.BtnAction);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.cbListe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionMembre";
            this.Text = "FormGestionMembre";
            this.Load += new System.EventHandler(this.FormGestionMembre_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbListe;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNomMembre;
        private System.Windows.Forms.TextBox tbLien;
        private System.Windows.Forms.Label lblien;
        private System.Windows.Forms.DateTimePicker dtDateNaiss;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.BindingSource bsMembre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbIdEntreprise;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}