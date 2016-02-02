﻿using System;
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
            row = (DataGridViewRow)dgv.Rows[2].Clone();
            dgv.Rows.Add(row);


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int j = e.ColumnIndex;
            int i = e.RowIndex;

            if (matrice[i, j] == 0)
            {
                matrice[i, j] = 1;
            }

            // Choix IA
            TicTacToe t = new TicTacToe(matrice);
            t.computeRecursiveChoice(matrice);

            remplirTicTacToe();
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
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetJeu();
        }
    }
}
