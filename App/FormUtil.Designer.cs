namespace App
{
    partial class FormUtil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.pbDeco = new System.Windows.Forms.PictureBox();
            this.pbPanier = new System.Windows.Forms.PictureBox();
            this.pbMarché = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pbSouhaits = new System.Windows.Forms.PictureBox();
            this.gbAlbums = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjoutManuel = new System.Windows.Forms.Button();
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.pbInfo1 = new System.Windows.Forms.PictureBox();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.lblSouhaits = new System.Windows.Forms.Label();
            this.lblMarché = new System.Windows.Forms.Label();
            this.gbSouhaits = new System.Windows.Forms.GroupBox();
            this.gbMarché = new System.Windows.Forms.GroupBox();
            this.lblBarreRecherche = new System.Windows.Forms.Label();
            this.tbBarreRecherche = new System.Windows.Forms.TextBox();
            this.pbinfo = new System.Windows.Forms.PictureBox();
            this.dgvSouhaits = new System.Windows.Forms.DataGridView();
            this.Couverture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retirer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListeAlbums = new System.Windows.Forms.GroupBox();
            this.pbAlbum1 = new System.Windows.Forms.PictureBox();
            this.lblTitre1 = new System.Windows.Forms.Label();
            this.pbAlbum2 = new System.Windows.Forms.PictureBox();
            this.lblTitre2 = new System.Windows.Forms.Label();
            this.pbAlbum3 = new System.Windows.Forms.PictureBox();
            this.lblTitre3 = new System.Windows.Forms.Label();
            this.pbAlbum4 = new System.Windows.Forms.PictureBox();
            this.lblTitre4 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarché)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouhaits)).BeginInit();
            this.gbAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo1)).BeginInit();
            this.Menu.SuspendLayout();
            this.gbSouhaits.SuspendLayout();
            this.gbMarché.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSouhaits)).BeginInit();
            this.gbListeAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum4)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHeader
            // 
            this.gbHeader.BackColor = System.Drawing.Color.Navy;
            this.gbHeader.Controls.Add(this.lblNom);
            this.gbHeader.Controls.Add(this.pbDeco);
            this.gbHeader.Controls.Add(this.pbPanier);
            this.gbHeader.Controls.Add(this.pbMarché);
            this.gbHeader.Controls.Add(this.pbMenu);
            this.gbHeader.Controls.Add(this.pbSouhaits);
            this.gbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHeader.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHeader.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbHeader.Location = new System.Drawing.Point(0, 0);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(742, 66);
            this.gbHeader.TabIndex = 0;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Mes albums";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(585, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(62, 20);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Inconnu";
            // 
            // pbDeco
            // 
            this.pbDeco.Image = global::App.Properties.Resources.déconnexion;
            this.pbDeco.Location = new System.Drawing.Point(679, 16);
            this.pbDeco.Name = "pbDeco";
            this.pbDeco.Size = new System.Drawing.Size(57, 44);
            this.pbDeco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeco.TabIndex = 4;
            this.pbDeco.TabStop = false;
            this.pbDeco.Click += new System.EventHandler(this.pbDeco_Click);
            // 
            // pbPanier
            // 
            this.pbPanier.Image = global::App.Properties.Resources.panier;
            this.pbPanier.Location = new System.Drawing.Point(481, 16);
            this.pbPanier.Name = "pbPanier";
            this.pbPanier.Size = new System.Drawing.Size(63, 44);
            this.pbPanier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPanier.TabIndex = 3;
            this.pbPanier.TabStop = false;
            this.pbPanier.Visible = false;
            // 
            // pbMarché
            // 
            this.pbMarché.Image = global::App.Properties.Resources.Marché;
            this.pbMarché.Location = new System.Drawing.Point(346, 16);
            this.pbMarché.Name = "pbMarché";
            this.pbMarché.Size = new System.Drawing.Size(53, 44);
            this.pbMarché.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMarché.TabIndex = 2;
            this.pbMarché.TabStop = false;
            this.pbMarché.Click += new System.EventHandler(this.pbMarché_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Image = global::App.Properties.Resources.menu_gris;
            this.pbMenu.Location = new System.Drawing.Point(6, 26);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(49, 37);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // pbSouhaits
            // 
            this.pbSouhaits.Image = global::App.Properties.Resources.souhaits;
            this.pbSouhaits.Location = new System.Drawing.Point(405, 16);
            this.pbSouhaits.Name = "pbSouhaits";
            this.pbSouhaits.Size = new System.Drawing.Size(63, 44);
            this.pbSouhaits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSouhaits.TabIndex = 1;
            this.pbSouhaits.TabStop = false;
            this.pbSouhaits.Click += new System.EventHandler(this.pbSouhaits_Click);
            // 
            // gbAlbums
            // 
            this.gbAlbums.Controls.Add(this.label1);
            this.gbAlbums.Controls.Add(this.btnAjoutManuel);
            this.gbAlbums.Controls.Add(this.dgvAlbums);
            this.gbAlbums.Controls.Add(this.pbInfo1);
            this.gbAlbums.Location = new System.Drawing.Point(70, 72);
            this.gbAlbums.Name = "gbAlbums";
            this.gbAlbums.Size = new System.Drawing.Size(656, 383);
            this.gbAlbums.TabIndex = 2;
            this.gbAlbums.TabStop = false;
            this.gbAlbums.Text = "Mes Albums";
            this.gbAlbums.MouseHover += new System.EventHandler(this.gb_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ajouter manuellement un album à ma collection";
            // 
            // btnAjoutManuel
            // 
            this.btnAjoutManuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAjoutManuel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutManuel.Location = new System.Drawing.Point(323, 331);
            this.btnAjoutManuel.Name = "btnAjoutManuel";
            this.btnAjoutManuel.Size = new System.Drawing.Size(75, 38);
            this.btnAjoutManuel.TabIndex = 6;
            this.btnAjoutManuel.Text = "+";
            this.btnAjoutManuel.UseVisualStyleBackColor = false;
            this.btnAjoutManuel.Click += new System.EventHandler(this.btnAjoutManuel_Click);
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Location = new System.Drawing.Point(0, 19);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.Size = new System.Drawing.Size(308, 320);
            this.dgvAlbums.TabIndex = 4;
            // 
            // pbInfo1
            // 
            this.pbInfo1.Image = global::App.Properties.Resources.infobullealbum;
            this.pbInfo1.Location = new System.Drawing.Point(314, 35);
            this.pbInfo1.Name = "pbInfo1";
            this.pbInfo1.Size = new System.Drawing.Size(346, 275);
            this.pbInfo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbInfo1.TabIndex = 3;
            this.pbInfo1.TabStop = false;
            // 
            // lblAlbums
            // 
            this.lblAlbums.AutoSize = true;
            this.lblAlbums.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbums.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlbums.Location = new System.Drawing.Point(2, 16);
            this.lblAlbums.Name = "lblAlbums";
            this.lblAlbums.Size = new System.Drawing.Size(52, 16);
            this.lblAlbums.TabIndex = 6;
            this.lblAlbums.Text = " Albums";
            this.lblAlbums.Click += new System.EventHandler(this.Album_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Navy;
            this.Menu.Controls.Add(this.lblSouhaits);
            this.Menu.Controls.Add(this.lblMarché);
            this.Menu.Controls.Add(this.lblAlbums);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 66);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(58, 389);
            this.Menu.TabIndex = 7;
            this.Menu.TabStop = false;
            // 
            // lblSouhaits
            // 
            this.lblSouhaits.AutoSize = true;
            this.lblSouhaits.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSouhaits.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSouhaits.Location = new System.Drawing.Point(1, 66);
            this.lblSouhaits.Name = "lblSouhaits";
            this.lblSouhaits.Size = new System.Drawing.Size(56, 16);
            this.lblSouhaits.TabIndex = 8;
            this.lblSouhaits.Text = "Souhaits";
            this.lblSouhaits.Click += new System.EventHandler(this.pbSouhaits_Click);
            // 
            // lblMarché
            // 
            this.lblMarché.AutoSize = true;
            this.lblMarché.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarché.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarché.Location = new System.Drawing.Point(3, 41);
            this.lblMarché.Name = "lblMarché";
            this.lblMarché.Size = new System.Drawing.Size(49, 16);
            this.lblMarché.TabIndex = 7;
            this.lblMarché.Text = "Marché";
            this.lblMarché.Click += new System.EventHandler(this.pbMarché_Click);
            // 
            // gbSouhaits
            // 
            this.gbSouhaits.Controls.Add(this.gbMarché);
            this.gbSouhaits.Controls.Add(this.dgvSouhaits);
            this.gbSouhaits.Location = new System.Drawing.Point(64, 72);
            this.gbSouhaits.Name = "gbSouhaits";
            this.gbSouhaits.Size = new System.Drawing.Size(666, 384);
            this.gbSouhaits.TabIndex = 8;
            this.gbSouhaits.TabStop = false;
            this.gbSouhaits.Text = "Mes Souhaits";
            // 
            // gbMarché
            // 
            this.gbMarché.Controls.Add(this.gbListeAlbums);
            this.gbMarché.Controls.Add(this.lblBarreRecherche);
            this.gbMarché.Controls.Add(this.tbBarreRecherche);
            this.gbMarché.Controls.Add(this.pbinfo);
            this.gbMarché.Location = new System.Drawing.Point(0, 0);
            this.gbMarché.Name = "gbMarché";
            this.gbMarché.Size = new System.Drawing.Size(666, 384);
            this.gbMarché.TabIndex = 6;
            this.gbMarché.TabStop = false;
            this.gbMarché.Text = "Bienvenu(e) sur MarchéBD, notre marché";
            // 
            // lblBarreRecherche
            // 
            this.lblBarreRecherche.AutoSize = true;
            this.lblBarreRecherche.Location = new System.Drawing.Point(47, 35);
            this.lblBarreRecherche.Name = "lblBarreRecherche";
            this.lblBarreRecherche.Size = new System.Drawing.Size(198, 13);
            this.lblBarreRecherche.TabIndex = 9;
            this.lblBarreRecherche.Text = "Rechercher parmi les albums disponibles";
            // 
            // tbBarreRecherche
            // 
            this.tbBarreRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbBarreRecherche.Location = new System.Drawing.Point(39, 54);
            this.tbBarreRecherche.Name = "tbBarreRecherche";
            this.tbBarreRecherche.Size = new System.Drawing.Size(217, 20);
            this.tbBarreRecherche.TabIndex = 7;
            // 
            // pbinfo
            // 
            this.pbinfo.Image = global::App.Properties.Resources.infobullemarché;
            this.pbinfo.Location = new System.Drawing.Point(319, 35);
            this.pbinfo.Name = "pbinfo";
            this.pbinfo.Size = new System.Drawing.Size(337, 320);
            this.pbinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbinfo.TabIndex = 6;
            this.pbinfo.TabStop = false;
            // 
            // dgvSouhaits
            // 
            this.dgvSouhaits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvSouhaits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSouhaits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Couverture,
            this.Titre,
            this.Auteur,
            this.Date,
            this.Retirer,
            this.Panier});
            this.dgvSouhaits.Location = new System.Drawing.Point(6, 92);
            this.dgvSouhaits.Name = "dgvSouhaits";
            this.dgvSouhaits.Size = new System.Drawing.Size(644, 319);
            this.dgvSouhaits.TabIndex = 5;
            // 
            // Couverture
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Couverture.DefaultCellStyle = dataGridViewCellStyle6;
            this.Couverture.HeaderText = "Couverture";
            this.Couverture.Name = "Couverture";
            // 
            // Titre
            // 
            this.Titre.HeaderText = "Titre de l\'album";
            this.Titre.Name = "Titre";
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur(s)";
            this.Auteur.Name = "Auteur";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date d\'ajout";
            this.Date.Name = "Date";
            // 
            // Retirer
            // 
            this.Retirer.HeaderText = "Retirer de la liste de souhait ?";
            this.Retirer.Name = "Retirer";
            // 
            // Panier
            // 
            this.Panier.HeaderText = "Ajouter au panier ?";
            this.Panier.Name = "Panier";
            // 
            // gbListeAlbums
            // 
            this.gbListeAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbListeAlbums.Controls.Add(this.btnNext);
            this.gbListeAlbums.Controls.Add(this.lblTitre4);
            this.gbListeAlbums.Controls.Add(this.pbAlbum4);
            this.gbListeAlbums.Controls.Add(this.lblTitre3);
            this.gbListeAlbums.Controls.Add(this.pbAlbum3);
            this.gbListeAlbums.Controls.Add(this.lblTitre2);
            this.gbListeAlbums.Controls.Add(this.pbAlbum2);
            this.gbListeAlbums.Controls.Add(this.lblTitre1);
            this.gbListeAlbums.Controls.Add(this.pbAlbum1);
            this.gbListeAlbums.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbListeAlbums.Location = new System.Drawing.Point(39, 92);
            this.gbListeAlbums.Name = "gbListeAlbums";
            this.gbListeAlbums.Size = new System.Drawing.Size(250, 292);
            this.gbListeAlbums.TabIndex = 10;
            this.gbListeAlbums.TabStop = false;
            // 
            // pbAlbum1
            // 
            this.pbAlbum1.Location = new System.Drawing.Point(6, 0);
            this.pbAlbum1.Name = "pbAlbum1";
            this.pbAlbum1.Size = new System.Drawing.Size(112, 119);
            this.pbAlbum1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum1.TabIndex = 0;
            this.pbAlbum1.TabStop = false;
            // 
            // lblTitre1
            // 
            this.lblTitre1.AutoSize = true;
            this.lblTitre1.Location = new System.Drawing.Point(7, 126);
            this.lblTitre1.Name = "lblTitre1";
            this.lblTitre1.Size = new System.Drawing.Size(64, 13);
            this.lblTitre1.TabIndex = 1;
            this.lblTitre1.Text = "TitreSuivant";
            // 
            // pbAlbum2
            // 
            this.pbAlbum2.Location = new System.Drawing.Point(127, 0);
            this.pbAlbum2.Name = "pbAlbum2";
            this.pbAlbum2.Size = new System.Drawing.Size(112, 119);
            this.pbAlbum2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum2.TabIndex = 2;
            this.pbAlbum2.TabStop = false;
            // 
            // lblTitre2
            // 
            this.lblTitre2.AutoSize = true;
            this.lblTitre2.Location = new System.Drawing.Point(133, 126);
            this.lblTitre2.Name = "lblTitre2";
            this.lblTitre2.Size = new System.Drawing.Size(64, 13);
            this.lblTitre2.TabIndex = 3;
            this.lblTitre2.Text = "TitreSuivant";
            // 
            // pbAlbum3
            // 
            this.pbAlbum3.Location = new System.Drawing.Point(6, 145);
            this.pbAlbum3.Name = "pbAlbum3";
            this.pbAlbum3.Size = new System.Drawing.Size(112, 121);
            this.pbAlbum3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum3.TabIndex = 4;
            this.pbAlbum3.TabStop = false;
            // 
            // lblTitre3
            // 
            this.lblTitre3.AutoSize = true;
            this.lblTitre3.Location = new System.Drawing.Point(8, 269);
            this.lblTitre3.Name = "lblTitre3";
            this.lblTitre3.Size = new System.Drawing.Size(64, 13);
            this.lblTitre3.TabIndex = 5;
            this.lblTitre3.Text = "TitreSuivant";
            // 
            // pbAlbum4
            // 
            this.pbAlbum4.Location = new System.Drawing.Point(127, 145);
            this.pbAlbum4.Name = "pbAlbum4";
            this.pbAlbum4.Size = new System.Drawing.Size(112, 121);
            this.pbAlbum4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum4.TabIndex = 6;
            this.pbAlbum4.TabStop = false;
            // 
            // lblTitre4
            // 
            this.lblTitre4.AutoSize = true;
            this.lblTitre4.Location = new System.Drawing.Point(124, 269);
            this.lblTitre4.Name = "lblTitre4";
            this.lblTitre4.Size = new System.Drawing.Size(64, 13);
            this.lblTitre4.TabIndex = 7;
            this.lblTitre4.Text = "TitreSuivant";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNext.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(188, 268);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FormUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(742, 455);
            this.Controls.Add(this.gbSouhaits);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.gbAlbums);
            this.Controls.Add(this.gbHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUtil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mes Albums";
            this.Load += new System.EventHandler(this.FormUtil_Load);
            this.Click += new System.EventHandler(this.FormUtil_Click);
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarché)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouhaits)).EndInit();
            this.gbAlbums.ResumeLayout(false);
            this.gbAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.gbSouhaits.ResumeLayout(false);
            this.gbMarché.ResumeLayout(false);
            this.gbMarché.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSouhaits)).EndInit();
            this.gbListeAlbums.ResumeLayout(false);
            this.gbListeAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.PictureBox pbSouhaits;
        private System.Windows.Forms.PictureBox pbMarché;
        private System.Windows.Forms.GroupBox gbAlbums;
        private System.Windows.Forms.PictureBox pbInfo1;
        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.PictureBox pbPanier;
        private System.Windows.Forms.PictureBox pbDeco;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Label lblSouhaits;
        private System.Windows.Forms.Label lblMarché;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjoutManuel;
        private System.Windows.Forms.GroupBox gbSouhaits;
        private System.Windows.Forms.GroupBox gbMarché;
        private System.Windows.Forms.Label lblBarreRecherche;
        private System.Windows.Forms.TextBox tbBarreRecherche;
        private System.Windows.Forms.PictureBox pbinfo;
        private System.Windows.Forms.DataGridView dgvSouhaits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Couverture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retirer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Panier;
        private System.Windows.Forms.GroupBox gbListeAlbums;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTitre4;
        private System.Windows.Forms.PictureBox pbAlbum4;
        private System.Windows.Forms.Label lblTitre3;
        private System.Windows.Forms.PictureBox pbAlbum3;
        private System.Windows.Forms.Label lblTitre2;
        private System.Windows.Forms.PictureBox pbAlbum2;
        private System.Windows.Forms.Label lblTitre1;
        private System.Windows.Forms.PictureBox pbAlbum1;
    }
}