using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    public partial class Form1 : Form
    {
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
            //listBox1.DataTextField = "Fermes" // Le nom de la propriéé qui sera afficher dans ListBox
            //listBox1.DataBind(); // Méthode qui actualise lales données de la liste
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultats_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fermes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button_q1_Click(object sender, EventArgs e)
        {
            
            // Shutdown the painting of the ListBox as items are added.
            listBox2.BeginUpdate();
            listBox2.Items.Add("Résultat impasses");
            foreach (Point element in Monde.Impasses())
            {
                listBox2.Items.Add(element);
            }
            listBox2.Items.Add("Fin impasses");
            // Allow the ListBox to repaint and display the new items.
            listBox2.EndUpdate();
        }
        private void button_q2_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            String[] elements = Regex.Split(textBox3.ToString(), @"\s?");
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            listBox2.Items.Clear();
            listBox2.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); 
            List<Point> res = Monde.Statue(Monde.List_Points);
            foreach (Point p in res)
            {
                listBox2.Items.Add(p);
            }
            Monde.List_Points = res;
            listBox1.BeginUpdate();
            listBox1.DataSource = Monde.List_Points;
            listBox1.EndUpdate();
        }
    }
}
