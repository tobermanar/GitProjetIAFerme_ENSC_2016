using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    class Monde
    {
        private string _nomMonde;
        public static List<Point> List_Points;

        public string NomMonde
        {
            get { return _nomMonde; }
            set { _nomMonde = value; }
        }
        public Monde(string nom, List<Point> points)
        {
            _nomMonde = nom;
            List_Points = points;
        }

        public List<Point> Impasses()
        {
            List<Point> res = new List<Point>();
            foreach (Point P in List_Points)
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

            foreach (lien q in A.List_Voisins)
            {

            }

            return res;
        }


  /*      public List<Point> Statue()
        {
            List<Point> res = new List<Point>();
            int statue1 = 8;
            int statue2 = 8;
            int statue3 = 7;
            

            List_Points[0].Statue = 1;
            --statue1;

            bool test = false;

            do
            {
                foreach (Point p in List_Points)
                {
                    if (p.Statue == 0)
                    {
                        foreach (lien q in p.List_Voisins)
                        {
                            List<int> pot = new List<int>();
                            for (int i = 0; i < List_Points.Count; i++)
                            {
                                if (List_Points[i].NomPoint == q.NomVoisin)
                                {
                                    pot.Add(List_Points[i].Statue);
                                }

                                if (pot.Contains(1) || pot.Contains(2) || pot.Contains(3))
                                {
                                    if (pot.Contains(1) && pot.Contains(2))
                                    {
                                        p.Statue = 3;
                                        statue3--;
                                    }

                                    if (pot.Contains(1) && pot.Contains(3))
                                    {
                                        p.Statue = 2;
                                        statue2--;
                                    }

                                    if (pot.Contains(2) && pot.Contains(3))
                                    {
                                        p.Statue = 1;
                                        statue1--;
                                    }

                                    if (pot.Contains(1) && !pot.Contains(2) && !pot.Contains(3))
                                    {
                                        if (statue2 > statue3)
                                        {
                                            p.Statue = 2;
                                            statue2--;
                                        }
                                        if (statue2 < statue3)
                                        {
                                            p.Statue = 3;
                                            statue3--;
                                        }
                                    }

                                    if (pot.Contains(2) && !pot.Contains(1) && !pot.Contains(3))
                                    {
                                        if (statue1 > statue3)
                                        {
                                            p.Statue = 1;
                                            statue1--;
                                        }
                                        if (statue1 < statue3)
                                        {
                                            p.Statue = 3;
                                            statue3--;
                                        }
                                    }

                                    if (pot.Contains(3) && !pot.Contains(1) && !pot.Contains(2))
                                    {
                                        if (statue1 > statue2)
                                        {
                                            p.Statue = 1;
                                            statue1--;
                                        }
                                        if (statue1 < statue2)
                                        {
                                            p.Statue = 2;
                                            statue2--;
                                        }
                                    }
                                }

                            }
                        }

                    }
                }

                List<bool> teste = new List<bool>();

                foreach (Point p in List_Points)
                {
                    if (p.Statue != 0)
                    {
                        teste.Add(true);
                    }
                    else
                    {
                        teste.Add(false);
                    }
                }

                if (teste.Contains(false))
                {
                    test = false;
                }
                else
                {
                    test = true;
                }
            } while (test);

            return res;
        }*/


    }
}
