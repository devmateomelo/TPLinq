using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLinq
{
    public enum typeEquip
    {
        barres,
        vitres,
        cendrier
    }

    public  class Equipement
    {
        public typeEquip type;
        public int prix;
        public string description;

        public Equipement(typeEquip type, int prix, string description)
        {
            this.type = type;
            this.prix = prix;
            this.description = description;
        }
    }
}
