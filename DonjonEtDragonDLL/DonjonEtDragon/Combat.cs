using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonjonEtDragon
{
    class Combat
    {
        Groupe aventuriers;

        public Groupe Aventuriers
        {
            get { return aventuriers; }
            set { aventuriers = value; }
        }
        GroupeMonstre monstres;

        public GroupeMonstre Monstres
        {
            get { return monstres; }
            set { monstres = value; }
        }

        public Combat(Groupe desAventuriers, GroupeMonstre desMonstres)
        {
            this.aventuriers = desAventuriers;
            this.monstres = desMonstres;
        }
    }
}
