using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;


namespace App
{
    public partial class FAccueil : Form
    {
        private int method;
        private int[,] matrice;
        private TicTacToe ticTacToe;
        private int free;

        public FAccueil()
        {
            method = 2;
            matrice = new int[3, 3];
            free = 9;
            InitializeComponent();
        }

        private void FAccueil_Load(object sender, EventArgs e)
        {
            // ajuste la taille des cases
            // Hauteur
            dgv.Rows[0].Height = 150;
            // Largeur
            for (int i = 0; i <= 2; i++)
            {
                dgv.Columns[i].Width = 150;
            }

            // Remplit la matrice de 0
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    matrice[i, j] = 0;
                }
            }

            // Initialise l'affichage du TicTacToe
            DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
            dgv.Rows.Add(row);
            row = (DataGridViewRow)dgv.Rows[1].Clone();
            dgv.Rows.Add(row);
            row = (DataGridViewRow)dgv.Rows[2].Clone();
            dgv.Rows.Add(row);

            ticTacToe = new TicTacToe(matrice);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int j = e.ColumnIndex;
            int i = e.RowIndex;
            
            dgv.ClearSelection();

            if (matrice[i, j] == 0)
            {
                matrice[i, j] = 1;
                free--;
                if (free > 0 && ticTacToe.computeWin() == 0)
                {
                    // Choix IA
                    if (method == 2) ticTacToe.computeRecursiveChoice();
                    //else if (method == 1) ticTacToe.computeIterativeChoice;
                    free--;
                }
                remplirTicTacToe();
                winnerIs();
                // if (ticTacToe.computeWin()) Console.
            }
        }

        private void winnerIs(){
            int winner = ticTacToe.computeWin();
            if (winner == 0 && free == 0) {
                lb_result.Text = "Egalité";
                resetJeu();
            } else if (winner == 1) {
                lb_result.Text = "Victoire";
                resetJeu();
            } else if (winner == -1) {
                lb_result.Text = "Perdu";
                resetJeu();
            } else
            {
                lb_result.Text = "";
            }

        }

        private void remplirTicTacToe()
        {
            // Remplit la matrice de 0
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {

                    if (matrice[i, j] == 1)
                    {
                        DataGridViewButtonColumn c = (DataGridViewButtonColumn)dgv.Columns[j];
                        c.FlatStyle = FlatStyle.Popup;
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                    }
                    else if (matrice[i, j] == -1)
                    {
                        DataGridViewButtonColumn c = (DataGridViewButtonColumn)dgv.Columns[j];
                        c.FlatStyle = FlatStyle.Popup;
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

        // Ajoute des bordures colorés rouge au dgv
        private void dgv_Paint(object sender, PaintEventArgs e)
        {
            Point currentPoint = new Point(0, 0);
            Size size = new Size(50 * 3, 50 * 3);
            Pen myPen = new Pen(Color.Red, 3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    currentPoint.X = i * 50 * 3;
                    currentPoint.Y = j * 50 * 3;
                    Rectangle rect = new Rectangle(currentPoint, size);
                    e.Graphics.DrawRectangle(myPen, rect);
                }
            }
        }

        private void recursifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            method = 2;
        }

        private void itératifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            method = 1;
        }

        private void resetJeu()
        {
            free = 9;
            // Remplit la matrice de 0
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    matrice[i, j] = 0;
                }
            }

            // Supprime les lignes
            // ajoute les lignes
            dgv.Rows.RemoveAt(0);
            dgv.Rows.Add();
            dgv.Rows.RemoveAt(0);
            dgv.Rows.Add();
            dgv.Rows.RemoveAt(0);
            dgv.Rows.Add();

            dgv.Rows[0].Height = 150;
            dgv.Rows[1].Height = 150;
            dgv.Rows[2].Height = 150;
            dgv.ClearSelection();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetJeu();
        }
    }
}
