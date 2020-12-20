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
        private static string cheminacces = Path.Combine(Environment.CurrentDirectory, "CircuitBD.Net", "Couvertures");
        private IActionRepository _actionrepo;
        private IPersonneRepository _persrepo;
        private IAlbumRepository _albrepo;
        public Utilisateur Utilisateur { get; set; }
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
                    IPersonneRepository PersonneRepository = new PersonneRepository(AlbumRepository);
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
            NumeroAlbum = 0;
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
        }

        private void pbSouhaits_Click(object sender, EventArgs e)

        {
            gbMarché.Visible = false;
            gbSouhaits.Visible = true;
            gbHeader.Text = "Mes Souhaits";
        }
        private void pbMarché_Click(object sender, EventArgs e)
        {
            gbSouhaits.Visible = true;
            gbMarché.Visible = true;
            gbHeader.Text = "MarchéBD";
            NumeroAlbum = 0;
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
        private void RefreshViews()
        {

            RefreshCarrouselMarché();
      

        }

        // INTERACTIONS INTERFACE MARCHE
        private void RefreshCarrouselMarché ()
        {
            //récupère la liste de tous les albums du marché
            List<Album> AlbumsDuMarché = _actionrepo.GetAll();
          
          
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
           Album SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
            if(SelectedAlbum.Couverture != "")
            {
                pbCouvertureDetail.Image = Image.FromFile(Path.Combine(cheminacces, SelectedAlbum.Couverture));
            }
            lblTitreDetail.Text = SelectedAlbum.Nom;
            lblSerie.Text = SelectedAlbum.Serie;
            lblAuteur.Text = SelectedAlbum.Auteur;
            lblCategorie.Text = SelectedAlbum.Categorie;
            lblEditeur.Text = SelectedAlbum.Editeur;
            lblGenre.Text = SelectedAlbum.Genre;
        }

        private void btnFermerPopUp_Click(object sender, EventArgs e)
        {
            gbInfosAlbum.Visible = false;
        }

        private void btnAjoutSouhaits_Click(object sender, EventArgs e)
        {

        }
    }

    }

    







