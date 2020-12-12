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
        bool RempliMdp;
        bool RempliLogin;
        bool CocheStatut;
        public FormAccueil()
        {
            InitializeComponent();
            RempliMdp = false;
            RempliLogin = false;
            CocheStatut = false;
            AffichageRefresh();

        }

    

      private void AffichageRefresh ()
        {
            btnConnexion.Click += btnConnexion_Click;
            btnCreation.Click += btnCreation_Click;
            if (RempliLogin == true && RempliMdp == true && CocheStatut == true)
            {
                btnValider.Visible = true;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            FormUtil formutil = new FormUtil();
            formutil.ShowDialog();
        }

       

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            // fait apparaître la group box correspondante
            gbCreation.Visible = false;
            gbConnexion.Visible = true;
            btnCreation.BackColor = Color.LightGray;
            btnConnexion.BackColor = Color.PaleGreen;


        }
        private void btnCreation_Click(object sender, EventArgs e)
        {
          
            gbCreation.Visible = true;
            btnConnexion.BackColor = Color.LightGray;
            btnCreation.BackColor = Color.PeachPuff;

        }

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

        private void tbLoginCrea_TextChanged(object sender, EventArgs e)
        {
            RempliLogin = true;
            AffichageRefresh();
        }

        private void tbMdpCrea_TextChanged(object sender, EventArgs e)
        {
            RempliMdp = true;
            AffichageRefresh();
        }

        private void tbLoginConnex_TextChanged(object sender, EventArgs e)
        {
            RempliLogin = true;
            AffichageRefresh();
        }

        private void tbMdpConnex_TextChanged(object sender, EventArgs e)
        {
            RempliMdp = true;
            AffichageRefresh();
        }
    }
}
