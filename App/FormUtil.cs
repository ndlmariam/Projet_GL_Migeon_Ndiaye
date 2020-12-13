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
        public FormUtil()
        {
            InitializeComponent();
           
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            Menu.Visible = true;
        }

        private void FormUtil_Load(object sender, EventArgs e)
        {

        }

        private void FormUtil_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
        }
    }
}
