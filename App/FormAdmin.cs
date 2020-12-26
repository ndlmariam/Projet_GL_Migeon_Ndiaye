﻿using DAL;
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
        private FormAdmin(IActionRepository ActionRepository,IPersonneRepository PersonneRepository, IAlbumRepository AlbumRepository)
        {
            InitializeComponent();
            if(!Directory.Exists(applipath))
            {
                Directory.CreateDirectory(applipath);
            }
            disparition = false;
            _actionrepo = ActionRepository;
            _albumrepo = AlbumRepository;
        }

       

        private void gbAjoutAlbum_MouseHover(object sender, EventArgs e)
        {
            if (placeholder != null && disparition == false) { placeholder.Visible = true; }
         
        }

        private void tbCategorie_TextChanged(object sender, EventArgs e)
        {
            placeholder.Visible = false;
            disparition = true;
            NouvelAlbum.Categorie = tbCategorie.Text;
            RefreshDgv();
        }

        private void tbGenre_TextChanged(object sender, EventArgs e)
        {
            placeholder.Visible = false;
            disparition = true;
            NouvelAlbum.Genre = tbGenre.Text;
            RefreshDgv();
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog parcourir = new OpenFileDialog();
            parcourir.DefaultExt = "jpg";
            parcourir.ShowDialog();
            string couverturespath = Path.Combine(apppath, "CircuitBD.Net", "Couvertures");
            if (!Directory.Exists(couverturespath))
            {
                Directory.CreateDirectory(couverturespath);
            }
            string fileName = Path.GetFileName(parcourir.FileName);
          File.Copy(parcourir.FileName, Path.Combine(couverturespath, fileName));

           // string cheminacces = Path.Combine(couverturespath, fileName);
            NouvelAlbum.Couverture = fileName;

        }

        private void PlaceHolder_MouseHover(object sender, EventArgs e)
        {
            placeholder = ((Label)sender);
            placeholder.Visible = false;
        }
        private void pbDeco_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Etes vous sûr de vouloir vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                instanceformadmin.Close();
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            btnValider.Visible = false;
            gbAjoutAlbum.Visible = true;
            gbMarchéAdmin.Visible = false;
            NouvelAlbum = new Album();
            
          
          
        }

        private void pbMarché_Click(object sender, EventArgs e)
        {
            gbMarchéAdmin.Visible = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Domain.Action AjoutMarché = new Domain.Action("AjoutMarché", Administrateur, NouvelAlbum);
            _albumrepo.Save(NouvelAlbum);
            _actionrepo.SaveAction(AjoutMarché);
            gbMarchéAdmin.Visible = true;
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            dgvMarché.DataSource = null;
            if (btnValider.Visible == false)
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
            List<Album> AlbumsDuMarché = _albumrepo.GetByNameOfAction("AjoutMarché");
            dgvMarché.DataSource = AlbumsDuMarché;

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblNom.Text = Administrateur.Nom;
            RefreshDgv();
        }

        private void tbTitre_TextChanged(object sender, EventArgs e)
        {
            NouvelAlbum.Nom = tbTitre.Text;
            RefreshDgv();
        }

        private void tbAuteur_TextChanged(object sender, EventArgs e)
        {
            NouvelAlbum.Auteur = tbAuteur.Text;
            RefreshDgv();
        }

        private void tbSerie_TextChanged(object sender, EventArgs e)
        {
            NouvelAlbum.Serie = tbSerie.Text; RefreshDgv();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Etes-Vous sur de vouloir supprimer un album ? Il sera définitivement supprimé de marchéBD", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==DialogResult.OK )
            {
                gbSuppression.Visible = true;
              
            }
           
        }

        private void tbSupression_TextChanged(object sender, EventArgs e)
        {
            btnSupressionSure.Visible = true;

        }

        private void btnSupressionSure_Click(object sender, EventArgs e)
        {
            gbSuppression.Visible = false;
            Album AlbumASuprimmer = _albumrepo.GetAlbumByTitle(tbSupression.Text);
            Domain.Action Suppression = new Domain.Action("Supression", Administrateur, AlbumASuprimmer);
            _actionrepo.SaveAction(Suppression);
            _albumrepo.Delete(AlbumASuprimmer);
            Domain.Action ActionASupprimer =_actionrepo.GetActionByNameAndAlbum( AlbumASuprimmer, "AjoutMarché");
            
          
                _actionrepo.DeleteAction(ActionASupprimer);
            
            RefreshDgv();
        }

        private void tbEditeur_TextChanged(object sender, EventArgs e)
        {
            NouvelAlbum.Editeur = tbEditeur.Text;
            RefreshDgv();
        }

        private void tbResume_TextChanged(object sender, EventArgs e)
        {
            NouvelAlbum.Resume = tbResume.Text;
            RefreshDgv();
        }
    }
}
