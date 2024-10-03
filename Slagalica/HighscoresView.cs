using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slagalica
{
    public partial class HighscoresView : Form
    {
        private List<(string, int)> vals;
        public HighscoresView(List<(string, int)> vals)
        {
            InitializeComponent();
            this.vals = vals;
        }

        private void CloseHSV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HighscoresView_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach(var v in vals)
            {
                ScoreView.Rows.Add();

                ScoreView.Rows[i].Cells[0].Value = i + 1;
                ScoreView.Rows[i].Cells[1].Value = v.Item1;
                ScoreView.Rows[i].Cells[2].Value = v.Item2;

                i++;
            }
        }
    }
}
