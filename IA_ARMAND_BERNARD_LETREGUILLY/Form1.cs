﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    public partial class Form1 : Form
    {
        int q5_iteration = 0;
        public Form1()
        {
            InitializeComponent();
            //Définition des points du monde
            List<Lien> list_Lien = new List<Lien>();
            List<Point> list_Points = new List<Point>();
            list_Lien.Add(new Lien("B", 4));
            list_Lien.Add(new Lien("C", 5));
            list_Lien.Add(new Lien("D", 6));
            list_Points.Add(new Point("A", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("A", 4));
            list_Lien.Add(new Lien("E", 5));
            list_Points.Add(new Point("B", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("A", 5));
            list_Lien.Add(new Lien("D", 4));
            list_Lien.Add(new Lien("E", 6));
            list_Lien.Add(new Lien("G", 6));
            list_Points.Add(new Point("C", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("A", 6));
            list_Lien.Add(new Lien("C", 4));
            list_Lien.Add(new Lien("F", 9));
            list_Points.Add(new Point("D", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("B", 5));
            list_Lien.Add(new Lien("C", 6));
            list_Lien.Add(new Lien("H", 4));
            list_Points.Add(new Point("E", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("D", 9));
            list_Lien.Add(new Lien("L", 9));
            list_Points.Add(new Point("F", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("C", 8));
            list_Lien.Add(new Lien("H", 8));
            list_Lien.Add(new Lien("K", 8));
            list_Points.Add(new Point("G", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("E", 4));
            list_Lien.Add(new Lien("G", 8));
            list_Lien.Add(new Lien("I", 2));
            list_Points.Add(new Point("H", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("H", 2));
            list_Lien.Add(new Lien("J", 3));
            list_Lien.Add(new Lien("K", 4));
            list_Points.Add(new Point("I", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("I", 3));
            list_Points.Add(new Point("J", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("G", 8));
            list_Lien.Add(new Lien("I", 4));
            list_Lien.Add(new Lien("W", 7));
            list_Points.Add(new Point("K", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("F", 9));
            list_Lien.Add(new Lien("M", 2));
            list_Lien.Add(new Lien("W", 10));
            list_Lien.Add(new Lien("Q", 7));
            list_Lien.Add(new Lien("N", 4));
            list_Points.Add(new Point("L", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("L", 2));
            list_Points.Add(new Point("M", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("L", 4));
            list_Lien.Add(new Lien("P", 3));
            list_Lien.Add(new Lien("O", 7));
            list_Points.Add(new Point("N", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("N", 7));
            list_Lien.Add(new Lien("P", 3));
            list_Lien.Add(new Lien("S", 8));
            list_Points.Add(new Point("O", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("N", 3));
            list_Lien.Add(new Lien("O", 3));
            list_Lien.Add(new Lien("R", 5));
            list_Points.Add(new Point("P", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("L", 7));
            list_Lien.Add(new Lien("R", 3));
            list_Points.Add(new Point("Q", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("P", 5));
            list_Lien.Add(new Lien("Q", 3));
            list_Lien.Add(new Lien("T", 6));
            list_Points.Add(new Point("R", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("O", 8));
            list_Lien.Add(new Lien("U", 7));
            list_Points.Add(new Point("S", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("R", 6));
            list_Lien.Add(new Lien("U", 5));
            list_Points.Add(new Point("T", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("T", 5));
            list_Lien.Add(new Lien("V", 11));
            list_Lien.Add(new Lien("S", 7));
            list_Points.Add(new Point("U", list_Lien));
            list_Lien.Clear();
            list_Lien.Add(new Lien("W", 6));
            list_Lien.Add(new Lien("U", 11));
            list_Points.Add(new Point("V", list_Lien, true));
            list_Lien.Clear();
            list_Lien.Add(new Lien("K", 7));
            list_Lien.Add(new Lien("L", 10));
            list_Lien.Add(new Lien("V", 6));
            list_Points.Add(new Point("W", list_Lien));
            Monde.NomMonde = "fermes";
            Monde.List_Points = list_Points;
            //this.Fermes = new Monde("fermes", list_Points);
            listBox1.DataSource = list_Points; // La liste que tu veux afficher dans ListBox
            //Initialisation des listbox de la question 2
            q2_alphabetical1.BeginUpdate();
            for (int i = 0; i < 23; i++)
            {
                q2_alphabetical1.Items.Add(string.Format("{0}", Convert.ToChar('A' + i)));
            }
            q2_alphabetical1.EndUpdate();
            q2_alphabetical2.BeginUpdate();
            for (int i = 0; i < 23; i++)
            {
                q2_alphabetical2.Items.Add(string.Format("{0}", Convert.ToChar('A' + i)));
            }
            q2_alphabetical2.EndUpdate();
            textQ3.ForeColor = Color.Gray;
            textQ3.Text = "Entrez une liste de points sans espaces séparés par une virgule";
            textQ4.ForeColor = Color.Gray;
            textQ4.Text = "Entrez une liste de points sans espaces séparés par une virgule";
        }

        private void button_q1_Click(object sender, EventArgs e)
        {
            
            // Shutdown the painting of the ListBox as items are added.
            listBox2.BeginUpdate();
            listBox2.Items.Add("  Question 1 : ");
            foreach (Point element in Monde.Impasses())
            {
                listBox2.Items.Add(element);
            }
            listBox2.Items.Add("Fin question 1");
            // Allow the ListBox to repaint and display the new items.
            listBox2.EndUpdate();
        }
        private void button_q2_Click(object sender, EventArgs e)
        {
            string param1 = q2_alphabetical1.GetItemText(q2_alphabetical1.SelectedItem);
            string param2 = q2_alphabetical2.GetItemText(q2_alphabetical2.SelectedItem);
            string[] result = Monde.Distance(param1, param2);
            listBox2.BeginUpdate();
            listBox2.Items.Add("  Question 2 : ");
            listBox2.Items.Add("Distance entre " + param1 + " et " + param2 + " = " + result[0]);
            listBox2.Items.Add("Chemin : " + result[1]);
            listBox2.Items.Add("Fin question 2");
            listBox2.EndUpdate();
        }
        private void button_q3_Click(object sender, EventArgs e)
        {
            //Gestion du texte de Q3
            //Découpage à chaque virgule
            string lower = textQ3.Text;
            textQ3.Text = lower.ToUpper();
            string[] lettresDecoupes = textQ3.Text.Split(',');
            //Vérification pour savoir si il ne s'agit que de lettres
            int  nombreLettresValides = lettresDecoupes.Count();
            for (int i = 0; i < lettresDecoupes.Count(); i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    if (string.Format("{0}", Convert.ToChar('A' + j)) == lettresDecoupes[i])
                    {
                        nombreLettresValides--;
                    }
                }
            }
            if (nombreLettresValides == 0)
            {
                string[] result = NodeChemin.TrouveChemin(lettresDecoupes);
                listBox2.BeginUpdate();
                listBox2.Items.Add("  Question 3 : ");
                listBox2.Items.Add("Distance du trajet total : " + result[0]);
                listBox2.Items.Add("Chemin : " + result[1]);
                listBox2.Items.Add("Fin question 3");
                listBox2.EndUpdate();
            }
            else
            {
                textQ3.Text = "Erreur lors de la saisie, recommencez";
                textQ3.ForeColor = Color.Red;
            }
        }
        private void button_q4_Click(object sender, EventArgs e)
        {
            //Gestion du texte de Q3
            //Découpage à chaque virgule
            string lower = textQ4.Text;
            textQ4.Text = lower.ToUpper();
            string[] lettresDecoupes = textQ4.Text.Split(',');
            //Vérification pour savoir si il ne s'agit que de lettres
            int nombreLettresValides = lettresDecoupes.Count();
            for (int i = 0; i < lettresDecoupes.Count(); i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    if (string.Format("{0}", Convert.ToChar('A' + j)) == lettresDecoupes[i])
                    {
                        nombreLettresValides--;
                    }
                }
            }
            if (nombreLettresValides == 0)
            {
                string[] result = NodeChemin.TrouveChemin(lettresDecoupes, true);
                listBox2.BeginUpdate();
                listBox2.Items.Add("  Question 4 : ");
                listBox2.Items.Add("Distance du trajet total : " + result[0]);
                listBox2.Items.Add("Chemin : " + result[1]);
                listBox2.Items.Add("Fin question 4");
                listBox2.EndUpdate();
            }
            else
            {
                textQ4.Text = "Erreur lors de la saisie, recommencez";
                textQ4.ForeColor = Color.Red;
            }
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            listBox2.Items.Clear();
            listBox2.EndUpdate();
            q5_iteration = 0;
            foreach (Point p in Monde.List_Points)
            {
                p.Statue = 0;
            }
        }

        private void textQ3_Click(object sender, EventArgs e)
        {
            textQ3.Clear();
            textQ3.ForeColor = Color.Black;
        }

        private void textQ4_Click(object sender, EventArgs e)
        {
            textQ4.Clear();
            textQ4.ForeColor = Color.Black;
        }

        private void button_q5_Click(object sender, EventArgs e)
        {
            if (Monde.ErStatue(Monde.List_Points) != 0)
            {
                q5_label.Text = "En cours de calcul";
                q5_label.Refresh();
                q5_iteration++;
                List<Point> res = Monde.Statue(Monde.List_Points);
                Monde.List_Points = res;
                Monde.NbStatues();
                listBox2.BeginUpdate();
                listBox2.Items.Add("  Question 5 : ");
                foreach (Point p in Monde.List_Points)
                {
                    listBox2.Items.Add(p);
                }
                listBox2.Items.Add("Itération n°" + q5_iteration);
                listBox2.Items.Add("Fin question 5");
                listBox2.EndUpdate();
                q5_label.Text = "Nombre de conflits : " + Monde.ErStatue(Monde.List_Points).ToString();
            }
        }
        private void button_q5b_Click(object sender, EventArgs e)
        {
            if (Monde.ErStatue(Monde.List_Points) != 0)
            {
                q5b_label.Text = "En cours de calcul";
                q5b_label.Refresh();
                q5_iteration++;
                List<Point> res = Monde.Statue2(Monde.List_Points);
                Monde.List_Points = res;
                listBox2.BeginUpdate();
                listBox2.Items.Add("  Question 5 : ");
                foreach (Point p in Monde.List_Points)
                {
                    listBox2.Items.Add(p);
                }
                listBox2.Items.Add("Itération n°" + q5_iteration);
                listBox2.Items.Add("Fin question 5");
                listBox2.EndUpdate();
                q5b_label.Text = "Nombre de conflits : " + Monde.ErStatue(Monde.List_Points).ToString();
            }
        }
    }
}
