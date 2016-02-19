using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    class NodeL : GenericNode
    {
        /*renvoit la distance entre le point correspondant au noeud this et le point correspondant au noeud node*/
        public override double GetArcCost(GenericNode node)
        {
            //on cherche à quel point ce node (this) correspond parmis les points du monde
            Point pointNode = Monde.List_Points.Find(point => point.NomPoint == node.GetNom());
            if (pointNode != null)
            {
                //on cherche à quel point voisin le noeud node correspond
                lien resultat = pointNode.List_Voisins.Find(voisin => voisin.NomVoisin == node.GetNom()); ;
                return resultat.Distance;
                
                /*if (resultat!=null)
                {
                    return resultat.distance;
                }
                else
                {
                    string erreur = "ce point n'a pas de voisin correspondant au nom " + node.GetNom();
                    throw new Exception(erreur);
                }*/
            }
            else
            {
                string erreur = "ce point n'a pas de voisin correspondant au nom " + node.GetNom();
                throw new Exception(erreur);
            }
        }
    }
}
