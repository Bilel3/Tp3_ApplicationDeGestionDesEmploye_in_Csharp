using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3;

namespace tp3_ClassLibrary
{
    class Ouvrier : Employe
    {
        public DateTime  dateentree { get; set; }

        public Ouvrier(int m, string n, string p, DateTime dn, DateTime de) : base(m, n, p, dn)
        {

        }

        public static double _SMIG
        {
            get { return _SMIG; }
        }

        public override string ToString()
        {
            return "Ouvrier: " + base.ToString() + "date 'entrée" + Prenom + "Date de naissance" + dateentree.ToString();
        }

        public override double GetSalaire()
        {
            double salaire;
            int anciennete = DateTime.Now.Year - dateentree.Year;
            if (dateentree.AddYears(anciennete) > DateTime.Now.Date)
                anciennete--;
            if (_SMIG + anciennete * 100 <= 2 * _SMIG)
                salaire = _SMIG + anciennete * 100;
            else
                salaire = _SMIG * 2;
            return salaire;
        }
    }
}
