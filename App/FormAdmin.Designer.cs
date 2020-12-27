namespace App
{
    partial class FormAdmin
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
            this.gbAjoutAlbum = new System.Windows.Forms.GroupBox();
            this.tbEditeur = new System.Windows.Forms.TextBox();
            this.lblEditeur = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.lblCouverture = new System.Windows.Forms.Label();
            this.plholdGenre = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.plholdCat = new System.Windows.Forms.Label();
            this.tbCategorie = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.tbSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.tbAuteur = new System.Windows.Forms.TextBox();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResume = new System.Windows.Forms.TextBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.gbMarchéAdmin = new System.Windows.Forms.GroupBox();
            this.gbSuppression = new System.Windows.Forms.GroupBox();
            this.btnSupressionSure = new System.Windows.Forms.Button();
            this.tbSupression = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.dgvMarché = new System.Windows.Forms.DataGridView();
            this.gbHeaderAdmin = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.pbDeco = new System.Windows.Forms.PictureBox();
            this.pbMarché = new System.Windows.Forms.PictureBox();
            this.gbAjoutAlbum.SuspendLayout();
            this.gbMarchéAdmin.SuspendLayout();
            this.gbSuppression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarché)).BeginInit();
            this.gbHeaderAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarché)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAjoutAlbum
            // 
            this.gbAjoutAlbum.Controls.Add(this.tbEditeur);
            this.gbAjoutAlbum.Controls.Add(this.lblEditeur);
            this.gbAjoutAlbum.Controls.Add(this.btnValider);
            this.gbAjoutAlbum.Controls.Add(this.btnParcourir);
            this.gbAjoutAlbum.Controls.Add(this.lblCouverture);
            this.gbAjoutAlbum.Controls.Add(this.plholdGenre);
            this.gbAjoutAlbum.Controls.Add(this.tbGenre);
            this.gbAjoutAlbum.Controls.Add(this.lblGenre);
            this.gbAjoutAlbum.Controls.Add(this.plholdCat);
            this.gbAjoutAlbum.Controls.Add(this.tbCategorie);
            this.gbAjoutAlbum.Controls.Add(this.lblCategorie);
            this.gbAjoutAlbum.Controls.Add(this.tbSerie);
            this.gbAjoutAlbum.Controls.Add(this.lblSerie);
            this.gbAjoutAlbum.Controls.Add(this.tbAuteur);
            this.gbAjoutAlbum.Controls.Add(this.lblAuteur);
            this.gbAjoutAlbum.Controls.Add(this.tbTitre);
            this.gbAjoutAlbum.Controls.Add(this.lblTitre);
            this.gbAjoutAlbum.Controls.Add(this.label1);
            this.gbAjoutAlbum.Controls.Add(this.tbResume);
            this.gbAjoutAlbum.Controls.Add(this.lblResume);
            this.gbAjoutAlbum.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAjoutAlbum.Location = new System.Drawing.Point(12, 72);
            this.gbAjoutAlbum.Name = "gbAjoutAlbum";
            this.gbAjoutAlbum.Size = new System.Drawing.Size(724, 378);
            this.gbAjoutAlbum.TabIndex = 0;
            this.gbAjoutAlbum.TabStop = false;
            this.gbAjoutAlbum.Text = "Informations";
            this.gbAjoutAlbum.MouseHover += new System.EventHandler(this.gbAjoutAlbum_MouseHover);
            // 
            // tbEditeur
            // 
            this.tbEditeur.Location = new System.Drawing.Point(127, 200);
            this.tbEditeur.Name = "tbEditeur";
            this.tbEditeur.Size = new System.Drawing.Size(100, 28);
            this.tbEditeur.TabIndex = 18;
            this.tbEditeur.TextChanged += new System.EventHandler(this.tbEditeur_TextChanged);
            // 
            // lblEditeur
            // 
            this.lblEditeur.AutoSize = true;
            this.lblEditeur.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditeur.Location = new System.Drawing.Point(41, 202);
            this.lblEditeur.Name = "lblEditeur";
            this.lblEditeur.Size = new System.Drawing.Size(65, 21);
            this.lblEditeur.TabIndex = 17;
            this.lblEditeur.Text = "Editeur";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnValider.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnValider.Location = new System.Drawing.Point(293, 314);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(86, 34);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Visible = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnParcourir
            // 
            this.btnParcourir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnParcourir.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnParcourir.Location = new System.Drawing.Point(127, 320);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(97, 30);
            this.btnParcourir.TabIndex = 14;
            this.btnParcourir.Text = "Parcourir ";
            this.btnParcourir.UseVisualStyleBackColor = false;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // lblCouverture
            // 
            this.lblCouverture.AutoSize = true;
            this.lblCouverture.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouverture.Location = new System.Drawing.Point(21, 320);
            this.lblCouverture.Name = "lblCouverture";
            this.lblCouverture.Size = new System.Drawing.Size(92, 21);
            this.lblCouverture.TabIndex = 13;
            this.lblCouverture.Text = "Couverture";
            // 
            // plholdGenre
            // 
            this.plholdGenre.AutoSize = true;
            this.plholdGenre.BackColor = System.Drawing.Color.White;
            this.plholdGenre.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plholdGenre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.plholdGenre.Location = new System.Drawing.Point(130, 284);
            this.plholdGenre.Name = "plholdGenre";
            this.plholdGenre.Size = new System.Drawing.Size(94, 16);
            this.plholdGenre.TabIndex = 12;
            this.plholdGenre.Text = "fantasy,polar,etc";
            this.plholdGenre.MouseHover += new System.EventHandler(this.PlaceHolder_MouseHover);
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(127, 279);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(100, 28);
            this.tbGenre.TabIndex = 11;
            this.tbGenre.TextChanged += new System.EventHandler(this.tbGenre_TextChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(41, 279);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(53, 21);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "Genre";
            // 
            // plholdCat
            // 
            this.plholdCat.AutoSize = true;
            this.plholdCat.BackColor = System.Drawing.Color.White;
            this.plholdCat.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plholdCat.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.plholdCat.Location = new System.Drawing.Point(136, 247);
            this.plholdCat.Name = "plholdCat";
            this.plholdCat.Size = new System.Drawing.Size(78, 16);
            this.plholdCat.TabIndex = 9;
            this.plholdCat.Text = "BD,Manga,etc";
            this.plholdCat.MouseHover += new System.EventHandler(this.PlaceHolder_MouseHover);
            // 
            // tbCategorie
            // 
            this.tbCategorie.Location = new System.Drawing.Point(127, 241);
            this.tbCategorie.Name = "tbCategorie";
            this.tbCategorie.Size = new System.Drawing.Size(100, 28);
            this.tbCategorie.TabIndex = 8;
            this.tbCategorie.TextChanged += new System.EventHandler(this.tbCategorie_TextChanged);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(34, 246);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(79, 21);
            this.lblCategorie.TabIndex = 7;
            this.lblCategorie.Text = "Catégorie";
            // 
            // tbSerie
            // 
            this.tbSerie.Location = new System.Drawing.Point(127, 166);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.Size = new System.Drawing.Size(100, 28);
            this.tbSerie.TabIndex = 6;
            this.tbSerie.TextChanged += new System.EventHandler(this.tbSerie_TextChanged);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(41, 168);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(47, 21);
            this.lblSerie.TabIndex = 5;
            this.lblSerie.Text = "Série";
            // 
            // tbAuteur
            // 
            this.tbAuteur.Location = new System.Drawing.Point(127, 127);
            this.tbAuteur.Name = "tbAuteur";
            this.tbAuteur.Size = new System.Drawing.Size(100, 28);
            this.tbAuteur.TabIndex = 4;
            this.tbAuteur.TextChanged += new System.EventHandler(this.tbAuteur_TextChanged);
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.Location = new System.Drawing.Point(34, 127);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(87, 21);
            this.lblAuteur.TabIndex = 3;
            this.lblAuteur.Text = "Auteur(s)";
            // 
            // tbTitre
            // 
            this.tbTitre.Location = new System.Drawing.Point(127, 89);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(100, 28);
            this.tbTitre.TabIndex = 2;
            this.tbTitre.TextChanged += new System.EventHandler(this.tbTitre_TextChanged);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(34, 89);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(47, 21);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez entrer les caracéristiques de l\'album";
            // 
            // tbResume
            // 
            this.tbResume.Location = new System.Drawing.Point(284, 124);
            this.tbResume.Multiline = true;
            this.tbResume.Name = "tbResume";
            this.tbResume.Size = new System.Drawing.Size(218, 181);
            this.tbResume.TabIndex = 20;
            this.tbResume.TextChanged += new System.EventHandler(this.tbResume_TextChanged);
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.Location = new System.Drawing.Point(280, 89);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(67, 21);
            this.lblResume.TabIndex = 19;
            this.lblResume.Text = "Résumé";
            // 
            // gbMarchéAdmin
            // 
            this.gbMarchéAdmin.Controls.Add(this.gbSuppression);
            this.gbMarchéAdmin.Controls.Add(this.label3);
            this.gbMarchéAdmin.Controls.Add(this.label2);
            this.gbMarchéAdmin.Controls.Add(this.btnSupprimer);
            this.gbMarchéAdmin.Controls.Add(this.btnAjout);
            this.gbMarchéAdmin.Controls.Add(this.dgvMarché);
            this.gbMarchéAdmin.Font = new System.Drawing.Font("Calibri", 11F);
            this.gbMarchéAdmin.Location = new System.Drawing.Point(9, 72);
            this.gbMarchéAdmin.Name = "gbMarchéAdmin";
            this.gbMarchéAdmin.Size = new System.Drawing.Size(730, 384);
            this.gbMarchéAdmin.TabIndex = 16;
            this.gbMarchéAdmin.TabStop = false;
            this.gbMarchéAdmin.Text = "Bienvenu(e) sur MarchéBD, voici l\'ensemble des albums du marché.";
            // 
            // gbSuppression
            // 
            this.gbSuppression.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbSuppression.Controls.Add(this.btnSupressionSure);
            this.gbSuppression.Controls.Add(this.tbSupression);
            this.gbSuppression.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSuppression.Location = new System.Drawing.Point(544, 124);
            this.gbSuppression.Name = "gbSuppression";
            this.gbSuppression.Size = new System.Drawing.Size(183, 244);
            this.gbSuppression.TabIndex = 10;
            this.gbSuppression.TabStop = false;
            this.gbSuppression.Text = "Entrer le titre de la BD à supprimer";
            this.gbSuppression.Visible = false;
            // 
            // btnSupressionSure
            // 
            this.btnSupressionSure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSupressionSure.Location = new System.Drawing.Point(17, 140);
            this.btnSupressionSure.Name = "btnSupressionSure";
            this.btnSupressionSure.Size = new System.Drawing.Size(142, 40);
            this.btnSupressionSure.TabIndex = 1;
            this.btnSupressionSure.Text = "Suppression";
            this.btnSupressionSure.UseVisualStyleBackColor = false;
            this.btnSupressionSure.Visible = false;
            this.btnSupressionSure.Click += new System.EventHandler(this.btnSupressionSure_Click);
            // 
            // tbSupression
            // 
            this.tbSupression.Location = new System.Drawing.Point(17, 88);
            this.tbSupression.Name = "tbSupression";
            this.tbSupression.Size = new System.Drawing.Size(142, 27);
            this.tbSupression.TabIndex = 0;
            this.tbSupression.TextChanged += new System.EventHandler(this.tbSupression_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(572, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "SUPPRIMER un album ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "AJOUTER un album ";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.MistyRose;
            this.btnSupprimer.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.Crimson;
            this.btnSupprimer.Location = new System.Drawing.Point(609, 173);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 61);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "🚮";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.LightCyan;
            this.btnAjout.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnAjout.Location = new System.Drawing.Point(609, 50);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(50, 49);
            this.btnAjout.TabIndex = 6;
            this.btnAjout.Text = "+";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // dgvMarché
            // 
            this.dgvMarché.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvMarché.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarché.Location = new System.Drawing.Point(0, 35);
            this.dgvMarché.Name = "dgvMarché";
            this.dgvMarché.Size = new System.Drawing.Size(538, 320);
            this.dgvMarché.TabIndex = 5;
            // 
            // gbHeaderAdmin
            // 
            this.gbHeaderAdmin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gbHeaderAdmin.Controls.Add(this.lblNom);
            this.gbHeaderAdmin.Controls.Add(this.pbDeco);
            this.gbHeaderAdmin.Controls.Add(this.pbMarché);
            this.gbHeaderAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHeaderAdmin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHeaderAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbHeaderAdmin.Location = new System.Drawing.Point(0, 0);
            this.gbHeaderAdmin.Name = "gbHeaderAdmin";
            this.gbHeaderAdmin.Size = new System.Drawing.Size(739, 66);
            this.gbHeaderAdmin.TabIndex = 1;
            this.gbHeaderAdmin.TabStop = false;
            this.gbHeaderAdmin.Text = "Espace Administrateur";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Impact", 13F);
            this.lblNom.Location = new System.Drawing.Point(573, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(69, 22);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Inconnu";
            // 
            // pbDeco
            // 
            this.pbDeco.Image = global::App.Properties.Resources.déconnexion;
            this.pbDeco.Location = new System.Drawing.Point(679, 21);
            this.pbDeco.Name = "pbDeco";
            this.pbDeco.Size = new System.Drawing.Size(45, 34);
            this.pbDeco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeco.TabIndex = 4;
            this.pbDeco.TabStop = false;
            this.pbDeco.Click += new System.EventHandler(this.pbDeco_Click);
            // 
            // pbMarché
            // 
            this.pbMarché.Image = global::App.Properties.Resources.Marché;
            this.pbMarché.Location = new System.Drawing.Point(511, 15);
            this.pbMarché.Name = "pbMarché";
            this.pbMarché.Size = new System.Drawing.Size(53, 44);
            this.pbMarché.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMarché.TabIndex = 2;
            this.pbMarché.TabStop = false;
            this.pbMarché.Click += new System.EventHandler(this.pbMarché_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(739, 455);
            this.Controls.Add(this.gbMarchéAdmin);
            this.Controls.Add(this.gbAjoutAlbum);
            this.Controls.Add(this.gbHeaderAdmin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CircuitBD espace Administrateur";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.gbAjoutAlbum.ResumeLayout(false);
            this.gbAjoutAlbum.PerformLayout();
            this.gbMarchéAdmin.ResumeLayout(false);
            this.gbMarchéAdmin.PerformLayout();
            this.gbSuppression.ResumeLayout(false);
            this.gbSuppression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarché)).EndInit();
            this.gbHeaderAdmin.ResumeLayout(false);
            this.gbHeaderAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarché)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAjoutAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbHeaderAdmin;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox pbDeco;
        private System.Windows.Forms.PictureBox pbMarché;
        private System.Windows.Forms.Label plholdCat;
        private System.Windows.Forms.TextBox tbCategorie;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.TextBox tbSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox tbAuteur;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.Label lblCouverture;
        private System.Windows.Forms.Label plholdGenre;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gbMarchéAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.DataGridView dgvMarché;
        private System.Windows.Forms.GroupBox gbSuppression;
        private System.Windows.Forms.Button btnSupressionSure;
        private System.Windows.Forms.TextBox tbSupression;
        private System.Windows.Forms.TextBox tbResume;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.TextBox tbEditeur;
        private System.Windows.Forms.Label lblEditeur;
    }
}