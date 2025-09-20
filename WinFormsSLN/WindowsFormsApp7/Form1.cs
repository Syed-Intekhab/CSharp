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

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = "data.txt";

            if (!string.IsNullOrEmpty(txtContent.Text))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Write(txtContent.Text);
                    txtContent.Text = "";
                    MessageBox.Show("Data Written Successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Something Inside Text Box!");
            }
        }
    }
}
