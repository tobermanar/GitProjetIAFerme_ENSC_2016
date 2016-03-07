using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    class Monde
    {
        private string _nomMonde;
        private static List<Point> list_Points;

        public string NomMonde
        {
            get { return _nomMonde; }
            set { _nomMonde = value; }
        }
        public List<Point> List_Points
        {
            get { return list_Points; }
        }
        public Monde(string nom, List<Point> points)
        {
            _nomMonde = nom;
            list_Points = points;
        }

        public List<Point> Impasses()
        {
            List<Point> res = new List<Point>();
            foreach (Point P in list_Points)
            {
                if (P.List_Voisins.Count == 1)
                {
                    res.Add(P);
                }
            }
            return res;
        }

        // Ajoutez à votre programme un module qui demande à l’utilisateur 2 points du réseau (2 lettres) et qui détermine le plus court chemin entre ces points ainsi que sa valeur.
        public List<Point> Distance(Point A, Point B)
        {
            List<Point> res = new List<Point>();
            return res;
        }

    }
}
