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
    public partial class FormAdmin : Form
    {
        private bool disparition;
        private static string apppath =Environment.CurrentDirectory;
        private static string applipath = Path.Combine(apppath, "CircuitBD.Net");
        Label placeholder;
        Album NouvelAlbum;
        private static string cheminacces = Path.Combine(Environment.CurrentDirectory, "CircuitBD.Net", "Couvertures");
        public Personne Administrateur { get; set; }
        private IActionRepository _actionrepo;
        private IAlbumRepository _albumrepo;
        // technique du singleton pour avoir une seule instance de notre form
        private static FormAdmin instanceformadmin = null;
        public static FormAdmin InstanceFormAdmin
        {
            get
            {
                if (instanceformadmin == null)
                {
                    //IMPORTANT : INSTANCIATION DES REPOSITORY
                    IAlbumRepository AlbumRepository = new AlbumRepository();
                    IPersonneRepository PersonneRepository = new PersonneRepository();
                    IActionRepository ActionRepository = new ActionRepository();
                    instanceformadmin = new FormAdmin(ActionRepository,PersonneRepository,AlbumRepository);
                }
                return instanceformadmin;
            }
        }

        //Initialisation du formulaire
        private FormAdmin(IActionRepository ActionRepository,IPersonneRepository PersonneRepository, IAlbumRepository AlbumRepository)
        {
            InitializeComponent();
            if(!Directory.Exists(applipath)) { Directory.CreateDirectory(applipath); }
            disparition = false;
            _actionrepo = ActionRepository;
            _albumrepo = AlbumRepository;
        }
        //Actualisation du formulaire
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblNom.Text = Administrateur.Nom;
            RefreshDgv();
        }
        //Ajout d'album
        private void btnAjout_Click(object sender, EventArgs e)
        {
            plholdCat.Visible = true;
            plholdGenre.Visible = true;
            btnValider.Visible = false;
            gbAjoutAlbum.Visible = true;
            gbMarchéAdmin.Visible = false;
            NouvelAlbum = new Album();
        }

        //Verifcation des champs remplis
        private bool ChampRempli(string champ)
        {
            if (String.IsNullOrEmpty(champ) == false && champ != "") { return true; }
            return false;
        }
        //Actualisation du datagridview des albums du marché
        private void RefreshDgv()
        {
            dgvMarché.DataSource = null;
            if (btnValider.Visible == false)
            {
              //Affichage du bouton de validation si tous les champs sont remplis
              if(ChampRempli(tbTitre.Text) && ChampRempli(tbAuteur.Text) && ChampRempli(tbCategorie.Text) && ChampRempli(tbSerie.Text) && ChampRempli(tbGenre.Text) && ChampRempli(tbResume.Text) && ChampRempli(tbEditeur.Text)) { btnValider.Visible = true; }
            }
            List<Album> AlbumsDuMarché = _albumrepo.GetByNameOfAction("AjoutMarché");
            dgvMarché.Rows.Clear();
            for (int i = 0; i < AlbumsDuMarché.Count; i++)
            {
                Album a = AlbumsDuMarché[i];
                Image image;
                if (a.Couverture != "" && a.Couverture != null)
                {
                    image = Image.FromFile(Path.Combine(cheminacces, a.Couverture));
                    dgvMarché.Rows.Add(image, a.Nom, a.Serie, a.Auteur, a.Editeur, a.Categorie, a.Genre, a.Resume);
                }
                else { dgvMarché.Rows.Add(null, a.Nom, a.Serie, a.Auteur, a.Editeur, a.Categorie, a.Genre, a.Resume); }
            }
        }

        //Redirection vers l'accueil
        private void pbMarché_Click(object sender, EventArgs e) { gbMarchéAdmin.Visible = true; }

        //Disparition des explications textbox quand on survole
        private void gbAjoutAlbum_MouseHover(object sender, EventArgs e)
        {
            if (placeholder != null && disparition == false) { placeholder.Visible = true; }
        }
        private void PlaceHolder_MouseHover(object sender, EventArgs e)
        {
            placeholder = ((Label)sender);
            placeholder.Visible = false;
        }

        //Affectation des nouveaux attributs des albums quand textbox remplie
        private void tbCategorie_TextChanged(object sender, EventArgs e)
        {
            if (tbCategorie.Text != "")
            {
                placeholder.Visible = false;
                disparition = true;
                NouvelAlbum.Categorie = tbCategorie.Text;
                RefreshDgv();
            }
        }

        private void tbGenre_TextChanged(object sender, EventArgs e)
        {
            if (tbGenre.Text != "")
            {
                placeholder.Visible = false;
                disparition = true;
                NouvelAlbum.Genre = tbGenre.Text;
                RefreshDgv();
            }
        }

        private void tbTitre_TextChanged(object sender, EventArgs e)
        {
            if (tbTitre.Text != "") { NouvelAlbum.Nom = tbTitre.Text; RefreshDgv(); }
        }

        private void tbAuteur_TextChanged(object sender, EventArgs e)
        {
            if (tbAuteur.Text != "") { NouvelAlbum.Auteur = tbAuteur.Text; RefreshDgv(); }
        }

        private void tbSerie_TextChanged(object sender, EventArgs e)
        {
            if (tbSerie.Text != "") { NouvelAlbum.Serie = tbSerie.Text; RefreshDgv(); }
        }

        private void tbEditeur_TextChanged(object sender, EventArgs e)
        {
            if (tbEditeur.Text != "") { NouvelAlbum.Editeur = tbEditeur.Text; RefreshDgv(); }
        }

        private void tbResume_TextChanged(object sender, EventArgs e)
        {
            if (tbResume.Text != "") { NouvelAlbum.Resume = tbResume.Text; RefreshDgv(); }
        }

        //Recherche d'une image chez l'utilisateur et ajout au bin debug
        private void btnParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog parcourir = new OpenFileDialog();
            parcourir.DefaultExt = "jpg";
            parcourir.ShowDialog();
            string couverturespath = Path.Combine(apppath, "CircuitBD.Net", "Couvertures");
            if (!Directory.Exists(couverturespath)) {  Directory.CreateDirectory(couverturespath); }
            string fileName = Path.GetFileName(parcourir.FileName);
            int numfile = 0;
            DirectoryInfo di = new DirectoryInfo(couverturespath);
            FileInfo[] allFiles = di.GetFiles(fileName);
            while (allFiles.Length!=0)
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
        
        //Ajout de l'album au marché et mise à 0 des paramètres
        private void btnValider_Click(object sender, EventArgs e)
        {
            if(tbAuteur.Text!="" && tbTitre.Text != "" && tbCategorie.Text != "" && tbSerie.Text != "" && tbGenre.Text != "" && tbResume.Text != "" && tbEditeur.Text != "")
            {
                btnParcourir.Text = "Parcourir";
                btnParcourir.BackColor = Color.SpringGreen;
                Domain.Action AjoutMarché = new Domain.Action("AjoutMarché", Administrateur, NouvelAlbum);
                _albumrepo.Save(NouvelAlbum);
                _actionrepo.SaveAction(AjoutMarché);
                gbMarchéAdmin.Visible = true;
                RefreshDgv();
                tbAuteur.Text = "";
                tbTitre.Text = "";
                tbCategorie.Text = "";
                tbSerie.Text = "";
                tbGenre.Text = "";
                tbResume.Text = "";
                tbEditeur.Text = "";
            }
            else { MessageBox.Show("Veuillez remplir tous les champs avant de valider. "); }
            
        }

        //Deconnexion
        private void pbDeco_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de vouloir vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblNom.Text = "";
                instanceformadmin.Close();
            }
        }

        //Suppression d'albums
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Etes-Vous sur de vouloir supprimer un album ? Il sera définitivement supprimé de marchéBD", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==DialogResult.OK )
            {
                gbSuppression.Visible = true;
                tbSupression.Text = "";
            }
        }

        private void tbSupression_TextChanged(object sender, EventArgs e) { btnSupressionSure.Visible = true; }

        private void btnSupressionSure_Click(object sender, EventArgs e)
        {
            gbSuppression.Visible = false;
            Album AlbumASuprimmer = _albumrepo.GetAlbumByTitle(tbSupression.Text);
            if (AlbumASuprimmer.Nom == null) { MessageBox.Show("Le titre que vous avez entré ne correspond a aucun album du marché. Veuillez réassayer."); }
            else
            {
                Domain.Action ActionASupprimer = _actionrepo.GetActionByNameAndAlbum(AlbumASuprimmer, "AjoutMarché");
                if (ActionASupprimer.Nom != null)
                {
                    _actionrepo.DeleteAction(ActionASupprimer);
                    _albumrepo.Delete(AlbumASuprimmer);
                    MessageBox.Show("L'album "+AlbumASuprimmer.Nom + " a bien été supprimé du marché ! ");
                }
                RefreshDgv();
            }
        }
    }
}
