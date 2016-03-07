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

        public override bool EndState()
        {
            return (this.GetNom() == "12345678?");
        }

        public override List<NodeL> GetListSucc(Monde M)
        {
            List<NodeL> list_succ = new List<NodeL>();
            List<NodeL> list_Node = new List<NodeL>();

            foreach (Point P in M.List_Points)
            {
                list_Node.Add(new NodeL(P.NomPoint));
            }

            foreach (NodeL N in list_Node)
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
        public override double GetArcCost(GenericNode node, Monde M)
        {
            //on cherche à quel point ce node (this) correspond parmis les points du monde
            Point pointNode = M.List_Points.Find(point => point.NomPoint == node.GetNom());
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
