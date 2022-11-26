namespace AP3_GestionHackathon
{
    partial class FormGestionHackathon
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
            this.BtnFermer = new System.Windows.Forms.Button();
            this.dtDebut = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbObjectifs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbThematique = new System.Windows.Forms.TextBox();
            this.tbLieu = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbConditions = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbOrganisateur = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAffiche = new System.Windows.Forms.TextBox();
            this.BtnAction = new System.Windows.Forms.Button();
            this.BtnAjoutOrganisateur = new System.Windows.Forms.Button();
            this.BSOrganisateur = new System.Windows.Forms.BindingSource(this.components);
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbnbPlaceMax = new System.Windows.Forms.TextBox();
            this.dtdateButoirInscrip = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbListe = new System.Windows.Forms.ComboBox();
            this.BSListeH = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BSOrganisateur)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSListeH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ajout d\'un Hackathon";
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(860, 416);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(127, 63);
            this.BtnFermer.TabIndex = 4;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // dtDebut
            // 
            this.dtDebut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDebut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDebut.Location = new System.Drawing.Point(31, 46);
            this.dtDebut.Margin = new System.Windows.Forms.Padding(4);
            this.dtDebut.Name = "dtDebut";
            this.dtDebut.Size = new System.Drawing.Size(265, 26);
            this.dtDebut.TabIndex = 5;
            // 
            // dtFin
            // 
            this.dtFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFin.Location = new System.Drawing.Point(31, 114);
            this.dtFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(265, 26);
            this.dtFin.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date Heure de début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date Heure de fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thématique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Objectifs";
            // 
            // tbObjectifs
            // 
            this.tbObjectifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObjectifs.Location = new System.Drawing.Point(348, 114);
            this.tbObjectifs.Margin = new System.Windows.Forms.Padding(4);
            this.tbObjectifs.Multiline = true;
            this.tbObjectifs.Name = "tbObjectifs";
            this.tbObjectifs.Size = new System.Drawing.Size(264, 77);
            this.tbObjectifs.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lieu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ville";
            // 
            // tbThematique
            // 
            this.tbThematique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThematique.Location = new System.Drawing.Point(348, 48);
            this.tbThematique.Margin = new System.Windows.Forms.Padding(4);
            this.tbThematique.Name = "tbThematique";
            this.tbThematique.Size = new System.Drawing.Size(264, 26);
            this.tbThematique.TabIndex = 15;
            // 
            // tbLieu
            // 
            this.tbLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLieu.Location = new System.Drawing.Point(31, 185);
            this.tbLieu.Margin = new System.Windows.Forms.Padding(4);
            this.tbLieu.Name = "tbLieu";
            this.tbLieu.Size = new System.Drawing.Size(264, 26);
            this.tbLieu.TabIndex = 16;
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(32, 261);
            this.tbVille.Margin = new System.Windows.Forms.Padding(4);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(264, 26);
            this.tbVille.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Conditions";
            // 
            // tbConditions
            // 
            this.tbConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConditions.Location = new System.Drawing.Point(348, 238);
            this.tbConditions.Margin = new System.Windows.Forms.Padding(4);
            this.tbConditions.Multiline = true;
            this.tbConditions.Name = "tbConditions";
            this.tbConditions.Size = new System.Drawing.Size(264, 77);
            this.tbConditions.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(637, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Organisateur";
            // 
            // cbOrganisateur
            // 
            this.cbOrganisateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrganisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrganisateur.FormattingEnabled = true;
            this.cbOrganisateur.Location = new System.Drawing.Point(644, 46);
            this.cbOrganisateur.Margin = new System.Windows.Forms.Padding(4);
            this.cbOrganisateur.Name = "cbOrganisateur";
            this.cbOrganisateur.Size = new System.Drawing.Size(261, 28);
            this.cbOrganisateur.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(637, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Affiche";
            // 
            // tbAffiche
            // 
            this.tbAffiche.Location = new System.Drawing.Point(644, 114);
            this.tbAffiche.Margin = new System.Windows.Forms.Padding(4);
            this.tbAffiche.Multiline = true;
            this.tbAffiche.Name = "tbAffiche";
            this.tbAffiche.Size = new System.Drawing.Size(264, 57);
            this.tbAffiche.TabIndex = 23;
            // 
            // BtnAction
            // 
            this.BtnAction.BackColor = System.Drawing.Color.Black;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAction.Location = new System.Drawing.Point(715, 416);
            this.BtnAction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(127, 63);
            this.BtnAction.TabIndex = 24;
            this.BtnAction.Text = "AJOUTER";
            this.BtnAction.UseVisualStyleBackColor = false;
            this.BtnAction.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnAjoutOrganisateur
            // 
            this.BtnAjoutOrganisateur.BackColor = System.Drawing.Color.Black;
            this.BtnAjoutOrganisateur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAjoutOrganisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjoutOrganisateur.ForeColor = System.Drawing.Color.White;
            this.BtnAjoutOrganisateur.Location = new System.Drawing.Point(915, 44);
            this.BtnAjoutOrganisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjoutOrganisateur.Name = "BtnAjoutOrganisateur";
            this.BtnAjoutOrganisateur.Size = new System.Drawing.Size(35, 28);
            this.BtnAjoutOrganisateur.TabIndex = 25;
            this.BtnAjoutOrganisateur.Text = "+";
            this.BtnAjoutOrganisateur.UseVisualStyleBackColor = false;
            this.BtnAjoutOrganisateur.Click += new System.EventHandler(this.BtnAjoutOrganisateur_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tbnbPlaceMax);
            this.gbInfo.Controls.Add(this.dtdateButoirInscrip);
            this.gbInfo.Controls.Add(this.label12);
            this.gbInfo.Controls.Add(this.label11);
            this.gbInfo.Controls.Add(this.dtDebut);
            this.gbInfo.Controls.Add(this.BtnAjoutOrganisateur);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.tbConditions);
            this.gbInfo.Controls.Add(this.tbObjectifs);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.dtFin);
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.tbAffiche);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.cbOrganisateur);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.tbVille);
            this.gbInfo.Controls.Add(this.tbLieu);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label10);
            this.gbInfo.Controls.Add(this.tbThematique);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.White;
            this.gbInfo.Location = new System.Drawing.Point(37, 70);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbInfo.Size = new System.Drawing.Size(971, 338);
            this.gbInfo.TabIndex = 26;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informations de l\'hackathon";
            this.gbInfo.Enter += new System.EventHandler(this.GbInfo_Enter);
            // 
            // tbnbPlaceMax
            // 
            this.tbnbPlaceMax.Location = new System.Drawing.Point(643, 268);
            this.tbnbPlaceMax.Name = "tbnbPlaceMax";
            this.tbnbPlaceMax.Size = new System.Drawing.Size(100, 26);
            this.tbnbPlaceMax.TabIndex = 29;
            // 
            // dtdateButoirInscrip
            // 
            this.dtdateButoirInscrip.CustomFormat = "dd/MM/yyyy";
            this.dtdateButoirInscrip.Location = new System.Drawing.Point(641, 214);
            this.dtdateButoirInscrip.Name = "dtdateButoirInscrip";
            this.dtdateButoirInscrip.Size = new System.Drawing.Size(200, 26);
            this.dtdateButoirInscrip.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(640, 191);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Date Butoir Inscription";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(640, 245);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Nombre de place maximum";
            // 
            // cbListe
            // 
            this.cbListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListe.FormattingEnabled = true;
            this.cbListe.Location = new System.Drawing.Point(401, 18);
            this.cbListe.Margin = new System.Windows.Forms.Padding(4);
            this.cbListe.Name = "cbListe";
            this.cbListe.Size = new System.Drawing.Size(605, 28);
            this.cbListe.TabIndex = 27;
            this.cbListe.SelectedIndexChanged += new System.EventHandler(this.CbListe_SelectedIndexChanged);
            // 
            // BSListeH
            // 
            this.BSListeH.CurrentChanged += new System.EventHandler(this.BSListeH_CurrentChanged);
            // 
            // FormGestionHackathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1035, 482);
            this.Controls.Add(this.cbListe);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.BtnAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGestionHackathon";
            this.Text = "FormGestionHackathon";
            this.Load += new System.EventHandler(this.FormGestionHackathon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BSOrganisateur)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSListeH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.DateTimePicker dtDebut;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbObjectifs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbThematique;
        private System.Windows.Forms.TextBox tbLieu;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbConditions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbOrganisateur;
        private System.Windows.Forms.BindingSource BSOrganisateur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAffiche;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button BtnAjoutOrganisateur;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.ComboBox cbListe;
        private System.Windows.Forms.BindingSource BSListeH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtdateButoirInscrip;
        private System.Windows.Forms.TextBox tbnbPlaceMax;
    }
}