
namespace App
{
    partial class FormDescription
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
            this.gbHeaderDescription = new System.Windows.Forms.GroupBox();
            this.pbImageDesc = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.lblSouhait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHeaderDescription
            // 
            this.gbHeaderDescription.BackColor = System.Drawing.Color.Navy;
            this.gbHeaderDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHeaderDescription.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHeaderDescription.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbHeaderDescription.Location = new System.Drawing.Point(0, 0);
            this.gbHeaderDescription.Name = "gbHeaderDescription";
            this.gbHeaderDescription.Size = new System.Drawing.Size(695, 66);
            this.gbHeaderDescription.TabIndex = 2;
            this.gbHeaderDescription.TabStop = false;
            this.gbHeaderDescription.Text = "Informations";
            // 
            // pbImageDesc
            // 
            this.pbImageDesc.Location = new System.Drawing.Point(55, 96);
            this.pbImageDesc.Name = "pbImageDesc";
            this.pbImageDesc.Size = new System.Drawing.Size(151, 189);
            this.pbImageDesc.TabIndex = 3;
            this.pbImageDesc.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitre.Location = new System.Drawing.Point(279, 96);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(54, 26);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Titre";
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.LightCyan;
            this.btnAjout.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnAjout.Location = new System.Drawing.Point(55, 325);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(60, 51);
            this.btnAjout.TabIndex = 7;
            this.btnAjout.Text = "+";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // lblSouhait
            // 
            this.lblSouhait.AutoSize = true;
            this.lblSouhait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSouhait.Location = new System.Drawing.Point(121, 352);
            this.lblSouhait.Name = "lblSouhait";
            this.lblSouhait.Size = new System.Drawing.Size(136, 17);
            this.lblSouhait.TabIndex = 8;
            this.lblSouhait.Text = "Ajouter aux souhaits";
            // 
            // FormDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.lblSouhait);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pbImageDesc);
            this.Controls.Add(this.gbHeaderDescription);
            this.Name = "FormDescription";
            this.Text = "FormDescription";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHeaderDescription;
        private System.Windows.Forms.PictureBox pbImageDesc;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Label lblSouhait;
    }
}