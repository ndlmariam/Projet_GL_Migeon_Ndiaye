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
        private bool ClickedOnce;
        public FormUtil()
        {
            InitializeComponent();
           
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (ClickedOnce == false) { Menu.Visible = true; ClickedOnce = true; }
            else { Menu.Visible = false; ClickedOnce = false; }
        }

        private void FormUtil_Load(object sender, EventArgs e)
        {
            gbSouhaits.Visible = false;
           gbMarché.Visible = false;
        }

        private void FormUtil_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
        }

        private void pbSouhaits_Click(object sender, EventArgs e)
        {
            gbSouhaits.Visible = true;
            gbHeader.Text = "Mes Souhaits";
        }

        private void gb_MouseHover(object sender, EventArgs e)
        {
            Menu.Visible = false;
        }

        private void gbAlbums_MouseHover(object sender, EventArgs e)
        {
            Menu.Visible = false;
        }

        private void pbMarché_Click(object sender, EventArgs e)
        {
            gbMarché.Visible = true;
            gbHeader.Text = "MarchéBD";
        }
    }
}
