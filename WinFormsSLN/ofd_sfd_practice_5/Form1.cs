using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ofd_sfd_practice_5
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

            // Retrieve User Details
            string name = txtName.Text.Trim();

            // CheckBoxes
            List<string> features = new List<string>();

            if (chkChat.Checked) features.Add("Chat");
            if (chkFileUpload.Checked) features.Add("File Upload");
            if (chkNotification.Checked) features.Add("Notifications");
            if (chkReports.Checked) features.Add("Reports");

            // Radio Buttons
            bool excellent = rdoExcellent.Checked;
            bool good = rdoGood.Checked;
            bool average = rdoAverage.Checked;
            bool poor = rdoPoor.Checked;

            string experience = "";
            if (excellent) experience = "Excellent";
            else if (good) experience = "Good";
            else if (average) experience = "Average";
            else if (poor) experience = "Poor";

            // CheckBox String
            string featuresString = "Nothing Checked!";
            if (features.Count > 0)
            {
                featuresString = string.Join(", ", features);
            } 

            if (!string.IsNullOrEmpty(name) && (excellent || good || average || poor))
            {
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    string data = $"Name: {name}\nExperience: {experience}\nFeatures: {featuresString}";

                    File.WriteAllText(saveFile.FileName, data);
                    MessageBox.Show("Information saved successfully!");

                    txtName.Text = "";
                    rdoExcellent.Checked = false;
                    rdoAverage.Checked = false;
                    rdoGood.Checked = false;
                    rdoPoor.Checked = false;
                    chkChat.Checked = false;
                    chkFileUpload.Checked = false;
                    chkNotification.Checked = false;
                    chkReports.Checked = false;
                }
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
                char[] delimeters = { ','};

                foreach(string s in data)
                {
                    if (s.StartsWith("Name:"))
                    {
                        txtName.Text = s.Replace("Name:", "").Trim();
                    }
                    else if (s.StartsWith("Experience:"))
                    {
                        string experience = s.Replace("Experience:", "").Trim();

                        if (experience.Equals("Excellent")) rdoExcellent.Checked = true;
                        else if (experience.Equals("Average")) rdoAverage.Checked = true;
                        else if (experience.Equals("Good")) rdoGood.Checked = true;
                        else if (experience.Equals("Poor")) rdoPoor.Checked = true;
                    }
                    else if (s.StartsWith("Features:"))
                    {
                        string[] features = s.Replace("Features:", "").Trim().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string feature in features)
                        {
                            if (feature.Trim().Equals("Chat")) chkChat.Checked = true;
                            else if (feature.Trim().Equals("File Upload")) chkFileUpload.Checked = true;
                            else if (feature.Trim().Equals("Notifications")) chkNotification.Checked = true;
                            else if (feature.Trim().Equals("Reports")) chkReports.Checked = true;

                        }
                    }
                }
            }
        }
    }
}
