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
        private bool NextNecessaryAlbum; // booléen utile pour le carroussel d'albums de ma liste
        private bool PreviousNecessaryAlbum; // booléen utile pour le carroussel d'albums de ma liste
        private bool NextNecessaryMarche; // booléen utile pour le carroussel d'albums du marché
        private bool PreviousNecessaryMarche; // booléen utile pour le carroussel d'albums du marché
        private int NumeroAlbumMarche; //  utile pour le carroussel d'albums du marché
        private int NumeroAlbum; //  utile pour le carroussel d'albums de ma liste
        private bool NextNecessarySouhait; // booléen utile pour le carroussel d'albums des souhaits
        private bool PreviousNecessarySouhait; // booléen utile pour le carroussel d'albums des souhaits
        private int NumeroAlbumSouhait; //  utile pour le carroussel d'albums du marché
        private static string cheminacces = Path.Combine(Environment.CurrentDirectory, "CircuitBD.Net", "Couvertures");
        private Album SelectedAlbum;
        private Album NouvelAlbum;
        private bool Recherche; // utile pour la recherche des albums par mot clé
        Label placeholder { get; set; }
        public Utilisateur Utilisateur { get; set; }
        //Différents repository
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
        // Chargement formulaire
        private void FormUtil_Load(object sender, EventArgs e)
        {
            btnValider.BackColor = Color.PowderBlue;
            NouvelAlbum = new Album();
            SelectedAlbum = new Album();
            NumeroAlbum = 0;
            NumeroAlbumMarche = 0;
            NumeroAlbumSouhait = 0;
            lblNom.Text = Utilisateur.Nom;
            NextNecessaryAlbum = false;
            NextNecessaryMarche = false;
            NextNecessarySouhait = false;
            initialiseAffichageSouhait();
            initialiseAffichageMarche();
            affichagesMarché();
        }

        //Déconnexion
        private void pbDeco_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de vouloir vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblNom.Text = "";
                instanceformutil.Close();
            }
        }

        // Affichage menu déroulant
        private void FormUtil_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
        }
        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (ClickedOnce == false) { Menu.Visible = true; ClickedOnce = true; }
            else { Menu.Visible = false; ClickedOnce = false; }
        }

        //Modification affichage icone selectionné
        private void SelectionIcone(string page)
        {
            pbSouhaits.BorderStyle = BorderStyle.None;
            pbAlbum.BorderStyle = BorderStyle.None;
            pbMarché.BorderStyle = BorderStyle.None;
            lblSouhaits.BackColor = Color.DarkSlateBlue;
            lblSouhaits.ForeColor = Color.White;
            lblMarché.BackColor = Color.DarkSlateBlue;
            lblMarché.ForeColor = Color.White;
            lblAlbums.BackColor = Color.DarkSlateBlue;
            lblAlbums.ForeColor = Color.White;
            if (page == "Souhait")
            {
                pbSouhaits.BorderStyle = BorderStyle.Fixed3D;
                lblSouhaits.BackColor = Color.Lavender;
                lblSouhaits.ForeColor = Color.Black;
            }
            else if(page == "Album")
            {
                pbAlbum.BorderStyle = BorderStyle.Fixed3D;
                lblAlbums.BackColor = Color.Lavender;
                lblAlbums.ForeColor = Color.Black;
            }
            else
            {
                pbMarché.BorderStyle = BorderStyle.Fixed3D;
                lblMarché.BackColor = Color.Lavender;
                lblMarché.ForeColor = Color.Black;
            }
        }

        //Affichages albums
        private void affichageAlbums()
        {
            NumeroAlbum = 0;
            gbListeAlbums.BackColor = Color.Thistle;
            Recherche = false;
            btnFermerPopUp.PerformClick();
            initialiseAffichageMarche();
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
            SelectionIcone("Album");
            RecupererAchatUser();
            RefreshCollection();
        }
        private void Album_Click(object sender, EventArgs e) { affichageAlbums(); }

        //Affichages souahits
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
            if (Utilisateur.ListSouhaits.Count -NumeroAlbumSouhait > 0)
            {
                pbCoeur1.Visible = true;
                pbPanier1.Visible = true;
                if (Utilisateur.ListSouhaits.Count - NumeroAlbumSouhait > 1)
                {
                    pbCoeur2.Visible = true;
                    pbPanier2.Visible = true;
                    if (Utilisateur.ListSouhaits.Count - NumeroAlbumSouhait > 2)
                    {
                        pbCoeur3.Visible = true;
                        pbPanier3.Visible = true;
                        if (Utilisateur.ListSouhaits.Count - NumeroAlbumSouhait > 3)
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
            NumeroAlbumSouhait = 0;
            affichagesChoixSouhaits();
            gbMarché.Visible = false;
            gbSouhaits.Visible = true;
            gbHeader.Text = "Mes Souhaits";
            SelectionIcone("Souhait");
            RefreshSouhaits();
        }

        //Affichages du marché
        private void affichagesMarché()
        {
            NumeroAlbumMarche = 0;
            gbListeAlbums.BackColor = Color.Honeydew;
            gbSouhaits.Visible = false;
            gbMarché.Visible = true;
            gbInfosAlbum.Visible = false;
            gbHeader.Text = "MarchéBD";
            gbMarché.Text = "Bienvenu(e) sur MarchéBD ! Vous pouvez retrouver un grand nombre d'albums que vous connaissez. En cliquant simplement sur le titre, obtenez les informations sur l'album mais ajoutez le aussi à vos souhaits ou votre collection ! Pour les consulter sélectionnez simplement Album ou Souhaits. ";
            lblBarreRecherche.Visible = true;
            tbBarreRecherche.Visible = true;
            tbBarreRecherche.Text = "";
            btnValideRecherche.Visible = true;
            lblAjoutManuel.Visible = false;
            btnAjoutManuel.Visible = false;
            pbInfo1.Visible = false;
            pbinfo.Visible = true;
            pbPanier.Visible = true;
            SelectionIcone("Marché");
            RefreshViews();
        }
        private void pbMarché_Click(object sender, EventArgs e) { affichagesMarché();}

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

        // Réinitialisation des paramètres lors de l'ajout d'un album
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

        //Affichage du bouton de validation si tous les champs sont remplis
        private bool ChampRempli(string champ)
        {
            if (String.IsNullOrEmpty(champ) == false && champ != "") { return true; }
            return false;
        }
        private void ApparitionBoutonValider ()
        {
            if (ChampRempli(tbTitre.Text) && ChampRempli(tbAuteur.Text) && ChampRempli(tbCategorie.Text) && ChampRempli(tbSerie.Text) && ChampRempli(tbGenre.Text) && ChampRempli(tbResume.Text) && ChampRempli(tbEditeur.Text)) { btnValider.Visible = true; }
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (tbAuteur.Text != "" && tbTitre.Text != "" && tbCategorie.Text != "" && tbSerie.Text != "" && tbGenre.Text != "" && tbResume.Text != "" && tbEditeur.Text != "")
            {
                MessageBox.Show("L'album " + tbTitre.Text + " a bien été ajouté à votre liste d'albums !");
                btnParcourir.Text = "Parcourir";
                btnParcourir.BackColor = Color.SpringGreen;
                List<Album> AlbumsBase = _albrepo.GetAll();
                if (AlbumsBase.Contains(NouvelAlbum) == false) { _albrepo.Save(NouvelAlbum); }
                Domain.Action Achat = new Domain.Action("Achat", Utilisateur, NouvelAlbum);
                _actionrepo.SaveAction(Achat);
                Utilisateur.ActionsUser.Add(Achat);
                btnValider.BackColor = Color.PeachPuff;
                btnFermerPopUp.PerformClick();
                initialiseAffichageMarche();
                affichageAlbums();
            }
            else { MessageBox.Show("Veuillez remplir tous les champs avant de valider. "); }
        }

        //Modification des textbox des paramètres d'un album
        private void tbTitre_TextChanged(object sender, EventArgs e)
        {
            if (tbTitre.Text != "") { NouvelAlbum.Nom = tbTitre.Text; ApparitionBoutonValider(); }
        }
        private void tbAuteur_TextChanged(object sender, EventArgs e)
        {
            if (tbAuteur.Text != "") {  NouvelAlbum.Auteur = tbAuteur.Text; ApparitionBoutonValider();}
        }
        private void tbSerie_TextChanged(object sender, EventArgs e)
        {
            if (tbSerie.Text != "") { NouvelAlbum.Serie = tbSerie.Text; ApparitionBoutonValider(); }
        }
        private void tbEditeur_TextChanged(object sender, EventArgs e)
        {
            if (tbEditeur.Text != "") { NouvelAlbum.Editeur = tbEditeur.Text; ApparitionBoutonValider(); }
        }
        private void tbResume_TextChanged(object sender, EventArgs e)
        {
            if (tbResume.Text != "") { NouvelAlbum.Resume = tbResume.Text;ApparitionBoutonValider(); }
        }
        private void tbCategorie_TextChanged(object sender, EventArgs e)
        {
            if (tbCategorie.Text != "")
            {
                placeholder.Visible = false;
                NouvelAlbum.Categorie = tbCategorie.Text;
                ApparitionBoutonValider();
            }
        }
        private void tbGenre_TextChanged(object sender, EventArgs e)
        {
            if (tbGenre.Text != "")
            {
                placeholder.Visible = false;
                NouvelAlbum.Genre = tbGenre.Text;
                ApparitionBoutonValider();
            }
        }

        //Ajout d'une image à partir d'un fichier utilisateur dans le bin debug
        private void btnParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog parcourir = new OpenFileDialog();
            parcourir.DefaultExt = "jpg";
            parcourir.ShowDialog();
            string couverturespath = Path.Combine(Environment.CurrentDirectory, "CircuitBD.Net", "Couvertures");
            if (!Directory.Exists(couverturespath))
            {
                Directory.CreateDirectory(couverturespath);
            }
            string fileName = Path.GetFileName(parcourir.FileName);
            int numfile = 0;
            DirectoryInfo di = new DirectoryInfo(couverturespath);
            FileInfo[] allFiles = di.GetFiles(fileName);
            while (allFiles.Length != 0)
            {
                fileName += numfile;
                numfile += 1;
                allFiles = di.GetFiles(fileName);
            }
            if (fileName != "")
            {
                File.Copy(parcourir.FileName, Path.Combine(couverturespath, fileName));
                NouvelAlbum.Couverture = fileName;
                btnParcourir.Text = "Modifier";
                btnParcourir.BackColor = Color.Moccasin;
            }
        }

        //Mise à jour des images et titres à afficher
        private void AffichageCouvertures(int num, List<Album> AlbumsDuMarché, PictureBox pb, Label lbl)
        {
            Album a1 = AlbumsDuMarché[num];
            if (a1.Couverture != "" && a1.Couverture != null)
            {
                pb.Image = Image.FromFile(Path.Combine(cheminacces, a1.Couverture));
                lbl.Text = a1.Nom;
            }
            else { lbl.Text = a1.Nom; pb.Image = null; }
        }
        private void RefreshCarrousel(List<Album> AlbumsDuMarché, bool NextNecessary, bool PreviousNecessary, int Numero, PictureBox pbAlbum1, PictureBox pbAlbum2, PictureBox pbAlbum3, PictureBox pbAlbum4, Label lblTitre1, Label lblTitre2, Label lblTitre3, Label lblTitre4)
        {
            while (Numero < AlbumsDuMarché.Count && NextNecessary == false)
            {
                AffichageCouvertures(Numero, AlbumsDuMarché, pbAlbum1, lblTitre1);
                if (Numero + 1 < AlbumsDuMarché.Count)
                {
                    AffichageCouvertures(Numero + 1, AlbumsDuMarché, pbAlbum2, lblTitre2);
                    if (Numero + 2 < AlbumsDuMarché.Count)
                    {
                        AffichageCouvertures(Numero + 2, AlbumsDuMarché, pbAlbum3, lblTitre3);
                        if (Numero + 3 < AlbumsDuMarché.Count) { AffichageCouvertures(Numero + 3, AlbumsDuMarché, pbAlbum4, lblTitre4); }
                    }
                }
                NextNecessary = true;
                if (Numero > 0) { PreviousNecessary = true; }
            }
            if (lblAlbums.ForeColor == Color.Black || lblMarché.ForeColor == Color.Black) { couleurBtn(AlbumsDuMarché, Numero, btnNext, btnPrevious); }
            else { couleurBtn(AlbumsDuMarché, Numero, btnNextSouhaits, btnPerviousSouhaits); }
        }
        //Mise à jour carrousel de la collection
        private void RefreshCollection()
        {
            RecupererAchatUser();
            RefreshCarrousel(Utilisateur.ListAlbums, NextNecessaryAlbum, PreviousNecessaryAlbum, NumeroAlbum, pbAlbum1, pbAlbum2, pbAlbum3, pbAlbum4, lblTitre1, lblTitre2, lblTitre3, lblTitre4); 
        }
        //Mise à jour carrousel des marché
        private void RefreshViews()
        {
            initialiseAffichageMarche();
            List<Album> AlbumsDuMarché = new List<Album>();
            if (Recherche == true) { AlbumsDuMarché = RechercheAlbum(); }
            else { AlbumsDuMarché = _albrepo.GetByNameOfAction("AjoutMarché");  }
            RefreshCarrousel(AlbumsDuMarché, NextNecessaryMarche, PreviousNecessaryMarche, NumeroAlbumMarche, pbAlbum1, pbAlbum2, pbAlbum3, pbAlbum4, lblTitre1, lblTitre2, lblTitre3, lblTitre4);     
        }
        //Mise à jour carrousel des souhaits
        private void RefreshSouhaits()
        {
            dgvSouhaits.Rows.Clear();
            initialiseAffichageSouhait();
            RecupererSouhaitUser();
            RefreshCarrousel(Utilisateur.ListSouhaits, NextNecessarySouhait, PreviousNecessarySouhait, NumeroAlbumSouhait, pbSouhait1, pbSouhait2, pbSouhait3, pbSouhait4, lblTitreSouhait1, lblTitreSouhait2, lblTitreSouhait3, lblTitreSouhait4);
        }

        //Récupérer la liste des souhaits d'un utilisateur
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
                    if (Utilisateur.Voeux.Contains(a) == false) { Utilisateur.Voeux.Add(a); }
                }
            }
            foreach (Domain.Action a in Utilisateur.Voeux)
            {
                dgvSouhaits.Rows.Add(a.Album.Serie, a.Album.Nom, a.Date);
                if (Utilisateur.ListSouhaits.Contains(a.Album) == false) {  Utilisateur.ListSouhaits.Add(a.Album); }
            }
        }
        
        //Récupérer les albums de la collection d'un utilisateur
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
                    if (Utilisateur.Achats.Contains(a) == false){ Utilisateur.Achats.Add(a); }
                }
            }
            foreach (Domain.Action a in Utilisateur.Achats)
            {
                if (Utilisateur.ListAlbums.Contains(a.Album) == false) { Utilisateur.ListAlbums.Add(a.Album); }
            }
        }
       
        //Affichages des informations sur un album
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
            else
            {
                btnAjoutSouhaits.Visible = true;
                btnAppartenance.Visible = true;
            }
            string titrealbum = ((Label)sender).Text;
            SelectedAlbum = _albrepo.GetAlbumByTitle(titrealbum);
            if (SelectedAlbum.Couverture != "" && SelectedAlbum.Couverture != null)
            {
                pbCouvertureDetail.Image = Image.FromFile(Path.Combine(cheminacces, SelectedAlbum.Couverture));
            }
            else { pbCouvertureDetail.Image = null; }
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
            else { btnAppartenance.BackColor = Color.Gold; }
            RecupererSouhaitUser();
            //si l'album est présent dans la liste des albums ou des souhaits, il ne peut plus être ajouté aux souhaits
            if (Utilisateur.ListSouhaits.Contains(SelectedAlbum) || Utilisateur.ListAlbums.Contains(SelectedAlbum))
            {
                SelectedAlbum.selected = true;
                btnAjoutSouhaits.BackColor = Color.LightGray;
            }
            else{ btnAjoutSouhaits.BackColor = Color.Salmon; }
        }
        //Fermer bulle d'informations
        private void btnFermerPopUp_Click(object sender, EventArgs e)
        {
            gbInfosAlbum.Visible = false;
            if (lblAlbums.ForeColor == Color.Black) { pbInfo1.Visible = true; }
            else { pbinfo.Visible = true; }
        }

        //Ajouter un album spécifique à la collection
        private void AjouterAlbumCollection(Album alb)
        {
            Domain.Action Achat = new Domain.Action("Achat", Utilisateur, alb);
            Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(alb, "AjouterSouhait");
            _actionrepo.DeleteAction(ActionASupprimer);
            Utilisateur.ActionsUser.Remove(ActionASupprimer);
            _actionrepo.SaveAction(Achat);
            Utilisateur.ActionsUser.Add(Achat);
            _persrepo.Save(Utilisateur);
            btnAjoutSouhaits.BackColor = Color.LightGray;
        }
        private void btnAppartenance_Click(object sender, EventArgs e)
        {
            if (lblSouhaits.ForeColor == Color.Black)
            {
                string PictureBoxDuMessage = ((PictureBox)sender).Name;
                if (PictureBoxDuMessage == "pbPanier1") { SelectedAlbum = _albrepo.GetAlbumByTitle(lblTitreSouhait1.Text); }
                if (PictureBoxDuMessage == "pbPanier2") { SelectedAlbum = _albrepo.GetAlbumByTitle(lblTitreSouhait2.Text); }
                if (PictureBoxDuMessage == "pbPanier3") { SelectedAlbum = _albrepo.GetAlbumByTitle(lblTitreSouhait3.Text); }
                if (PictureBoxDuMessage == "pbPanier4") { SelectedAlbum = _albrepo.GetAlbumByTitle(lblTitreSouhait4.Text); }
                if (MessageBox.Show("Voulez-vous vraiment ajouter l'album " + SelectedAlbum.Nom+ " à votre liste ?", "AjoutAlbum", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AjouterAlbumCollection(SelectedAlbum);
                    _persrepo.Save(Utilisateur);
                    SelectedAlbum.selected = false;
                    affichagesChoixSouhaits();
                }
                RefreshSouhaits();
            }
            else
            {
                if (SelectedAlbum.posseder == false)
                {
                    MessageBox.Show("L'album " + SelectedAlbum.Nom + " a bien été ajouté à la liste des albums que vous possédez !");
                    SelectedAlbum.posseder = true;
                    btnAppartenance.BackColor = Color.LightGray;
                    AjouterAlbumCollection(SelectedAlbum);
                    RefreshViews();
                }
                else { MessageBox.Show("L'album " + SelectedAlbum.Nom + " est déjà dans vos albums."); }
            }
        }
        //Ajouter tous les souhaits à la collection
        private void pbPanier_Click(object sender, EventArgs e)
        {
            RecupererSouhaitUser();
            if (Utilisateur.ListSouhaits.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous ajouter l'ensemble de votre liste de souhaits dans votre liste d'albums ?", "Acheter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (Album souhait in Utilisateur.ListSouhaits) { AjouterAlbumCollection(souhait); }
                }
                Utilisateur.ListSouhaits = null;
                Utilisateur.ListSouhaits = new List<Album>();
                affichagesChoixSouhaits();
                if (lblAlbums.ForeColor == Color.Black) { RefreshCollection(); }
                else
                {
                    if (lblMarché.ForeColor == Color.Black) { RefreshViews(); }
                    else { RefreshSouhaits(); }
                }
            }
            else { MessageBox.Show("Vous n'avez encore aucun album dans votre liste de souhaits. Rendez-vous dans le marché si vous voulez en ajouter !"); }
        }

        //Ajouter un album aux souhaits
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
        
        //Supprimer un album des souhaits
        private void SupprimerAlbumSouhait()
        {
            Utilisateur.ListSouhaits.Remove(SelectedAlbum);
            Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(SelectedAlbum, "AjouterSouhait");
            _actionrepo.DeleteAction(ActionASupprimer);
            Utilisateur.ActionsUser.Remove(ActionASupprimer);
        }
        private void pbCoeur_Click(object sender, EventArgs e)
        {
            string PictureBoxDuMessage = ((PictureBox)sender).Name;
            if (PictureBoxDuMessage == "pbCoeur1") {  SelectedAlbum = _albrepo.GetAlbumByTitle(lblTitreSouhait1.Text); }
            if (PictureBoxDuMessage == "pbCoeur2") {  SelectedAlbum = _albrepo.GetAlbumByTitle(lblTitreSouhait2.Text); }
            if (PictureBoxDuMessage == "pbCoeur3") {  SelectedAlbum = _albrepo.GetAlbumByTitle(lblTitreSouhait3.Text); }
            if (PictureBoxDuMessage == "pbCoeur4") {  SelectedAlbum = _albrepo.GetAlbumByTitle(lblTitreSouhait4.Text); }
            if (MessageBox.Show("Voulez-vous vraiment supprimer cet album de vos souhaits ?", "Supprimer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SupprimerAlbumSouhait();
                _persrepo.Save(Utilisateur);
                btnAjoutSouhaits.BackColor = Color.LightSalmon;
                SelectedAlbum.selected = false;
                affichagesChoixSouhaits();
            }
            RefreshSouhaits();
        }

        //Recherche d'un album à partir d'un mot clé
        private List<Album> RechercheAlbum()
        {
            string recherche = tbBarreRecherche.Text;
            AlbumRepository albumRepository = new AlbumRepository();
            List<Album> albumsrecherche = albumRepository.GetAlbumByRecherche(recherche);
            return albumsrecherche;
        }
        private void btnValideRecherche_Click(object sender, EventArgs e)
        {
            Recherche = true;
            initialiseAffichageMarche();
            List<Album> albumsrecherche = RechercheAlbum();
            NumeroAlbumMarche = 0;
            RefreshCarrousel(albumsrecherche, NextNecessaryMarche, PreviousNecessaryMarche,NumeroAlbumMarche, pbAlbum1, pbAlbum2, pbAlbum3, pbAlbum4, lblTitre1, lblTitre2, lblTitre3, lblTitre4);
            gbInfosAlbum.Visible = false;
        }

        //Modification d'affichage des boutons de changement de page
        private void couleurBtn(List<Album> Albums, int Num, Button Next, Button Previous)
        {
            if (Num + 4 < Albums.Count) { Next.Enabled = true; Next.BackColor = Color.LightPink; }
            else { Next.Enabled = false; Next.BackColor = Color.LightGray; }
            if (Num > 0) { Previous.Enabled = true; Previous.BackColor = Color.LightPink; }
            else { Previous.Enabled = false; Previous.BackColor = Color.LightGray; }
        }
        //Modification des paramètres du nombre d'albums à afficher sur la page (4 par page) 
        private void btnNext_Click(object sender, EventArgs e)
        {
            List<Album> Albums = new List<Album>();
            if (lblAlbums.ForeColor == Color.Black)
            {
                RecupererAchatUser();
                Albums = Utilisateur.ListAlbums;
                if (NumeroAlbum + 4 < Albums.Count)
                {
                    NextNecessaryAlbum = false;
                    initialiseAffichageMarche();
                    NumeroAlbum = NumeroAlbum + 4; RefreshCollection();
                }
            }
            else
            {
                Albums = _albrepo.GetByNameOfAction("AjoutMarché");
                if (NumeroAlbumMarche + 4 < Albums.Count)
                {
                    NextNecessaryMarche = false;
                    initialiseAffichageMarche();
                    NumeroAlbumMarche = NumeroAlbumMarche + 4; RefreshViews();

                }
            }
        }
        private void btnNextSouhait_Click(object sender, EventArgs e)
        {
            RecupererSouhaitUser();
            List<Album> Albums = Utilisateur.ListSouhaits;
            if (NumeroAlbumSouhait + 4 < Albums.Count)
            {
                NextNecessarySouhait = false;
                initialiseAffichageSouhait();
                NumeroAlbumSouhait = NumeroAlbumSouhait + 4;
            }
            affichagesChoixSouhaits();
            RefreshSouhaits();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lblAlbums.ForeColor == Color.Black)
            {
                if (NumeroAlbum - 4 >= 0)
                {
                    PreviousNecessaryAlbum = false;
                    initialiseAffichageMarche();
                    NumeroAlbum = NumeroAlbum - 4;
                    RefreshCollection();
                }
            }
            else
            {
                if (NumeroAlbumMarche - 4 >= 0)
                {
                    PreviousNecessaryMarche = false;
                    initialiseAffichageMarche();
                    NumeroAlbumMarche = NumeroAlbumMarche - 4;
                    RefreshViews(); 
                }
            }
        }
        private void btnPerviousSouhaits_Click(object sender, EventArgs e)
        {
            if (NumeroAlbumSouhait - 4 >= 0)
            {
                 PreviousNecessarySouhait = false;
                initialiseAffichageSouhait();
                NumeroAlbumSouhait = NumeroAlbumSouhait - 4;
            }
            affichagesChoixSouhaits();
            RefreshSouhaits();
        }

        //Remise à 0 des paramètres d'affichage des albums
        private void initialiseAffichageMarche()
        {
            pbAlbum1.Image = null;
            pbAlbum2.Image = null;
            pbAlbum3.Image = null;
            pbAlbum4.Image = null;
            lblTitre1.Text = "";
            lblTitre2.Text = "";
            lblTitre3.Text = "";
            lblTitre4.Text = "";
        }
        private void initialiseAffichageSouhait()
        {
            pbSouhait1.Image = null;
            pbSouhait2.Image = null;
            pbSouhait3.Image = null;
            pbSouhait4.Image = null;
            lblTitreSouhait1.Text = "";
            lblTitreSouhait2.Text = "";
            lblTitreSouhait3.Text = "";
            lblTitreSouhait4.Text = "";
        }
    }
}









