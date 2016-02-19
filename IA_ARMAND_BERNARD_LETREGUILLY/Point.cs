using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    struct lien
    {
        private string _nomVoisin;
        private int _distance;
        public string NomVoisin
        {
            get { return _nomVoisin;}
            set{ _nomVoisin = value;}
        }
        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }
        public lien(string nom, int distance)
        {
            _nomVoisin = nom;
            _distance = distance;
        }
    }
    class Point
    {
        private List<lien> _list_Voisins;
        private string _nomPoint;
        private bool _ferme;
        public string NomPoint
        {
            get { return _nomPoint; }
            set { _nomPoint = value; }
        }

        public string NomVoisin
        {
            get { return _nomPoint; }
            set { _nomPoint = value; }
        }
        public List<lien> List_Voisins
        {
            get { return _list_Voisins; }
            set { _list_Voisins = value; }
        }
        public Point(string nom, List<lien> voisins)
        {
            _nomPoint = nom;
            _list_Voisins = voisins;
            _ferme = false;
        }
        public Point(string nom, List<lien> voisins, bool ferme)
        {
            _nomPoint = nom;
            _list_Voisins = voisins;
            _ferme = ferme;
        }
    }
}
