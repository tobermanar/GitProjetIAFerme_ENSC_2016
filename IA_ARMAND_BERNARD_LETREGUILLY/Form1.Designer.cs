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
            this.button_q2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.Q1 = new System.Windows.Forms.Label();
            this.Q2 = new System.Windows.Forms.Label();
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
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(222, 349);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(466, 31);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Entrez deux noeuds présent dans la liste séparés par un espace.";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            // Q2
            // 
            this.Q2.AutoSize = true;
            this.Q2.Location = new System.Drawing.Point(24, 354);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(30, 20);
            this.Q2.TabIndex = 13;
            this.Q2.Text = "Q2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 743);
            this.Controls.Add(this.Q2);
            this.Controls.Add(this.Q1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_q2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_q1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_q1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button_q2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label Q1;
        private System.Windows.Forms.Label Q2;
    }
}

