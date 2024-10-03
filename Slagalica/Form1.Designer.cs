using System.Windows.Forms;

namespace Slagalica
{
    partial class Slagalica_492018
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private const int WS_SYSMENU = 0x80000;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.countLabel = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.endGame = new System.Windows.Forms.Button();
            this.Highscores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // imageGrid
            // 
            this.imageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imageGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.imageGrid.Location = new System.Drawing.Point(15, 51);
            this.imageGrid.Name = "imageGrid";
            this.imageGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.imageGrid.RowHeadersVisible = false;
            this.imageGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.imageGrid.Size = new System.Drawing.Size(160, 162);
            this.imageGrid.TabIndex = 0;
            this.imageGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.imageGrid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 40;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 40;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 40;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 40;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 40;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 40;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(12, 23);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(38, 13);
            this.countLabel.TabIndex = 1;
            this.countLabel.Text = "Score:";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(61, 23);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(13, 13);
            this.count.TabIndex = 2;
            this.count.Text = "0";
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(372, 51);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(60, 60);
            this.newGame.TabIndex = 3;
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // endGame
            // 
            this.endGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.endGame.Location = new System.Drawing.Point(346, 117);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(86, 58);
            this.endGame.TabIndex = 4;
            this.endGame.UseVisualStyleBackColor = true;
            this.endGame.Click += new System.EventHandler(this.endGame_Click);
            // 
            // Highscores
            // 
            this.Highscores.Location = new System.Drawing.Point(357, 190);
            this.Highscores.Name = "Highscores";
            this.Highscores.Size = new System.Drawing.Size(75, 23);
            this.Highscores.TabIndex = 5;
            this.Highscores.Text = "Highscores";
            this.Highscores.UseVisualStyleBackColor = true;
            this.Highscores.Click += new System.EventHandler(this.Highscores_Click);
            // 
            // Slagalica_492018
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 228);
            this.Controls.Add(this.Highscores);
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.count);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.imageGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Slagalica_492018";
            this.Text = "Slagalica_492018";
            this.Load += new System.EventHandler(this.Slagalica_492018_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView imageGrid;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button endGame;
        private Button Highscores;
    }
}

