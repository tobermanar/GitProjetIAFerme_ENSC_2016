using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Graph leGraph = new Graph();
            //List<GenericNode> truc = leGraph.RechercheSolutionAEtoile(new NodeL("A"), "L");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
           

        }
    }
}
