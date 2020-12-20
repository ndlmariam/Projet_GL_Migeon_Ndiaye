using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FormUtil : Form
    {
        private bool ClickedOnce; // booléen utile pour l'appartition ou disparition du menu
        private bool NextNecessary; // booléen utile pour le carroussel d'albums du marché
        private int NumeroAlbum; //  utile pour le carroussel d'albums du marché
        private bool NextNecessarySouhait; // booléen utile pour le carroussel d'albums du marché
        private int NumeroAlbumSouhait; //  utile pour le carroussel d'albums du marché
        private static string cheminacces = Path.Combine(Environment.CurrentDirectory, "CircuitBD.Net", "Couvertures");
        private Album SelectedAlbum;
        public  Utilisateur Utilisateur { get; set; }
       

        private IActionRepository _actionrepo;
        private IPersonneRepository _persrepo;
        private IAlbumRepository _albrepo;
       
        // technique du singleton pour avoir une seule instance de notre form
        private static FormUtil instanceformutil = null;
        public static FormUtil InstanceFormUtil
        {
            get
            {
                if (instanceformutil == null)
                {
                    //IMPORTANT : INSTANCIATION DES REPOSITORY
                    IAlbumRepository AlbumRepository = new AlbumRepository();
                    IPersonneRepository PersonneRepository = new PersonneRepository();
                    IActionRepository ActionRepository = new ActionRepository();
                    instanceformutil = new FormUtil(ActionRepository, AlbumRepository, PersonneRepository);
                }
                return instanceformutil;
            }

        }
        private FormUtil(IActionRepository Actionrepository, IAlbumRepository Albumrepository, IPersonneRepository Personnerepository)
        {
            InitializeComponent();
            _actionrepo = Actionrepository;
            _albrepo = Albumrepository;
            _persrepo = Personnerepository;
        


        }

        // événements du form
        private void FormUtil_Load(object sender, EventArgs e)
        {
            lblNom.Text = Utilisateur.Nom;
            gbSouhaits.Visible = false;
            gbMarché.Visible = false;
            NextNecessary = false;
            NextNecessarySouhait = false;
            NumeroAlbum = 0;
            NumeroAlbumSouhait = 0;
            
            RefreshViews();
        
        }



        private void FormUtil_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
        }
        // évènements clicks de gestion des boutons
        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (ClickedOnce == false) { Menu.Visible = true; ClickedOnce = true; }
            else { Menu.Visible = false; ClickedOnce = false; }

        }


        private void Album_Click(object sender, EventArgs e)
        {
            gbMarché.Visible = false;
            gbSouhaits.Visible = false;
            gbAlbums.Visible = true;
            gbHeader.Text = "Mes Albums";
            RefreshViews();
        }

        private void pbSouhaits_Click(object sender, EventArgs e)

        {
            gbMarché.Visible = false;
            gbSouhaits.Visible = true;
            gbHeader.Text = "Mes Souhaits";
            RefreshViews();
        }
        private void pbMarché_Click(object sender, EventArgs e)
        {
            gbSouhaits.Visible = true;
            gbMarché.Visible = true;
            gbHeader.Text = "MarchéBD";
            NumeroAlbum = 0;
            pbPanier.Visible = true;
            RefreshViews();
        }

        private void pbDeco_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Etes vous sûr de vouloir vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                instanceformutil.Close();
            }
        }
        // événement mousehover
        private void gb_MouseHover(object sender, EventArgs e)
        {
            Menu.Visible = false;
        }
        // Evénement en lien avec l'affichage des données
        // A FAIRE form pour pouvoir ajouter un album à sa collection
        private void btnAjoutManuel_Click(object sender, EventArgs e)
        {

        }
        private void RecupererSouhaitUser ()
        {
            Utilisateur.ListSouhaits = null;
            Utilisateur.ListSouhaits = new List<Album>();
            Utilisateur.Voeux = null;
            Utilisateur.Voeux = new List<Domain.Action>();
            foreach (Domain.Action a in Utilisateur.ActionsUser)
            {
                if (a.Nom == "AjouterSouhait")
                {
                    if (Utilisateur.Voeux.Contains(a) == false)
                    {
                        Utilisateur.Voeux.Add(a);
                    }
                }
            }
                foreach (Domain.Action a in Utilisateur.Voeux)
                {
                    dgvSouhaits.Rows.Add(a.Album.Serie, a.Album.Nom, a.Date);
                if (Utilisateur.ListSouhaits.Contains(a.Album) == false)
                {
                    Utilisateur.ListSouhaits.Add(a.Album);
                }
                }
            

            
        }
     
        private void RefreshViews()
        {
           
        
            //récupère la liste de tous les albums du marché
            List<Album> AlbumsDuMarché = _albrepo.GetAll();
            RefreshCarrousel( AlbumsDuMarché,  NextNecessary,  NumeroAlbum,  pbAlbum1,  pbAlbum2,  pbAlbum3,  pbAlbum4,  lblTitre1,  lblTitre2,  lblTitre3,  lblTitre4);
            
            dgvSouhaits.Rows.Clear();

            RecupererSouhaitUser();
            RefreshCarrousel(Utilisateur.ListSouhaits, NextNecessarySouhait, NumeroAlbumSouhait, pbSouhait1, pbSouhait2, pbSouhait3, pbSouhait4, lblTitreSouhait1, lblTitreSouhait2, lblTitreSouhait3, lblTitreSouhait4);

        }
        // INTERACTIONS INTERFACE SOUHAIT
     
        private void btnNextSouhait_Click(object sender, EventArgs e)
        {
            NextNecessarySouhait = false;
            pbSouhait1.Image = null;
            pbSouhait2.Image = null;
            pbSouhait3.Image = null;
            pbSouhait4.Image = null;
            lblTitreSouhait1.Text = "";
            lblTitreSouhait2.Text = "";
            lblTitreSouhait3.Text = "";
            lblTitreSouhait4.Text = "";
            RefreshViews();
        }
        // INTERACTIONS INTERFACE MARCHE
        private void RefreshCarrousel(List<Album> AlbumsDuMarché, bool NextNecessary,int NumeroAlbum,PictureBox pbAlbum1,PictureBox pbAlbum2,PictureBox pbAlbum3,PictureBox pbAlbum4,Label lblTitre1,Label lblTitre2,Label lblTitre3, Label lblTitre4)
        {
           
           
            while (NumeroAlbum < AlbumsDuMarché.Count && NextNecessary == false)

            {
                Album a1 = AlbumsDuMarché[NumeroAlbum];



                if (a1.Couverture != "")
                {
                    pbAlbum1.Image = Image.FromFile(Path.Combine(cheminacces,a1.Couverture));
                    lblTitre1.Text = a1.Nom;

                }
                else
                {
                    lblTitre1.Text = a1.Nom;

                }
                if (NumeroAlbum + 1 < AlbumsDuMarché.Count)
                {
                    Album a2 = AlbumsDuMarché[NumeroAlbum + 1];

                    if (a2.Couverture != "")
                    {
                        pbAlbum2.Image = Image.FromFile(Path.Combine(cheminacces, a2.Couverture));
                        lblTitre2.Text = a2.Nom;
                    }
                    else
                    {
                        lblTitre2.Text = a2.Nom;
                    }
                    if (NumeroAlbum + 2 < AlbumsDuMarché.Count)
                    {
                        Album a3 = AlbumsDuMarché[NumeroAlbum + 2];
                        


                        if (a3.Couverture != "")
                        {
                            pbAlbum3.Image = Image.FromFile(Path.Combine(cheminacces, a3.Couverture));
                            lblTitre3.Text = a3.Nom;
                        }
                        else
                        {
                            lblTitre3.Text = a3.Nom;
                        }
                        if (NumeroAlbum + 3 < AlbumsDuMarché.Count)
                        {
                            Album a4 = AlbumsDuMarché[NumeroAlbum + 3];
                            if (a4.Couverture != "")
                            {
                                pbAlbum4.Image = Image.FromFile(Path.Combine(cheminacces, a4.Couverture));
                                lblTitre4.Text = a4.Nom;
                            }
                            else
                            {
                                lblTitre4.Text = a4.Nom;
                            }
                        }
                    }

                }

                NextNecessary = true;
                NumeroAlbum = NumeroAlbum + 4;

            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            NextNecessary = false;
            pbAlbum1.Image = null;
            pbAlbum2.Image = null;
            pbAlbum3.Image = null;
            pbAlbum4.Image = null;
            lblTitre1.Text = "";
            lblTitre2.Text = "";
            lblTitre3.Text = "";
            lblTitre4.Text = "";
            RefreshViews();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {
            
            gbInfosAlbum.Visible = true;
          string titrealbum = ((Label)sender).Text;
            SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
           
              
                if (SelectedAlbum.Couverture != "")
                {
                    pbCouvertureDetail.Image = Image.FromFile(Path.Combine(cheminacces, SelectedAlbum.Couverture));
                }
                lblTitreDetail.Text = SelectedAlbum.Nom;
                lblSerie.Text = SelectedAlbum.Serie;
                lblAuteur.Text = SelectedAlbum.Auteur;
                lblCategorie.Text = SelectedAlbum.Categorie;
                lblEditeur.Text = SelectedAlbum.Editeur;
                lblGenre.Text = SelectedAlbum.Genre;
            if (SelectedAlbum.selected == false)
            {
                btnAjoutSouhaits.BackColor = Color.Salmon;
            }

        }
        private void btnAjoutSouhaits_Click(object sender, EventArgs e)
        {
            if (SelectedAlbum.selected == false)
            {
                SelectedAlbum.selected = true;
                btnAjoutSouhaits.BackColor = Color.LightGray;
                Domain.Action Voeu = new Domain.Action("AjouterSouhait", Utilisateur, SelectedAlbum);
                Utilisateur.ListSouhaits.Add(SelectedAlbum);
                Utilisateur.ActionsUser.Add(Voeu);
               
                _actionrepo.SaveAction(Voeu);
                _persrepo.Save(Utilisateur);
             
                RefreshViews();
               
                

            }

        }

        private void btnFermerPopUp_Click(object sender, EventArgs e)
        {
            gbInfosAlbum.Visible = false;
        }

        private void pbCoeur_Click(object sender, EventArgs e)
        {
            string PictureBoxDuMessage = ((PictureBox)sender).Name;
            if (PictureBoxDuMessage == "pbCoeur1")
            {
                
                string titrealbum = lblTitreSouhait1.Text;
                SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
                Utilisateur.ListSouhaits.Remove(SelectedAlbum);
                Domain.Action ActionASupprimer =_actionrepo.GetActionByNameAndAlbum( SelectedAlbum, "AjouterSouhait");
                _actionrepo.DeleteAction(ActionASupprimer);
                Utilisateur.ActionsUser.Remove(ActionASupprimer);
               



            }
            if (PictureBoxDuMessage == "pbCoeur2")
            {
                string titrealbum = lblTitreSouhait2.Text;
                SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
                Utilisateur.ListSouhaits.Remove(SelectedAlbum);
                Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(SelectedAlbum, "AjouterSouhait");
                _actionrepo.DeleteAction(ActionASupprimer);
                Utilisateur.ActionsUser.Remove(ActionASupprimer);

            }
            if (PictureBoxDuMessage == "pbCoeur3")
            {
                string titrealbum = lblTitreSouhait3.Text;
                SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
                Utilisateur.ListSouhaits.Remove(SelectedAlbum);
                Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(SelectedAlbum, "AjouterSouhait");
                _actionrepo.DeleteAction(ActionASupprimer);
                Utilisateur.ActionsUser.Remove(ActionASupprimer);
            }
            if (PictureBoxDuMessage == "pbCoeur4")
            {
                string titrealbum = lblTitreSouhait4.Text;
                SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
                Utilisateur.ListSouhaits.Remove(SelectedAlbum);
                Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(SelectedAlbum, "AjouterSouhait");
                _actionrepo.DeleteAction(ActionASupprimer);
                Utilisateur.ActionsUser.Remove(ActionASupprimer);
            }
            _persrepo.Save(Utilisateur);
            RefreshViews();
         


        }

        private void pbPanier_Click(object sender, EventArgs e)
        {
            RefreshViews();
            RecupererSouhaitUser();
           if ( MessageBox.Show( "Voulez-vous acheter l'ensemble de votre liste de souhaits ?", "Acheter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            { foreach (Album souhait in Utilisateur.ListSouhaits)
                {
                    Domain.Action Achat = new Domain.Action("Achat", Utilisateur,souhait);
                    _actionrepo.SaveAction(Achat);
                    Utilisateur.ListSouhaits.Remove(souhait);
                    Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(souhait, "AjouterSouhait");
                    _actionrepo.DeleteAction(ActionASupprimer);
                    Utilisateur.ActionsUser.Remove(ActionASupprimer);
                    _persrepo.Save(Utilisateur);
                }
            }
            RefreshViews();
        }
    }

    }

    







