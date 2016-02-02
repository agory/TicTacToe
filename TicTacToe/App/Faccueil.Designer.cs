namespace App
{
    partial class FAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itératifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cln1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cln2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cln3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recursifToolStripMenuItem,
            this.itératifToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // recursifToolStripMenuItem
            // 
            this.recursifToolStripMenuItem.Name = "recursifToolStripMenuItem";
            this.recursifToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.recursifToolStripMenuItem.Text = "Recursif";
            // 
            // itératifToolStripMenuItem
            // 
            this.itératifToolStripMenuItem.Name = "itératifToolStripMenuItem";
            this.itératifToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.itératifToolStripMenuItem.Text = "Itératif";
            // 
            // dgv
            // 
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln1,
            this.cln2,
            this.cln3});
            this.dgv.Location = new System.Drawing.Point(92, 70);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(451, 451);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dgv.Paint += new System.Windows.Forms.PaintEventHandler(this.dgv_Paint);
            // 
            // cln1
            // 
            this.cln1.HeaderText = "Column1";
            this.cln1.Name = "cln1";
            // 
            // cln2
            // 
            this.cln2.HeaderText = "Column2";
            this.cln2.Name = "cln2";
            // 
            // cln3
            // 
            this.cln3.HeaderText = "Column3";
            this.cln3.Name = "cln3";
            // 
            // FAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 560);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FAccueil";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FAccueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itératifToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewButtonColumn cln1;
        private System.Windows.Forms.DataGridViewButtonColumn cln2;
        private System.Windows.Forms.DataGridViewButtonColumn cln3;
    }
}

