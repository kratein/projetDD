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
    public partial class CreationPersonnage : Form
    {
        CreationGroupe c = new CreationGroupe();

        public CreationPersonnage()
        {
            InitializeComponent();
        }

        private void btRetour_Click(object sender, EventArgs e)
        {            
            c.Show();
            this.Close();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            c.Show();
            this.Close();
        }
    }
}
