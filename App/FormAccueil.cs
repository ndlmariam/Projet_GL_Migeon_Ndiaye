using DAL;
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
        bool RempliMdp; //booléen pour savoir si un mdp est rentré
        bool RempliLogin; //booléen pour savoir si un login est rentré
        bool CocheStatut; //vérifie qu'une checkbox du type a bien été sélectionnée
        IPersonneRepository _personnerepo;

        //Initialisation
        public FormAccueil(IPersonneRepository personnerepository)
        {
            InitializeComponent();
            RempliMdp = false;
            RempliLogin = false;
            CocheStatut = false;
            _personnerepo = personnerepository;
            AffichageRefresh();
        }

        //Affichage ou non du bouton valider en fonction des champs remplis
        private void AffichageRefresh ()
        {
            btnConnexion.Click += btnConnexion_Click;
            btnCreation.Click += btnCreation_Click;
            if (RempliLogin == true && RempliMdp == true && CocheStatut == true) { btnValider.Visible = true; }
        }

        //Vérification du formulaire
        private void btnValider_Click(object sender, EventArgs e)
        {
            List<Personne> pers = _personnerepo.GetAll();
            btnValider.UseWaitCursor = true;
            if (rbAdminConnex.Checked == true && !tbPseudo.Visible) { VerificationsIdType(pers, "Admin");}
            if (rbAdminCrea.Checked == true && tbPseudo.Visible) { VerificationsProfilExistant(pers, "Admin"); }
            if (rbUserConnex.Checked == true && !tbPseudo.Visible) {VerificationsIdType(pers, "User");}
            if (rbUserCrea.Checked == true && tbPseudo.Visible) { VerificationsProfilExistant(pers, "User"); }
            InitialiseChamps();
        }

        //Verification des identifiants et du type
        private void VerificationsIdType(List<Personne> pers, string type)
        {
            bool verificationad = false;
            for (int i = 0; i < pers.Count; i++)
            {
                if (pers[i].Login == tbLoginConnex.Text && pers[i].Mdp == tbMdpConnex.Text && pers[i].Type == type) { verificationad = true; }
            }

            if (verificationad)
            {
                if (type == "Admin")
                {
                    FormAdmin.InstanceFormAdmin.Administrateur = (Administrateur)_personnerepo.TrouverPersonne(tbLoginConnex.Text, tbMdpConnex.Text, "Admin");
                    FormAdmin formadmin = FormAdmin.InstanceFormAdmin;
                    formadmin.ShowDialog();
                }
                else
                {
                    FormUtil.InstanceFormUtil.Utilisateur = (Utilisateur)_personnerepo.TrouverPersonne(tbLoginConnex.Text, tbMdpConnex.Text, "User");
                    FormUtil.InstanceFormUtil.ShowDialog();
                }
                
            }
            else { MessageBox.Show("Soit votre login ou mot de passe est erroné, soit votre statut sélectionné n'est pas le bon."); }

        }

        //vérification de  l'existance ou non d'un profil similaire
        private void VerificationsProfilExistant(List<Personne> pers, string type)
        {
            bool verif = _personnerepo.PresentBDD(tbLoginCrea.Text);
            if (verif == true) { MessageBox.Show("Veuillez choisir un autre login, celui-ci est déjà utilisé"); }
            else
            {
                if (type == "Admin")
                {
                    Personne administrateur = new Administrateur(tbPseudo.Text, "Admin", tbLoginCrea.Text, tbMdpCrea.Text);
                    _personnerepo.Save(administrateur);
                    FormAdmin.InstanceFormAdmin.Administrateur = administrateur;
                    FormAdmin formadmin = FormAdmin.InstanceFormAdmin;
                    formadmin.ShowDialog();
                }
                else
                {
                    Personne utilisateur = new Utilisateur(tbPseudo.Text, "User", tbLoginCrea.Text, tbMdpCrea.Text);
                    _personnerepo.Save(utilisateur);
                    FormUtil.InstanceFormUtil.Utilisateur = (Utilisateur)utilisateur;
                    FormUtil.InstanceFormUtil.ShowDialog();
                }
            }
        }

        //Initialisation des champs
        private void InitialiseChamps()
        {
            rbAdminConnex.Checked = false;
            rbAdminCrea.Checked = false;
            rbUserConnex.Checked = false;
            rbUserCrea.Checked = false;
            tbLoginConnex.Text = null;
            tbLoginCrea.Text = null;
            tbPseudo.Text = null;
            tbMdpConnex.Text = null;
            tbMdpCrea.Text = null;
            btnValider.Visible = false;
        }
        //Affichage connexion
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            // fait apparaître la group box correspondante
            gbCreation.Visible = false;
            gbConnexion.Visible = true;
            btnCreation.BackColor = Color.LightGray;
            btnConnexion.BackColor = Color.PaleGreen;
        }

        //Affichage création
        private void btnCreation_Click(object sender, EventArgs e)
        {
            gbConnexion.Visible = true;
            gbCreation.Visible = true;
            btnConnexion.BackColor = Color.LightGray;
            btnCreation.BackColor = Color.PeachPuff;
        }

        // Modification des statuts
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

        //Ecriture du login création
        private void tbLoginCrea_TextChanged(object sender, EventArgs e)
        {
            if (tbLoginCrea.Text != "")
            {
                RempliLogin = true;
                AffichageRefresh();
            }
           
        }
        //Ecriture du mdp création
        private void tbMdpCrea_TextChanged(object sender, EventArgs e)
        {
            if (tbMdpCrea.Text != "")
            {
                RempliMdp = true;
                AffichageRefresh();
            }
            
        }

        //Ecriture du login connexion
        private void tbLoginConnex_TextChanged(object sender, EventArgs e)
        {
            if (tbLoginConnex.Text != "")
            {
                RempliLogin = true;
                AffichageRefresh();
            }
            else { RempliLogin = false; }
        }

        //Ecriture du mdp connextion
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
