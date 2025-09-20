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

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\tauseef quazi\\source\\repos\\Intekhab\\WindowsFormsApp7\\bin\\Debug\\data.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string content = sr.ReadToEnd();
                    txtLoad.Text = content;
                }
            }
            else
            {
                txtLoad.Text = "File Not Found!";
            }
        }
    }
}
