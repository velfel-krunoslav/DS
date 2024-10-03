namespace Slagalica
{
    partial class HighscoresView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.ScoreView = new System.Windows.Forms.DataGridView();
            this.CloseHSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreView
            // 
            this.ScoreView.AllowUserToAddRows = false;
            this.ScoreView.AllowUserToDeleteRows = false;
            this.ScoreView.AllowUserToResizeColumns = false;
            this.ScoreView.AllowUserToResizeRows = false;
            this.ScoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rank,
            this.Username,
            this.Score});
            this.ScoreView.Location = new System.Drawing.Point(12, 49);
            this.ScoreView.Name = "ScoreView";
            this.ScoreView.RowHeadersVisible = false;
            this.ScoreView.Size = new System.Drawing.Size(268, 145);
            this.ScoreView.TabIndex = 0;
            // 
            // CloseHSV
            // 
            this.CloseHSV.Location = new System.Drawing.Point(205, 210);
            this.CloseHSV.Name = "CloseHSV";
            this.CloseHSV.Size = new System.Drawing.Size(75, 23);
            this.CloseHSV.TabIndex = 1;
            this.CloseHSV.Text = "Close";
            this.CloseHSV.UseVisualStyleBackColor = true;
            this.CloseHSV.Click += new System.EventHandler(this.CloseHSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lower score means higher ranking.";
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.MinimumWidth = 40;
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.Width = 40;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 100;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 100;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // HighscoresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseHSV);
            this.Controls.Add(this.ScoreView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HighscoresView";
            this.Text = "HighscoresView";
            this.Load += new System.EventHandler(this.HighscoresView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ScoreView;
        private System.Windows.Forms.Button CloseHSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}