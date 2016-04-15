using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    class NodeChemin : GenericNode
    {
        public static List<Point> Laiteries;
        public static List<string> cheminsLaiteries; //sert à stocker les chemins les plus courts entre les laiteries
        /* vérifie que l'algorthme est passé par la totalité des laiteries*/
        public override bool EndState(string NomPointFin)
        {
            foreach (Point Laiterie in Laiteries)
            {
                if (!this.GetNom().Contains(Laiterie.NomPoint)) return false;
            }
            return true;
        }
        //renvoie tous les successeurs de du node par lesquels il n'est pas déjà passé. Il aurait été plus pertinent de modifier la fonction AStar dans Graph.cs, mais ça permet de centraliser le code.
        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lesSuccesseurs = new List<GenericNode>();
            Point pointNode = this.findPointNodeChemin();
            foreach (Lien unLien in pointNode.List_Voisins)
            {
                if (!this.GetNom().Contains(unLien.NomVoisin))
                    lesSuccesseurs.Add(new NodeChemin(this.GetNom() + unLien.NomVoisin));
            }
            return lesSuccesseurs;
        }
        /*renvoie la distance entre le point correspondant au noeud this et le point correspondant au noeud node*/
        public override double GetArcCost(GenericNode node)
        {
            //on cherche à quel point ce node (this) correspond parmis les points du monde
            Point pointNode = this.findPointNodeChemin();
            if (pointNode != null)
            {
                //on cherche à quel point voisin le noeud node correspond
                string debug_nodeID = node.GetID();
                bool debug_trouverVoisin = pointNode.List_Voisins[0].NomVoisin == node.GetID();
                Lien resultat = pointNode.List_Voisins.Find(voisin => voisin.NomVoisin == node.GetID());
                if (resultat==null) throw new Exception("le point n\'a pas de voisin correspondant à ce nom");
                if (resultat.Distance != 0)
                {
                    return resultat.Distance;
                }
                else
                {
                    return -1;
                    /*string erreur = "ce point n'a pas de voisin correspondant au nom " + node.GetNom();
                    throw new Exception(erreur);*/
                }
            }
            else
            {
                string erreur = "Il n'y a pas de point correspondant au nom " + node.GetID();
                throw new Exception(erreur);
            }
        }
        public override string GetID()
        {
            return this.GetNom()[this.GetNom().Length - 1].ToString();
        }
        public Point findPointNodeChemin()
        {
            Point pointNode = NodeChemin.Laiteries.Find(point => this.GetID() == point.NomPoint); ;
            if (!pointNode.Equals(null)) return pointNode;
            else throw new Exception("il n'y a pas de point correspondant à ce nom");
        }
        public override void CalculeHCost()
        {
            this.SetEstimation(this.GetArcCost(new NodeChemin(Laiteries[0].NomPoint)));
        }
        public NodeChemin(string nom)
            : base(nom)
        { }
        //trouve le chemin le plus court passant par les points du graphe contenus dans nomLaiteries. Modifie CheminLaiteries et Laiteries pour reconstruire un monde
        //ne contenant plus que les laiteries.
        public static string[] TrouveChemin(string[] nomLaiteries)
        {
            //on refait un territoire avec uniquement les laiteries et les distances qui les séparent.
            Laiteries = new List<Point>();
            cheminsLaiteries = new List<string>();
            char[] charIndesirables = { ',', ' ' };
            foreach (string laLaiterie in nomLaiteries)
            {
                Point pointLaiterie = new Point(laLaiterie, new List<Lien>());
                foreach (string uneLaiterieVoine in nomLaiteries)
                {
                    //on calcule le chemin le plus court entre chaque laiterie. Peut être optimisé en ne recalculant pas dans les deux sens à chaque fois
                    // ie : dans le cas présent, on calcule par exemple le chemin de A vers H, puis on recalcule celui de H vers A.
                    if (laLaiterie != uneLaiterieVoine)
                    {
                        string[] distance = Monde.DistanceWoBC(uneLaiterieVoine, laLaiterie);
                        //distance 0 contient la mesure du chemin parcouru, distance 1 contient le chemin.
                        pointLaiterie.List_Voisins.Add(new Lien(uneLaiterieVoine, Convert.ToInt32(distance[0])));
                        cheminsLaiteries.Add(distance[1].Trim(charIndesirables));
                    }
                }
                Laiteries.Add(pointLaiterie);
                //on calcule le chemin entre chacune des laiteries.
            }

            //on utilise la fonction AStar pour trouver le plus court chemin passant par toutes les laiteries
            Graph leGraph = new Graph();
            List<GenericNode> List_trajet = leGraph.RechercheSolutionAEtoile(new NodeChemin(nomLaiteries[0]), " ");
            string[] voyage = new string[2];
            double distanceTotale = 0;
            string voyageLaiteries = List_trajet[List_trajet.Count() - 1].GetNom() + nomLaiteries[0];
            voyage[1] = completeVoyage(voyageLaiteries).Trim(charIndesirables);
            for (int i = 0; i < voyage[1].Length - 1; i++)
            {
                distanceTotale += trouveDistanceLaiteries(voyage[1][i].ToString(), voyage[1][i + 1].ToString());
            }
            voyage[0] = distanceTotale.ToString();
            //on rajoute les étapes intermédiaires entre chacune des laiteries
            return voyage;
        }
        /* renvoie la distance entre deux laiteries */
        public static double trouveDistanceLaiteries(string A, string B)
        {
            Point laiterieDepart = Monde.List_Points.Find(laiterie => laiterie.NomPoint == A);
            Lien laiterieArrivee = laiterieDepart.List_Voisins.Find(lienLaiterie => lienLaiterie.NomVoisin == B);
            return laiterieArrivee.Distance;
        }
        public static string[] PlusCourtChemin(string A, string B)
        {
            string[] distance = new string[2];
            double distanceTempo = 0;
            Graph leGraph = new Graph();
            List<GenericNode> chemin = leGraph.RechercheSolutionAEtoile(new NodeChemin(A), B);
            for (int i = 0; i < chemin.Count() - 1; i++)
            {
                distanceTempo = distanceTempo + chemin[i].GetArcCost(chemin[i + 1]);
                distance[1] = distance[1] + ", " + chemin[i].GetNom();
            }
            distance[0] = distanceTempo.ToString();
            distance[1] = distance[1] + " " + B;

            return distance;
        }
        public static string completeVoyage(string laiteriesVisitees)
        {
            string cheminIntermediaire;
            string resultat = "";
            char[] charIndesirables = { ',', ' ' };
            for(int i=0; i<laiteriesVisitees.Length-1;i++)
            {
                resultat += laiteriesVisitees[i];
                List<string> debug_cheminLaiterie = NodeChemin.cheminsLaiteries;
                cheminIntermediaire = NodeChemin.cheminsLaiteries.Find(chemin => (chemin.First() == laiteriesVisitees[i] && chemin.Last() == laiteriesVisitees[i + 1]));
                cheminIntermediaire = cheminIntermediaire.Remove(cheminIntermediaire.Length-1,1);
                cheminIntermediaire = cheminIntermediaire.Remove(0,1);
                resultat += cheminIntermediaire;
            }
            resultat += laiteriesVisitees.Last();
            return resultat.Trim(charIndesirables);
        }
    }
}
