using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume_App_Level_1
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

            if (!string.IsNullOrEmpty(skill))
            {
                lstSkill.Items.Add(skill);
                txtSkill.Clear();
            }
            else
            {
                MessageBox.Show("Please enter skill first.");
            }
        }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if(lstSkill.SelectedIndex != -1)
            {
                lstSkill.Items.RemoveAt(lstSkill.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a skill first.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = "resume.txt";
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if(!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(phone))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine($"Name: {name}");
                    sw.WriteLine($"Email: {email}");
                    sw.WriteLine($"Phone: {phone}");
                    sw.WriteLine();
                    sw.WriteLine("Skills:");

                    foreach(string item in lstSkill.Items)
                    {
                        sw.WriteLine(item);
                    }
                }

                MessageBox.Show("File saved successfully!");

                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                lstSkill.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please fill out form.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filePath = "resume.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                // Clear Old Data
                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                lstSkill.Items.Clear();

                bool skillsSection = false;

                foreach(string line in lines)
                {
                    if (line.StartsWith("Name:"))
                        txtName.Text = line.Replace("Name:", "").Trim();
                    else if (line.StartsWith("Email:"))
                        txtEmail.Text = line.Replace("Email:", "").Trim();
                    else if (line.StartsWith("Phone:"))
                        txtPhone.Text = line.Replace("Phone:", "").Trim();
                    else if (line.StartsWith("Skills:"))
                        skillsSection = true;
                    else if (skillsSection && !string.IsNullOrWhiteSpace(line))
                        lstSkill.Items.Add(line.Trim());
                }
            }
            else
            {
                MessageBox.Show("No resume file found! Please save first.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            lstSkill.Items.Clear();
        }
    }
}
