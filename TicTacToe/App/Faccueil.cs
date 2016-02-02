using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FAccueil : Form
    {
        private int method;
        private int[,] matrice;

        public FAccueil()
        {
            method = 0;
            matrice = new int[3, 3];
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


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void remplirTicTacToe(int[,] matrice)
        {
            // Remplit la matrice de 0
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (matrice[i, j] == 1)
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    else if (matrice[i, j] == 2)
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Blue;
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
    }
}
