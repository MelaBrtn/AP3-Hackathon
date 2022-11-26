
namespace AP3_GestionHackathon
{
    partial class FormMembre
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
            this.dgvMembres = new System.Windows.Forms.DataGridView();
            this.bsMembre = new System.Windows.Forms.BindingSource(this.components);
            this.BtnFermer = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liste des Membres";
            // 
            // dgvMembres
            // 
            this.dgvMembres.AllowUserToAddRows = false;
            this.dgvMembres.AllowUserToDeleteRows = false;
            this.dgvMembres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembres.Location = new System.Drawing.Point(55, 91);
            this.dgvMembres.Name = "dgvMembres";
            this.dgvMembres.ReadOnly = true;
            this.dgvMembres.RowHeadersWidth = 51;
            this.dgvMembres.RowTemplate.Height = 24;
            this.dgvMembres.Size = new System.Drawing.Size(1176, 370);
            this.dgvMembres.TabIndex = 5;
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(1104, 468);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(127, 63);
            this.BtnFermer.TabIndex = 6;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "idmembre",
            "nom",
            "prenom",
            "identreprise"});
            this.checkedListBox1.Location = new System.Drawing.Point(339, 14);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(152, 55);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "votre recherche";
            // 
            // FormMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1288, 544);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.dgvMembres);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMembre";
            this.Text = "FormMembre";
            this.Load += new System.EventHandler(this.FormMembre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMembres;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.BindingSource bsMembre;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}