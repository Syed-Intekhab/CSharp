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

namespace sfd_ofd_practice_1
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

            if (!string.IsNullOrEmpty(txtName.Text.Trim()) && (rdoMale.Checked || rdoFemale.Checked))
            {
                string name = txtName.Text.Trim();
                string gender = rdoMale.Checked ? "Male" : "Female";

                string data = $"Name: {name}\n" +
                    $"Gender: {gender}";

                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFile.FileName, data);
                    MessageBox.Show("Data saved successfully!");

                    txtName.Text = "";
                    rdoFemale.Checked = false;
                    rdoMale.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Details.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string[] data = File.ReadAllLines(openFile.FileName);

                foreach(string s in data)
                {
                    if(s.StartsWith("Name:"))
                        txtName.Text = s.Replace("Name:", "").Trim();
                    else if (s.StartsWith("Gender:"))
                    {
                        if (s.Replace("Gender:", "").Trim().Equals("Male"))
                            rdoMale.Checked = true;
                        else
                            rdoFemale.Checked = true;
                    }
                        
                }
            }
        }
    }
}
