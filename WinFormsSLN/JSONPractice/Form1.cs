using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JSONPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Function to save json file
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog()
            {
                Title = "Save your file",
                Filter = "JSON File (*.json)|*.json"
            };

            Details data = new Details()
            {
                Name = TxtName.Text,
                Age = TxtAge.Text,
                Email = TxtEmail.Text,
                Phone = TxtPhone.Text
            };

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                string dataJson = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(saveFile.FileName, dataJson);
                ClearFields();
            }
        }

        // Function to clear fields.
        void ClearFields()
        {
            TxtName.Clear();
            TxtAge.Clear();
            TxtEmail.Clear();
            TxtPhone.Clear();
        }

        // Function to load json data
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Title = "Open JSON File",
                Filter = "JSON Files (*.json)|*.json"
            };

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(openFile.FileName);

                if(data.Length > 0)
                {
                    Details details = JsonConvert.DeserializeObject<Details>(data);

                    TxtName.Text = details.Name;
                    TxtAge.Text = details.Age;
                    TxtEmail.Text = details.Email;
                    TxtPhone.Text = details.Phone;
                }
                else
                {
                    MessageBox.Show("File Was Empty!");
                }
            }
        }
    }
}