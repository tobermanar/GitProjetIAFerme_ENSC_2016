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
            //Définition des points du monde
            List<lien> list_Lien = new List<lien>();
            List<Point> list_Point = new List<Point>();
            list_Lien.Add(new lien("B", 4));
            list_Lien.Add(new lien("C", 5));
            list_Lien.Add(new lien("D", 6));
            list_Point.Add(new Point("A", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("A", 4));
            list_Lien.Add(new lien("E", 5));
            list_Point.Add(new Point("B", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("A", 5));
            list_Lien.Add(new lien("D", 4));
            list_Lien.Add(new lien("E", 6));
            list_Lien.Add(new lien("G", 6));
            list_Point.Add(new Point("C", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("A", 6));
            list_Lien.Add(new lien("C", 4));
            list_Lien.Add(new lien("F", 9));
            list_Point.Add(new Point("D", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("B", 5));
            list_Lien.Add(new lien("C", 6));
            list_Lien.Add(new lien("H", 4));
            list_Point.Add(new Point("E", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("D", 9));
            list_Lien.Add(new lien("L", 9));
            list_Point.Add(new Point("F", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("C", 8));
            list_Lien.Add(new lien("H", 8));
            list_Lien.Add(new lien("K", 8));
            list_Point.Add(new Point("G", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("E", 4));
            list_Lien.Add(new lien("G", 8));
            list_Lien.Add(new lien("I", 2));
            list_Point.Add(new Point("H", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("H", 2));
            list_Lien.Add(new lien("J", 3));
            list_Lien.Add(new lien("K", 4));
            list_Point.Add(new Point("I", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("I", 3));
            list_Point.Add(new Point("J", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("G", 8));
            list_Lien.Add(new lien("I", 4));
            list_Lien.Add(new lien("W", 7));
            list_Point.Add(new Point("K", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("F", 9));
            list_Lien.Add(new lien("M", 2));
            list_Lien.Add(new lien("W", 10));
            list_Lien.Add(new lien("Q", 7));
            list_Lien.Add(new lien("N", 4));
            list_Point.Add(new Point("L", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("L", 2));
            list_Point.Add(new Point("M", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("L", 4));
            list_Lien.Add(new lien("P", 3));
            list_Lien.Add(new lien("O", 7));
            list_Point.Add(new Point("N", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("N", 7));
            list_Lien.Add(new lien("P", 3));
            list_Lien.Add(new lien("S", 8));
            list_Point.Add(new Point("O", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("N", 3));
            list_Lien.Add(new lien("O", 3));
            list_Lien.Add(new lien("R", 5));
            list_Point.Add(new Point("P", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("L", 7));
            list_Lien.Add(new lien("R", 3));
            list_Point.Add(new Point("Q", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("P", 5));
            list_Lien.Add(new lien("Q", 3));
            list_Lien.Add(new lien("T", 6));
            list_Point.Add(new Point("R", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("O", 8));
            list_Lien.Add(new lien("U", 7));
            list_Point.Add(new Point("S", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("R", 6));
            list_Lien.Add(new lien("U", 5));
            list_Point.Add(new Point("T", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("T", 5));
            list_Lien.Add(new lien("V", 11));
            list_Lien.Add(new lien("S", 7));
            list_Point.Add(new Point("U", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new lien("W", 6));
            list_Lien.Add(new lien("U", 11));
            list_Point.Add(new Point("V", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new lien("K", 7));
            list_Lien.Add(new lien("L", 10));
            list_Lien.Add(new lien("V", 6));
            list_Point.Add(new Point("W", list_Lien));
            Monde fermes = new Monde("fermes", list_Point);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
