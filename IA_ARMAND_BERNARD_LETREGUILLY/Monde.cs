using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    static class Monde
    {
        private static string _nomMonde;
        public static List<Point> List_Points;

        public static string NomMonde
        {
            get { return _nomMonde; }
            set { _nomMonde = value; }
        }
        /*public static Monde(string nom, List<Point> points)
        {
            _nomMonde = nom;
            List_Points = points;
        }*/

        public static List<Point> Impasses()
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
        public static List<Point> Distance(Point A, Point B)
        {
            List<Point> res = new List<Point>();
            return res;
        }


        public static int Distance2(Point A, Point B)
        {
            int res =0;

            Graph g = new Graph();

            NodeL a = new NodeL(A.NomPoint);
            NodeL b = new NodeL(B.NomPoint);

            List<GenericNode> res2 = new List<GenericNode>();

           // res2 = g.RechercheSolutionAEtoile(a, b);

            for (int j = 0; j < res2.Count-1; j++)
            {
                foreach (Point p in Monde.List_Points)
                {
                    if (res2[j].GetNom() == p.NomPoint)
                    {
                        foreach (Lien l in p.List_Voisins)
                        {
                            if (res2[j + 1].GetNom() == l.NomVoisin)
                            {
                                res = res + l.Distance;
                            }
                        }
                    }
                }
            }

            return res;
        }

        public static List<Point> Statue(List<Point> M)
        {
            List<Point> res = new List<Point>();
            res = M;
            List<List<Point>> resu = new List<List<Point>>();

            if (res[0].Statue == 0)
            {                
                List<int> erreur = new List<int>();
                for (int i = 0; i < 1000; i++)
                {
                    erreur.Add(0);
                    resu.Add(res);                    

                    for (int k = 0; k < 23; k++)
                    {
                        Random r = new Random();
                        int R = r.Next(1, 4);
                        resu[i][k].Statue = R;
                    }

                    for (int k = 0; k < 23; k++)
                    {
                        foreach (Lien l in res[k].List_Voisins)
                        {
                            Point test = new Point("", new List<Lien>(),false);
                            foreach (Point pt in res)
                            {
                                if (l.NomVoisin == pt.NomPoint)
                                {
                                    test = pt;
                                    if ( resu[i][k].Statue == test.Statue)
                                    {
                                        ++erreur[i];
                                    }
                                }
                            }                            
                        }
                    }

                    if (i > 1)
                    {
                        for (int j = 0; j < erreur.Count-1; j++)
                        {
                            for (int k = 0; k < 1000; k++)
                            {
                                if (erreur[j] > erreur[j + 1])
                                {
                                    erreur.Reverse(j, 2);
                                    resu.Reverse(j, 2);
                                }
                            }
                        }
                    }
                    else
                    {
                        resu[i] = res;
                    }
                }
            }

            else
            {
                List<int> erreur = new List<int>();
                for (int i = 0; i < 1000; i++)
                {
                    erreur.Add(0);
                    resu.Add(new List<Point>());
                    foreach (Point p in res)
                    {
                        Random c = new Random();
                        int C = c.Next(1, 6);
                        if (C == 1)
                        {
                            Random r = new Random();
                            int R = r.Next(1, 4);
                            p.Statue = R;
                        }
                    }
                    
                    foreach (Point p in res)
                    {                        
                        foreach (Lien l in p.List_Voisins)
                        {
                            Point test = new Point("", new List<Lien>(), false);
                            foreach (Point pt in res)
                            {
                                if (l.NomVoisin == pt.NomPoint)
                                {
                                    test = pt;
                                }
                            }

                            if (p.Statue == test.Statue)
                            {
                                ++erreur[i];
                            }
                        }
                    }

                    if (i > 1)
                    {
                        for (int j = 0; j < erreur.Count - 1; j++)
                        {
                            for (int k = 0; k < erreur.Count; k++)
                            {
                                if (erreur[j] > erreur[j + 1])
                                {
                                    erreur.Reverse(j, 2);
                                    resu.Reverse(j, 2);
                                }
                            }
                        }
                    }
                    else
                    {
                        resu[i] = res;
                    }
                }
            }
            return resu[0];
        }

        public static Point findPointNode(GenericNode node)
        {
            Point pointNode;
            return pointNode = List_Points.Find(point => point.NomPoint == node.GetNom());
        }
    }
}
