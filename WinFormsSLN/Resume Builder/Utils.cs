using Newtonsoft.Json;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Resume_Builder
{
    internal class Utils
    {
        // My Helper Method to check if the fields are filled or not
        public static bool AllFieldsFilled(params string[] fields)
        {
            return fields.All(f => !string.IsNullOrEmpty(f));
        }

        // Save files into text format
        public static bool SaveToText(Resume resume)
        {
            // Setting up the save file dialog box here.
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save your file",
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (Utils.AllFieldsFilled(resume.Name, resume.Age, resume.Email, resume.Phone, resume.Address, resume.Degree, resume.Year, resume.University, resume.Gender))
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder($"Name: {resume.Name}\nAge: {resume.Age}\nGender: {resume.Gender}\nEmail: {resume.Email}\nPhone: {resume.Phone}\nAddress: {resume.Address.Replace("\n", " ")}\nDegree: {resume.Degree}\nYear: {resume.Year}\nUniversity: {resume.University}\nSkills: {resume.SkillsStr}\nCompany: {resume.Company}\nRole: {resume.Role}\nExperience: {resume.Exp}\nSummary: {resume.Summary}");
                    
                    File.WriteAllText(saveFile.FileName, sb.ToString());
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Please fill out all the details or check if the details are valid!");
            }

            return false;
        }

        // Save files into json format
        public static bool SaveToJson(Resume resume)
        {
            // Setting up the save file dialog box here.
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save your file",
                Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*"
            };

            if (AllFieldsFilled(resume.Name, resume.Age, resume.Email, resume.Phone, resume.Address, resume.Degree, resume.Year, resume.University, resume.Gender))
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string json = JsonConvert.SerializeObject(resume, Formatting.Indented);

                    File.WriteAllText(saveFile.FileName, json);
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Please fill out all the details or check if the details are valid!");
            }

            return false;
        }
    }
}