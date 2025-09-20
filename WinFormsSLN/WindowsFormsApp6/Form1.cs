using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void increase_Click(object sender, EventArgs e)
        {
            if(count < 999)
            {
                count++;
                counter.Text = count.ToString();
            }
        }

        private void decrease_Click(object sender, EventArgs e)
        {
            if(count > -999)
            {
                count--;
                counter.Text = count.ToString();
            }
        }
    }
}
