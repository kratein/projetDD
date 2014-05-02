using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonjonEtDragon
{
    [Serializable]
    public class Classe
    {
        string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        string sourcePouvoir;

        public string SourcePouvoir
        {
            get { return sourcePouvoir; }
            set { sourcePouvoir = value; }
        }
        List<string> caracPrincipale;

        public List<string> CaracPrincipale
        {
            get { return caracPrincipale; }
            set { caracPrincipale = value; }
        }
        List<string> portArmure;

        public List<string> PortArmure
        {
            get { return portArmure; }
            set { portArmure = value; }
        }
        List<string> maniement;

        public List<string> Maniement
        {
            get { return maniement; }
            set { maniement = value; }
        }
        string bonusDef;

        public string BonusDef
        {
            get { return bonusDef; }
            set { bonusDef = value; }
        }
        int pdvDepart;

        public int PdvDepart
        {
            get { return pdvDepart; }
            set { pdvDepart = value; }
        }
        int pdvLvl;

        public int PdvLvl
        {
            get { return pdvLvl; }
            set { pdvLvl = value; }
        }
        int recupJour;

        public int RecupJour
        {
            get { return recupJour; }
            set { recupJour = value; }
        }

        List<string> optionCrea;

        public List<string> OptionCrea
        {
            get { return optionCrea; }
            set { optionCrea = value; }
        }
        List<string> aptitudeClasse;

        public List<string> AptitudeClasse
        {
            get { return aptitudeClasse; }
            set { aptitudeClasse = value; }
        }

        public Classe(string unNom, string unRole, string uneSource, List<string> desCarac, List<string> desPorts, List<string> desManiement, string unBonus, int desPdv, int desPdvParLvl, int desRecups, List<string> desOptions, List<string> desAptitudes)
        {
            this.nom = unNom;
            this.role = unRole;
            this.sourcePouvoir = uneSource;
            this.caracPrincipale = desCarac;
            this.portArmure = desPorts;
            this.maniement = desManiement;
            this.bonusDef = unBonus;
            this.pdvDepart = desPdv;
            this.pdvLvl = desPdvParLvl;
            this.recupJour = desRecups;            
            this.optionCrea = desOptions;
            this.aptitudeClasse = desAptitudes;
        }
    }

    [Serializable]
    public class Race
    {
        string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        string tailleMoyenne;

        public string TailleMoyenne
        {
            get { return tailleMoyenne; }
            set { tailleMoyenne = value; }
        }
        string poidsMoyen;

        public string PoidsMoyen
        {
            get { return poidsMoyen; }
            set { poidsMoyen = value; }
        }
        string bonusCarac;

        public string BonusCarac
        {
            get { return bonusCarac; }
            set { bonusCarac = value; }
        }
        string categorieTaille;

        public string CategorieTaille
        {
            get { return categorieTaille; }
            set { categorieTaille = value; }
        }
        int vd;

        public int Vd
        {
            get { return vd; }
            set { vd = value; }
        }
        string vision;

        public string Vision
        {
            get { return vision; }
            set { vision = value; }
        }
        List<string> langue;

        public List<string> Langue
        {
            get { return langue; }
            set { langue = value; }
        }

        List<string> pouvoirRacial;

        public List<string> PouvoirRacial
        {
            get { return pouvoirRacial; }
            set { pouvoirRacial = value; }
        }
        public Race(string unNom, string uneTaille, string unPoids, string desBonusCarac, string uneCategorie, int uneVd, string uneVision, List<string> desLangues, List<string> desPouvoirs)
        {
            this.nom = unNom;
            this.tailleMoyenne = uneTaille;
            this.poidsMoyen = unPoids;
            this.bonusCarac = desBonusCarac;
            this.categorieTaille = uneCategorie;
            this.vd = uneVd;
            this.vision = uneVision;
            this.langue = desLangues;
            this.pouvoirRacial = desPouvoirs;
        }
    }

    [Serializable]
    public class Personnage
    {
        string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        int niveau;

        public int Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }
        Classe laClasse;

        public Classe LaClasse
        {
            get { return laClasse; }
            set { laClasse = value; }
        }
        float xp;

        public float Xp
        {
            get { return xp; }
            set { xp = value; }
        }
        Race laRace;

        public Race LaRace
        {
            get { return laRace; }
            set { laRace = value; }
        }

        string sexe;

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        float poids;

        public float Poids
        {
            get { return poids; }
            set { poids = value; }
        }

        int initiative;

        public int Initiative
        {
            get { return initiative; }
            set { initiative = value; }
        }
        int force;

        public int Force
        {
            get { return force; }
            set { force = value; }
        }
        int modCaracFOR;

        public int ModCaracFOR
        {
            get { return modCaracFOR; }
            set { modCaracFOR = value; }
        }
        int constitution;

        public int Constitution
        {
            get { return constitution; }
            set { constitution = value; }
        }
        int modCaracCON;

        public int ModCaracCON
        {
            get { return modCaracCON; }
            set { modCaracCON = value; }
        }
        int dexeterite;

        public int Dexeterite
        {
            get { return dexeterite; }
            set { dexeterite = value; }
        }
        int modCaracDEX;

        public int ModCaracDEX
        {
            get { return modCaracDEX; }
            set { modCaracDEX = value; }
        }
        int intelligence;

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        int modCaracINT;

        public int ModCaracINT
        {
            get { return modCaracINT; }
            set { modCaracINT = value; }
        }
        int sagesse;

        public int Sagesse
        {
            get { return sagesse; }
            set { sagesse = value; }
        }
        int modCaracSAG;

        public int ModCaracSAG
        {
            get { return modCaracSAG; }
            set { modCaracSAG = value; }
        }
        int charisme;

        public int Charisme
        {
            get { return charisme; }
            set { charisme = value; }
        }
        int modCaracCHA;

        public int ModCaracCHA
        {
            get { return modCaracCHA; }
            set { modCaracCHA = value; }
        }

        int classeArmure;

        public int ClasseArmure
        {
            get { return classeArmure; }
            set { classeArmure = value; }
        }
        int vigueur;

        public int Vigueur
        {
            get { return vigueur; }
            set { vigueur = value; }
        }
        int reflexe;

        public int Reflexe
        {
            get { return reflexe; }
            set { reflexe = value; }
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

        int pvMax;

        public int PvMax
        {
            get { return pvMax; }
            set { pvMax = value; }
        }
        int peril;

        public int Peril
        {
            get { return peril; }
            set { peril = value; }
        }
        int valeurRecup;

        public int ValeurRecup
        {
            get { return valeurRecup; }
            set { valeurRecup = value; }
        }
        int recupJour;

        public int RecupJour
        {
            get { return recupJour; }
            set { recupJour = value; }
        }
        int pvActuel;

        public int PvActuel
        {
            get { return pvActuel; }
            set { pvActuel = value; }
        }
        int nbRecupUtil;

        public int NbRecupUtil
        {
            get { return nbRecupUtil; }
            set { nbRecupUtil = value; }
        }
        int pdvTemporaire;

        public int PdvTemporaire
        {
            get { return pdvTemporaire; }
            set { pdvTemporaire = value; }
        }
        bool secondSouffle;

        public bool SecondSouffle
        {
            get { return secondSouffle; }
            set { secondSouffle = value; }
        }
        int nbEchecSave;

        public int NbEchecSave
        {
            get { return nbEchecSave; }
            set { nbEchecSave = value; }
        }
        int modifJetSave;

        public int ModifJetSave
        {
            get { return modifJetSave; }
            set { modifJetSave = value; }
        }
        string resistances;

        public string Resistances
        {
            get { return resistances; }
            set { resistances = value; }
        }

        List<string> langues;

        public List<string> Langues
        {
            get { return langues; }
            set { langues = value; }
        }

        List<string> talents;

        public List<string> Talents
        {
            get { return talents; }
            set { talents = value; }
        }
        List<Pouvoir> listePouvoir;

        private List<Pouvoir> ListePouvoir
        {
            get { return listePouvoir; }
            set { listePouvoir = value; }
        }
        int pieceOr;

        public int PieceOr
        {
            get { return pieceOr; }
            set { pieceOr = value; }
        }
        int pieceArgent;

        public int PieceArgent
        {
            get { return pieceArgent; }
            set { pieceArgent = value; }
        }
        int pieceCuivre;

        public int PieceCuivre
        {
            get { return pieceCuivre; }
            set { pieceCuivre = value; }
        }

        List<Arme> armes;

        public List<Arme> Armes
        {
            get { return armes; }
            set { armes = value; }
        }
        List<Armure> armures;

        public List<Armure> Armures
        {
            get { return armures; }
            set { armures = value; }
        }

        public Personnage(string unNom, int unNiveau,Classe uneClasse, float deLxp, Race uneRace, string unSexe, int unPoids,int lInit, int laForce, int laConstite, int laDex, int lIntell, int laSagesse, int leCharisme, int LaCA, int laVigueur, int lesReflexes, int laVolonte, int laVd, int lesPvMax, int lePeril, int laValeurRecup, int nbRecupJour, int lesPvActuel, int leNbRecupUtile, int lesPdvTemporaires, bool leSecondSouffle, int leNbEchec, int leModifSave, string lesRestistances, List<string> lesLangues, List<string> lesTalents, List<Pouvoir> uneListePouvoir, int lesPieceOr, int lesPieceArgent, int lesPieceCuivre, List<Arme> desArmes, List<Armure> desArmures)
        {
            this.nom = unNom;
            this.niveau = unNiveau;
            this.laClasse = uneClasse;
            this.xp = deLxp;
            this.laRace = uneRace;
            this.sexe = unSexe;
            this.poids = unPoids;
            this.initiative = lInit;
            this.force = laForce;
            this.constitution = laConstite;
            this.dexeterite = laDex;
            this.intelligence = lIntell;
            this.sagesse = laSagesse;
            this.charisme = leCharisme;
            this.classeArmure = LaCA;
            this.vigueur = laVigueur;
            this.reflexe = lesReflexes;
            this.volonte = laVolonte;
            this.vd = laVd;
            this.pvMax = lesPvMax;
            this.peril = lePeril;
            this.valeurRecup = laValeurRecup;
            this.recupJour = nbRecupJour;
            this.pvActuel = lesPvActuel;
            this.nbRecupUtil = leNbRecupUtile;
            this.pdvTemporaire = lesPdvTemporaires;
            this.secondSouffle = leSecondSouffle;
            this.nbEchecSave = leNbEchec;
            this.modifJetSave = leModifSave;
            this.resistances = lesRestistances;
            this.langues = lesLangues;
            this.talents = lesTalents;
            this.listePouvoir = uneListePouvoir;
            this.pieceOr = lesPieceOr;
            this.pieceArgent = lesPieceArgent;
            this.pieceCuivre = lesPieceCuivre;
            this.armes = desArmes;
            this.armures = desArmures;
        }

    }

    [Serializable]
    public class Groupe
    {
        string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        List<Personnage> aventuriers = new List<Personnage>();

        public List<Personnage> Aventuriers
        {
            get { return aventuriers; }
            set { aventuriers = value; }
        }

        public Groupe(string unNom, List<Personnage> unGroupe)
        {
            this.nom = unNom;
            this.aventuriers = unGroupe;
        }
    }
    
}
