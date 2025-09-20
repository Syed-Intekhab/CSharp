using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataGridViewPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'practiceDataSet.UserDetails' table. You can move, or remove it, as needed.
            this.userDetailsTableAdapter.Fill(this.practiceDataSet.UserDetails);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=localhost;Initial Catalog=Practice;Integrated Security=true;";
            SqlConnection conn = null;

            string name = TxtName.Text;
            string age = TxtAge.Text;
            string phone = TxtPhone.Text;
            string email = TxtEmail.Text;

            try
            {
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string query = "INSERT INTO UserDetails (Name, Age, Email, Phone) VALUES (@Name, @Age, @Email, @Phone);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Information saved successfully!");

                    TxtAge.Clear();
                    TxtName.Clear();
                    TxtPhone.Clear();
                    TxtEmail.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string Id = row.Cells[0].Value.ToString();

            string cs = "Data Source=localhost;Initial Catalog=Practice;Integrated Security=true;";
            SqlConnection conn = null;

            try
            {
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string query = "SELECT * FROM UserDetails WHERE ID = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);
                        
                        SqlDataReader data = cmd.ExecuteReader();

                        while (data.Read())
                        {
                            TxtName.Text = data["Name"].ToString();
                            TxtAge.Text = data["Age"].ToString();
                            TxtPhone.Text = data["Phone"].ToString();
                            TxtEmail.Text = data["Email"].ToString();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}