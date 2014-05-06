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
        int force;
        int constitution;
        int dexeterite;
        int intelligence;
        int sagesse;
        int charisme;

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

        private void listbClasse_SelectedValueChanged(object sender, EventArgs e)
        {
            lbBonusClasse.Visible = true;
            lbCa.Visible = true;
            lbVig.Visible = true;
            lbRef.Visible = true;
            lbVol.Visible = true;
            nudFor.Enabled = true;
            nudCon.Enabled = true;
            nudDex.Enabled = true;
            nudInt.Enabled = true;
            nudSag.Enabled = true;
            nudCha.Enabled = true;

            if (listbClasse.SelectedItem.ToString() == "Guerrier")
            {
                lbCa.Text = "0";
                lbVig.Text = "2";
                lbRef.Text = "0";
                lbVol.Text = "0";
                nudFor.Minimum = 10;
                nudFor.Value = 10;
                force = 10;
                nudCon.Minimum = 10;
                nudCon.Value = 10;
                constitution = 10;
                nudDex.Minimum = 10;
                nudDex.Value = 10;
                dexeterite = 10;
                nudSag.Minimum = 10;
                nudSag.Value = 10;
                sagesse = 10;
                nudInt.Minimum = 8;
                nudInt.Value = 8;
                intelligence = 8;
                nudCha.Minimum = 8;
                nudCha.Value = 8;
                charisme = 8;
            }
            if (listbClasse.SelectedItem.ToString() == "Magicien")
            {
                lbCa.Text = "0";
                lbVig.Text = "0";
                lbRef.Text = "0";
                lbVol.Text = "2";
                nudFor.Minimum = 8;
                nudFor.Value = 8;
                force = 8;
                nudCon.Minimum = 10;
                nudCon.Value = 10;
                constitution = 10;
                nudDex.Minimum = 10;
                nudDex.Value = 10;
                dexeterite = 10;
                nudSag.Minimum = 10;
                nudSag.Value = 10;
                sagesse = 10;
                nudInt.Minimum = 10;
                nudInt.Value = 10;
                intelligence = 10;
                nudCha.Minimum = 8;
                nudCha.Value = 8;
                charisme = 8;
            }
            if (listbClasse.SelectedItem.ToString() == "Voleur")
            {
                lbCa.Text = "0";
                lbVig.Text = "0";
                lbRef.Text = "2";
                lbVol.Text = "0";
                nudFor.Minimum = 10;
                nudFor.Value = 10;
                force = 10;
                nudCon.Minimum = 10;
                nudCon.Value = 10;
                constitution = 10;
                nudDex.Minimum = 10;
                nudDex.Value = 10;
                dexeterite = 10;
                nudSag.Minimum = 8;
                nudSag.Value = 8;
                sagesse = 8;
                nudInt.Minimum = 8;
                nudInt.Value = 8;
                intelligence = 8;
                nudCha.Minimum = 10;
                nudCha.Value = 10;
                charisme = 10;
            }
        }

        private void listbRace_SelectedValueChanged(object sender, EventArgs e)
        {
            lbBonus.Visible = true;
            lbBonusF.Visible = true;
            lbBonusC.Visible = true;
            lbBonusD.Visible = true;
            lbBonusI.Visible = true;
            lbBonusS.Visible = true;
            lbBonusCha.Visible = true;

            if (listbRace.SelectedItem.ToString() == "Drakéide")
            {
                lbBonusF.Text = "2";
                lbBonusC.Text = "0";
                lbBonusD.Text = "0";
                lbBonusI.Text = "0";
                lbBonusS.Text = "0";
                lbBonusCha.Text = "2";
            }
            if (listbRace.SelectedItem.ToString() == "Nain")
            {
                lbBonusF.Text = "0";
                lbBonusC.Text = "2";
                lbBonusD.Text = "0";
                lbBonusI.Text = "0";
                lbBonusS.Text = "2";
                lbBonusCha.Text = "0";
            }
            
        }

        private void nudFor_ValueChanged(object sender, EventArgs e)
        {

        }




    }
}
