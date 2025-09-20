using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLite_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Create or open if exists the database file.
            string cs = "Data Source=mydatabase.db;Version=3;";
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();

                // Create table if not exists
                string createTAbleQuery = "CREATE TABLE IF NOT EXISTS users (Id INTEGER PRIMARY KEY AUTOINCREAMENT, Name TEXT, Age TEXT)";
                using (SQLiteCommand cmd = new SQLiteCommand(createTAbleQuery, con))
                {
                    cmd.ExecuteNonQuery();
                }

                // Insert Data into Table
                string insertData = "INSERT INTO users (Name, Age) VALUES (@name, @age)";
                using (SQLiteCommand cmd = new SQLiteCommand(insertData, con))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("DataBase Created Successfully!");
            }
        }
    }
}
