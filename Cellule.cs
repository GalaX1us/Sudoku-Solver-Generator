using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class Cellule : Button
    {
        public int X;
        public int Y;
        public int valeur; // valeur théorique de la case, peut être différente de son texte
        public bool locked; // indique si l'utilisateur peut écrire dans la case ou non
        public bool[] notes;
    }
}
