namespace Sudoku
{
    partial class Sudoku
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
            this.LB_titre = new System.Windows.Forms.Label();
            this.BT_generer = new System.Windows.Forms.Button();
            this.RB_facile = new System.Windows.Forms.RadioButton();
            this.RB_moyen = new System.Windows.Forms.RadioButton();
            this.RB_difficile = new System.Windows.Forms.RadioButton();
            this.LB_difficulte = new System.Windows.Forms.Label();
            this.BT_quitter = new System.Windows.Forms.Button();
            this.Panel_sudoku = new System.Windows.Forms.Panel();
            this.Panel_Line4 = new System.Windows.Forms.Panel();
            this.Panel_Line2 = new System.Windows.Forms.Panel();
            this.Panel_Line1 = new System.Windows.Forms.Panel();
            this.BT_Verif = new System.Windows.Forms.Button();
            this.Panel_Line3 = new System.Windows.Forms.Panel();
            this.BT_Solution = new System.Windows.Forms.Button();
            this.CB_note = new System.Windows.Forms.CheckBox();
            this.Panel_sudoku.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_titre
            // 
            this.LB_titre.AutoSize = true;
            this.LB_titre.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_titre.Location = new System.Drawing.Point(254, 6);
            this.LB_titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_titre.Name = "LB_titre";
            this.LB_titre.Size = new System.Drawing.Size(184, 63);
            this.LB_titre.TabIndex = 1;
            this.LB_titre.Text = "Sudoku";
            this.LB_titre.Click += new System.EventHandler(this.LB_titre_Click);
            // 
            // BT_generer
            // 
            this.BT_generer.Location = new System.Drawing.Point(564, 135);
            this.BT_generer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_generer.Name = "BT_generer";
            this.BT_generer.Size = new System.Drawing.Size(75, 41);
            this.BT_generer.TabIndex = 3;
            this.BT_generer.Text = "Générer";
            this.BT_generer.UseVisualStyleBackColor = true;
            this.BT_generer.Click += new System.EventHandler(this.BT_generer_Click);
            // 
            // RB_facile
            // 
            this.RB_facile.AutoSize = true;
            this.RB_facile.Location = new System.Drawing.Point(458, 126);
            this.RB_facile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_facile.Name = "RB_facile";
            this.RB_facile.Size = new System.Drawing.Size(53, 17);
            this.RB_facile.TabIndex = 4;
            this.RB_facile.TabStop = true;
            this.RB_facile.Text = "Facile";
            this.RB_facile.UseVisualStyleBackColor = true;
            // 
            // RB_moyen
            // 
            this.RB_moyen.AutoSize = true;
            this.RB_moyen.Location = new System.Drawing.Point(458, 147);
            this.RB_moyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_moyen.Name = "RB_moyen";
            this.RB_moyen.Size = new System.Drawing.Size(57, 17);
            this.RB_moyen.TabIndex = 5;
            this.RB_moyen.TabStop = true;
            this.RB_moyen.Text = "Moyen";
            this.RB_moyen.UseVisualStyleBackColor = true;
            // 
            // RB_difficile
            // 
            this.RB_difficile.AutoSize = true;
            this.RB_difficile.Location = new System.Drawing.Point(458, 169);
            this.RB_difficile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_difficile.Name = "RB_difficile";
            this.RB_difficile.Size = new System.Drawing.Size(59, 17);
            this.RB_difficile.TabIndex = 6;
            this.RB_difficile.TabStop = true;
            this.RB_difficile.Text = "Difficile";
            this.RB_difficile.UseVisualStyleBackColor = true;
            // 
            // LB_difficulte
            // 
            this.LB_difficulte.AutoSize = true;
            this.LB_difficulte.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_difficulte.Location = new System.Drawing.Point(400, 84);
            this.LB_difficulte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_difficulte.Name = "LB_difficulte";
            this.LB_difficulte.Size = new System.Drawing.Size(271, 31);
            this.LB_difficulte.TabIndex = 7;
            this.LB_difficulte.Text = "Choix de la difficulté :";
            // 
            // BT_quitter
            // 
            this.BT_quitter.Location = new System.Drawing.Point(485, 407);
            this.BT_quitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_quitter.Name = "BT_quitter";
            this.BT_quitter.Size = new System.Drawing.Size(107, 39);
            this.BT_quitter.TabIndex = 9;
            this.BT_quitter.Text = "Quitter";
            this.BT_quitter.UseVisualStyleBackColor = true;
            this.BT_quitter.Click += new System.EventHandler(this.BT_quitter_Click);
            // 
            // Panel_sudoku
            // 
            this.Panel_sudoku.Controls.Add(this.Panel_Line4);
            this.Panel_sudoku.Controls.Add(this.Panel_Line2);
            this.Panel_sudoku.Controls.Add(this.Panel_Line1);
            this.Panel_sudoku.Location = new System.Drawing.Point(9, 84);
            this.Panel_sudoku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_sudoku.Name = "Panel_sudoku";
            this.Panel_sudoku.Size = new System.Drawing.Size(368, 366);
            this.Panel_sudoku.TabIndex = 11;
            // 
            // Panel_Line4
            // 
            this.Panel_Line4.BackColor = System.Drawing.Color.Black;
            this.Panel_Line4.Location = new System.Drawing.Point(0, 119);
            this.Panel_Line4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_Line4.Name = "Panel_Line4";
            this.Panel_Line4.Size = new System.Drawing.Size(360, 5);
            this.Panel_Line4.TabIndex = 1;
            // 
            // Panel_Line2
            // 
            this.Panel_Line2.BackColor = System.Drawing.Color.Black;
            this.Panel_Line2.Location = new System.Drawing.Point(239, 0);
            this.Panel_Line2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_Line2.Name = "Panel_Line2";
            this.Panel_Line2.Size = new System.Drawing.Size(4, 360);
            this.Panel_Line2.TabIndex = 1;
            // 
            // Panel_Line1
            // 
            this.Panel_Line1.BackColor = System.Drawing.Color.Black;
            this.Panel_Line1.Location = new System.Drawing.Point(117, 0);
            this.Panel_Line1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_Line1.Name = "Panel_Line1";
            this.Panel_Line1.Size = new System.Drawing.Size(4, 360);
            this.Panel_Line1.TabIndex = 0;
            // 
            // BT_Verif
            // 
            this.BT_Verif.Location = new System.Drawing.Point(406, 323);
            this.BT_Verif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Verif.Name = "BT_Verif";
            this.BT_Verif.Size = new System.Drawing.Size(122, 52);
            this.BT_Verif.TabIndex = 12;
            this.BT_Verif.Text = "Vérifier les erreurs";
            this.BT_Verif.UseVisualStyleBackColor = true;
            this.BT_Verif.Click += new System.EventHandler(this.BT_Verif_Click);
            // 
            // Panel_Line3
            // 
            this.Panel_Line3.BackColor = System.Drawing.Color.Black;
            this.Panel_Line3.Location = new System.Drawing.Point(9, 323);
            this.Panel_Line3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_Line3.Name = "Panel_Line3";
            this.Panel_Line3.Size = new System.Drawing.Size(360, 5);
            this.Panel_Line3.TabIndex = 2;
            // 
            // BT_Solution
            // 
            this.BT_Solution.Location = new System.Drawing.Point(549, 323);
            this.BT_Solution.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Solution.Name = "BT_Solution";
            this.BT_Solution.Size = new System.Drawing.Size(122, 52);
            this.BT_Solution.TabIndex = 13;
            this.BT_Solution.Text = "Afficher la solution";
            this.BT_Solution.UseVisualStyleBackColor = true;
            this.BT_Solution.Click += new System.EventHandler(this.BT_Solution_Click);
            // 
            // CB_note
            // 
            this.CB_note.AutoSize = true;
            this.CB_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_note.Location = new System.Drawing.Point(479, 239);
            this.CB_note.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_note.Name = "CB_note";
            this.CB_note.Size = new System.Drawing.Size(113, 21);
            this.CB_note.TabIndex = 14;
            this.CB_note.Text = "Mode \"Notes\"";
            this.CB_note.UseVisualStyleBackColor = true;
            this.CB_note.CheckedChanged += new System.EventHandler(this.CB_note_CheckedChanged);
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 457);
            this.Controls.Add(this.CB_note);
            this.Controls.Add(this.BT_Solution);
            this.Controls.Add(this.Panel_Line3);
            this.Controls.Add(this.BT_Verif);
            this.Controls.Add(this.Panel_sudoku);
            this.Controls.Add(this.BT_quitter);
            this.Controls.Add(this.LB_difficulte);
            this.Controls.Add(this.RB_difficile);
            this.Controls.Add(this.RB_moyen);
            this.Controls.Add(this.RB_facile);
            this.Controls.Add(this.BT_generer);
            this.Controls.Add(this.LB_titre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sudoku";
            this.Text = " ";
            this.Click += new System.EventHandler(this.Sudoku_Click);
            this.Panel_sudoku.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_titre;
        private System.Windows.Forms.Button BT_generer;
        private System.Windows.Forms.RadioButton RB_facile;
        private System.Windows.Forms.RadioButton RB_moyen;
        private System.Windows.Forms.RadioButton RB_difficile;
        private System.Windows.Forms.Label LB_difficulte;
        private System.Windows.Forms.Button BT_quitter;
        private System.Windows.Forms.Panel Panel_sudoku;
        private System.Windows.Forms.Button BT_Verif;
        private System.Windows.Forms.Panel Panel_Line4;
        private System.Windows.Forms.Panel Panel_Line2;
        private System.Windows.Forms.Panel Panel_Line1;
        private System.Windows.Forms.Panel Panel_Line3;
        private System.Windows.Forms.Button BT_Solution;
        private System.Windows.Forms.CheckBox CB_note;
    }
}

