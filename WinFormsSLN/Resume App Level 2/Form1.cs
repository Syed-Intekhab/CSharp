using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume_App_Level_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            string skill = txtSkill.Text.Trim();

            if(!string.IsNullOrEmpty(skill))
            {
                lstSkills.Items.Add(skill);
                txtSkill.Clear();
            }
            else
            {
                MessageBox.Show("Please enter skill into skill field first.");
            }
        }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if(lstSkills.SelectedIndex !=  -1)
            {
                lstSkills.Items.RemoveAt(lstSkills.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please selecte a skill to remove from skills list.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFile.Title = "Save your file";

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                // Save text from textbox into that file.
                string name = txtName.Text;
                string age = txtAge.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;

                // Skills
                string skills = string.Join(", ", lstSkills.Items.Cast<string>());

                // Achievement Details
                string achievementHeading = txtAchievementHeading.Text;
                string achievementDesc = txtAchievementDesc.Text;

                // University Details
                string degree = txtDegree.Text;
                string year = txtYear.Text;
                string university = txtUniversity.Text;

                // Experience Details
                string company = txtCompany.Text;
                string role = txtRole.Text;
                string expYears = txtExpYears.Text;

                string data =
                    $"Name: {name}\n" +
                    $"Age: {age}\n" +
                    $"Email: {email}\n" +
                    $"Phone: {phone}\n\n" +
                    $"Skills: {skills}\n\n" +
                    $"Achievement Heading:\n{achievementHeading}\n" +
                    $"Achievement Description:\n{achievementDesc}\n\n" +
                    $"Degree: {degree}\n" +
                    $"Passing Year: {year}\n" +
                    $"University: {university}\n\n" +
                    $"Company: {company}\n" +
                    $"Role: {role}\n" +
                    $"Years Of Experience: {expYears}";

                File.WriteAllText(saveFile.FileName, data);

                MessageBox.Show("Information Saved SuccessfullyS!");
            }
        }

        private void txtLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string[] data = File.ReadAllLines(openFile.FileName);
                char[] delimiters = { ',', ' ' };
                bool achievementHeading = false;
                bool achievementDesc = false;

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
                    else if (s.StartsWith("Skills:"))
                    {
                        string skillString = s.Replace("Skills:", "");
                        string[] words = skillString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in words)
                        {
                            lstSkills.Items.Add(word);
                        }
                    }
                    else if (s.StartsWith("Achievement Heading:"))
                        achievementHeading = true;
                    else if (!string.IsNullOrWhiteSpace(s) && achievementHeading)
                    {
                        txtAchievementHeading.Text = s.Trim();
                        achievementHeading = false;
                    }
                    else if (s.StartsWith("Degree:"))
                        txtDegree.Text = s.Replace("Degree:", "").Trim();
                    else if (s.StartsWith("Passing Year:"))
                        txtYear.Text = s.Replace("Passing Year:", "").Trim();
                    else if (s.StartsWith("University:"))
                        txtUniversity.Text = s.Replace("University:", "").Trim();
                    else if (s.StartsWith("Company:"))
                        txtCompany.Text = s.Replace("Company:", "").Trim();
                    else if (s.StartsWith("Role:"))
                        txtRole.Text = s.Replace("Role:", "").Trim();
                    else if (s.StartsWith("Years Of Experience:"))
                        txtExpYears.Text = s.Replace("Years Of Experience:", "").Trim();
                    else if (s.StartsWith("Achievement Description:"))
                        achievementDesc = true;
                    else if (!string.IsNullOrWhiteSpace(s) && achievementDesc)
                        txtAchievementDesc.Text = s.Trim();
                }
            }
        }
    }
}