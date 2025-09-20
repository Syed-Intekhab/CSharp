using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sfd_ofd_practice_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> eventList = new List<string>();

            // Get user details
            string name = txtName.Text.Trim();
            bool minor = rdoU18.Checked;
            bool adult = rdo18p.Checked;
            bool old = rdo30p.Checked;

            // Get events
            if (chkSinging.Checked) eventList.Add("Singing");
            if (chkDancing.Checked) eventList.Add("Dancing");
            if (chkPainting.Checked) eventList.Add("Painting");
            if (chkCoding.Checked) eventList.Add("Coding");

            // Check Which Age Group Selected
            string ageGroup = "";
            if (minor) ageGroup = "Under 18";
            else if (adult) ageGroup = "18 - 30";
            else if (old) ageGroup = "30+";

            // Make Events String From List
            string events;
            if(eventList.Count > 0)
            {
                events = string.Join(", ", eventList);
            }
            else
            {
                events = "Not participated!";
            }

            if (!string.IsNullOrEmpty(name) && (minor || adult || old))
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Save your file";
                saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string data = $"Name: {name}\nAge: {ageGroup}\nEvents: {events}";

                    File.WriteAllText(saveFile.FileName, data);
                    MessageBox.Show("Information Saved Successfully!");

                    txtName.Text = "";
                    chkCoding.Checked = false;
                    chkDancing.Checked = false;
                    chkPainting.Checked = false;
                    chkSinging.Checked = false;
                    rdo18p.Checked = false;
                    rdo30p.Checked = false;
                    rdoU18.Checked = false;
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
                char[] delimeters = { ',', ' '};

                foreach(string s in data)
                {
                    if (s.StartsWith("Name:"))
                    {
                        txtName.Text = s.Replace("Name:", "").Trim();
                    }
                    else if (s.StartsWith("Age:"))
                    {
                        string age = s.Replace("Age:", "").Trim();

                        if (age.Equals("Under 18"))
                            rdoU18.Checked = true;
                        else if (age.Equals("18 - 30"))
                            rdo18p.Checked = true;
                        else if (age.Equals("30+"))
                            rdo30p.Checked = true;
                    }
                    else if (s.StartsWith("Events:"))
                    {
                        string[] events = s.Replace("Events:", "").Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

                        foreach(string ev in events)
                        {
                            if (ev.Equals("Singing")) chkSinging.Checked = true;
                            else if (ev.Equals("Dancing")) chkDancing.Checked = true;
                            else if (ev.Equals("Painting")) chkPainting.Checked = true;
                            else if (ev.Equals("Coding")) chkCoding.Checked = true;
                        }
                    }
                }
            }
        }
    }
}
