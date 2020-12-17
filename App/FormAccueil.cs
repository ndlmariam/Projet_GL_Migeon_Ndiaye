﻿using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FormAccueil : Form
    {
        bool RempliMdp;
        bool RempliLogin;
        bool CocheStatut;
        IPersonneRepository _personnerepo;
        public FormAccueil(IPersonneRepository personnerepository)
        {
            InitializeComponent();
            RempliMdp = false;
            RempliLogin = false;
            CocheStatut = false;
            _personnerepo = personnerepository;
            AffichageRefresh();

        }

    

      private void AffichageRefresh ()
        {
            btnConnexion.Click += btnConnexion_Click;
            btnCreation.Click += btnCreation_Click;
            if (RempliLogin == true && RempliMdp == true && CocheStatut == true)
            {
                btnValider.Visible = true;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (rbAdminConnex.Checked == true || rbAdminCrea.Checked == true)
            {
                if (rbAdminConnex.Checked == true)
                {
                    bool verificationad = _personnerepo.CompareMdp(tbLoginConnex.Text, tbMdpConnex.Text);
                    if (verificationad == true)
                    {
                        Personne administrateur = _personnerepo.TrouverPersonne(tbLoginConnex.Text, tbMdpConnex.Text, "Admin");
                        FormAdmin formadmin = new FormAdmin();
                        formadmin.ShowDialog();
                    }
                }
                if (rbAdminCrea.Checked == true)
                {
                    Personne administrateur = new Administrateur(tbPseudo.Text, "Admin", tbLoginCrea.Text, tbMdpCrea.Text);
                    _personnerepo.Save(administrateur);
                    FormAdmin formadmin = new FormAdmin();
                    formadmin.ShowDialog();
                }
                }
                if (rbUserConnex.Checked == true || rbUserCrea.Checked == true)
                {
                    if (rbUserConnex.Checked == true)
                    {
                        bool verificationus = _personnerepo.CompareMdp(tbLoginConnex.Text, tbMdpConnex.Text);
                        if (verificationus == true)
                        {
                            Personne utilisateur = _personnerepo.TrouverPersonne(tbLoginConnex.Text, tbMdpConnex.Text, "User");
                            FormUtil.InstanceFormUtil.Utilisateur = utilisateur;
                            FormUtil.InstanceFormUtil.ShowDialog();
                        }
                    }
                    if (rbUserCrea.Checked == true)
                    {
                        Personne utilisateur = new Utilisateur(tbPseudo.Text, "User", tbLoginCrea.Text, tbMdpCrea.Text);
                        _personnerepo.Save(utilisateur);

                        FormUtil.InstanceFormUtil.Utilisateur = utilisateur;
                        FormUtil.InstanceFormUtil.ShowDialog();


                    }

                }
            
        }

       

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            // fait apparaître la group box correspondante
            gbCreation.Visible = false;
            gbConnexion.Visible = true;
            btnCreation.BackColor = Color.LightGray;
            btnConnexion.BackColor = Color.PaleGreen;


        }
        private void btnCreation_Click(object sender, EventArgs e)
        {
            gbConnexion.Visible = true;
            gbCreation.Visible = true;
            btnConnexion.BackColor = Color.LightGray;
            btnCreation.BackColor = Color.PeachPuff;

        }

        private void rbUserConnex_CheckedChanged(object sender, EventArgs e)
        {
            CocheStatut = true;
            AffichageRefresh();

        }

        private void rbAdminConnex_CheckedChanged(object sender, EventArgs e)
        {
            CocheStatut = true;
            AffichageRefresh();
        }

        private void rbUserCrea_CheckedChanged(object sender, EventArgs e)
        {
            CocheStatut = true;
            AffichageRefresh();
        }

        private void rbAdminCrea_CheckedChanged(object sender, EventArgs e)
        {
            CocheStatut = true;
            AffichageRefresh();
        }

        private void tbLoginCrea_TextChanged(object sender, EventArgs e)
        {
            RempliLogin = true;
            AffichageRefresh();
        }

        private void tbMdpCrea_TextChanged(object sender, EventArgs e)
        {
            RempliMdp = true;
            AffichageRefresh();
        }

        private void tbLoginConnex_TextChanged(object sender, EventArgs e)
        {
            RempliLogin = true;
            AffichageRefresh();
        }

        private void tbMdpConnex_TextChanged(object sender, EventArgs e)
        {
            RempliMdp = true;
            AffichageRefresh();
        }

      
    }
}
