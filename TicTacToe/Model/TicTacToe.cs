using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class TicTacToe
    {
        private int[,] matrix;

        public TicTacToe(int[,] matrix) {
            this.matrix = matrix;
        }

        public void computeRecursiveChoice() {
            if (matrix[1, 1] == 0)
            {
                matrix[1, 1] = 2;
            }
            else {
                
            }
        }

        private int computeWin(int[,] matrix) {
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
                   (matrix[3, 0] == matrix[1, 1] && matrix[1, 1] == matrix[0, 2]))
                {
                    winner = matrix[1, 1];
                }
            }
            return winner;
        }
        
    }
}
