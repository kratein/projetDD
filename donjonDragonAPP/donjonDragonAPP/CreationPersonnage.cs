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
        int forceT=0;
        int constitution;
        int constitutionT=0;
        int dexeterite;
        int dexeteriteT=0;
        int intelligence;
        int intelligenceT=0;
        int sagesse;
        int sagesseT=0;
        int charisme;
        int charismeT=0;
        int ptsRestants = 22;
        int vigueur = 10;
        int reflexe = 10;
        int volonte = 10;

        public CreationPersonnage()
        {
            InitializeComponent();
            force = Convert.ToInt32(nudFor.Value);
            constitution = Convert.ToInt32(nudCon.Value);
            dexeterite = Convert.ToInt32(nudDex.Value);
            intelligence = Convert.ToInt32(nudInt.Value);
            sagesse = Convert.ToInt32(nudSag.Value);
            charisme = Convert.ToInt32(nudCha.Value);
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
                nudCha.Minimum = 10;
                nudCha.Value = 10;
                charisme = 10;
            }
            if (listbClasse.SelectedItem.ToString() == "Magicien")
            {                
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
                nudCha.Minimum = 10;
                nudCha.Value = 10;
                charisme = 10;
            }
            if (listbClasse.SelectedItem.ToString() == "Voleur")
            {
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
                nudSag.Minimum = 10;
                nudSag.Value = 10;
                sagesse = 10;
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
                int difference;


                difference = Convert.ToInt32(nudFor.Value) - force;

                if (difference == 1)
                {
                    if (force == 8)
                    {
                        ptsRestants = ptsRestants - 1;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (force == 9)
                        {
                            ptsRestants = ptsRestants - 1;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (force == 10)
                            {
                                ptsRestants = ptsRestants - 1;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (force == 11)
                                {
                                    ptsRestants = ptsRestants - 1;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (force == 12)
                                    {
                                        ptsRestants = ptsRestants - 1;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (force == 13)
                                        {
                                            ptsRestants = ptsRestants - 2;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                        else
                                        {
                                            if (force == 14)
                                            {
                                                ptsRestants = ptsRestants - 2;
                                                lbNbPts.Text = ptsRestants.ToString();
                                            }
                                            else
                                            {
                                                if (force == 15)
                                                {
                                                    ptsRestants = ptsRestants - 2;
                                                    lbNbPts.Text = ptsRestants.ToString();
                                                }
                                                else
                                                {
                                                    if (force == 16)
                                                    {
                                                        ptsRestants = ptsRestants - 3;
                                                        lbNbPts.Text = ptsRestants.ToString();
                                                    }
                                                    else
                                                    {
                                                        if (force == 17)
                                                        {
                                                            ptsRestants = ptsRestants - 4;
                                                            lbNbPts.Text = ptsRestants.ToString();
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (difference == -1)
                    {
                        if (force == 18)
                        {
                            ptsRestants = ptsRestants + 4;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (force == 17)
                            {
                                ptsRestants = ptsRestants + 3;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (force == 16)
                                {
                                    ptsRestants = ptsRestants + 2;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (force == 15)
                                    {
                                        ptsRestants = ptsRestants + 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (force == 14)
                                        {
                                            ptsRestants = ptsRestants + 2;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                        else
                                        {
                                            if (force == 13 || force == 12 || force == 11 || force == 10 || force == 9)
                                            {
                                                ptsRestants = ptsRestants + 1;
                                                lbNbPts.Text = ptsRestants.ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            force = Convert.ToInt32(nudFor.Value);
            forceT = force + Convert.ToInt32(lbBonusF.Text);
            if (forceT > constitutionT)
            {
                int modCarac;
                float calcul;

                if (force <= 8)
                {
                    modCarac = -1;
                }
                else
                {
                    calcul = (forceT - 10) / 2;                    
                    modCarac = (int)(Math.Floor(calcul));
                }
                vigueur = 10 + modCarac;
                lbNbVig.Text = vigueur.ToString();
            }

        }
        private void nudCon_ValueChanged(object sender, EventArgs e)
        {
            int difference;


            difference = Convert.ToInt32(nudCon.Value) - constitution;

            if (difference == 1)
            {
                if (constitution == 8)
                {
                    ptsRestants = ptsRestants - 1;
                    lbNbPts.Text = ptsRestants.ToString();
                }
                else
                {
                    if (constitution == 9)
                    {
                        ptsRestants = ptsRestants - 1;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (constitution == 10)
                        {
                            ptsRestants = ptsRestants - 1;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (constitution == 11)
                            {
                                ptsRestants = ptsRestants - 1;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (constitution == 12)
                                {
                                    ptsRestants = ptsRestants - 1;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (constitution == 13)
                                    {
                                        ptsRestants = ptsRestants - 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (constitution == 14)
                                        {
                                            ptsRestants = ptsRestants - 2;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                        else
                                        {
                                            if (constitution == 15)
                                            {
                                                ptsRestants = ptsRestants - 2;
                                                lbNbPts.Text = ptsRestants.ToString();
                                            }
                                            else
                                            {
                                                if (constitution == 16)
                                                {
                                                    ptsRestants = ptsRestants - 3;
                                                    lbNbPts.Text = ptsRestants.ToString();
                                                }
                                                else
                                                {
                                                    if (constitution == 17)
                                                    {
                                                        ptsRestants = ptsRestants - 4;
                                                        lbNbPts.Text = ptsRestants.ToString();
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (difference == -1)
                {
                    if (constitution == 18)
                    {
                        ptsRestants = ptsRestants + 4;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (constitution == 17)
                        {
                            ptsRestants = ptsRestants + 3;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (constitution == 16)
                            {
                                ptsRestants = ptsRestants + 2;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (constitution == 15)
                                {
                                    ptsRestants = ptsRestants + 2;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (constitution == 14)
                                    {
                                        ptsRestants = ptsRestants + 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (constitution == 13 || constitution == 12 || constitution == 11 || constitution == 10 || constitution == 9)
                                        {
                                            ptsRestants = ptsRestants + 1;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            constitution = Convert.ToInt32(nudCon.Value);
            constitutionT = constitution + Convert.ToInt32(lbBonusC.Text);
            if (forceT < constitutionT)
            {
                int modCarac;

                if (constitution <= 8)
                {
                    modCarac = -1;
                }
                else
                {
                    float calcul = (constitutionT - 10) / 2;
                    modCarac = (int)(Math.Floor(calcul));                    
                }
                vigueur = 10 + modCarac;
                lbNbVig.Text = vigueur.ToString();
            }
        }

        private void nudDex_ValueChanged(object sender, EventArgs e)
        {
            int difference;


            difference = Convert.ToInt32(nudDex.Value) - dexeterite;

            if (difference == 1)
            {
                if (dexeterite == 8)
                {
                    ptsRestants = ptsRestants - 1;
                    lbNbPts.Text = ptsRestants.ToString();
                }
                else
                {
                    if (dexeterite == 9)
                    {
                        ptsRestants = ptsRestants - 1;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (dexeterite == 10)
                        {
                            ptsRestants = ptsRestants - 1;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (dexeterite == 11)
                            {
                                ptsRestants = ptsRestants - 1;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (dexeterite == 12)
                                {
                                    ptsRestants = ptsRestants - 1;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (dexeterite == 13)
                                    {
                                        ptsRestants = ptsRestants - 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (dexeterite == 14)
                                        {
                                            ptsRestants = ptsRestants - 2;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                        else
                                        {
                                            if (dexeterite == 15)
                                            {
                                                ptsRestants = ptsRestants - 2;
                                                lbNbPts.Text = ptsRestants.ToString();
                                            }
                                            else
                                            {
                                                if (dexeterite == 16)
                                                {
                                                    ptsRestants = ptsRestants - 3;
                                                    lbNbPts.Text = ptsRestants.ToString();
                                                }
                                                else
                                                {
                                                    if (dexeterite == 17)
                                                    {
                                                        ptsRestants = ptsRestants - 4;
                                                        lbNbPts.Text = ptsRestants.ToString();
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (difference == -1)
                {
                    if (dexeterite == 18)
                    {
                        ptsRestants = ptsRestants + 4;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (dexeterite == 17)
                        {
                            ptsRestants = ptsRestants + 3;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (dexeterite == 16)
                            {
                                ptsRestants = ptsRestants + 2;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (dexeterite == 15)
                                {
                                    ptsRestants = ptsRestants + 2;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (dexeterite == 14)
                                    {
                                        ptsRestants = ptsRestants + 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (dexeterite == 13 || dexeterite == 12 || dexeterite == 11 || dexeterite == 10 || dexeterite == 9)
                                        {
                                            ptsRestants = ptsRestants + 1;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            dexeterite = Convert.ToInt32(nudDex.Value);
            dexeteriteT = dexeterite + Convert.ToInt32(lbBonusD.Text);
            if (dexeteriteT > intelligenceT)
            {
                int modCarac;

                if (dexeterite <= 8)
                {
                    modCarac = -1;
                }
                else
                {
                    float calcul = (dexeteriteT - 10) / 2;
                    modCarac = (int)(Math.Floor(calcul));
                }
                reflexe = 10 + modCarac;
                lbNbRef.Text = reflexe.ToString();
            }
        }

        private void nudInt_ValueChanged(object sender, EventArgs e)
        {
            int difference;


            difference = Convert.ToInt32(nudInt.Value) - intelligence;

            if (difference == 1)
            {
                if (intelligence == 8)
                {
                    ptsRestants = ptsRestants - 1;
                    lbNbPts.Text = ptsRestants.ToString();
                }
                else
                {
                    if (intelligence == 9)
                    {
                        ptsRestants = ptsRestants - 1;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (intelligence == 10)
                        {
                            ptsRestants = ptsRestants - 1;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (intelligence == 11)
                            {
                                ptsRestants = ptsRestants - 1;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (intelligence == 12)
                                {
                                    ptsRestants = ptsRestants - 1;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (dexeterite == 13)
                                    {
                                        ptsRestants = ptsRestants - 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (intelligence == 14)
                                        {
                                            ptsRestants = ptsRestants - 2;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                        else
                                        {
                                            if (intelligence == 15)
                                            {
                                                ptsRestants = ptsRestants - 2;
                                                lbNbPts.Text = ptsRestants.ToString();
                                            }
                                            else
                                            {
                                                if (intelligence == 16)
                                                {
                                                    ptsRestants = ptsRestants - 3;
                                                    lbNbPts.Text = ptsRestants.ToString();
                                                }
                                                else
                                                {
                                                    if (intelligence == 17)
                                                    {
                                                        ptsRestants = ptsRestants - 4;
                                                        lbNbPts.Text = ptsRestants.ToString();
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (difference == -1)
                {
                    if (intelligence == 18)
                    {
                        ptsRestants = ptsRestants + 4;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (intelligence == 17)
                        {
                            ptsRestants = ptsRestants + 3;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (intelligence == 16)
                            {
                                ptsRestants = ptsRestants + 2;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (intelligence == 15)
                                {
                                    ptsRestants = ptsRestants + 2;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (intelligence == 14)
                                    {
                                        ptsRestants = ptsRestants + 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (intelligence == 13 || intelligence == 12 || intelligence == 11 || intelligence == 10 || intelligence == 9)
                                        {
                                            ptsRestants = ptsRestants + 1;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            intelligence = Convert.ToInt32(nudInt.Value);
            intelligenceT = intelligence + Convert.ToInt32(lbBonusI.Text);
            if (dexeteriteT < intelligenceT)
            {
                int modCarac;

                if (intelligence <= 8)
                {
                    modCarac = -1;
                }
                else
                {
                    float calcul = (intelligenceT - 10) / 2;
                    modCarac = (int)(Math.Floor(calcul));
                }
                reflexe = 10 + modCarac;
                lbNbRef.Text = reflexe.ToString();
            }
        }

        private void nudSag_ValueChanged(object sender, EventArgs e)
        {
            int difference;


            difference = Convert.ToInt32(nudSag.Value) - sagesse;

            if (difference == 1)
            {
                if (sagesse == 8)
                {
                    ptsRestants = ptsRestants - 1;
                    lbNbPts.Text = ptsRestants.ToString();
                }
                else
                {
                    if (sagesse == 9)
                    {
                        ptsRestants = ptsRestants - 1;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (sagesse == 10)
                        {
                            ptsRestants = ptsRestants - 1;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (sagesse == 11)
                            {
                                ptsRestants = ptsRestants - 1;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (sagesse == 12)
                                {
                                    ptsRestants = ptsRestants - 1;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (sagesse == 13)
                                    {
                                        ptsRestants = ptsRestants - 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (sagesse == 14)
                                        {
                                            ptsRestants = ptsRestants - 2;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                        else
                                        {
                                            if (sagesse == 15)
                                            {
                                                ptsRestants = ptsRestants - 2;
                                                lbNbPts.Text = ptsRestants.ToString();
                                            }
                                            else
                                            {
                                                if (sagesse == 16)
                                                {
                                                    ptsRestants = ptsRestants - 3;
                                                    lbNbPts.Text = ptsRestants.ToString();
                                                }
                                                else
                                                {
                                                    if (sagesse == 17)
                                                    {
                                                        ptsRestants = ptsRestants - 4;
                                                        lbNbPts.Text = ptsRestants.ToString();
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (difference == -1)
                {
                    if (sagesse == 18)
                    {
                        ptsRestants = ptsRestants + 4;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (sagesse == 17)
                        {
                            ptsRestants = ptsRestants + 3;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (sagesse == 16)
                            {
                                ptsRestants = ptsRestants + 2;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (sagesse == 15)
                                {
                                    ptsRestants = ptsRestants + 2;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (sagesse == 14)
                                    {
                                        ptsRestants = ptsRestants + 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (sagesse == 13 || sagesse == 12 || sagesse == 11 || sagesse == 10 || sagesse == 9)
                                        {
                                            ptsRestants = ptsRestants + 1;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            sagesse = Convert.ToInt32(nudSag.Value);
            sagesseT = sagesse + Convert.ToInt32(lbBonusS.Text);
            if (sagesseT > charismeT)
            {
                int modCarac;

                if (sagesse <= 8)
                {
                    modCarac = -1;
                }
                else
                {
                    float calcul = (sagesseT - 10) / 2;
                    modCarac = (int)(Math.Floor(calcul));
                }
                volonte = 10 + modCarac;
                lbNbVol.Text = volonte.ToString();
            }
        }

        private void nudCha_ValueChanged(object sender, EventArgs e)
        {
            int difference;


            difference = Convert.ToInt32(nudCha.Value) - charisme;

            if (difference == 1)
            {
                if (charisme == 8)
                {
                    ptsRestants = ptsRestants - 1;
                    lbNbPts.Text = ptsRestants.ToString();
                }
                else
                {
                    if (charisme == 9)
                    {
                        ptsRestants = ptsRestants - 1;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (charisme == 10)
                        {
                            ptsRestants = ptsRestants - 1;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (charisme == 11)
                            {
                                ptsRestants = ptsRestants - 1;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (charisme == 12)
                                {
                                    ptsRestants = ptsRestants - 1;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (charisme == 13)
                                    {
                                        ptsRestants = ptsRestants - 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (charisme == 14)
                                        {
                                            ptsRestants = ptsRestants - 2;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                        else
                                        {
                                            if (charisme == 15)
                                            {
                                                ptsRestants = ptsRestants - 2;
                                                lbNbPts.Text = ptsRestants.ToString();
                                            }
                                            else
                                            {
                                                if (charisme == 16)
                                                {
                                                    ptsRestants = ptsRestants - 3;
                                                    lbNbPts.Text = ptsRestants.ToString();
                                                }
                                                else
                                                {
                                                    if (charisme == 17)
                                                    {
                                                        ptsRestants = ptsRestants - 4;
                                                        lbNbPts.Text = ptsRestants.ToString();
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (difference == -1)
                {
                    if (charisme == 18)
                    {
                        ptsRestants = ptsRestants + 4;
                        lbNbPts.Text = ptsRestants.ToString();
                    }
                    else
                    {
                        if (charisme == 17)
                        {
                            ptsRestants = ptsRestants + 3;
                            lbNbPts.Text = ptsRestants.ToString();
                        }
                        else
                        {
                            if (charisme == 16)
                            {
                                ptsRestants = ptsRestants + 2;
                                lbNbPts.Text = ptsRestants.ToString();
                            }
                            else
                            {
                                if (charisme == 15)
                                {
                                    ptsRestants = ptsRestants + 2;
                                    lbNbPts.Text = ptsRestants.ToString();
                                }
                                else
                                {
                                    if (charisme == 14)
                                    {
                                        ptsRestants = ptsRestants + 2;
                                        lbNbPts.Text = ptsRestants.ToString();
                                    }
                                    else
                                    {
                                        if (charisme == 13 || charisme == 12 || charisme == 11 || charisme == 10 || charisme == 9)
                                        {
                                            ptsRestants = ptsRestants + 1;
                                            lbNbPts.Text = ptsRestants.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            charisme = Convert.ToInt32(nudCha.Value);
            charismeT = charisme + Convert.ToInt32(lbBonusCha.Text);
            if (sagesseT < charismeT)
            {
                int modCarac;

                if (charisme <= 8)
                {
                    modCarac = -1;
                }
                else
                {
                    float calcul = (charismeT - 10) / 2;
                    modCarac = (int)(Math.Floor(calcul));
                }
                volonte = 10 + modCarac;
                lbNbVol.Text = volonte.ToString();
            }
        }
                 
            
     }

     
    
}








