using Microsoft.Data.Sqlite;
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
    public partial class VictoryDialog : Form
    {
        private int score;
        public VictoryDialog(int score)
        {
            InitializeComponent();
            this.score = score;
        }

        private void VictoryDialog_Load(object sender, EventArgs e)
        {
            ScoreText.Text = score.ToString();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int UID;

            SqliteConnection conn = ConnectionDB.Instance;
            conn.Open();

            var command = conn.CreateCommand();
            command.CommandText = "INSERT INTO users(user_name) VALUES ('" + Username.Text + "');";
            command.ExecuteNonQuery();

            command.CommandText = "SELECT last_insert_rowid() FROM users;";
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                UID = reader.GetInt32(0);
            }

            command.CommandText = "INSERT INTO scores(user_id, score) VALUES (" + UID + ", " + score + ")";
            command.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }
    }
}
