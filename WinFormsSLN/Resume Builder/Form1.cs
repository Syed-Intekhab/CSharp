using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Resume_Builder
{
    public partial class Form1 : Form //Inherited
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Return Resume
        private Resume BuildResume()
        {
            Resume resume = new Resume()
            {
                Name = txtName.Text.Trim(),
                Age = txtAge.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Degree = txtDegree.Text.Trim(),
                Year = txtYear.Text.Trim(),
                University = txtUniversity.Text.Trim(),
                Company = txtCompany.Text.Trim(),
                Role = txtRole.Text.Trim(),
                Exp = txtExp.Text.Trim(),
                Summary = txtSummary.Text.Trim(),
                Gender = rdoMale.Checked ? "Male" : "Female"
            };

            if (lstSkills.Items.Count > 0)
            {
                foreach (string skill in lstSkills.Items)
                    resume.Skills.Add(skill);
            }

            return resume;
        }

        // Function To Clear All Filled Fields
        public void ClearFields()
        {
            txtName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtDegree.Clear();
            txtYear.Clear();
            txtUniversity.Clear();
            txtCompany.Clear();
            txtRole.Clear();
            txtExp.Clear();
            txtSummary.Clear();
            lstSkills.Items.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
        }

        // Add Skill Button
        private void kuchbhi_click(object sender, EventArgs e)
        {
            string skill = txtSkill.Text.Trim();

            if (!string.IsNullOrEmpty(skill))
            {
                lstSkills.Items.Add(skill);
                txtSkill.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a skill to add!");
            }
        }

        // Remove Skill Button
        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if(lstSkills.SelectedIndex != -1)
                lstSkills.Items.RemoveAt(lstSkills.SelectedIndex);
            else
                MessageBox.Show("Please select a skill to remove!");
        }

        // Clears filled data from fields.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Saving Text File Using Menu Bar
        private void saveAsTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utils.SaveToText(BuildResume()))
                ClearFields();
        }

        // Load Text File From Menu Bar
        private void loadFromTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string[] data = File.ReadAllLines(openFile.FileName);
                char[] delimeters = { ',', ' ' };

                if (data.Length > 0)
                {
                    foreach (string s in data)
                    {
                        if (s.StartsWith("Name:"))
                            txtName.Text = s.Replace("Name:", "").Trim();
                        else if (s.StartsWith("Age:"))
                            txtAge.Text = s.Replace("Age:", "").Trim();
                        else if (s.StartsWith("Email:"))
                            txtEmail.Text = s.Replace("Email:", "").Trim();
                        else if (s.StartsWith("Phone:"))
                            txtPhone.Text = s.Replace("Phone:", "").Trim();
                        else if (s.StartsWith("Address:"))
                            txtAddress.Text = s.Replace("Address:", "").Trim();
                        else if (s.StartsWith("Degree:"))
                            txtDegree.Text = s.Replace("Degree:", "").Trim();
                        else if (s.StartsWith("Year:"))
                            txtYear.Text = s.Replace("Year:", "").Trim();
                        else if (s.StartsWith("University:"))
                            txtUniversity.Text = s.Replace("University:", "").Trim();
                        else if (s.StartsWith("Company:"))
                            txtCompany.Text = s.Replace("Company:", "").Trim();
                        else if (s.StartsWith("Role:"))
                            txtRole.Text = s.Replace("Role:", "").Trim();
                        else if (s.StartsWith("Experience:"))
                            txtExp.Text = s.Replace("Experience:", "").Trim();
                        else if (s.StartsWith("Summary:"))
                            txtSummary.Text = s.Replace("Summary:", "").Trim();
                        else if (s.StartsWith("Gender:"))
                        {
                            string gender = s.Replace("Gender:", "").Trim();
                            if (gender.Equals("Male"))
                                rdoMale.Checked = true;
                            else
                                rdoFemale.Checked = true;
                        }
                        else if (s.StartsWith("Skills:"))
                        {
                            string[] skills = s.Replace("Skills:", "").Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

                            foreach (string skill in skills)
                                lstSkills.Items.Add(skill);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File was empty!");
                }
            }
        }

        // Save information in JSON format using menu bar.
        private void saveAsJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utils.SaveToJson(BuildResume()))
                ClearFields();
        }

        // Load JSON File From Menu Strip Bar
        private void loadFromJSONFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "JSON File (*.json)|*.json"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Resume resume = JsonConvert.DeserializeObject<Resume>(File.ReadAllText(openFile.FileName));
                char[] delimeters = { ',', ' ' };

                txtName.Text = resume.Name;
                txtAge.Text = resume.Age;
                txtEmail.Text = resume.Email;
                txtPhone.Text = resume.Phone;
                txtAddress.Text = resume.Address;
                txtDegree.Text = resume.Degree;
                txtYear.Text = resume.Year;
                txtUniversity.Text = resume.University;
                txtCompany.Text = resume.Company;
                txtRole.Text = resume.Role;
                txtExp.Text = resume.Exp;
                txtSummary.Text = resume.Summary;

                if (resume.Gender == "Male")
                    rdoMale.Checked = true;
                else
                    rdoFemale.Checked = true;

                string[] skills = resume.SkillsStr.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

                foreach (string skill in skills)
                    lstSkills.Items.Add(skill);
            }
        }

        // Error mark object
        ErrorProvider error = new ErrorProvider();

        // Name Input Validate
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Any(char.IsDigit))
                error.SetError(txtName, "Name cannot contain number.");
            else
                error.SetError(txtName, "");
        }

        // Age Input Validate
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (txtAge.Text.Any(char.IsLetter))
                error.SetError(txtAge, "Age cannot contain character.");
            else
                error.SetError(txtAge, "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resumesDBDataSet.resumes' table. You can move, or remove it, as needed.
            this.resumesTableAdapter.Fill(this.resumesDBDataSet.resumes);
        }

        // Save Data Into Database
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            Resume resume = BuildResume();

            if (Utils.AllFieldsFilled(resume.Name, resume.Age, resume.Email, resume.Phone, resume.Address, resume.Degree, resume.Year, resume.University, resume.Gender))
            {
                DBOperations.SaveData(resume);
                ClearFields();
                LoadResumes();
            }
            else
            {
                MessageBox.Show("Please fill out all the details or check if the details are valid!");
            }
        }

        // Load data when user clicked specific row
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Resume resume = null;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string resumeId = row.Cells[0].Value.ToString();
                resume = DBOperations.LoadData(resumeId);
            }

            txtName.Text = resume.Name;
            txtAge.Text = resume.Age;
            txtEmail.Text = resume.Email;
            txtPhone.Text = resume.Phone;
            txtAddress.Text = resume.Address;
            txtDegree.Text = resume.Degree;
            txtYear.Text = resume.Year;
            txtUniversity.Text = resume.University;
            txtCompany.Text = resume.Company;
            txtRole.Text = resume.Role;
            txtExp.Text = resume.Exp;
            txtSummary.Text = resume.Summary;

            if (resume.Gender == "Male")
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = true;

            foreach (string skill in resume.Skills)
                lstSkills.Items.Add(skill);
        }
        
        // Delete Selected Resume From Data Grid View.
        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                string resumeId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete this resume?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    DBOperations.DeleteResume(resumeId);
                    LoadResumes();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        // Load Grid View
        public void LoadResumes()
        {
            dataGridView1.DataSource = DBOperations.GetDataTable();
        }
    }
}

// TODO: (Discussed in Meeting)
// Use class model. - Done
// Use Newtons of JSON (serialize, deserialize). - Done
// Try with string builder. - Done
// Use SQL Server Management Studio - Done
// Store Data Inside SQL Server - Done
// Use Data Grid View - Done
// Move all the db related code into its own class (LoadResumes) - Done
// Use Stored Procedure - Done
// Start Doing MVC - Done

//My TODO:
// Add more styling in the app - Done
// Add more validation - Done
// Add a method to save data to db - Done
// Add a method to read data from db - Done
// Add a method to delete data from db - Done
// Add a method to update existing data to db
// Explore more methods of sqlconnect class - Done
// Explore more methods of sqlcommnad class - Done