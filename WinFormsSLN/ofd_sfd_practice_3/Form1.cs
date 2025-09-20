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

namespace ofd_sfd_practice_3
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
            List<string> extras = new List<string>();

            // Saving Properties
            saveFile.Title = "Save your file";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // Extract Which Course Selected And Other Details
            string name = txtName.Text.Trim();
            bool radioCSharp = rdoCSharp.Checked;
            bool radioJava = rdoJava.Checked;
            bool radioPython = rdoPython.Checked;

            // Add Checked Extras Into List
            if (chCertification.Checked) extras.Add("Certification");
            if (chInternship.Checked) extras.Add("Internship");
            if (chNotes.Checked) extras.Add("Notes");

            // Join the extras into one string
            string extrasString = "";
            if (extras.Count > 0)
            {
                extrasString = string.Join(", ", extras);
            }
            string course = "";

            // Check which course selected
            if (radioCSharp) course = "C#";
            else if (radioJava) course = "Java";
            else if (radioPython) course = "Python";

            // Formatted data to add into the file
            string data = $"Name: {name}\nCourse: {course}\nExtras: {extrasString}";

            if (!string.IsNullOrEmpty(name) && (radioCSharp || radioJava || radioPython))
            {
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFile.FileName, data);
                    MessageBox.Show("Data Saved Successfully!");
                }

                txtName.Text = "";
                rdoCSharp.Checked = false;
                rdoJava.Checked = false;
                rdoPython.Checked = false;
                chCertification.Checked = false;
                chInternship.Checked = false;
                chNotes.Checked = false;
            }
            else
            {
                MessageBox.Show("Please enter your details!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string[] data = File.ReadAllLines(openFile.FileName);
                char[] delimeters = { ',', ' '};

                foreach(string s in data)
                {
                    if (s.StartsWith("Name:"))
                    {
                        txtName.Text = s.Replace("Name:", "").Trim();
                    }
                    else if (s.StartsWith("Course:"))
                    {
                        string course = s.Replace("Course:", "").Trim();

                        if (course.Equals("C#")) rdoCSharp.Checked = true;
                        else if (course.Equals("Python")) rdoPython.Checked = true;
                        else if (course.Equals("Java")) rdoJava.Checked = true;
                    }
                    else if (s.StartsWith("Extras:"))
                    {
                        string[] extras = s.Replace("Extras:", "").Trim().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

                        foreach(string extra in extras)
                        {
                            if (extra.Equals("Certification")) chCertification.Checked = true;
                            else if (extra.Equals("Notes")) chNotes.Checked = true;
                            else if (extra.Equals("Internship")) chInternship.Checked = true;
                        }
                    }
                }
            }
        }
    }
}