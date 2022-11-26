
namespace AP3_GestionHackathon
{
    partial class FormEquipes
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
            this.dgvEquipes = new System.Windows.Forms.DataGridView();
            this.BSEquipe = new System.Windows.Forms.BindingSource(this.components);
            this.BtnFermer = new System.Windows.Forms.Button();
            this.BSMembre = new System.Windows.Forms.BindingSource(this.components);
            this.btndesinscrire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste des Equipes";
            // 
            // dgvEquipes
            // 
            this.dgvEquipes.AllowUserToAddRows = false;
            this.dgvEquipes.AllowUserToDeleteRows = false;
            this.dgvEquipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipes.Location = new System.Drawing.Point(44, 67);
            this.dgvEquipes.Name = "dgvEquipes";
            this.dgvEquipes.ReadOnly = true;
            this.dgvEquipes.RowHeadersWidth = 51;
            this.dgvEquipes.RowTemplate.Height = 24;
            this.dgvEquipes.Size = new System.Drawing.Size(941, 318);
            this.dgvEquipes.TabIndex = 0;
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(858, 397);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(127, 63);
            this.BtnFermer.TabIndex = 4;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // btndesinscrire
            // 
            this.btndesinscrire.BackColor = System.Drawing.Color.Black;
            this.btndesinscrire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndesinscrire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesinscrire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndesinscrire.Location = new System.Drawing.Point(695, 397);
            this.btndesinscrire.Margin = new System.Windows.Forms.Padding(4);
            this.btndesinscrire.Name = "btndesinscrire";
            this.btndesinscrire.Size = new System.Drawing.Size(127, 63);
            this.btndesinscrire.TabIndex = 5;
            this.btndesinscrire.Text = "Désinscrire";
            this.btndesinscrire.UseVisualStyleBackColor = false;
            this.btndesinscrire.Click += new System.EventHandler(this.btndesinscrire_Click);
            // 
            // FormEquipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1045, 473);
            this.Controls.Add(this.btndesinscrire);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.dgvEquipes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEquipes";
            this.Text = "Gestion des équipes";
            this.Load += new System.EventHandler(this.FormEquipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSMembre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEquipes;
        private System.Windows.Forms.BindingSource BSEquipe;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.BindingSource BSMembre;
        private System.Windows.Forms.Button btndesinscrire;
    }
}