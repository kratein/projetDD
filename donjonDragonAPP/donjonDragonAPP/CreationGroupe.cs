using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace donjonDragonAPP
{
    public partial class CreationGroupe : Form
    {
        public CreationGroupe()
        {
            InitializeComponent();
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
            this.Close();
        }

        private void pbPerso1_Click(object sender, EventArgs e)
        {
            CreationPersonnage c = new CreationPersonnage();
            c.Show();
            this.Close();
        }

        private void pbPerso2_Click(object sender, EventArgs e)
        {
            CreationPersonnage c = new CreationPersonnage();
            c.Show();
            this.Close();
        }

        private void pbPerso3_Click(object sender, EventArgs e)
        {
            CreationPersonnage c = new CreationPersonnage();
            c.Show();
            this.Close();
        }

        private void pbPerso4_Click(object sender, EventArgs e)
        {
            CreationPersonnage c = new CreationPersonnage();
            c.Show();
            this.Close();
        }
    }
}
