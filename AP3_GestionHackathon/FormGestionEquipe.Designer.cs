
namespace AP3_GestionHackathon
{
    partial class FormGestionEquipe
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbLienProto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNomEquipe = new System.Windows.Forms.Label();
            this.cbListe = new System.Windows.Forms.ComboBox();
            this.BtnAction = new System.Windows.Forms.Button();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.bsListeE = new System.Windows.Forms.BindingSource(this.components);
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ajout d\'une équipe";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.textBox5);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.textBox4);
            this.gbInfo.Controls.Add(this.lbPassword);
            this.gbInfo.Controls.Add(this.textBox3);
            this.gbInfo.Controls.Add(this.lbLogin);
            this.gbInfo.Controls.Add(this.textBox2);
            this.gbInfo.Controls.Add(this.lbLienProto);
            this.gbInfo.Controls.Add(this.textBox1);
            this.gbInfo.Controls.Add(this.lbNomEquipe);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.White;
            this.gbInfo.Location = new System.Drawing.Point(46, 88);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(778, 298);
            this.gbInfo.TabIndex = 4;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informations de l\'équipe";
            this.gbInfo.Enter += new System.EventHandler(this.gbInfo_Enter);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(43, 240);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 24);
            this.textBox5.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de participants";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(396, 165);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 24);
            this.textBox4.TabIndex = 7;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(393, 130);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(100, 18);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Mot de Passe";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(396, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 24);
            this.textBox3.TabIndex = 5;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(393, 42);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(44, 18);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "Login";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 24);
            this.textBox2.TabIndex = 3;
            // 
            // lbLienProto
            // 
            this.lbLienProto.AutoSize = true;
            this.lbLienProto.Location = new System.Drawing.Point(40, 133);
            this.lbLienProto.Name = "lbLienProto";
            this.lbLienProto.Size = new System.Drawing.Size(103, 18);
            this.lbLienProto.TabIndex = 2;
            this.lbLienProto.Text = "Lien Prototype";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 24);
            this.textBox1.TabIndex = 1;
            // 
            // lbNomEquipe
            // 
            this.lbNomEquipe.AutoSize = true;
            this.lbNomEquipe.Location = new System.Drawing.Point(40, 51);
            this.lbNomEquipe.Name = "lbNomEquipe";
            this.lbNomEquipe.Size = new System.Drawing.Size(90, 18);
            this.lbNomEquipe.TabIndex = 0;
            this.lbNomEquipe.Text = "Nom Equipe";
            // 
            // cbListe
            // 
            this.cbListe.FormattingEnabled = true;
            this.cbListe.Location = new System.Drawing.Point(501, 23);
            this.cbListe.Name = "cbListe";
            this.cbListe.Size = new System.Drawing.Size(323, 24);
            this.cbListe.TabIndex = 27;
            this.cbListe.SelectedIndexChanged += new System.EventHandler(this.cbListe_SelectedIndexChanged);
            // 
            // BtnAction
            // 
            this.BtnAction.BackColor = System.Drawing.Color.Black;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAction.Location = new System.Drawing.Point(554, 412);
            this.BtnAction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(127, 63);
            this.BtnAction.TabIndex = 28;
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
            this.BtnFermer.Location = new System.Drawing.Point(697, 412);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(127, 63);
            this.BtnFermer.TabIndex = 29;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // bsListeE
            // 
            this.bsListeE.CurrentChanged += new System.EventHandler(this.bsListeE_CurrentChanged);
            // 
            // FormGestionEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(695, 390);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.BtnAction);
            this.Controls.Add(this.cbListe);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionEquipe";
            this.Text = "FormGestionEquipe";
            this.Load += new System.EventHandler(this.FormGestionEquipe_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.ComboBox cbListe;
        private System.Windows.Forms.Label lbNomEquipe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbLienProto;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.BindingSource bsListeE;
    }
}