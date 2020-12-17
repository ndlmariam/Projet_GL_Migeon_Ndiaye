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
    public partial class FormUtil : Form
    {
        private bool ClickedOnce; // booléen utile pour l'appartition ou disparition du menu
        private  IMarcheRepository _marcherepo;
        public Personne Utilisateur { get; set; }
        // technique du singleton pour avoir une seule instance de notre form
        private static FormUtil instanceformutil = null;
        public static FormUtil InstanceFormUtil
        {
            get { if (instanceformutil == null) {
                    IMarcheRepository RepositoryDuMarche = new MarcheRepository();
                    instanceformutil = new FormUtil(RepositoryDuMarche); }
                    return instanceformutil; }
            
        }
        private FormUtil(IMarcheRepository MarcheRepository)
        {
            InitializeComponent();
            _marcherepo = MarcheRepository;
           
        }
        // événements du form
        private void FormUtil_Load(object sender, EventArgs e)
        {
            lblNom.Text = Utilisateur.Nom;
            gbSouhaits.Visible = false;
            gbMarché.Visible = false;
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            dgvMarché.DataSource = null;
           
            List<Album> AlbumsDuMarché = _marcherepo.GetAll();
            dgvMarché.DataSource = AlbumsDuMarché;

        }

        private void FormUtil_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
        }
        // évènements clicks
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
            RefreshDgv();
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

        
    }
}
