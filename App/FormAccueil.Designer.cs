namespace App
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.gbConnexion = new System.Windows.Forms.GroupBox();
            this.tbMdpConnex = new System.Windows.Forms.TextBox();
            this.tbLoginConnex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAdminConnex = new System.Windows.Forms.RadioButton();
            this.rbUserConnex = new System.Windows.Forms.RadioButton();
            this.gbCreation = new System.Windows.Forms.GroupBox();
            this.tbMdpCrea = new System.Windows.Forms.TextBox();
            this.tbLoginCrea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbAdminCrea = new System.Windows.Forms.RadioButton();
            this.rbUserCrea = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnCreation = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.gbConnexion.SuspendLayout();
            this.gbCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnexion
            // 
            this.gbConnexion.Controls.Add(this.gbCreation);
            this.gbConnexion.Controls.Add(this.tbMdpConnex);
            this.gbConnexion.Controls.Add(this.tbLoginConnex);
            this.gbConnexion.Controls.Add(this.label3);
            this.gbConnexion.Controls.Add(this.label2);
            this.gbConnexion.Controls.Add(this.label1);
            this.gbConnexion.Controls.Add(this.rbAdminConnex);
            this.gbConnexion.Controls.Add(this.rbUserConnex);
            this.gbConnexion.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbConnexion.Location = new System.Drawing.Point(86, 253);
            this.gbConnexion.Name = "gbConnexion";
            this.gbConnexion.Size = new System.Drawing.Size(524, 150);
            this.gbConnexion.TabIndex = 0;
            this.gbConnexion.TabStop = false;
            this.gbConnexion.Text = "Informations de connexion";
            this.gbConnexion.Visible = false;
            // 
            // tbMdpConnex
            // 
            this.tbMdpConnex.Location = new System.Drawing.Point(228, 119);
            this.tbMdpConnex.Name = "tbMdpConnex";
            this.tbMdpConnex.PasswordChar = '*';
            this.tbMdpConnex.Size = new System.Drawing.Size(100, 24);
            this.tbMdpConnex.TabIndex = 6;
            this.tbMdpConnex.TextChanged += new System.EventHandler(this.tbMdpConnex_TextChanged);
            // 
            // tbLoginConnex
            // 
            this.tbLoginConnex.Location = new System.Drawing.Point(228, 89);
            this.tbLoginConnex.Name = "tbLoginConnex";
            this.tbLoginConnex.Size = new System.Drawing.Size(100, 24);
            this.tbLoginConnex.TabIndex = 5;
            this.tbLoginConnex.TextChanged += new System.EventHandler(this.tbLoginConnex_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.Location = new System.Drawing.Point(48, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vous êtes :";
            // 
            // rbAdminConnex
            // 
            this.rbAdminConnex.AutoSize = true;
            this.rbAdminConnex.Font = new System.Drawing.Font("Calibri", 10F);
            this.rbAdminConnex.Location = new System.Drawing.Point(292, 40);
            this.rbAdminConnex.Name = "rbAdminConnex";
            this.rbAdminConnex.Size = new System.Drawing.Size(111, 21);
            this.rbAdminConnex.TabIndex = 1;
            this.rbAdminConnex.TabStop = true;
            this.rbAdminConnex.Text = "Administrateur";
            this.rbAdminConnex.UseVisualStyleBackColor = true;
            this.rbAdminConnex.CheckedChanged += new System.EventHandler(this.rbAdminConnex_CheckedChanged);
            // 
            // rbUserConnex
            // 
            this.rbUserConnex.AutoSize = true;
            this.rbUserConnex.Font = new System.Drawing.Font("Calibri", 10F);
            this.rbUserConnex.Location = new System.Drawing.Point(165, 40);
            this.rbUserConnex.Name = "rbUserConnex";
            this.rbUserConnex.Size = new System.Drawing.Size(85, 21);
            this.rbUserConnex.TabIndex = 0;
            this.rbUserConnex.TabStop = true;
            this.rbUserConnex.Text = "Utilisateur";
            this.rbUserConnex.UseVisualStyleBackColor = true;
            this.rbUserConnex.CheckedChanged += new System.EventHandler(this.rbUserConnex_CheckedChanged);
            // 
            // gbCreation
            // 
            this.gbCreation.Controls.Add(this.tbMdpCrea);
            this.gbCreation.Controls.Add(this.tbLoginCrea);
            this.gbCreation.Controls.Add(this.label6);
            this.gbCreation.Controls.Add(this.label7);
            this.gbCreation.Controls.Add(this.label8);
            this.gbCreation.Controls.Add(this.rbAdminCrea);
            this.gbCreation.Controls.Add(this.rbUserCrea);
            this.gbCreation.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbCreation.Location = new System.Drawing.Point(6, 0);
            this.gbCreation.Name = "gbCreation";
            this.gbCreation.Size = new System.Drawing.Size(524, 150);
            this.gbCreation.TabIndex = 12;
            this.gbCreation.TabStop = false;
            this.gbCreation.Text = "Création de compte";
            this.gbCreation.Visible = false;
            // 
            // tbMdpCrea
            // 
            this.tbMdpCrea.Location = new System.Drawing.Point(228, 119);
            this.tbMdpCrea.Name = "tbMdpCrea";
            this.tbMdpCrea.PasswordChar = '*';
            this.tbMdpCrea.Size = new System.Drawing.Size(100, 24);
            this.tbMdpCrea.TabIndex = 6;
            this.tbMdpCrea.TextChanged += new System.EventHandler(this.tbMdpCrea_TextChanged);
            // 
            // tbLoginCrea
            // 
            this.tbLoginCrea.Location = new System.Drawing.Point(228, 89);
            this.tbLoginCrea.Name = "tbLoginCrea";
            this.tbLoginCrea.Size = new System.Drawing.Size(100, 24);
            this.tbLoginCrea.TabIndex = 5;
            this.tbLoginCrea.TextChanged += new System.EventHandler(this.tbLoginCrea_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F);
            this.label6.Location = new System.Drawing.Point(48, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mot de passe :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F);
            this.label7.Location = new System.Drawing.Point(48, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Login :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F);
            this.label8.Location = new System.Drawing.Point(48, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Vous êtes :";
            // 
            // rbAdminCrea
            // 
            this.rbAdminCrea.AutoSize = true;
            this.rbAdminCrea.Font = new System.Drawing.Font("Calibri", 10F);
            this.rbAdminCrea.Location = new System.Drawing.Point(292, 40);
            this.rbAdminCrea.Name = "rbAdminCrea";
            this.rbAdminCrea.Size = new System.Drawing.Size(111, 21);
            this.rbAdminCrea.TabIndex = 1;
            this.rbAdminCrea.TabStop = true;
            this.rbAdminCrea.Text = "Administrateur";
            this.rbAdminCrea.UseVisualStyleBackColor = true;
            this.rbAdminCrea.CheckedChanged += new System.EventHandler(this.rbAdminCrea_CheckedChanged);
            // 
            // rbUserCrea
            // 
            this.rbUserCrea.AutoSize = true;
            this.rbUserCrea.Font = new System.Drawing.Font("Calibri", 10F);
            this.rbUserCrea.Location = new System.Drawing.Point(165, 40);
            this.rbUserCrea.Name = "rbUserCrea";
            this.rbUserCrea.Size = new System.Drawing.Size(85, 21);
            this.rbUserCrea.TabIndex = 0;
            this.rbUserCrea.TabStop = true;
            this.rbUserCrea.Text = "Utilisateur";
            this.rbUserCrea.UseVisualStyleBackColor = true;
            this.rbUserCrea.CheckedChanged += new System.EventHandler(this.rbUserCrea_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(157, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bienvenu(e) sur MarchéBD, votre gestionnaire d\'albums !";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F);
            this.label5.Location = new System.Drawing.Point(237, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Veuillez vous connecter ou créer un compte";
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConnexion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnConnexion.Location = new System.Drawing.Point(143, 197);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(193, 33);
            this.btnConnexion.TabIndex = 9;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnCreation
            // 
            this.btnCreation.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCreation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreation.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCreation.Location = new System.Drawing.Point(363, 197);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(193, 33);
            this.btnCreation.TabIndex = 10;
            this.btnCreation.Text = "Créer un compte";
            this.btnCreation.UseVisualStyleBackColor = false;
            this.btnCreation.Click += new System.EventHandler(this.btnCreation_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnValider.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnValider.Location = new System.Drawing.Point(491, 409);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(86, 34);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Visible = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDescription.Location = new System.Drawing.Point(83, 61);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(565, 79);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 455);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnCreation);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbConnexion);
            this.Name = "FormAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire de BD";
            this.gbConnexion.ResumeLayout(false);
            this.gbConnexion.PerformLayout();
            this.gbCreation.ResumeLayout(false);
            this.gbCreation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnexion;
        private System.Windows.Forms.TextBox tbMdpConnex;
        private System.Windows.Forms.TextBox tbLoginConnex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAdminConnex;
        private System.Windows.Forms.RadioButton rbUserConnex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnCreation;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gbCreation;
        private System.Windows.Forms.TextBox tbMdpCrea;
        private System.Windows.Forms.TextBox tbLoginCrea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbAdminCrea;
        private System.Windows.Forms.RadioButton rbUserCrea;
        private System.Windows.Forms.Label lblDescription;
    }
}

