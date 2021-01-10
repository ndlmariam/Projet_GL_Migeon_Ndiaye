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
            List<Personne> pers = _personnerepo.GetAll();
            btnValider.UseWaitCursor = true;
            if (rbAdminConnex.Checked == true || rbAdminCrea.Checked == true)
            {
                if (rbAdminConnex.Checked == true)
                {
                    bool verificationad = false;
                    for (int i=0; i < pers.Count; i++)
                    {
                        if (pers[i].Login== tbLoginConnex.Text && pers[i].Mdp== tbMdpConnex.Text && pers[i].Type == "Admin") { verificationad = true; }
                    }
                    
                    if (verificationad)
                    {
                        FormAdmin.InstanceFormAdmin.Administrateur =(Administrateur) _personnerepo.TrouverPersonne(tbLoginConnex.Text, tbMdpConnex.Text, "Admin");
                        FormAdmin formadmin = FormAdmin.InstanceFormAdmin;
                        formadmin.ShowDialog();
                    }
                    else { MessageBox.Show("Login / mot de passe erroné ou mauvais statut sélectionné"); }

                }
                if (rbAdminCrea.Checked == true)
                {
                    //vérification de  l'existance ou non d'un profil similaire
                    bool verif = _personnerepo.PresentBDD(tbLoginCrea.Text);

                    if (verif == true && rbAdminCrea.Checked == true) { MessageBox.Show("Veuillez choisir un autre login, celui-ci est déjà utilisé"); }
                    else
                    {
                        Personne administrateur = new Administrateur(tbPseudo.Text, "Admin", tbLoginCrea.Text, tbMdpCrea.Text);
                        _personnerepo.Save(administrateur);
                        FormAdmin.InstanceFormAdmin.Administrateur = administrateur;
                        FormAdmin formadmin = FormAdmin.InstanceFormAdmin;
                        formadmin.ShowDialog();
                    }
                }
            }
            if (rbUserConnex.Checked == true || rbUserCrea.Checked == true)
            {
                if (rbUserConnex.Checked == true)
                {
                    bool verificationus = false;
                    for (int i = 0; i < pers.Count; i++)
                    {
                        if (pers[i].Login == tbLoginConnex.Text && pers[i].Mdp == tbMdpConnex.Text && pers[i].Type == "User") { verificationus = true; }
                    }

                    if (verificationus)
                    {
                        FormUtil.InstanceFormUtil.Utilisateur =(Utilisateur) _personnerepo.TrouverPersonne(tbLoginConnex.Text, tbMdpConnex.Text, "User");
                        FormUtil.InstanceFormUtil.ShowDialog();
                    }
                    else{ MessageBox.Show("Login / mot de passe erroné ou mauvais statut sélectionné");}

                }

                }
                if (rbUserCrea.Checked == true)
                {
                    bool verif = _personnerepo.PresentBDD(tbLoginCrea.Text);
                    if (verif == true && rbUserCrea.Checked == true) { MessageBox.Show("Veuillez choisir un autre login, celui-ci est déjà utilisé"); }
                    else
                    {
                        Personne utilisateur = new Utilisateur(tbPseudo.Text, "User", tbLoginCrea.Text, tbMdpCrea.Text);
                        _personnerepo.Save(utilisateur);

                        FormUtil.InstanceFormUtil.Utilisateur = (Utilisateur)utilisateur;
                        FormUtil.InstanceFormUtil.ShowDialog();
                    }
                }
            rbAdminConnex.Checked = false;
            rbAdminCrea.Checked = false;
            rbUserConnex.Checked = false;
            rbUserCrea.Checked = false;
            tbLoginConnex.Text = null;
            tbLoginCrea.Text = null;
            tbPseudo.Text = null;
            tbMdpConnex.Text = null;
            tbMdpCrea.Text = null;
            btnValider.Visible=false;

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
            if (tbLoginCrea.Text != "")
            {
                RempliLogin = true;
                AffichageRefresh();
            }
           
        }

        private void tbMdpCrea_TextChanged(object sender, EventArgs e)
        {
            if (tbMdpCrea.Text != "")
            {
                RempliMdp = true;
                AffichageRefresh();
            }
            
        }

        private void tbLoginConnex_TextChanged(object sender, EventArgs e)
        {
            if (tbLoginConnex.Text != "")
            {
                RempliLogin = true;
                AffichageRefresh();
            }
            else { RempliLogin = false; }
            
        }

        private void tbMdpConnex_TextChanged(object sender, EventArgs e)
        {
            if (tbMdpConnex.Text != "")
            {
                RempliMdp = true;
                AffichageRefresh();
            }
            else { RempliMdp = false; }
            
        }

      
    }
}
