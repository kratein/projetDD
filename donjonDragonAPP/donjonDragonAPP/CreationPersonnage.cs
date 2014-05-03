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
        bool chiffre;
        string prenom;

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

        private void tbNom_Validated(object sender, EventArgs e)
        {
            string lettre;
            int taillePrenom;
            float erreur;
            bool test, espace;
            

            test = false;
            prenom = tbNom.Text;
            taillePrenom = prenom.Length;
            espace = prenom.Contains(" ");
            for (int i = 0; i < taillePrenom; i++)
            {
                lettre = Convert.ToString(prenom[i]);
                test = Single.TryParse(lettre, out erreur);
                if (test)
                {
                    chiffre = true;
                }
            }
            if (chiffre == true || espace == true)
            {
                MessageBox.Show("Le nom de votre personnage ne peut pas contenir d'espace ou de chiffres.");
                tbNom.Text = "";
            }
        }
    }
}
