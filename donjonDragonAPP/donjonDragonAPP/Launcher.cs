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
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btJouer_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            this.Hide();
            m.Show();
        }
    }
}
