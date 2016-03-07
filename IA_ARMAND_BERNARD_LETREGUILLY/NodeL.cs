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

        public override bool EndState(GenericNode NodeFin)
        {
            return (this.GetNom() == NodeFin.GetNom());
        }


        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> list_succ = new List<GenericNode>();
            List<GenericNode> list_Node = new List<GenericNode>();


            foreach (Point P in Monde.List_Points)
            {
                list_Node.Add(new NodeL(P.NomPoint));
            }

            foreach (GenericNode N in list_Node)
            {
                if (N.GetNoeud_Parent() == null)
                {
                    N.SetNoeud_Parent(this);
                }

                foreach (NodeL K in this.Enfants)
                {
                    list_succ.Add(N);
                }
            }
            return list_succ;
        }

        /*renvoit la distance entre le point correspondant au noeud this et le point correspondant au noeud node*/
        public override double GetArcCost(GenericNode node)
        {
            //on cherche à quel point ce node (this) correspond parmis les points du monde
            Point pointNode = Monde.List_Points.Find(point => point.NomPoint == node.GetNom());
            if (pointNode != null)
            {
                //on cherche à quel point voisin le noeud node correspond
                lien resultat = pointNode.List_Voisins.Find(voisin => voisin.NomVoisin == node.GetNom()); ;
                if (resultat.Distance != 0)
                {
                    return resultat.Distance;
                }
                else
                {
                    string erreur = "ce point n'a pas de voisin correspondant au nom " + node.GetNom();
                    throw new Exception(erreur);
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
    }
}
