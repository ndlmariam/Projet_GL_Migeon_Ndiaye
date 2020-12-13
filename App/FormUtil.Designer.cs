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
            this.pbMarché = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pbSouhaits = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.ListBox();
            this.gbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarché)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouhaits)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHeader
            // 
            this.gbHeader.BackColor = System.Drawing.Color.Navy;
            this.gbHeader.Controls.Add(this.pbMarché);
            this.gbHeader.Controls.Add(this.pbMenu);
            this.gbHeader.Controls.Add(this.pbSouhaits);
            this.gbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHeader.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHeader.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbHeader.Location = new System.Drawing.Point(0, 0);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(700, 66);
            this.gbHeader.TabIndex = 0;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Mes albums";
            // 
            // pbMarché
            // 
            this.pbMarché.Image = global::App.Properties.Resources.Marché;
            this.pbMarché.Location = new System.Drawing.Point(512, 16);
            this.pbMarché.Name = "pbMarché";
            this.pbMarché.Size = new System.Drawing.Size(53, 44);
            this.pbMarché.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMarché.TabIndex = 2;
            this.pbMarché.TabStop = false;
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
            this.pbSouhaits.Location = new System.Drawing.Point(442, 16);
            this.pbSouhaits.Name = "pbSouhaits";
            this.pbSouhaits.Size = new System.Drawing.Size(63, 44);
            this.pbSouhaits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSouhaits.TabIndex = 1;
            this.pbSouhaits.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Navy;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.SystemColors.Window;
            this.Menu.FormattingEnabled = true;
            this.Menu.ItemHeight = 19;
            this.Menu.Items.AddRange(new object[] {
            "Mes ",
            "Albums",
            "",
            "Marché",
            "",
            "Souhaits"});
            this.Menu.Location = new System.Drawing.Point(0, 66);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(64, 389);
            this.Menu.TabIndex = 1;
            this.Menu.Visible = false;
            // 
            // FormUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 455);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.gbHeader);
            this.Name = "FormUtil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mes Albums";
            this.Load += new System.EventHandler(this.FormUtil_Load);
            this.Click += new System.EventHandler(this.FormUtil_Click);
            this.gbHeader.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox Menu;
    }
}