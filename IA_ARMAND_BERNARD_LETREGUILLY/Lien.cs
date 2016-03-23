using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    class Lien
    {
        private string _nomVoisin;
        private int _distance = 0;
        public string NomVoisin
        {
            get { return _nomVoisin; }
            set { _nomVoisin = value; }
        }
        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }
        public Lien(string nom, int distance)
        {
            _nomVoisin = nom;
            _distance = distance;
        }
        public override string ToString()
        {
            return "Voisin: " + _nomVoisin + "  Dist: " + _distance + " ";
        }
    }
}
