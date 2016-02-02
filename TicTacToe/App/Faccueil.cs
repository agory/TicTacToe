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

        }

        private void recursif() {

        }
        private void iteratif()
        {

        }
    }
}
