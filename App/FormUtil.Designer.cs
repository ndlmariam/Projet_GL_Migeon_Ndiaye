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
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.gbAlbums = new System.Windows.Forms.GroupBox();
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.gbSouhaits = new System.Windows.Forms.GroupBox();
            this.dgvSouhaits = new System.Windows.Forms.DataGridView();
            this.gbMarché = new System.Windows.Forms.GroupBox();
            this.dgvMarché = new System.Windows.Forms.DataGridView();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.lblMarché = new System.Windows.Forms.Label();
            this.lblSouhaits = new System.Windows.Forms.Label();
            this.pbinfo = new System.Windows.Forms.PictureBox();
            this.pbInfo1 = new System.Windows.Forms.PictureBox();
            this.pbDeco = new System.Windows.Forms.PictureBox();
            this.pbPanier = new System.Windows.Forms.PictureBox();
            this.pbMarché = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pbSouhaits = new System.Windows.Forms.PictureBox();
            this.gbHeader.SuspendLayout();
            this.gbAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            this.gbSouhaits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSouhaits)).BeginInit();
            this.gbMarché.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarché)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarché)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouhaits)).BeginInit();
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
            // gbAlbums
            // 
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
            // dgvAlbums
            // 
            this.dgvAlbums.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Location = new System.Drawing.Point(0, 19);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.Size = new System.Drawing.Size(308, 320);
            this.dgvAlbums.TabIndex = 4;
            // 
            // gbSouhaits
            // 
            this.gbSouhaits.Controls.Add(this.gbMarché);
            this.gbSouhaits.Controls.Add(this.dgvSouhaits);
            this.gbSouhaits.Location = new System.Drawing.Point(64, 71);
            this.gbSouhaits.Name = "gbSouhaits";
            this.gbSouhaits.Size = new System.Drawing.Size(666, 384);
            this.gbSouhaits.TabIndex = 5;
            this.gbSouhaits.TabStop = false;
            this.gbSouhaits.Text = "Mes Souhaits";
            this.gbSouhaits.MouseHover += new System.EventHandler(this.gb_MouseHover);
            // 
            // dgvSouhaits
            // 
            this.dgvSouhaits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvSouhaits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSouhaits.Location = new System.Drawing.Point(12, 19);
            this.dgvSouhaits.Name = "dgvSouhaits";
            this.dgvSouhaits.Size = new System.Drawing.Size(308, 320);
            this.dgvSouhaits.TabIndex = 5;
            this.dgvSouhaits.MouseHover += new System.EventHandler(this.gb_MouseHover);
            // 
            // gbMarché
            // 
            this.gbMarché.Controls.Add(this.pbinfo);
            this.gbMarché.Controls.Add(this.dgvMarché);
            this.gbMarché.Location = new System.Drawing.Point(0, 1);
            this.gbMarché.Name = "gbMarché";
            this.gbMarché.Size = new System.Drawing.Size(666, 384);
            this.gbMarché.TabIndex = 6;
            this.gbMarché.TabStop = false;
            this.gbMarché.Text = "Bienvenu(e) sur le marché";
            this.gbMarché.MouseHover += new System.EventHandler(this.gb_MouseHover);
            // 
            // dgvMarché
            // 
            this.dgvMarché.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvMarché.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarché.Location = new System.Drawing.Point(0, 35);
            this.dgvMarché.Name = "dgvMarché";
            this.dgvMarché.Size = new System.Drawing.Size(308, 320);
            this.dgvMarché.TabIndex = 5;
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
            // FormUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(742, 455);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.gbSouhaits);
            this.Controls.Add(this.gbAlbums);
            this.Controls.Add(this.gbHeader);
            this.Name = "FormUtil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mes Albums";
            this.Load += new System.EventHandler(this.FormUtil_Load);
            this.Click += new System.EventHandler(this.FormUtil_Click);
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.gbAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            this.gbSouhaits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSouhaits)).EndInit();
            this.gbMarché.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarché)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarché)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouhaits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.PictureBox pbSouhaits;
        private System.Windows.Forms.PictureBox pbMarché;
        private System.Windows.Forms.GroupBox gbAlbums;
        private System.Windows.Forms.PictureBox pbInfo1;
        private System.Windows.Forms.GroupBox gbSouhaits;
        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.DataGridView dgvSouhaits;
        private System.Windows.Forms.GroupBox gbMarché;
        private System.Windows.Forms.DataGridView dgvMarché;
        private System.Windows.Forms.PictureBox pbPanier;
        private System.Windows.Forms.PictureBox pbDeco;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Label lblSouhaits;
        private System.Windows.Forms.Label lblMarché;
        private System.Windows.Forms.PictureBox pbinfo;
    }
}