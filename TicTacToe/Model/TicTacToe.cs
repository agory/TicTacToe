using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TicTacToe
    {
        private int[,] matrix;

        public TicTacToe(int[,] matrix) {
            this.matrix = matrix;
        }


        public int computeWin() {
            int winner = 0;
            for (int i = 0; i < 3; i++) {
                if ((matrix[i, 0] == matrix[i, 1] && matrix[i, 0] == matrix[i, 2]) ||
                   (matrix[0, i] == matrix[1, i] && matrix[0, i] == matrix[2, i]))
                {
                    winner = matrix[i, i];
                }
            }
            if (winner == 0) {
                if ((matrix[0, 0] == matrix[1, 1] && matrix[2, 2] == matrix[1, 1]) ||
                   (matrix[2, 0] == matrix[1, 1] && matrix[1, 1] == matrix[0, 2]))
                {
                    winner = matrix[1, 1];
                }
            }
            return winner;
        }
       

        private int minimax(int joueur)
        {
            int resultat, i, j, resultat_coup, coups_possibles = 0;
            resultat = computeWin();
            if (resultat == 0)
            {
                resultat = -joueur; /* pire cas */
                for (i = 0; i < 3; i = i + 1)
                {
                    for (j = 0; j < 3; j = j + 1)
                    {
                        if (matrix[i,j] == 0)
                        {
                            matrix[i,j] = joueur; /* coup "virtuel" */
                            resultat_coup = minimax(-joueur); /* appel récursif */
                            matrix[i,j] = 0; /* retour arrière */
                            coups_possibles = 1;
                            if (resultat_coup * joueur > resultat * joueur)
                            {
                                resultat = resultat_coup;
                            }
                        }
                    }
                }
                if (coups_possibles == 0) resultat = 0; /* jeu bloqué = match nul */
            }
            return resultat;
        }

        public void computeRecursiveChoice()
        {
            int joueur = -1;
            int resultat, i, j, resultat_coup, i_mieux = 0, j_mieux = 0;
            resultat = -2 * joueur; /* pour être sur de mémoriser au moins un coup */
            for (i = 0; i < 3; i = i + 1)
            {
                for (j = 0; j < 3; j = j + 1)
                {
                    if (matrix[i,j] == 0)
                    {
                        matrix[i,j] = joueur; /* coup "virtuel" */
                        resultat_coup = minimax(-joueur); /* calcul score */
                        matrix[i,j] = 0; /* retour arrière */
                        if (resultat_coup * joueur > resultat * joueur)
                        {
                            resultat = resultat_coup;
                            i_mieux = i;
                            j_mieux = j;
                        }
                    }
                }
            }
            matrix[i_mieux,j_mieux] = joueur;
        }

    }
}
