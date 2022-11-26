namespace AP3_GestionHackathon
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.hACKATHONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesHackathonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesHackathonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnHackathonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQUIPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesÉquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationDesÉquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionDuneÉquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBRESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMembresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationDunMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionDunMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUITTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dECONNECTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripPrincipal.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hACKATHONToolStripMenuItem,
            this.eQUIPEToolStripMenuItem,
            this.mEMBRESToolStripMenuItem,
            this.qUITTERToolStripMenuItem,
            this.dECONNECTIONToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(1067, 28);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // hACKATHONToolStripMenuItem
            // 
            this.hACKATHONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesHackathonsToolStripMenuItem,
            this.gestionDesHackathonsToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.supprimerUnHackathonToolStripMenuItem});
            this.hACKATHONToolStripMenuItem.Name = "hACKATHONToolStripMenuItem";
            this.hACKATHONToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.hACKATHONToolStripMenuItem.Text = "HACKATHON";
            // 
            // listeDesHackathonsToolStripMenuItem
            // 
            this.listeDesHackathonsToolStripMenuItem.Name = "listeDesHackathonsToolStripMenuItem";
            this.listeDesHackathonsToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.listeDesHackathonsToolStripMenuItem.Text = "Liste des hackathons";
            this.listeDesHackathonsToolStripMenuItem.Click += new System.EventHandler(this.ListeDesHackathonsToolStripMenuItem_Click);
            // 
            // gestionDesHackathonsToolStripMenuItem
            // 
            this.gestionDesHackathonsToolStripMenuItem.Name = "gestionDesHackathonsToolStripMenuItem";
            this.gestionDesHackathonsToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.gestionDesHackathonsToolStripMenuItem.Text = "Ajout d\'un hackathon";
            this.gestionDesHackathonsToolStripMenuItem.Click += new System.EventHandler(this.GestionDesHackathonsToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.modificationToolStripMenuItem.Text = "Modification d\'un hackathon";
            this.modificationToolStripMenuItem.Click += new System.EventHandler(this.ModificationToolStripMenuItem_Click);
            // 
            // supprimerUnHackathonToolStripMenuItem
            // 
            this.supprimerUnHackathonToolStripMenuItem.Name = "supprimerUnHackathonToolStripMenuItem";
            this.supprimerUnHackathonToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.supprimerUnHackathonToolStripMenuItem.Text = "Supprimer un hackathon";
            this.supprimerUnHackathonToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnHackathonToolStripMenuItem_Click);
            // 
            // eQUIPEToolStripMenuItem
            // 
            this.eQUIPEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesÉquipesToolStripMenuItem,
            this.ajoutDunÉquipeToolStripMenuItem,
            this.modificationDesÉquipesToolStripMenuItem,
            this.suppressionDuneÉquipesToolStripMenuItem});
            this.eQUIPEToolStripMenuItem.Name = "eQUIPEToolStripMenuItem";
            this.eQUIPEToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.eQUIPEToolStripMenuItem.Text = "EQUIPE";
            // 
            // listeDesÉquipesToolStripMenuItem
            // 
            this.listeDesÉquipesToolStripMenuItem.Name = "listeDesÉquipesToolStripMenuItem";
            this.listeDesÉquipesToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.listeDesÉquipesToolStripMenuItem.Text = "Liste des équipes";
            this.listeDesÉquipesToolStripMenuItem.Click += new System.EventHandler(this.listeDesÉquipesToolStripMenuItem_Click);
            // 
            // ajoutDunÉquipeToolStripMenuItem
            // 
            this.ajoutDunÉquipeToolStripMenuItem.Name = "ajoutDunÉquipeToolStripMenuItem";
            this.ajoutDunÉquipeToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.ajoutDunÉquipeToolStripMenuItem.Text = "Ajout d\'une équipe";
            this.ajoutDunÉquipeToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunÉquipeToolStripMenuItem_Click);
            // 
            // modificationDesÉquipesToolStripMenuItem
            // 
            this.modificationDesÉquipesToolStripMenuItem.Name = "modificationDesÉquipesToolStripMenuItem";
            this.modificationDesÉquipesToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.modificationDesÉquipesToolStripMenuItem.Text = "Modification d\'une équipe";
            this.modificationDesÉquipesToolStripMenuItem.Click += new System.EventHandler(this.modificationDesÉquipesToolStripMenuItem_Click);
            // 
            // suppressionDuneÉquipesToolStripMenuItem
            // 
            this.suppressionDuneÉquipesToolStripMenuItem.Name = "suppressionDuneÉquipesToolStripMenuItem";
            this.suppressionDuneÉquipesToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.suppressionDuneÉquipesToolStripMenuItem.Text = "Suppression d\'une équipe";
            this.suppressionDuneÉquipesToolStripMenuItem.Click += new System.EventHandler(this.suppressionDuneÉquipesToolStripMenuItem_Click);
            // 
            // mEMBRESToolStripMenuItem
            // 
            this.mEMBRESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesMembresToolStripMenuItem,
            this.ajoutDunMembreToolStripMenuItem,
            this.modificationDunMembreToolStripMenuItem,
            this.suppressionDunMembreToolStripMenuItem});
            this.mEMBRESToolStripMenuItem.Name = "mEMBRESToolStripMenuItem";
            this.mEMBRESToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.mEMBRESToolStripMenuItem.Text = "MEMBRES";
            // 
            // listeDesMembresToolStripMenuItem
            // 
            this.listeDesMembresToolStripMenuItem.Name = "listeDesMembresToolStripMenuItem";
            this.listeDesMembresToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.listeDesMembresToolStripMenuItem.Text = "Liste des membres";
            this.listeDesMembresToolStripMenuItem.Click += new System.EventHandler(this.listeDesMembresToolStripMenuItem_Click);
            // 
            // ajoutDunMembreToolStripMenuItem
            // 
            this.ajoutDunMembreToolStripMenuItem.Name = "ajoutDunMembreToolStripMenuItem";
            this.ajoutDunMembreToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.ajoutDunMembreToolStripMenuItem.Text = "Ajout d\'un membre";
            this.ajoutDunMembreToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunMembreToolStripMenuItem_Click);
            // 
            // modificationDunMembreToolStripMenuItem
            // 
            this.modificationDunMembreToolStripMenuItem.Name = "modificationDunMembreToolStripMenuItem";
            this.modificationDunMembreToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.modificationDunMembreToolStripMenuItem.Text = "Modification d\'un membre";
            this.modificationDunMembreToolStripMenuItem.Click += new System.EventHandler(this.modificationDunMembreToolStripMenuItem_Click);
            // 
            // suppressionDunMembreToolStripMenuItem
            // 
            this.suppressionDunMembreToolStripMenuItem.Name = "suppressionDunMembreToolStripMenuItem";
            this.suppressionDunMembreToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.suppressionDunMembreToolStripMenuItem.Text = "Suppression d\'un membre";
            this.suppressionDunMembreToolStripMenuItem.Click += new System.EventHandler(this.suppressionDunMembreToolStripMenuItem_Click);
            // 
            // qUITTERToolStripMenuItem
            // 
            this.qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            this.qUITTERToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.qUITTERToolStripMenuItem.Text = "QUITTER";
            this.qUITTERToolStripMenuItem.Click += new System.EventHandler(this.QUITTERToolStripMenuItem_Click);
            // 
            // dECONNECTIONToolStripMenuItem
            // 
            this.dECONNECTIONToolStripMenuItem.Name = "dECONNECTIONToolStripMenuItem";
            this.dECONNECTIONToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.dECONNECTIONToolStripMenuItem.Text = "SE DECONNECTER";
            this.dECONNECTIONToolStripMenuItem.Click += new System.EventHandler(this.dECONNECTIONToolStripMenuItem_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FloralWhite;
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 34);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1067, 521);
            this.panelPrincipal.TabIndex = 1;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1047, 517);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.Text = "HACKAT\'INNOV";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem hACKATHONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQUIPEToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem dECONNECTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnHackathonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesÉquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationDesÉquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionDuneÉquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBRESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesMembresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationDunMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionDunMembreToolStripMenuItem;
    }
}