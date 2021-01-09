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
        private bool PreviousNecessary; // booléen utile pour le carroussel d'albums du marché
        private int NumeroAlbum; //  utile pour le carroussel d'albums du marché
        private bool NextNecessarySouhait; // booléen utile pour le carroussel d'albums du marché
        private bool PreviousNecessarySouhait; // booléen utile pour le carroussel d'albums du marché
        private int NumeroAlbumSouhait; //  utile pour le carroussel d'albums du marché
        private static string cheminacces = Path.Combine(Environment.CurrentDirectory, "CircuitBD.Net", "Couvertures");
        private Album SelectedAlbum;
        private Album NouvelAlbum;
        Label placeholder { get; set; }
        protected static int NumberCouverture; // pour éviter que deux images soient nommées pareilles
        public Utilisateur Utilisateur { get; set; }
      

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
            NumberCouverture = _albrepo.GetAll().Count;


        }

        // événements du form
        private void FormUtil_Load(object sender, EventArgs e)
        {
            btnValider.BackColor = Color.PowderBlue;
            NouvelAlbum = new Album();
            SelectedAlbum = new Album();
            gbListeAlbums.BackColor = Color.PaleVioletRed;
            gbSouhaits.Visible = true;
            gbMarché.Visible = true;
            lblBarreRecherche.Visible = false;
            tbBarreRecherche.Visible = false;
            btnValideRecherche.Visible = false;
            lblAjoutManuel.Visible = true;
            btnAjoutManuel.Visible = true;
            pbInfo1.Visible = false;
            pbinfo.Visible = false;
            gbHeader.Text = "Mes Albums";
            NumeroAlbum = 0;
            NumeroAlbumSouhait = 0;
            lblNom.Text = Utilisateur.Nom;
            gbSouhaits.Visible = false;
            gbMarché.Visible = false;
            NextNecessary = false;
            NextNecessarySouhait = false;
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
            btnFermerPopUp.PerformClick();
            pbAlbum1.Image = null;
            pbAlbum2.Image = null;
            pbAlbum3.Image = null;
            pbAlbum4.Image = null;
            lblTitre1.Text = "";
            lblTitre2.Text = "";
            lblTitre3.Text = "";
            lblTitre4.Text = "";
            pbAlbum.BorderStyle = BorderStyle.Fixed3D;
            pbSouhaits.BorderStyle = BorderStyle.None;
            pbMarché.BorderStyle = BorderStyle.None;


            RecupererAchatUser();

            RefreshCollection();
            gbListeAlbums.BackColor = Color.Thistle;

            gbSouhaits.Visible = false;
            gbMarché.Visible = true;
            gbInfosAlbum.Visible = false;

            lblBarreRecherche.Visible = false;
            tbBarreRecherche.Visible = false;
            btnValideRecherche.Visible = false;
            lblAjoutManuel.Visible = true;
            btnAjoutManuel.Visible = true;
            pbInfo1.Visible = true;
            pbinfo.Visible = false;

            gbHeader.Text = "Mes Albums";
            gbMarché.Text = "Voici la liste de vos albums ! Vous pouvez en ajouter des nouveaux en parcourant le marché mais s'ils ne sont pas présents, vous pouvez aussi en ajouter manuellement !";
            NumeroAlbum = 0;
            lblAlbums.BackColor = Color.Lavender;
            lblAlbums.ForeColor = Color.Black;
            lblSouhaits.BackColor = Color.DarkSlateBlue;
            lblSouhaits.ForeColor = Color.White;
            lblMarché.BackColor = Color.DarkSlateBlue;
            lblMarché.ForeColor = Color.White;
           
        }

        private void affichagesChoixSouhaits()
        {
            pbCoeur1.Visible = false;
            pbPanier1.Visible = false;
            pbCoeur2.Visible = false;
            pbPanier2.Visible = false;
            pbCoeur3.Visible = false;
            pbPanier3.Visible = false;
            pbCoeur4.Visible = false;
            pbPanier4.Visible = false;
            RecupererSouhaitUser();
            if (Utilisateur.ListSouhaits.Count > 0)
            {
                pbCoeur1.Visible = true;
                pbPanier1.Visible = true;
                if (Utilisateur.ListSouhaits.Count > 1)
                {
                    pbCoeur2.Visible = true;
                    pbPanier2.Visible = true;
                    if (Utilisateur.ListSouhaits.Count > 2)
                    {
                        pbCoeur3.Visible = true;
                        pbPanier3.Visible = true;
                        if (Utilisateur.ListSouhaits.Count > 3)
                        {
                            pbCoeur4.Visible = true;
                            pbPanier4.Visible = true;
                        }
                    }
                }
            }
        }
      
        private void pbSouhaits_Click(object sender, EventArgs e)

        {
            affichagesChoixSouhaits();
            gbMarché.Visible = false;
            gbSouhaits.Visible = true;
            gbHeader.Text = "Mes Souhaits";
            NumeroAlbum = 0;
            NumeroAlbumSouhait = 0;

            pbSouhaits.BorderStyle = BorderStyle.Fixed3D;
            pbAlbum.BorderStyle = BorderStyle.None;
            pbMarché.BorderStyle = BorderStyle.None;

            lblSouhaits.BackColor = Color.Lavender;
            lblSouhaits.ForeColor = Color.Black;
            lblMarché.BackColor = Color.DarkSlateBlue;
            lblMarché.ForeColor = Color.White;
            lblAlbums.BackColor = Color.DarkSlateBlue;
            lblAlbums.ForeColor = Color.White;
            RefreshViews();
        }
        private void pbMarché_Click(object sender, EventArgs e)
        {
            gbListeAlbums.BackColor = Color.PaleGreen;
            gbSouhaits.Visible = false;
            gbMarché.Visible = true;
            gbInfosAlbum.Visible = false;
            gbHeader.Text = "MarchéBD";
            gbMarché.Text = "Bienvenu(e) sur MarchéBD ! Vous pouvez retrouver un grand nombre d'albums que vous connaissez. En cliquant simplement sur le titre, obtenez les informations sur l'album mais ajoutez le aussi à vos souhaits ! ";
            NumeroAlbum = 0;
            lblBarreRecherche.Visible = true;
            tbBarreRecherche.Visible = true;
            tbBarreRecherche.Text = "";
            btnValideRecherche.Visible = true;
            lblAjoutManuel.Visible = false;
            btnAjoutManuel.Visible = false;
            pbInfo1.Visible = false;
            pbinfo.Visible = true;

            pbPanier.Visible = true;

            pbMarché.BorderStyle = BorderStyle.Fixed3D;
            pbSouhaits.BorderStyle = BorderStyle.None;
            pbAlbum.BorderStyle = BorderStyle.None;
            lblMarché.BackColor = Color.Lavender;
            lblMarché.ForeColor = Color.Black;
            lblSouhaits.BackColor = Color.DarkSlateBlue;
            lblSouhaits.ForeColor = Color.White;
            lblAlbums.BackColor = Color.DarkSlateBlue;
            lblAlbums.ForeColor = Color.White;
            RefreshViews();
        }

        private void pbDeco_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Etes vous sûr de vouloir vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblNom.Text = "";
                instanceformutil.Close();
            }
        }
        // événements mousehover
        private void gb_MouseHover(object sender, EventArgs e)
        {
            Menu.Visible = false;
        }

        private void PlaceHolder_MouseHover(object sender, EventArgs e)
        {
            placeholder = ((Label)sender);
            placeholder.Visible = false;
        }

        private void titre_MouseHover(object sender, EventArgs e)
        {
            placeholder = ((Label)sender);
            placeholder.ForeColor = Color.Crimson;
            placeholder.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold) ;

        }
        private void titre_MouseLeave(object sender, EventArgs e)
        {
            placeholder = ((Label)sender);
            placeholder.ForeColor = Color.Black;
            placeholder.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
        }

        // INTERACTIONS INTERFACES ALBUM
        private void btnAjoutManuel_Click(object sender, EventArgs e)
        {
            tbTitre.Text = "";
            tbAuteur.Text = "";
            tbSerie.Text = "";
            tbEditeur.Text = "";
            tbCategorie.Text = "";
            tbGenre.Text = "";
            tbResume.Text = "";

            btnValider.Visible = false;
            btnValider.BackColor = Color.PowderBlue;
            gbMarché.Visible = false;
            gbSouhaits.Visible = false;
        }
        private void ApparitionBoutonValider ()
        {
           
           
                if (String.IsNullOrEmpty(tbTitre.Text) == false)
                {
              
                if (String.IsNullOrEmpty(tbAuteur.Text) == false)
                    {
                        if (String.IsNullOrEmpty(tbCategorie.Text) == false)
                        {
                            if (String.IsNullOrEmpty(tbSerie.Text) == false)
                            {
                                if (String.IsNullOrEmpty(tbGenre.Text) == false)
                                {
                                    if (String.IsNullOrEmpty(tbResume.Text) == false)
                                    {
                                   
                                        if (String.IsNullOrEmpty(tbEditeur.Text) == false)
                                        {
                                            btnValider.Visible = true;
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            
            }
        private void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("L'album " + SelectedAlbum.Nom + " a bien été ajouté à votre liste d'albums !");
            btnParcourir.Text = "Parcourir";
            btnParcourir.BackColor = Color.SpringGreen;

            List <Album> AlbumsBase =  _albrepo.GetAll();
            if (AlbumsBase.Contains(NouvelAlbum) == false)
            {
                _albrepo.Save(NouvelAlbum);

            }
            Domain.Action Achat = new Domain.Action("Achat", Utilisateur, NouvelAlbum);
            _actionrepo.SaveAction(Achat);
            Utilisateur.ActionsUser.Add(Achat);
            RecupererAchatUser();
            RefreshCollection();
            btnValider.BackColor = Color.PeachPuff;

            btnFermerPopUp.PerformClick();
            pbAlbum1.Image = null;
            pbAlbum2.Image = null;
            pbAlbum3.Image = null;
            pbAlbum4.Image = null;
            lblTitre1.Text = "";
            lblTitre2.Text = "";
            lblTitre3.Text = "";
            lblTitre4.Text = "";
            RecupererAchatUser();

            RefreshCollection();
            gbListeAlbums.BackColor = Color.Thistle;

            gbSouhaits.Visible = false;
            gbMarché.Visible = true;
            gbInfosAlbum.Visible = false;

            lblBarreRecherche.Visible = false;
            tbBarreRecherche.Visible = false;
            btnValideRecherche.Visible = false;
            lblAjoutManuel.Visible = true;
            btnAjoutManuel.Visible = true;
            pbInfo1.Visible = true;
            pbinfo.Visible = false;

            gbHeader.Text = "Mes Albums";
            gbMarché.Text = "Mes Albums";
            NumeroAlbum = 0;
            lblAlbums.BackColor = Color.Lavender;
            lblAlbums.ForeColor = Color.Black;
            lblSouhaits.BackColor = Color.DarkSlateBlue;
            lblSouhaits.ForeColor = Color.White;
            lblMarché.BackColor = Color.DarkSlateBlue;
            lblMarché.ForeColor = Color.White;
        }
        private void tbTitre_TextChanged(object sender, EventArgs e)
        {
            NouvelAlbum.Nom = tbTitre.Text;
            ApparitionBoutonValider();
        }

        private void tbAuteur_TextChanged(object sender, EventArgs e)
        {
            NouvelAlbum.Auteur = tbAuteur.Text;
            ApparitionBoutonValider();
        }

        private void tbSerie_TextChanged(object sender, EventArgs e)
        {
            NouvelAlbum.Serie = tbSerie.Text; ApparitionBoutonValider();
        }
        private void tbEditeur_TextChanged(object sender, EventArgs e)
        {
            NouvelAlbum.Editeur = tbEditeur.Text;
            ApparitionBoutonValider();
        }

        private void tbResume_TextChanged(object sender, EventArgs e)
        {
            NouvelAlbum.Resume = tbResume.Text;
            ApparitionBoutonValider();
        }
        private void tbCategorie_TextChanged(object sender, EventArgs e)
        {
            placeholder.Visible = false;

            NouvelAlbum.Categorie = tbCategorie.Text;
            ApparitionBoutonValider();
        }

        private void tbGenre_TextChanged(object sender, EventArgs e)
        {
            placeholder.Visible = false;

            NouvelAlbum.Genre = tbGenre.Text;
            ApparitionBoutonValider();
        }
        private void btnParcourir_Click(object sender, EventArgs e)
        {
            NumberCouverture += 1; // on incrémente dès qu'un utilisateur clique sur parcourir
            OpenFileDialog parcourir = new OpenFileDialog();
            parcourir.DefaultExt = "jpg";
            parcourir.ShowDialog();
            string couverturespath = Path.Combine(Environment.CurrentDirectory, "CircuitBD.Net", "Couvertures");
            if (!Directory.Exists(couverturespath))
            {
                Directory.CreateDirectory(couverturespath);
            }
            string fileName = Path.GetFileName(parcourir.FileName);
            //problème quand il y a deux images nommées de la même manière
            fileName = tbTitre.Text + NumberCouverture;
            File.Copy(parcourir.FileName, Path.Combine(couverturespath, fileName));

            // string cheminacces = Path.Combine(couverturespath, fileName);
            NouvelAlbum.Couverture = fileName;
            btnParcourir.Text = "Modifier";
            btnParcourir.BackColor = Color.Moccasin;

        }
        // INTERACTIONS INTERFACES SOUHAIT et MARCHE
        private void RefreshCollection()
        {
            //Carrousel de mes albums
            RefreshCarrousel(Utilisateur.ListAlbums, NextNecessary, PreviousNecessary, NumeroAlbum, pbAlbum1, pbAlbum2, pbAlbum3, pbAlbum4, lblTitre1, lblTitre2, lblTitre3, lblTitre4);
            
        }
        private void RefreshViews()
        {
            pbAlbum1.Image = null;
            pbAlbum2.Image = null;
            pbAlbum3.Image = null;
            pbAlbum4.Image = null;
            lblTitre1.Text = "";
            lblTitre2.Text = "";
            lblTitre3.Text = "";
            lblTitre4.Text = "";
            //récupère la liste de tous les albums du marché
            List<Album> AlbumsAjoutésMarché = _albrepo.GetByNameOfAction("AjoutMarché"); // le problème c'est qu'il peut y avoir des actions de suppression associées à ces albums
            List<Album> AlbumsDeLaBase = _albrepo.GetAll();
            List<Album> AlbumsDuMarché = new List<Album>();
            //si l'album est supprimé il ne sera plus présent dans la base
            for(int i=0; i < AlbumsAjoutésMarché.Count; i++)
            {
                if (AlbumsDeLaBase.Contains(AlbumsAjoutésMarché[i]))
                {
                    AlbumsDuMarché.Add(AlbumsAjoutésMarché[i]);
                }
            }
            //Carrousel du marché sans filtre de recherche
            RefreshCarrousel(AlbumsDuMarché, NextNecessary,PreviousNecessary, NumeroAlbum, pbAlbum1, pbAlbum2, pbAlbum3, pbAlbum4, lblTitre1, lblTitre2, lblTitre3, lblTitre4);

            dgvSouhaits.Rows.Clear();
            pbSouhait1.Image = null;
            pbSouhait2.Image = null;
            pbSouhait3.Image = null;
            pbSouhait4.Image = null;
            lblTitreSouhait1.Text = "";
            lblTitreSouhait2.Text = "";
            lblTitreSouhait3.Text = "";
            lblTitreSouhait4.Text = "";

            

            RecupererSouhaitUser();
            //Carrousel des souhaits
            RefreshCarrousel(Utilisateur.ListSouhaits, NextNecessarySouhait,PreviousNecessarySouhait, NumeroAlbumSouhait, pbSouhait1, pbSouhait2, pbSouhait3, pbSouhait4, lblTitreSouhait1, lblTitreSouhait2, lblTitreSouhait3, lblTitreSouhait4);

        }
        private void RecupererSouhaitUser()
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
        private void btnNextSouhait_Click(object sender, EventArgs e)
        {
            List<Album> Albums = Utilisateur.ListSouhaits;
            if (NumeroAlbumSouhait +4 < Albums.Count)
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

                NumeroAlbumSouhait = NumeroAlbumSouhait + 4; RefreshViews();
            }
        }
        private void RecupererAchatUser()
        {
            Utilisateur.ListAlbums = null;
            Utilisateur.ListAlbums = new List<Album>();
            Utilisateur.Achats = null;
            Utilisateur.Achats = new List<Domain.Action>();
            foreach (Domain.Action a in Utilisateur.ActionsUser)
            {
                if (a.Nom == "Achat")
                {

                    if (Utilisateur.Achats.Contains(a) == false)
                    {
                        Utilisateur.Achats.Add(a);
                    }
                }
            }
            foreach (Domain.Action a in Utilisateur.Achats)
            {

                if (Utilisateur.ListAlbums.Contains(a.Album) == false)
                {
                    Utilisateur.ListAlbums.Add(a.Album);
                }
            }
        }
        private void RefreshCarrousel(List<Album> AlbumsDuMarché, bool NextNecessary, bool PreviousNecessary, int NumeroAlbum, PictureBox pbAlbum1, PictureBox pbAlbum2, PictureBox pbAlbum3, PictureBox pbAlbum4, Label lblTitre1, Label lblTitre2, Label lblTitre3, Label lblTitre4)
        {
            

            while (NumeroAlbum < AlbumsDuMarché.Count && NextNecessary == false)

            {
                Album a1 = AlbumsDuMarché[NumeroAlbum];



                if (a1.Couverture != "" && a1.Couverture != null)
                {
                    pbAlbum1.Image = Image.FromFile(Path.Combine(cheminacces, a1.Couverture));
                    lblTitre1.Text = a1.Nom;

                }
                else
                {
                    lblTitre1.Text = a1.Nom;

                }
                if (NumeroAlbum + 1 < AlbumsDuMarché.Count)
                {
                    Album a2 = AlbumsDuMarché[NumeroAlbum + 1];

                    if (a2.Couverture != "" && a2.Couverture != null)
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



                        if (a3.Couverture != "" && a3.Couverture != null)
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
                            if (a4.Couverture != "" && a4.Couverture != null)
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

                if (NumeroAlbum > 0)
                {
                    PreviousNecessary = true;
                }
                couleurBtn(AlbumsDuMarché);

                }
        }

        private void couleurBtn(List<Album> Albums)
        {
            if (gbMarché.Visible == true)
            {
                if(NumeroAlbum+4< Albums.Count)
                {
                    btnNext.Enabled = true;
                    btnNext.BackColor = Color.LemonChiffon;
                }
                else
                {
                    btnNext.Enabled = false;
                    btnNext.BackColor = Color.LightGray;
                }
                if (NumeroAlbum > 0)
                {
                    btnPrevious.Enabled = true;
                    btnPrevious.BackColor = Color.LemonChiffon;
                }
                else
                {
                    btnPrevious.Enabled = false;
                    btnPrevious.BackColor = Color.LightGray;
                }
                
            }
            else
            {
                if (NumeroAlbumSouhait + 4 < Albums.Count)
                {
                    btnNextSouhaits.Enabled = true;
                    btnNextSouhaits.BackColor = Color.LightPink;
                }
                else
                {
                    btnNextSouhaits.Enabled = false;
                    btnNextSouhaits.BackColor = Color.LightGray;
                }
                if (NumeroAlbumSouhait > 0)
                {
                    btnPerviousSouhaits.Enabled = true;
                    btnPerviousSouhaits.BackColor = Color.LightPink;
                }
                else
                {
                    btnPerviousSouhaits.Enabled = false;
                    btnPerviousSouhaits.BackColor = Color.LightGray;
                }
            }
            
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            List<Album> Albums = new List<Album>();
            if (lblAlbums.ForeColor == Color.Black)
            {
                Albums = Utilisateur.ListAlbums;
            }
            else
            {
                List<Album> AlbumsAjoutésMarché = _albrepo.GetByNameOfAction("AjoutMarché"); // le problème c'est qu'il peut y avoir des actions de suppression associées à ces albums
                List<Album> AlbumsDeLaBase = _albrepo.GetAll();
                //si l'album est supprimé il ne sera plus présent dans la base
                for (int i = 0; i < AlbumsAjoutésMarché.Count; i++)
                {
                    if (AlbumsDeLaBase.Contains(AlbumsAjoutésMarché[i]))
                    {
                        Albums.Add(AlbumsAjoutésMarché[i]);
                    }
                }
                
            }
            

            
            if (NumeroAlbum+4 < Albums.Count)
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
                if (btnAjoutManuel.Visible == true)
                {
                    NumeroAlbum = NumeroAlbum + 4; RefreshCollection();
                }
                else
                { NumeroAlbum = NumeroAlbum + 4; RefreshViews(); }
            }
           


        }

        private void lblTitre_Click(object sender, EventArgs e)
        {
            pbInfo1.Visible = false;
            pbinfo.Visible = false;

            gbInfosAlbum.Visible = true;
            if (lblAlbums.ForeColor == Color.Black)
            {
                btnAjoutSouhaits.Visible = false;
                btnAppartenance.Visible = false;
            }
            else {
                btnAjoutSouhaits.Visible = true;
                btnAppartenance.Visible = true;
            }
            string titrealbum = ((Label)sender).Text;
            SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);


            if (SelectedAlbum.Couverture != "" && SelectedAlbum.Couverture != null)
            {
                pbCouvertureDetail.Image = Image.FromFile(Path.Combine(cheminacces, SelectedAlbum.Couverture));
            }
            lblTitreDetail.Text = SelectedAlbum.Nom;
            lblSerie.Text = SelectedAlbum.Serie;
            lblAuteur.Text = SelectedAlbum.Auteur;
            lblCategorie.Text = SelectedAlbum.Categorie;
            lblEditeur.Text = SelectedAlbum.Editeur;
            lblGenre.Text = SelectedAlbum.Genre;
             tbResumé.Text = SelectedAlbum.Resume;

            RecupererAchatUser();
            if (Utilisateur.ListAlbums.Contains(SelectedAlbum))
            {
                SelectedAlbum.posseder = true;
                btnAppartenance.BackColor = Color.LightGray;
            }
            else
            {
                btnAppartenance.BackColor = Color.Gold;
            }
            RecupererSouhaitUser();
            //si l'album est présent dans la liste des albums ou des souhaits, il ne peut plus être ajouté aux souhaits

            if (Utilisateur.ListSouhaits.Contains(SelectedAlbum) || Utilisateur.ListAlbums.Contains(SelectedAlbum))
            {
                SelectedAlbum.selected = true;
                btnAjoutSouhaits.BackColor = Color.LightGray;
            }
            else
            {

                btnAjoutSouhaits.BackColor = Color.Salmon;
            }
      

        }

        private void btnAppartenance_Click(object sender, EventArgs e)
        {
            if (lblSouhaits.ForeColor == Color.Black)
            {
                if (MessageBox.Show("Voulez-vous vraiment ajouter cet album de votre liste ?", "AjoutAlbum", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string PictureBoxDuMessage = ((PictureBox)sender).Name;
                    if (PictureBoxDuMessage == "pbPanier1")
                    {

                        string titrealbum = lblTitreSouhait1.Text;
                        SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
                        Domain.Action Achat = new Domain.Action("Achat", Utilisateur, SelectedAlbum);
                        Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(SelectedAlbum, "AjouterSouhait");
                        _actionrepo.DeleteAction(ActionASupprimer);
                        Utilisateur.ActionsUser.Remove(ActionASupprimer);
                        _actionrepo.SaveAction(Achat);
                        Utilisateur.ActionsUser.Add(Achat);
                        _persrepo.Save(Utilisateur);


                    }
                    if (PictureBoxDuMessage == "pbPanier2")
                    {
                        string titrealbum = lblTitreSouhait2.Text;
                        SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
                        Domain.Action Achat = new Domain.Action("Achat", Utilisateur, SelectedAlbum);
                        Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(SelectedAlbum, "AjouterSouhait");
                        _actionrepo.DeleteAction(ActionASupprimer);
                        Utilisateur.ActionsUser.Remove(ActionASupprimer);
                        _actionrepo.SaveAction(Achat);
                        Utilisateur.ActionsUser.Add(Achat);
                        _persrepo.Save(Utilisateur);

                    }
                    if (PictureBoxDuMessage == "pbPanier3")
                    {
                        string titrealbum = lblTitreSouhait3.Text;
                        SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
                        Domain.Action Achat = new Domain.Action("Achat", Utilisateur, SelectedAlbum);
                        Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(SelectedAlbum, "AjouterSouhait");
                        _actionrepo.DeleteAction(ActionASupprimer);
                        Utilisateur.ActionsUser.Remove(ActionASupprimer);
                        _actionrepo.SaveAction(Achat);
                        Utilisateur.ActionsUser.Add(Achat);
                        _persrepo.Save(Utilisateur);
                    }
                    if (PictureBoxDuMessage == "pbPanier4")
                    {
                        string titrealbum = lblTitreSouhait4.Text;
                        SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
                        Domain.Action Achat = new Domain.Action("Achat", Utilisateur, SelectedAlbum);
                        Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(SelectedAlbum, "AjouterSouhait");
                        _actionrepo.DeleteAction(ActionASupprimer);
                        Utilisateur.ActionsUser.Remove(ActionASupprimer);
                        _actionrepo.SaveAction(Achat);
                        Utilisateur.ActionsUser.Add(Achat);
                        _persrepo.Save(Utilisateur);
                    }
                    _persrepo.Save(Utilisateur);
                    SelectedAlbum.selected = false;
                    affichagesChoixSouhaits();

                }


                RefreshViews();
            }
            else
            {
                if (SelectedAlbum.posseder == false)
                {
                    MessageBox.Show("L'album " + SelectedAlbum.Nom + " a bien été ajouté à la liste des albums que vous possédez !");
                    SelectedAlbum.posseder = true;
                    btnAppartenance.BackColor = Color.LightGray;
                    Domain.Action Achat = new Domain.Action("Achat", Utilisateur, SelectedAlbum);
                    Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(SelectedAlbum, "AjouterSouhait");
                    _actionrepo.DeleteAction(ActionASupprimer);
                    Utilisateur.ActionsUser.Remove(ActionASupprimer);
                    _actionrepo.SaveAction(Achat);
                    Utilisateur.ActionsUser.Add(Achat);
                    _persrepo.Save(Utilisateur);

                    RefreshViews();
                }
                else
                {
                    MessageBox.Show("L'album " + SelectedAlbum.Nom + " est déjà dans vos albums.");

                }
            }
            
            }
        private void btnAjoutSouhaits_Click(object sender, EventArgs e)
        {
           
            if (SelectedAlbum.selected == false)
            {
                MessageBox.Show("L'album " + SelectedAlbum.Nom + " a bien été ajouté à vos souhaits !");
                SelectedAlbum.selected = true;
                btnAjoutSouhaits.BackColor = Color.LightGray;
                Domain.Action Voeu = new Domain.Action("AjouterSouhait", Utilisateur, SelectedAlbum);
                Utilisateur.ListSouhaits.Add(SelectedAlbum);
                Utilisateur.ActionsUser.Add(Voeu);

                _actionrepo.SaveAction(Voeu);
                _persrepo.Save(Utilisateur);

                RefreshViews();
            }
            else
            {
                if (Utilisateur.ListAlbums.Contains(SelectedAlbum)) { MessageBox.Show("L'album " + SelectedAlbum.Nom + " est déjà dans vos albums."); }
                else { MessageBox.Show("L'album " + SelectedAlbum.Nom + " est déjà dans vos souhaits."); }
            }
            

        }

        private void btnFermerPopUp_Click(object sender, EventArgs e)
        {
            gbInfosAlbum.Visible = false;
            if (lblAlbums.ForeColor == Color.Black) { pbInfo1.Visible = true; }
            else { pbinfo.Visible = true; }
          
        }

        private void pbCoeur_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment supprimer cet album de vos souhaits ?", "Supprimer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string PictureBoxDuMessage = ((PictureBox)sender).Name;
                if (PictureBoxDuMessage == "pbCoeur1")
                {

                    string titrealbum = lblTitreSouhait1.Text;
                    SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
                    Utilisateur.ListSouhaits.Remove(SelectedAlbum);
                    Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(SelectedAlbum, "AjouterSouhait");
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
                btnAjoutSouhaits.BackColor = Color.LightSalmon;
                SelectedAlbum.selected = false;
                affichagesChoixSouhaits();

            }


            RefreshViews();
        }

        private void pbPanier_Click(object sender, EventArgs e)
        {
            RefreshViews();
            RecupererSouhaitUser();
            if (Utilisateur.ListSouhaits.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous ajouter l'ensemble de votre liste de souhaits dans votre liste d'albums ?", "Acheter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (Album souhait in Utilisateur.ListSouhaits)
                    {
                        Domain.Action Achat = new Domain.Action("Achat", Utilisateur, souhait);
                        _actionrepo.SaveAction(Achat);
                        Utilisateur.ActionsUser.Add(Achat);
                        Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(souhait, "AjouterSouhait");
                        _actionrepo.DeleteAction(ActionASupprimer);
                        Utilisateur.ActionsUser.Remove(ActionASupprimer);
                        _persrepo.Save(Utilisateur);
                    }
                }
                Utilisateur.ListSouhaits = null;
                Utilisateur.ListSouhaits = new List<Album>();
                pbSouhait1.Image = null;
                pbSouhait2.Image = null;
                pbSouhait3.Image = null;
                pbSouhait4.Image = null;
                lblTitreSouhait1.Text = "";
                lblTitreSouhait2.Text = "";
                lblTitreSouhait3.Text = "";
                lblTitreSouhait4.Text = "";
                RefreshViews();
                RecupererAchatUser();
                RefreshCollection();
            }
            else
            {
                MessageBox.Show("Vous n'avez encore aucun album dans votre liste de souhaits. Rendez-vous dans le marché si vous voulez en ajouter !");
            }
        
           
          
        }

        private void btnValideRecherche_Click(object sender, EventArgs e)
        {
            pbAlbum1.Image = null;
            pbAlbum2.Image = null;
            pbAlbum3.Image = null;
            pbAlbum4.Image = null;
            lblTitre1.Text = "";
            lblTitre2.Text = "";
            lblTitre3.Text = "";
            lblTitre4.Text = "";
            string recherche = tbBarreRecherche.Text;
            AlbumRepository albumRepository = new AlbumRepository();
            List<Album> albumsrecherche = albumRepository.GetAlbumByRecherche(recherche);

            RefreshCarrousel(albumsrecherche, NextNecessary, PreviousNecessary,NumeroAlbum, pbAlbum1, pbAlbum2, pbAlbum3, pbAlbum4, lblTitre1, lblTitre2, lblTitre3, lblTitre4);
            gbInfosAlbum.Visible = false;
            NumeroAlbum = 0;
            NumeroAlbumSouhait = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            

            if (NumeroAlbum - 4 >= 0)
            {
                PreviousNecessary = false;
                pbAlbum1.Image = null;
                pbAlbum2.Image = null;
                pbAlbum3.Image = null;
                pbAlbum4.Image = null;
                lblTitre1.Text = "";
                lblTitre2.Text = "";
                lblTitre3.Text = "";
                lblTitre4.Text = "";

                if (btnAjoutManuel.Visible == true)
                {
                    NumeroAlbum = NumeroAlbum - 4; RefreshCollection();
                }
                else
                { NumeroAlbum = NumeroAlbum - 4; RefreshViews(); }
            }
            

        }

        private void btnPerviousSouhaits_Click(object sender, EventArgs e)
        {
            if (NumeroAlbumSouhait - 4 >= 0)
            {
                PreviousNecessarySouhait = false;
                pbAlbum1.Image = null;
                pbAlbum2.Image = null;
                pbAlbum3.Image = null;
                pbAlbum4.Image = null;
                lblTitre1.Text = "";
                lblTitre2.Text = "";
                lblTitre3.Text = "";
                lblTitre4.Text = "";
                NumeroAlbumSouhait = NumeroAlbumSouhait - 4; RefreshViews(); 
            }
        }

        
    }

}









