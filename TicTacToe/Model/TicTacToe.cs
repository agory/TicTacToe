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

        /// <summary>
        /// Compute the next play of computer with algo iterative 
        /// </summary>
        public void computeIterativeChoice()
        {
            int computer = -1;
            int better_i = 0, better_j = 0;
            bool trouve = false;

            // test if a row can win or loose
            int score;
            for (int i = 0; i < 3; i++)
            {
                score = 0;
                for (int j = 0; j < 3; j++)
                {
                    score += matrix[i, j];
                }

                if (score == -2 || score == 2)
                {
                    trouve = true;
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix[i, j] == 0)
                        {
                            better_i = i;
                            better_j = j;
                        }
                    }
                }
            }

            // test if a column can win or loose
            for (int j = 0; j < 3; j++)
            {
                score = 0;
                for (int i = 0; i < 3; i++)
                {
                    score += matrix[i, j];
                }

                if (score == -2 || score == 2)
                {
                    trouve = true;
                    for (int i = 0; i < 3; i++)
                    {
                        if (matrix[i, j] == 0)
                        {
                            better_i = i;
                            better_j = j;
                        }
                    }
                }
            }

            // test if diagonal 1 can win or loose
            score = 0;
            for (int i = 0; i < 3; i++)
            {
                int j = i;
                score += matrix[i, j];
            }
            if (score == -2 || score == 2)
            {
                trouve = true;
                for (int i = 0; i < 3; i++)
                {
                    int j = i;
                    if (matrix[i, j] == 0)
                    {
                        better_i = i;
                        better_j = j;
                    }
                }
            }

            // test if diagonal 2 can win or loose
            score = 0;
            int k = 2; // k is j
            for (int i = 0; i < 3; i++)
            {
                score += matrix[i, k];
                k--;
            }
            if (score == -2 || score == 2)
            {
                trouve = true;
                k = 2;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[i, k] == 0)
                    {
                        better_i = i;
                        better_j = k;
                    }
                    k--;
                }
            }

            // center case
            if (!trouve && matrix[1, 1] == 0)
            {
                better_i = 1;
                better_j = 1;
            }
            else if (!trouve) {
                // test specific scenarios
                int nbOccupied = nbCaseOccupied();
                if (nbOccupied == 3) // 2nd movement for the computer
                {
                    // scenario 1 and 2 correspond to the case
                    // where the center is surrendered in the corners
                    // scenario 1
                    if (matrix[0, 0] == 1 && matrix[2, 2] == 1)
                    {
                        better_i = 0;
                        better_j = 1;
                    } // scenario 2
                    else if (matrix[0, 2] == 1 && matrix[2, 0] == 1)
                    {
                        better_i = 0;
                        better_j = 1;
                    }
                    // scenarios 3 4 5 and 6 correspond to the case where
                    // the players plays in a corner and then in the middle
                    // scenario 3
                    else if (matrix[1, 2] == 1 && matrix[2, 0] == 1)
                    {
                        better_i = 2;
                        better_j = 1;
                    } // scenario 4
                    else if (matrix[0, 0] == 1 && matrix[1, 2] == 1)
                    {
                        better_i = 0;
                        better_j = 1;
                    } // scenario 5
                    else if (matrix[1, 0] == 1 && matrix[2, 2] == 1)
                    {
                        better_i = 2;
                        better_j = 1;
                    } // scenario 6
                    else if (matrix[0, 2] == 1 && matrix[1, 0] == 1)
                    {
                        better_i = 0;
                        better_j = 1;
                    }
                    // scenarios 7 8 9 and 10 correspond to the case where
                    // the players plays twice in the middle
                    // scenario 7
                    else if (matrix[1, 0] == 1 && matrix[2, 1] == 1)
                    {
                        better_i = 2;
                        better_j = 0;
                    } // scenario 8
                    else if (matrix[1, 2] == 1 && matrix[2, 1] == 1)
                    {
                        better_i = 2;
                        better_j = 2;
                    } // scenario 9
                    else if (matrix[1, 0] == 1 && matrix[0, 1] == 1)
                    {
                        better_i = 0;
                        better_j = 0;
                    } // scenario 10
                    else if (matrix[0, 1] == 1 && matrix[1, 2] == 1)
                    {
                        better_i = 0;
                        better_j = 2;
                    }
                } // Default moves
                else
                {
                    // try corners
                    if (matrix[0, 2] == 0)
                    {
                        better_i = 0;
                        better_j = 2;
                    }
                    else if (matrix[2, 0] == 0)
                    {
                        better_i = 2;
                        better_j = 0;
                    }
                    else if (matrix[2, 2] == 0)
                    {
                        better_i = 2;
                        better_j = 2;
                    } // try middle cases
                    else if (matrix[0, 1] == 0)
                    {
                        better_i = 0;
                        better_j = 1;
                    }
                    else if (matrix[1, 0] == 0)
                    {
                        better_i = 1;
                        better_j = 0;
                    }
                    else if (matrix[1, 2] == 0)
                    {
                        better_i = 1;
                        better_j = 2;
                    }
                    else if (matrix[2, 1] == 0)
                    {
                        better_i = 1;
                        better_j = 1;
                    }
                }
            }
            
            matrix[better_i, better_j] = computer;
        }

        private int nbCaseOccupied()
        {
            int res = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] == 1 || matrix[i, j] == -1)
                    {
                        res += 1;
                    }
                }
            }

            return res;
        }

    }
}
