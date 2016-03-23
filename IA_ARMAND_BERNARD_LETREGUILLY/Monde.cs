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
        public static string[] Distance(string A, string B)
        {
            string[] distance = new string[2];
            double distanceTempo = 0;
            Graph leGraph = new Graph();
            List<GenericNode> chemin = leGraph.RechercheSolutionAEtoile(new NodeL(A), B);
            for (int i = 0; i < chemin.Count() - 1; i++)
            {
                distanceTempo = distanceTempo + chemin[i].GetArcCost(chemin[i + 1]);
                distance[1] = distance[1] + ", " + chemin[i].GetNom();
            }
            distance[0] = distanceTempo.ToString();
            distance[1] = distance[1] + " " + B;
            
            return distance;
        }

        public static Point findPointNode(GenericNode node)
        {
            Point pointNode;
            return pointNode = List_Points.Find(point => point.NomPoint == node.GetNom());
        }

        public static Point findPointByString(string toFind)
        {
            Point trouve = null;
            foreach (Point cherche in Monde.List_Points)
            {
                if (toFind == cherche.NomPoint)
                {
                    trouve = cherche;
                }
            }
            return trouve;
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
                    foreach (Point p in res)
                    {
                        Random r = new Random();
                        r.Next(1, 4);
                        p.Statue = Convert.ToInt32(r);
                    }

                    foreach (Point p in res)
                    {

                        foreach (Lien l in p.List_Voisins)
                        {
                            Point test = new Point("", null);
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

            else
            {
                List<int> erreur = new List<int>();
                for (int i = 0; i < 1000; i++)
                {
                    foreach (Point p in res)
                    {
                        Random c = new Random();
                        c.Next(1, 6);
                        if (Convert.ToInt32(c) == 1)
                        {
                            Random r = new Random();
                            r.Next(1, 4);
                            p.Statue = Convert.ToInt32(r);
                        }
                    }

                    foreach (Point p in res)
                    {
                        foreach (Lien l in p.List_Voisins)
                        {
                            Point test = new Point("", null);
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
    }
}
