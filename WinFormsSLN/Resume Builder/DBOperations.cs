using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Resume_Builder
{
    internal class DBOperations
    {
        static string cs = "Data Source=localhost;Initial Catalog=ResumesDB;Integrated Security=true;";
        static SqlConnection conn = null;

        // Save data into database.
        public static void SaveData(Resume resume)
        {
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string query = "INSERT INTO resumes (Name, Age, Email, Phone, Gender, Address, Summary, Skills, Degree, Year, University, Company, Role, Years)" +
                        "VALUES (@Name, @Age, @Email, @Phone, @Gender, @Address, @Summary, @Skills, @Degree, @Year, @University, @Company, @Role, @Years);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", resume.Name);
                        cmd.Parameters.AddWithValue("@Age", resume.Age);
                        cmd.Parameters.AddWithValue("@Email", resume.Email);
                        cmd.Parameters.AddWithValue("@Phone", resume.Phone);
                        cmd.Parameters.AddWithValue("@Gender", resume.Gender);
                        cmd.Parameters.AddWithValue("@Address", resume.Address);
                        cmd.Parameters.AddWithValue("@Summary", resume.Summary);
                        cmd.Parameters.AddWithValue("@Skills", resume.SkillsStr);
                        cmd.Parameters.AddWithValue("@Degree", resume.Degree);
                        cmd.Parameters.AddWithValue("@Year", resume.Year);
                        cmd.Parameters.AddWithValue("@University", resume.University);
                        cmd.Parameters.AddWithValue("@Company", resume.Company);
                        cmd.Parameters.AddWithValue("@Role", resume.Role);
                        cmd.Parameters.AddWithValue("@Years", resume.Exp);

                        cmd.ExecuteNonQuery();
                    }
                }
                // Try with Stored Procedure
                MessageBox.Show("Data Saved Successfully!");
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

        // Function To Retrieve All The Details From DB of specific resume by its id.
        public static Resume LoadData(string id)
        {
            Resume resume = new Resume();
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("GetResumeID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ResumeID", id);
                        SqlDataReader data = cmd.ExecuteReader();

                        char[] delimeters = { ',', ' ' };

                        while (data.Read())
                        {
                            resume.Name = data["Name"].ToString();
                            resume.Age = data["Age"].ToString();
                            resume.Email = data["Email"].ToString();
                            resume.Phone = data["Phone"].ToString();
                            resume.Address = data["Address"].ToString();
                            resume.Degree = data["Degree"].ToString();
                            resume.Year = data["Year"].ToString();
                            resume.University = data["University"].ToString();
                            resume.Company = data["Company"].ToString();
                            resume.Role = data["Role"].ToString();
                            resume.Exp = data["Years"].ToString();
                            resume.Summary = data["Summary"].ToString();

                            if (data["Gender"].ToString() == "Male")
                                resume.Gender = "Male";
                            else
                                resume.Gender = "Female";

                            string[] skills = data["Skills"].ToString().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

                            foreach (string s in skills)
                                resume.Skills.Add(s);
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


            return resume;
        }

        // Function To Delete Resume
        public static void DeleteResume(string resumeId)
        {
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string query = "DELETE FROM resumes WHERE ResumeID = @ResumeID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ResumeID", resumeId);
                        int row = cmd.ExecuteNonQuery();

                        if (row > 0)
                            MessageBox.Show("Resume deleted successfully!");
                        else
                            MessageBox.Show("No resume found with that ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Function to return Data Table
        public static DataTable GetDataTable()
        {
            using (conn = new SqlConnection(cs))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetAllResumes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }
    }
}