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
        // technique du singleton pour avoir une seule instance de notre form
        private static FormUtil instanceformutil = null;
        public static FormUtil InstanceFormUtil
        {
            get { if (instanceformutil == null) { instanceformutil = new FormUtil(); } return instanceformutil; }
        }
        private FormUtil()
        {
            InitializeComponent();
           
        }
        // évènements du form
        private void FormUtil_Load(object sender, EventArgs e)
        {
            gbSouhaits.Visible = false;
            gbMarché.Visible = false;
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
       

        private void pbSouhaits_Click(object sender, EventArgs e)

        {
            gbMarché.Visible = false;
            gbSouhaits.Visible = true;
            gbHeader.Text = "Mes Souhaits";
        }
        private void pbMarché_Click(object sender, EventArgs e)
        {
            gbMarché.Visible = true;
            gbHeader.Text = "MarchéBD";
        }

        private void pbDeco_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("Etes vous sûr de vouloir vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
