using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Save To File
        private void Save_Click(object sender, EventArgs e)
        {
            string filePath = "resume.txt";
            string name = txtName.Text;
            string age = txtAge.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(age) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(email))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("Name: " + name);
                    sw.WriteLine("Age: " + age);
                    sw.WriteLine("Phone: " + phone);
                    sw.WriteLine("Email: " + email);

                    sw.WriteLine();
                    sw.WriteLine("Skills: ");
                    foreach (var item in lstSkills.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }

                    MessageBox.Show("Data Written Successfully!");
                }

                txtName.Clear();
                txtAge.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                lstSkills.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please fill out all details.");
            }
        }

        // Add Skill
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string skill = txtSkill.Text.Trim();

            if (!string.IsNullOrEmpty(skill))
            {
                lstSkills.Items.Add(skill);
                txtSkill.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter a Skill First...");
            }
        }

        // Remove Skill
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstSkills.SelectedIndex != -1)
            {
                lstSkills.Items.RemoveAt(lstSkills.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please Select A Skill To Remove...");
            }
        }
    }
}