using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string skill = txtSkill.Text.Trim();

            if(!string.IsNullOrEmpty(skill) )
            {
                lstSkills.Items.Add(skill);
                txtSkill.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a skill before adding.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstSkills.SelectedIndex != -1) // If something is selected.
            {
                lstSkills.Items.RemoveAt(lstSkills.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a skill to remove.");
            }
        }
    }
}
