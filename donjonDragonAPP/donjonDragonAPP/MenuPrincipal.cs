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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            CreationGroupe c = new CreationGroupe();            
            c.Show();
            this.Close();
        }
    }
}
