using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sfd_opd_practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save your file";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            List<string> hobbiesList = new List<string>();

            string name = (txtName.Text).Trim();
            if (chCoding.Checked)
                hobbiesList.Add("Coding");

            if (chMusic.Checked)
                hobbiesList.Add("Music");

            if (chReading.Checked)
                hobbiesList.Add("Reading");

            if (chSports.Checked)
                hobbiesList.Add("Sports");

            string hobbies = string.Join(", ", hobbiesList);
            string data = $"Name: {name}\nHobbies: {hobbies}";

            if (!string.IsNullOrEmpty(name))
            {
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFile.FileName, data);
                    MessageBox.Show("Data saved successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please enter your details.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            char[] delimeters = { ',', ' ' };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string[] data = File.ReadAllLines(openFile.FileName);

                foreach (string s in data)
                {
                    if (s.StartsWith("Name:"))
                        txtName.Text = s.Replace("Name:", "").Trim();
                    else if (s.StartsWith("Hobbies:"))
                    {
                        string hobbiesString = s.Replace("Hobbies:", "").Trim();
                        string[] hobbies = hobbiesString.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

                        foreach(string hobbie in hobbies)
                        {
                            if (hobbie.Equals("Coding"))
                            {
                                chCoding.Checked = true;
                            } else if (hobbie.Equals("Music"))
                            {
                                chMusic.Checked = true;
                            }else if (hobbie.Equals("Sports"))
                            {
                                chSports.Checked = true;
                            }else if (hobbie.Equals("Reading"))
                            {
                                chReading.Checked = true;
                            }
                        }
                    }

                }
            }
        }
    }
}