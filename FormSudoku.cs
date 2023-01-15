using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sudoku
{
    public partial class Sudoku : Form
    {

        Cellule[,] cellules = new Cellule[9, 9];

        public Sudoku()
        {
            InitializeComponent();
            Initialisation();
        }

        private void Initialisation()
        {
            // on crée toutes les cellules de la grille
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    // création d'une nouvelle cellule
                    cellules[i, j] = new Cellule();
                    cellules[i, j].Size = new Size(40, 40);
                    cellules[i, j].Location = new Point(40 * i, 40 * j);
                    cellules[i, j].X = i;
                    cellules[i, j].Y = j;
                    cellules[i, j].locked = true;
                    cellules[i, j].notes = new bool[] {false, false, false, false, false, false, false, false, false,};
                    cellules[i, j].FlatStyle = FlatStyle.Flat;
                    cellules[i, j].Font = new Font(this.Font.FontFamily, 20);

                    cellules[i, j].KeyPress += Sudoku_KeyPress; // ajoute l'événement d'appui sur une touche à la cellule
                    cellules[i, j].Click += Sudoku_Click; // ajoute l'événement de clic à la cellule
                    Panel_sudoku.Controls.Add(cellules[i, j]); // ajout de la cellule au panel
                }
            }
        }

        private void Sudoku_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = sender as Cellule;

            if(c != null && !c.locked)
            {

                // mode "note"
                if (CB_note.Checked)
                {
                    // si on n'a pas de chiffre ou si on a déjà une note :
                    if(c.Text == "" || c.Text=="      \n      \n      " || c.notes[0] || c.notes[1] || c.notes[2] || c.notes[3] ||
                         c.notes[4] || c.notes[5] || c.notes[6] || c.notes[7] || c.notes[8])
                    {
                        // touches pour effacer
                        if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.NumPad0)
                        {
                            c.Text = "";
                        }
                        // touches de chiffres
                        else if (Char.IsDigit(e.KeyChar))
                        {
                            int chiffre = (int)(e.KeyChar - '0'); // récupère le chiffre de la touche

                            c.notes[chiffre - 1] = !c.notes[chiffre - 1];
                            String nouveauTexte = GenererNote(c.notes);
                            c.Font = new Font(this.Font.FontFamily, 6);
                            c.Text = nouveauTexte;
                        }
                    }
                }

                // mode normal
                else
                {
                    if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.NumPad0)
                    {
                        for(int i = 0; i<9; i++)
                        {
                            c.notes[i] = false;
                        }

                        c.Text = "";
                        c.ForeColor = Color.Black;
                    }
                    else if (Char.IsDigit(e.KeyChar))
                    {

                        for (int i = 0; i < 9; i++)
                        {
                            c.notes[i] = false;
                        }
                        c.Text = "";
                        c.Font = new Font(this.Font.FontFamily, 20);
                        c.ForeColor = Color.Black;
                        c.Text = e.KeyChar.ToString();

                        // vérification de la solution
                        int erreurs = 0;
                        int casesRemplies = 0;
                        for(int i = 0; i<9; i++)
                        {
                            for(int j = 0; j<9; j++)
                            {
                                if(cellules[i, j].Text != "")
                                {
                                    casesRemplies++;
                                    if (cellules[i, j].Text != Convert.ToString(cellules[i, j].valeur))
                                    {
                                        erreurs++;
                                    }
                                }
                            }
                        }
                        if(casesRemplies==81)
                        {
                            if(erreurs == 0)
                            {
                                MessageBox.Show("Bravo ! Vous avez gagné !");
                            }
                            else MessageBox.Show("Vous avez "+ Convert.ToString(erreurs) + " erreurs.");
                        }
                    }
                }
            }
        }

        // Colore les case de la même ligne/colonne/carré en gris
        private void Sudoku_Click(object sender, EventArgs e)
        {
            var c = sender as Cellule;

            if(c != null)
            {
                // On réinitialise toute la grille en blanc
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        cellules[i, j].BackColor = Color.White;
                    }
                }

                int x = c.X;
                int y = c.Y;

                for (int i = 0; i < 9; i++)
                {
                    cellules[x, i].BackColor = Color.LightGray; // colore la ligne
                    cellules[i, y].BackColor = Color.LightGray; // colore la colonne
                }

                int xGroupe = x % 3;
                int yGroupe = y % 3;

                // colore le groupe
                for (int i = x - xGroupe; i < x - xGroupe + 3; i++)
                {
                    for (int j = y - yGroupe; j < y - yGroupe + 3; j++)
                    {
                        cellules[i, j].BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void BT_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_generer_Click(object sender, EventArgs e)
        {
            int difficulte = 0;

            if(RB_facile.Checked) difficulte = 1;
            if(RB_moyen.Checked) difficulte = 2;
            if(RB_difficile.Checked) difficulte = 3;

            if(difficulte == 0)
            {
                MessageBox.Show("Veuillez d'abord choisir une difficulté.");
            }
            else
            {
                int nbCases = 0;
                switch (difficulte)
                {
                    case 1:
                        nbCases = 30;
                        break;
                    case 2:
                        nbCases = 40;
                        break;
                    case 3:
                        nbCases = 50;
                        break;
                }
                GenererGrille(nbCases);
            }
        }

        private void GenererGrille(int difficulte)
        {
            foreach (var cell in cellules)
            {
                cell.valeur = 0;
                cell.Text = "";
            }
            
            RemplirGrille(0, -1);

            CacherCase(difficulte);
        }

        Random random = new Random();

        private bool RemplirGrille(int i, int j)
        {

            if (++j > 8)
            {
                j = 0;
                if (++i > 8)
                    return true;
            }

            var valeur = 0;
            var valDispo = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            do
            {
                if (valDispo.Count < 1)
                {
                    cellules[i, j].valeur = 0;
                    return false;
                }

                valeur = valDispo[random.Next(0, valDispo.Count)];
                cellules[i, j].valeur = valeur;

                valDispo.Remove(valeur);
            }
            while (!estValide(cellules, valeur, i, j) || !RemplirGrille(i, j));

            /*cellules[i, j].Text = valeur.ToString();*/

            return true;
        }

        private bool estValide(Cellule[,] grille, int valeur, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != y && grille[x, i].valeur == valeur) return false;

                if (i != x && grille[i, y].valeur == valeur) return false;
            }

            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && grille[i, j].valeur == valeur) return false;
                }
            }
            return true;
        }

        private void CacherCase(int diff)
        {

            Cellule[,] temp = new Cellule[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    temp[i, j] = new Cellule();
                    temp[i, j].valeur = cellules[i, j].valeur;
                }
            }

            int nombreDeCasesAEnlever = diff; // nombre de cases à enlever

            for (int i = 0; i < nombreDeCasesAEnlever; i++)
            {
                bool caseEnleveeValide = false;
                while (!caseEnleveeValide)
                {
                    int ligne = random.Next(0, 9);
                    int colonne = random.Next(0, 9);// la borne sup est exclue mais pas la borne inf

                    if (temp[ligne, colonne].valeur != 0)
                    {
                        temp[ligne, colonne].valeur = 0;
                        caseEnleveeValide = true;

                        // vérification de la grille
                        if (NombreSolutions(temp, 0, 0, 0) != 1)
                        {
                            temp[ligne, colonne].valeur = cellules[ligne, colonne].valeur;
                            caseEnleveeValide = false;
                        }

                    }
                }
            }

            AfficherGrille(temp);
        }

        private int NombreSolutions(Cellule[,] grille, int x, int y, int count)
        {
            if (x == 9)
            {
                x = 0;
                if (++y == 9) return (1 + count);
            }

            if (grille[x, y].valeur != 0) return NombreSolutions(grille, x + 1, y, count);

            for (int num = 1; (num <= 9) && (count < 2); num++)
            {
                if (estValide(grille, num, x, y))
                {
                    grille[x, y].valeur = num;
                    count = NombreSolutions(grille, x + 1, y, count);
                }
            }

            grille[x, y].valeur = 0;
            return count;
        }

        private void AfficherGrille(Cellule[,] grille)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grille[i, j].valeur != 0)
                    {
                        cellules[i, j].Text = grille[i, j].valeur.ToString();
                    }
                    else
                    {
                        cellules[i, j].locked = false;
                    }
                }
            }
        }

        private String GenererNote(bool[] notes)
        {
            String resultat = "";
            for(int i = 0; i<9; i++)
            {
                if (i%3==0 && i!=0)
                {
                    resultat += "\n";
                }
                if (notes[i])
                {
                    resultat += Convert.ToString(i + 1) + " ";
                }
                else
                {
                    resultat += "  ";
                }
            }
            return resultat;
        }

        private void BT_Verif_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    String texteCellule = cellules[i, j].Text;
                    int valeurReponse = cellules[i, j].valeur;
                    if (!string.Equals(texteCellule, valeurReponse.ToString()) && texteCellule!="")
                    {
                        cellules[i, j].ForeColor = Color.Red;
                    }
                }
            }
        }

        private void BT_Solution_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cellules[i, j].Text = Convert.ToString(cellules[i, j].valeur);
                }
            }
        }

        private void CB_note_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LB_titre_Click(object sender, EventArgs e)
        {

        }
    }
}
