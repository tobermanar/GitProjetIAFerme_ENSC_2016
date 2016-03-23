using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    class Point
    {
        private List<Lien> _list_Voisins;
        private string _nomPoint;
        private bool _ferme;
        private int _statue = 0;

        public override string ToString()
        {
            string sentence;
            string farm;
            if(_ferme == true)
            {
                farm = "Farm  ";
            }else
            {
                farm = "Node ";
            }
            sentence = farm + "Nom : " + _nomPoint + "  ";
            foreach (Lien voisin in _list_Voisins)
            {
                sentence += voisin.ToString(); 
            }
            return sentence;
        }
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
        public int Statue
        {
            get { return _statue; }
            set { _statue = value; }
        }
        public List<Lien> List_Voisins
        {
            get { return _list_Voisins; }
            set { _list_Voisins = value; }
        }
       
        public Point(string nom, List<Lien> voisins, bool ferme = false)
        {
            this._nomPoint = nom;
            this._list_Voisins = new List<Lien>();
            foreach (Lien l in voisins)
                this._list_Voisins.Add(l);

            this._ferme = ferme;
        }
    }
}
