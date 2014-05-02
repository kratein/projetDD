using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonjonEtDragon
{
    [Serializable]
    public class Arme
    {
        string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        int maniement;

        public int Maniement
        {
            get { return maniement; }
            set { maniement = value; }
        }
        string degat;

        public string Degat
        {
            get { return degat; }
            set { degat = value; }
        }
        string portee;

        public string Portee
        {
            get { return portee; }
            set { portee = value; }
        }
        string prix;

        public string Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        float poids;

        public float Poids
        {
            get { return poids; }
            set { poids = value; }
        }
        string groupe;

        public string Groupe
        {
            get { return groupe; }
            set { groupe = value; }
        }
        string propriete;

        public string Propriete
        {
            get { return propriete; }
            set { propriete = value; }
        }

        public Arme(string unNom, int unManiement, string desDegats, string unePortee, string unPrix, float unPoids, string unGroupe, string unePropriete)
        {
            this.nom = unNom;
            this.maniement = unManiement;
            this.degat = desDegats;
            this.portee = unePortee;
            this.prix = unPrix;
            this.poids = unPoids;
            this.groupe = unGroupe;
            this.propriete = unePropriete;
        }
    }

    [Serializable]
    public class Armure
    {
        string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        int bonusArmure;

        public int BonusArmure
        {
            get { return bonusArmure; }
            set { bonusArmure = value; }
        }
        int bonusAlte;

        public int BonusAlte
        {
            get { return bonusAlte; }
            set { bonusAlte = value; }
        }
        int test;

        public int Test
        {
            get { return test; }
            set { test = value; }
        }
        int vd;

        public int Vd
        {
            get { return vd; }
            set { vd = value; }
        }
        string prix;
        
        public string Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        float poids;

        public float Poids
        {
            get { return poids; }
            set { poids = value; }
        }

       

        public Armure(string unNom, int unBonusArmure, int unBonusAlte, int unTest, int uneVd, float unPoids, string unPrix)
        {
            this.nom = unNom;
            this.bonusArmure = unBonusArmure;
            this.bonusAlte = unBonusAlte;
            this.test = unTest;
            this.vd = uneVd;
            this.prix = unPrix;
            this.poids = unPoids;            
        }
    }
}
