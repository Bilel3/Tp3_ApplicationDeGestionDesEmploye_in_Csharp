using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3;

namespace tp3_ClassLibrary
{
    public class Patron : Employe
    {
        public double ca { get; set; }
        public double pourcentage { get; set; }
        public Patron(int matricule, string nom, string prenom, DateTime dn, double ca, double p) : base(matricule, nom, prenom, dn)
        {
            this.ca = ca;
            this.pourcentage = p;
        }
       

        public override string ToString()
        {
            return "Patron " + base.ToString() + "pourcentage" + pourcentage + "%";
        }

        public override double GetSalaire()
        {
            throw new NotImplementedException();
        }
    }
}
