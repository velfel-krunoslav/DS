using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Slagalica
{
    public partial class Slagalica_492018 : Form
    {
        private LoadInfo l;
        public Slagalica_492018()
        {
            InitializeComponent();
        }

        private void Check()
        {
            int i, j, q = 0;
            bool wonH = true, wonV = true;

            for (; q < 16; q++)
            {
                if (l.m[q / 4, q % 4] == Field.EMPTY) break;
            }
            i = q / 4;
            j = q % 4;

            for(int v = 0; wonH && v < 4; v++)
            {
                if (v == i) ;
                else
                {
                    for(int w = 1; wonH && w < 4; w++)
                    {
                        if (l.m[v, w] != l.m[v, 0]) wonH = false;
                    }
                }
            }

            for (int v = 0; !wonH && wonV && v < 4; v++)
            {
                if (v == j) ;
                else
                {
                    for (int w = 1; wonV && w < 4; w++)
                    {
                        if (l.m[w, v] != l.m[0, v]) wonV = false;
                    }
                }
            }

            if(wonH || wonV)
            {
                Form dialog = new VictoryDialog(l.score);
                dialog.ShowDialog(this);
                newGame_Click(null, null);
            }
        }
        private void RefreshGrid()
        {
            Bitmap pik, karo, tref, herc, empty, newGameImg, endGameImg;

            pik = new Bitmap(@"..\..\dat\rsrc\pik.bmp");
            karo = new Bitmap(@"..\..\dat\rsrc\karo.bmp");
            tref = new Bitmap(@"..\..\dat\rsrc\tref.bmp");
            herc = new Bitmap(@"..\..\dat\rsrc\herc.bmp");
            empty = new Bitmap(@"..\..\dat\rsrc\prazno.bmp");
            newGameImg = new Bitmap(@"..\..\dat\rsrc\newgame.bmp");
            endGameImg = new Bitmap(@"..\..\dat\rsrc\theend.bmp");

            newGame.Image = newGameImg;
            endGame.Image = endGameImg;

            count.Text = l.score.ToString();

            for (int i = 0; i < 4; i++)
            {
                DataGridViewImageColumn tmpCol = new DataGridViewImageColumn();
                imageGrid.Columns.Add(tmpCol);
                imageGrid.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    switch (l.m[i, j])
                    {
                        case Field.PIK:
                            imageGrid.Rows[i].Cells[j].Value = pik;
                            break;
                        case Field.KARO:
                            imageGrid.Rows[i].Cells[j].Value = karo;
                            break;
                        case Field.TREF:
                            imageGrid.Rows[i].Cells[j].Value = tref;
                            break;
                        case Field.HERC:
                            imageGrid.Rows[i].Cells[j].Value = herc;
                            break;
                        default:
                            imageGrid.Rows[i].Cells[j].Value = empty;
                            break;
                    }
                }
            }
        }

        private void imageGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fi = e.RowIndex;
            int fj = e.ColumnIndex;
            int si = fi, sj = fj;

            bool hasSwappable = false;

            List<(int, int)> indices = new List<(int, int)> {(0,-1),(-1,0),(0,1),(1,0)};

            foreach(var t in indices)
            {
                int i = fi + t.Item1;
                int j = fj + t.Item2;

                if (i < 0 || j < 0 || (i / 4 > 0) || (j / 4 > 0)) ;
                else if (l.m[i, j] == Field.EMPTY)
                {
                    hasSwappable = true;
                    si = i;
                    sj = j;
                    break;
                }
            }

            if (l.m[fi, fj] == Field.EMPTY || !hasSwappable) return;

            l.score++;

            Field tmpField = l.m[fi, fj];
            l.m[fi, fj] = l.m[si, sj];
            l.m[si, sj] = tmpField;

            Bitmap tmpBitmap = (Bitmap)imageGrid.Rows[fi].Cells[fj].Value;
            imageGrid.Rows[fi].Cells[fj].Value = imageGrid.Rows[si].Cells[sj].Value;
            imageGrid.Rows[si].Cells[sj].Value = tmpBitmap;

            count.Text = l.score.ToString();
            Check();
        }

        private void Slagalica_492018_Load(object sender, EventArgs e)
        {
            l = new LoadInfo();

            imageGrid.RowTemplate.Height = 40;
            imageGrid.ColumnHeadersVisible = false;
            imageGrid.AllowUserToAddRows = false;
            imageGrid.AllowUserToResizeRows = false;
            imageGrid.AllowUserToResizeColumns = false;

            RefreshGrid();
            Check();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            l.ResetState();
            RefreshGrid();
            Check();
        }

        private void endGame_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Save progress before quitting?", "Message", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                l.Flush();
            }
            else
            {
                File.Delete(Properties.Resources.PreviousStateFileName);
            }
            
            Application.Exit();
        }

        private void Highscores_Click(object sender, EventArgs e)
        {
            SqliteConnection conn = ConnectionDB.Instance;
            conn.Open();

            List<(string, int)> res = new List<(string, int)>();

            var command = conn.CreateCommand();
            command.CommandText = "SELECT U.user_name, S.score FROM users U JOIN scores S ON U.user_id = S.user_id ORDER BY S.score ASC;";

            using (var reader = command.ExecuteReader())
            {
                for(int i = 0; i < 10 && reader.Read(); i++)
                {
                    res.Add((reader.GetString(0), reader.GetInt32(1)));
                }
            }
            conn.Close();
            Form dialog = new HighscoresView(res);
            dialog.ShowDialog(this);
        }
    }
}