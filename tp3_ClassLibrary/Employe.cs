using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    public abstract class Employe 
    {

        public int Matricule { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }

        protected Employe(int matricule, String nom, String prenom, DateTime dateDeNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;
        }

        public abstract double GetSalaire();
        public bool Equals(Employe e)
        {
            return e.Matricule == Matricule;
        }
        public override string ToString()
        {
            return "Matricule: " + Matricule + "Nom: " + Nom + "prenom" + Prenom + "Date de naissance" + DateDeNaissance;
        }
        

    }
}
