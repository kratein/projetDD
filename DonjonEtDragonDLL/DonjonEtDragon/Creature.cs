using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonjonEtDragon
{
    class Creature
    {
        string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        string classe;

        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }
        int niveau;

        public int Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }
        int xp;

        public int Xp
        {
            get { return xp; }
            set { xp = value; }
        }
        string categorieTaille;

        public string CategorieTaille
        {
            get { return categorieTaille; }
            set { categorieTaille = value; }
        }
        int pdvMax;

        public int PdvMax
        {
            get { return pdvMax; }
            set { pdvMax = value; }
        }
        int peril;

        public int Peril
        {
            get { return peril; }
            set { peril = value; }
        }
        int pdvActuel;

        public int PdvActuel
        {
            get { return pdvActuel; }
            set { pdvActuel = value; }
        }
        int initiative;

        public int Initiative
        {
            get { return initiative; }
            set { initiative = value; }
        }
        int ca;

        public int Ca
        {
            get { return ca; }
            set { ca = value; }
        }
        int vigueur;

        public int Vigueur
        {
            get { return vigueur; }
            set { vigueur = value; }
        }
        int reflexes;

        public int Reflexes
        {
            get { return reflexes; }
            set { reflexes = value; }
        }
        int volonte;

        public int Volonte
        {
            get { return volonte; }
            set { volonte = value; }
        }
        int vd;

        public int Vd
        {
            get { return vd; }
            set { vd = value; }
        }
        string resistance;

        public string Resistance
        {
            get { return resistance; }
            set { resistance = value; }
        }
        List<Pouvoir> listePouvoir;

        public List<Pouvoir> ListePouvoir
        {
            get { return listePouvoir; }
            set { listePouvoir = value; }
        }

        public Creature(string unNom, string uneDescription, string uneClasse, int unNiveau, int deXp, string uneCategorie, int desPdvMax, int unPeril, int uneInit, int uneCa, int uneVigueur, int desReflexes, int uneVolonte, string uneResistance, List<Pouvoir> uneListePouvoir)
        {
            this.nom = unNom;
            this.description = uneDescription;
            this.classe = uneClasse;
            this.niveau = unNiveau;
            this.xp = deXp;
            this.categorieTaille = uneCategorie;
            this.pdvMax = desPdvMax;
            this.peril = unPeril;
            this.initiative = uneInit;
            this.ca = uneCa;
            this.vigueur = uneVigueur;
            this.reflexes = desReflexes;
            this.volonte = uneVolonte;
            this.resistance = uneResistance;
            this.listePouvoir = uneListePouvoir;
        }
    }
    public class GroupeMonstre
    {
        List<Creature> monstres = new List<Creature>();

        internal List<Creature> Monstres
        {
            get { return monstres; }
            set { monstres = value; }
        }

        public GroupeMonstre(List<Creature> desMonstres)
        {
            this.monstres = desMonstres;
        }
    }
}
