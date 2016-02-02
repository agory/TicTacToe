﻿using System;
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

        /// <summary>
        /// Return the int of Winner
        /// -1 : Computer Win
        /// 0  : Egality
        /// 1  : Player Win
        /// </summary>
        /// <returns>int</returns>
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
       

        private int minimax(int player)
        {
            int resultat, i, j, result_move, possible_move = 0;
            resultat = computeWin();
            if (resultat == 0)
            {
                resultat = -player;
                for (i = 0; i < 3; i = i + 1)
                {
                    for (j = 0; j < 3; j = j + 1)
                    {
                        if (matrix[i,j] == 0)
                        {
                            matrix[i,j] = player; // coup d'avance 
                            result_move = minimax(-player); 
                            matrix[i,j] = 0; // annulation coup d'avance 
                            possible_move = 1;
                            if (result_move * player > resultat * player)
                            {
                                resultat = result_move;
                            }
                        }
                    }
                }
                if (possible_move == 0) resultat = 0; // jeu bloqué = match nul 
            }
            return resultat;
        }

        /// <summary>
        /// Compute the next play of computer with algo recursive minimax 
        /// </summary>
        public void computeRecursiveChoice()
        {
            int player = -1;
            int resultat, i, j, result_move, better_i = 0, better_j = 0;
            resultat = -2 * player;
            for (i = 0; i < 3; i = i + 1)
            {
                for (j = 0; j < 3; j = j + 1)
                {
                    if (matrix[i,j] == 0)
                    {
                        matrix[i,j] = player; // coup d'avance 
                        result_move = minimax(-player); // calcul score 
                        matrix[i,j] = 0; // annulation coup d'avance 
                        if (result_move * player > resultat * player)
                        {
                            resultat = result_move;
                            better_i = i;
                            better_j = j;
                        }
                    }
                }
            }
            matrix[better_i,better_j] = player;
        }

    }
}
