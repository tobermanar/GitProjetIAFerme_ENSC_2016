using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    class NodeL : GenericNode
    {
        public NodeL(string newname)
            : base(newname)
        {
        }

        public override bool EndState(String NomPointFin)
        {
            return (this.GetNom() == NomPointFin);
        }


        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> list_succ = new List<GenericNode>();
            Point point = this.findPointNode();
            foreach (Lien successeur in point.List_Voisins)
            {
                list_succ.Add(new NodeL(successeur.NomVoisin));
            }
            return list_succ;
        }

        /*renvoit la distance entre le point correspondant au noeud this et le point correspondant au noeud node*/
        public override double GetArcCost(GenericNode node)
        {
            //on cherche à quel point ce node (this) correspond parmis les points du monde
            Point pointNode = Monde.findPointNode(node);
            if (pointNode != null)
            {
                //on cherche à quel point voisin le noeud node correspond
                Lien resultat = pointNode.List_Voisins.Find(voisin => voisin.NomVoisin == node.GetNom()); ;
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
                string erreur = "Il n'y a pas de point correspondant au nom " + node.GetNom();
                throw new Exception(erreur);
            }
        }
        public override void CalculeHCost()
        {
            SetEstimation(0);
        }
        public Point findPointNode()
        {
            Point pointNode;
            return pointNode = Monde.List_Points.Find(point => point.NomPoint == this.GetNom());
        }
    }
}
