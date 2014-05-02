using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonjonEtDragon
{
    [Serializable]
    public class Pouvoir
    {
        string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        string periodicite;

        public string Periodicite
        {
            get { return periodicite; }
            set { periodicite = value; }
        }
        string typeDegat;

        public string TypeDegat
        {
            get { return typeDegat; }
            set { typeDegat = value; }
        }
        string cible;

        public string Cible
        {
            get { return cible; }
            set { cible = value; }
        }
        string zoneImpact;

        public string ZoneImpact
        {
            get { return zoneImpact; }
            set { zoneImpact = value; }
        }
        string attaque;

        public string Attaque
        {
            get { return attaque; }
            set { attaque = value; }
        }
        string reussite;

        public string Reussite
        {
            get { return reussite; }
            set { reussite = value; }
        }
        string special;

        public string Special
        {
            get { return special; }
            set { special = value; }
        }
        string condition;

        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }
        string declencheur;

        public string Declencheur
        {
            get { return declencheur; }
            set { declencheur = value; }
        }
        string attaqueSecond;

        public string AttaqueSecond
        {
            get { return attaqueSecond; }
            set { attaqueSecond = value; }
        }

        public Pouvoir(string unNom, string unePeriodicite, string unTypeDegat, string uneCible, string uneZone, string uneAttaque, string uneReussite, string unSpecial, string uneCondition, string unDeclencheur, string uneAttaqueSecond)
        {
            this.nom = unNom;
            this.periodicite = unePeriodicite;
            this.typeDegat = unTypeDegat;
            this.cible = uneCible;
            this.zoneImpact = uneZone;
            this.attaque = uneAttaque;
            this.reussite = uneReussite;
            this.special = unSpecial;
            this.condition = uneCondition;
            this.declencheur = unDeclencheur;
            this.attaqueSecond = uneAttaqueSecond;
        }

    }
}
