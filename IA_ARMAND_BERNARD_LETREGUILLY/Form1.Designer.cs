﻿using System.Collections.Generic;
using System;
namespace IA_ARMAND_BERNARD_LETREGUILLY
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_q1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.Q1 = new System.Windows.Forms.Label();
            this.q2_alphabetical1 = new System.Windows.Forms.ListBox();
            this.q2_alphabetical2 = new System.Windows.Forms.ListBox();
            this.button_q2 = new System.Windows.Forms.Button();
            this.Q2 = new System.Windows.Forms.Label();
            this.Q3 = new System.Windows.Forms.Label();
            this.button_q3 = new System.Windows.Forms.Button();
            this.textQ3 = new System.Windows.Forms.TextBox();
            this.textQ4 = new System.Windows.Forms.TextBox();
            this.Q4 = new System.Windows.Forms.Label();
            this.button_q4 = new System.Windows.Forms.Button();
            this.Q5 = new System.Windows.Forms.Label();
            this.button_q5 = new System.Windows.Forms.Button();
            this.q5_label = new System.Windows.Forms.Label();
            this.q5b_label = new System.Windows.Forms.Label();
            this.Q5b = new System.Windows.Forms.Label();
            this.button_q5b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_q1
            // 
            this.button_q1.Location = new System.Drawing.Point(58, 312);
            this.button_q1.Name = "button_q1";
            this.button_q1.Size = new System.Drawing.Size(131, 31);
            this.button_q1.TabIndex = 0;
            this.button_q1.Text = "Impasses";
            this.button_q1.UseVisualStyleBackColor = true;
            this.button_q1.Click += new System.EventHandler(this.button_q1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Fermes";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(730, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Résultats";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(774, 224);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(808, 41);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(774, 644);
            this.listBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Réseau routier d\'entrée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sortie(s)";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(808, 700);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(131, 31);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Q1
            // 
            this.Q1.AutoSize = true;
            this.Q1.Location = new System.Drawing.Point(24, 317);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(30, 20);
            this.Q1.TabIndex = 12;
            this.Q1.Text = "Q1";
            // 
            // q2_alphabetical1
            // 
            this.q2_alphabetical1.FormattingEnabled = true;
            this.q2_alphabetical1.ItemHeight = 20;
            this.q2_alphabetical1.Location = new System.Drawing.Point(222, 336);
            this.q2_alphabetical1.Name = "q2_alphabetical1";
            this.q2_alphabetical1.ScrollAlwaysVisible = true;
            this.q2_alphabetical1.Size = new System.Drawing.Size(62, 44);
            this.q2_alphabetical1.TabIndex = 14;
            // 
            // q2_alphabetical2
            // 
            this.q2_alphabetical2.FormattingEnabled = true;
            this.q2_alphabetical2.ItemHeight = 20;
            this.q2_alphabetical2.Location = new System.Drawing.Point(303, 336);
            this.q2_alphabetical2.Name = "q2_alphabetical2";
            this.q2_alphabetical2.ScrollAlwaysVisible = true;
            this.q2_alphabetical2.Size = new System.Drawing.Size(62, 44);
            this.q2_alphabetical2.TabIndex = 15;
            // 
            // button_q2
            // 
            this.button_q2.Location = new System.Drawing.Point(58, 349);
            this.button_q2.Name = "button_q2";
            this.button_q2.Size = new System.Drawing.Size(158, 31);
            this.button_q2.TabIndex = 7;
            this.button_q2.Text = "Plus court chemin";
            this.button_q2.UseVisualStyleBackColor = true;
            this.button_q2.Click += new System.EventHandler(this.button_q2_Click);
            // 
            // Q2
            // 
            this.Q2.AutoSize = true;
            this.Q2.Location = new System.Drawing.Point(24, 354);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(30, 20);
            this.Q2.TabIndex = 13;
            this.Q2.Text = "Q2";
            // 
            // Q3
            // 
            this.Q3.AutoSize = true;
            this.Q3.Location = new System.Drawing.Point(24, 391);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(30, 20);
            this.Q3.TabIndex = 17;
            this.Q3.Text = "Q3";
            // 
            // button_q3
            // 
            this.button_q3.Location = new System.Drawing.Point(58, 386);
            this.button_q3.Name = "button_q3";
            this.button_q3.Size = new System.Drawing.Size(158, 31);
            this.button_q3.TabIndex = 16;
            this.button_q3.Text = "Plus court circuit";
            this.button_q3.UseVisualStyleBackColor = true;
            this.button_q3.Click += new System.EventHandler(this.button_q3_Click);
            // 
            // textQ3
            // 
            this.textQ3.Location = new System.Drawing.Point(222, 388);
            this.textQ3.Name = "textQ3";
            this.textQ3.Size = new System.Drawing.Size(553, 26);
            this.textQ3.TabIndex = 18;
            this.textQ3.Click += new System.EventHandler(this.textQ3_Click);
            // 
            // textQ4
            // 
            this.textQ4.Location = new System.Drawing.Point(290, 426);
            this.textQ4.Name = "textQ4";
            this.textQ4.Size = new System.Drawing.Size(485, 26);
            this.textQ4.TabIndex = 21;
            this.textQ4.Click += new System.EventHandler(this.textQ4_Click);
            // 
            // Q4
            // 
            this.Q4.AutoSize = true;
            this.Q4.Location = new System.Drawing.Point(24, 429);
            this.Q4.Name = "Q4";
            this.Q4.Size = new System.Drawing.Size(30, 20);
            this.Q4.TabIndex = 20;
            this.Q4.Text = "Q4";
            // 
            // button_q4
            // 
            this.button_q4.Location = new System.Drawing.Point(58, 424);
            this.button_q4.Name = "button_q4";
            this.button_q4.Size = new System.Drawing.Size(226, 31);
            this.button_q4.TabIndex = 19;
            this.button_q4.Text = "Plus court circuit + Contrainte";
            this.button_q4.UseVisualStyleBackColor = true;
            this.button_q4.Click += new System.EventHandler(this.button_q4_Click);
            // 
            // Q5
            // 
            this.Q5.AutoSize = true;
            this.Q5.Location = new System.Drawing.Point(24, 466);
            this.Q5.Name = "Q5";
            this.Q5.Size = new System.Drawing.Size(30, 20);
            this.Q5.TabIndex = 23;
            this.Q5.Text = "Q5";
            // 
            // button_q5
            // 
            this.button_q5.Location = new System.Drawing.Point(58, 461);
            this.button_q5.Name = "button_q5";
            this.button_q5.Size = new System.Drawing.Size(131, 31);
            this.button_q5.TabIndex = 22;
            this.button_q5.Text = "Statues";
            this.button_q5.UseVisualStyleBackColor = true;
            this.button_q5.Click += new System.EventHandler(this.button_q5_Click);
            // 
            // q5_label
            // 
            this.q5_label.AutoSize = true;
            this.q5_label.Location = new System.Drawing.Point(195, 466);
            this.q5_label.Name = "q5_label";
            this.q5_label.Size = new System.Drawing.Size(327, 20);
            this.q5_label.TabIndex = 24;
            this.q5_label.Text = "Appuyez jusqu\'a qu\'il ne reste plus de conflits";
            // 
            // q5b_label
            // 
            this.q5b_label.AutoSize = true;
            this.q5b_label.Location = new System.Drawing.Point(195, 503);
            this.q5b_label.Name = "q5b_label";
            this.q5b_label.Size = new System.Drawing.Size(387, 20);
            this.q5b_label.TabIndex = 28;
            this.q5b_label.Text = "Deuxième version sans gestion du nombre de statues";
            // 
            // Q5b
            // 
            this.Q5b.AutoSize = true;
            this.Q5b.Location = new System.Drawing.Point(24, 503);
            this.Q5b.Name = "Q5b";
            this.Q5b.Size = new System.Drawing.Size(39, 20);
            this.Q5b.TabIndex = 27;
            this.Q5b.Text = "Q5b";
            // 
            // button_q5b
            // 
            this.button_q5b.Location = new System.Drawing.Point(58, 498);
            this.button_q5b.Name = "button_q5b";
            this.button_q5b.Size = new System.Drawing.Size(131, 31);
            this.button_q5b.TabIndex = 29;
            this.button_q5b.Text = "Statues bis";
            this.button_q5b.UseVisualStyleBackColor = true;
            this.button_q5b.Click += new System.EventHandler(this.button_q5b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 743);
            this.Controls.Add(this.button_q5b);
            this.Controls.Add(this.q5b_label);
            this.Controls.Add(this.Q5b);
            this.Controls.Add(this.q5_label);
            this.Controls.Add(this.Q5);
            this.Controls.Add(this.button_q5);
            this.Controls.Add(this.textQ4);
            this.Controls.Add(this.Q4);
            this.Controls.Add(this.button_q4);
            this.Controls.Add(this.textQ3);
            this.Controls.Add(this.Q3);
            this.Controls.Add(this.button_q3);
            this.Controls.Add(this.q2_alphabetical2);
            this.Controls.Add(this.q2_alphabetical1);
            this.Controls.Add(this.Q2);
            this.Controls.Add(this.Q1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_q2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_q1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_q1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label Q1;
        private System.Windows.Forms.ListBox q2_alphabetical1;
        private System.Windows.Forms.ListBox q2_alphabetical2;
        private System.Windows.Forms.Button button_q2;
        private System.Windows.Forms.Label Q2;
        private System.Windows.Forms.Label Q3;
        private System.Windows.Forms.Button button_q3;
        private System.Windows.Forms.TextBox textQ3;
        private System.Windows.Forms.TextBox textQ4;
        private System.Windows.Forms.Label Q4;
        private System.Windows.Forms.Button button_q4;
        private System.Windows.Forms.Label Q5;
        private System.Windows.Forms.Button button_q5;
        private System.Windows.Forms.Label q5_label;
        private System.Windows.Forms.Label q5b_label;
        private System.Windows.Forms.Label Q5b;
        private System.Windows.Forms.Button button_q5b;
    }
}

