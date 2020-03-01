using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3;

namespace tp3_ClassLibrary
{
    class Cadre : Employe
    {
        public int indice { get; set; }
        public Cadre(int matricule, string nom, string prenom, DateTime dn, int indice) : base(matricule, nom, prenom, dn)
        {
            this.indice = indice;
        }
        public override string ToString()
        {
            return "cadre" + "" + base.ToString() + "indice" + indice;
        }

        public override double GetSalaire()
        {
            if (indice == 1)
                return 1300;
            if (indice == 2)
                return 1500;
            if (indice == 3)
                return 1700;
            if (indice == 4)
                return 2000;
            else return -1; // probléme d'indice

        }

    }
}
