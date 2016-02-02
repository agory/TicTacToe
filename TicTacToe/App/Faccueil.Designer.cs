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
            this.btnReset = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
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
            this.recursifToolStripMenuItem.Click += new System.EventHandler(this.recursifToolStripMenuItem_Click);
            // 
            // itératifToolStripMenuItem
            // 
            this.itératifToolStripMenuItem.Name = "itératifToolStripMenuItem";
            this.itératifToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.itératifToolStripMenuItem.Text = "Itératif";
            this.itératifToolStripMenuItem.Click += new System.EventHandler(this.itératifToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln1,
            this.cln2,
            this.cln3});
            this.dgv.Location = new System.Drawing.Point(31, 63);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.ShowEditingIcon = false;
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
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(31, 27);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(158, 36);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset le jeu (pleutre !)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(195, 39);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(35, 13);
            this.lb_result.TabIndex = 4;
            this.lb_result.Text = "label1";
            // 
            // FAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 560);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lb_result;
    }
}

