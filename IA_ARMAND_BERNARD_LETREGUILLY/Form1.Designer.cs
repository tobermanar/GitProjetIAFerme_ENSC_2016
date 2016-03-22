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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nom_point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voisin1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voisin2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voisin3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voisin4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(857, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom_point,
            this.voisin1,
            this.distance1,
            this.voisin2,
            this.distance2,
            this.voisin3,
            this.distance3,
            this.voisin4,
            this.distance4});
            this.dataGridView1.Location = new System.Drawing.Point(36, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(542, 180);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nom_point
            // 
            this.nom_point.HeaderText = "Nom Point";
            this.nom_point.Name = "nom_point";
            // 
            // voisin1
            // 
            this.voisin1.HeaderText = "Voisin 1";
            this.voisin1.Name = "voisin1";
            // 
            // distance1
            // 
            this.distance1.HeaderText = "D";
            this.distance1.Name = "distance1";
            // 
            // voisin2
            // 
            this.voisin2.HeaderText = "Voisin 2";
            this.voisin2.Name = "voisin2";
            // 
            // distance2
            // 
            this.distance2.HeaderText = "D";
            this.distance2.Name = "distance2";
            // 
            // voisin3
            // 
            this.voisin3.HeaderText = "Voisin 3";
            this.voisin3.Name = "voisin3";
            // 
            // distance3
            // 
            this.distance3.HeaderText = "D";
            this.distance3.Name = "distance3";
            // 
            // voisin4
            // 
            this.voisin4.HeaderText = "Voisin 4";
            this.voisin4.Name = "voisin4";
            // 
            // distance4
            // 
            this.distance4.HeaderText = "D";
            this.distance4.Name = "distance4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 743);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_point;
        private System.Windows.Forms.DataGridViewTextBoxColumn voisin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn voisin2;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance2;
        private System.Windows.Forms.DataGridViewTextBoxColumn voisin3;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance3;
        private System.Windows.Forms.DataGridViewTextBoxColumn voisin4;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance4;
    }
}

