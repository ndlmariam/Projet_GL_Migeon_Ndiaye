using DAL;
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
        private static string applidatapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string applipath = Path.Combine(applidatapath, "CircuitBD.Net");
        Label placeholder;

        // technique du singleton pour avoir une seule instance de notre form
        private static FormAdmin instanceformadmin = null;
        public static FormAdmin InstanceFormAdmin
        {
            get
            {
                if (instanceformadmin == null)
                {
                    IMarcheRepository RepositoryMarche = new MarcheRepository();
                    instanceformadmin = new FormAdmin(RepositoryMarche);
                }
                return instanceformadmin;
            }

        }
        private FormAdmin(IMarcheRepository MarcheRepository)
        {
            InitializeComponent();
            if(!Directory.Exists(applipath))
            {
                Directory.CreateDirectory(applipath);
            }
            disparition = false;

        }

       

        private void gbAjoutAlbum_MouseHover(object sender, EventArgs e)
        {
            if (placeholder != null && disparition == false) { placeholder.Visible = true; }
         
        }

        private void tbCategorie_TextChanged(object sender, EventArgs e)
        {
            placeholder.Visible = false;
            disparition = true;
        }

        private void tbGenre_TextChanged(object sender, EventArgs e)
        {
            placeholder.Visible = false;
            disparition = true;
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog parcourir = new OpenFileDialog();
            parcourir.DefaultExt = "jpg";
            parcourir.ShowDialog();
            string couverturespath = Path.Combine(applidatapath, "CircuitBD.Net", "Couvertures");
            if (!Directory.Exists(couverturespath))
            {
                Directory.CreateDirectory(couverturespath);
            }
            string fileName = Path.GetFileName(parcourir.FileName);
            File.Copy(parcourir.FileName, Path.Combine(couverturespath, fileName));
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
    }
}
