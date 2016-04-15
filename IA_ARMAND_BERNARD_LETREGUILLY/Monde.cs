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
        public static string[] DistanceWoBC(string A, string B)
        {
            string[] distance = new string[2];
            double distanceTempo = 0;
            Graph leGraph = new Graph();
            List<GenericNode> chemin = leGraph.RechercheSolutionAEtoile(new NodeL(A), B);
            for (int i = 0; i < chemin.Count() - 1; i++)
            {
                distanceTempo = distanceTempo + chemin[i].GetArcCost(chemin[i + 1]);
                distance[1] = distance[1]  + chemin[i].GetNom();
            }
            distance[0] = distanceTempo.ToString();
            distance[1] = distance[1] + B;

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
                    erreur.Add(0);
                    resu.Add(new List<Point>());

                    Random r = new Random();

                    for (int k = 0; k < 23; k++)
                    {
                        int R = r.Next(1, 4);
                        resu[i].Add(new Point(res[k].NomPoint, res[k].List_Voisins, R, res[k].Ferme));
                    }

                    for (int k = 0; k < 23; k++)
                    {
                        foreach (Lien l in resu[i][k].List_Voisins)
                        {
                            Point test = new Point("", new List<Lien>(), false);
                            foreach (Point pt in resu[i])
                            {
                                if (l.NomVoisin == pt.NomPoint)
                                {
                                    test = pt;
                                    if (resu[i][k].Statue == test.Statue)
                                    {
                                        ++erreur[i];
                                    }
                                }
                            }
                        }
                    }

                    erreur[i] = erreur[i] / 2;

                    if (i > 1)
                    {
                        for (int u = 0; u < 1000; u++)
                        {
                            for (int j = 0; j < erreur.Count - 1; j++)
                            {
                                if (erreur[j] > erreur[j + 1])
                                {
                                    erreur.Reverse(j, 2);
                                    resu.Reverse(j, 2);
                                }
                            }
                        }
                    }
                }
            }

            else
            {
                List<int> erreur = new List<int>();

                resu.Add(M);
                int cmpt = ErStatue(M);
                erreur.Add(cmpt);

                for (int i = 1; i < 1000; i++)
                {
                    erreur.Add(0);
                    resu.Add(new List<Point>());
                    for (int k = 0; k < 23; k++)
                    {
                        resu[i].Add(new Point(res[k].NomPoint, res[k].List_Voisins, res[k].Statue, res[k].Ferme));
                    }
                    Random c = new Random();
                    Random r = new Random();

                    for (int k = 0; k < 23; k++)
                    {
                        int C = c.Next(1, 6);
                        if (C == 1)
                        {
                            int R = r.Next(1, 4);
                            resu[i][k].Statue = R;
                        }
                    }

                    for (int k = 0; k < 23; k++)
                    {
                        foreach (Lien l in resu[i][k].List_Voisins)
                        {
                            Point test = new Point("", new List<Lien>(), false);
                            foreach (Point pt in resu[i])
                            {
                                if (l.NomVoisin == pt.NomPoint)
                                {
                                    test = pt;
                                    if (resu[i][k].Statue == test.Statue)
                                    {
                                        ++erreur[i];
                                    }
                                }
                            }
                        }
                    }

                    erreur[i] = erreur[i] / 2;


                    if (i > 1)
                    {
                        for (int u = 0; u < 1000; u++)
                        {
                            for (int j = 0; j < erreur.Count - 1; j++)
                            {
                                if (erreur[j] > erreur[j + 1])
                                {
                                    erreur.Reverse(j, 2);
                                    resu.Reverse(j, 2);
                                }
                            }
                        }
                    }
                }
            }

            return resu[0];

        }

        public static int ErStatue(List<Point> M)
        {
            List<Point> res = new List<Point>();
            res = M;

            int cmpt = 0, cmpt1 = 0, cmpt2 = 0, cmpt3 = 0;
            for (int k = 0; k < 23; k++)
            {
                if(res[k].Statue == 1)
                {
                    cmpt1++;
                }
                else if(res[k].Statue == 2)
                {
                    cmpt2++;
                }
                else if (res[k].Statue == 3)
                {
                    cmpt3++;
                }
                foreach (Lien l in res[k].List_Voisins)
                {
                    Point test = new Point("", new List<Lien>(), false);
                    foreach (Point pt in res)
                    {
                        if (l.NomVoisin == pt.NomPoint)
                        {
                            test = pt;
                            if (res[k].Statue == test.Statue)
                            {
                                ++cmpt;
                            }
                        }
                    }
                }
            }
            cmpt = cmpt / 2;
            if (cmpt1 > 8)
            {
                cmpt++;
            }
            if (cmpt2 > 8)
            {
                cmpt++;
            }
            if (cmpt3 > 8)
            {
                cmpt++;
            }
            return cmpt;
        }

        public static List<Point> Statue2(List<Point> M)
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
                    resu.Add(new List<Point>());

                    Random r = new Random();

                    for (int k = 0; k < 23; k++)
                    {
                        int R = r.Next(1, 4);
                        resu[i].Add(new Point(res[k].NomPoint, res[k].List_Voisins, R, res[k].Ferme));
                    }

                    for (int k = 0; k < 23; k++)
                    {
                        foreach (Lien l in resu[i][k].List_Voisins)
                        {
                            Point test = new Point("", new List<Lien>(), false);
                            foreach (Point pt in resu[i])
                            {
                                if (l.NomVoisin == pt.NomPoint)
                                {
                                    test = pt;
                                    if (resu[i][k].Statue == test.Statue)
                                    {
                                        ++erreur[i];
                                    }
                                }
                            }
                        }
                    }

                    erreur[i] = erreur[i] / 2;

                    if (i > 1)
                    {
                        for (int u = 0; u < 1000; u++)
                        {
                            for (int j = 0; j < erreur.Count - 1; j++)
                            {
                                if (erreur[j] > erreur[j + 1])
                                {
                                    erreur.Reverse(j, 2);
                                    resu.Reverse(j, 2);
                                }
                            }
                        }
                    }
                }
            }

            else
            {
                List<int> erreur = new List<int>();

                resu.Add(M);
                int cmpt = ErStatue2(M);
                erreur.Add(cmpt);

                for (int i = 1; i < 1000; i++)
                {
                    erreur.Add(0);
                    resu.Add(new List<Point>());
                    for (int k = 0; k < 23; k++)
                    {
                        resu[i].Add(new Point(res[k].NomPoint, res[k].List_Voisins, res[k].Statue, res[k].Ferme));
                    }
                    Random c = new Random();
                    Random r = new Random();

                    for (int k = 0; k < 23; k++)
                    {
                        int C = c.Next(1, 6);
                        if (C == 1)
                        {
                            int R = r.Next(1, 4);
                            resu[i][k].Statue = R;
                        }
                    }

                    for (int k = 0; k < 23; k++)
                    {
                        foreach (Lien l in resu[i][k].List_Voisins)
                        {
                            Point test = new Point("", new List<Lien>(), false);
                            foreach (Point pt in resu[i])
                            {
                                if (l.NomVoisin == pt.NomPoint)
                                {
                                    test = pt;
                                    if (resu[i][k].Statue == test.Statue)
                                    {
                                        ++erreur[i];
                                    }
                                }
                            }
                        }
                    }

                    erreur[i] = erreur[i] / 2;


                    if (i > 1)
                    {
                        for (int u = 0; u < 1000; u++)
                        {
                            for (int j = 0; j < erreur.Count - 1; j++)
                            {
                                if (erreur[j] > erreur[j + 1])
                                {
                                    erreur.Reverse(j, 2);
                                    resu.Reverse(j, 2);
                                }
                            }
                        }
                    }
                }
            }

            return resu[0];

        }

        public static int ErStatue2(List<Point> M)
        {
            List<Point> res = new List<Point>();
            res = M;
            int cmpt = 0;
            for (int k = 0; k < 23; k++)
            {
                foreach (Lien l in res[k].List_Voisins)
                {
                    Point test = new Point("", new List<Lien>(), false);
                    foreach (Point pt in res)
                    {
                        if (l.NomVoisin == pt.NomPoint)
                        {
                            test = pt;
                            if (res[k].Statue == test.Statue)
                            {
                                ++cmpt;
                            }
                        }
                    }
                }
            }
            cmpt = cmpt / 2;
            return cmpt;
        }

        public static void NbStatues()
        {
            int compteur_statue = 0;
            List<Point> permut = new List<Point>();
            foreach (Point p in List_Points)
            {
                if (p.Statue == 3) compteur_statue++;
            }
            if (compteur_statue == 8)
            {
                compteur_statue = 0;
                foreach (Point p in List_Points)
                {
                    if (p.Statue == 2) compteur_statue++;
                }
                if (compteur_statue == 7)
                {
                    foreach (Point p in List_Points)
                    {
                        if (p.Statue == 3)
                        {
                            p.Statue = 2;
                        }
                        else if (p.Statue == 2)
                        {
                            p.Statue = 3;
                        }
                    }
                }
                else
                {
                    foreach (Point p in List_Points)
                    {
                        if (p.Statue == 3)
                        {
                            p.Statue = 1;
                        }
                        else if (p.Statue == 1)
                        {
                            p.Statue = 3;
                        }
                    }
                }
                
            }
        }
    }
}
