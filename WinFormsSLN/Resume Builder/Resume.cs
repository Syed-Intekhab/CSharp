using System.Collections.Generic;
using System.Linq;

namespace Resume_Builder
{
    class Resume
    {
        private string _name;
        private string _age;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!value.Any(char.IsDigit))
                    _name = value;
                else
                    _name = "";
            }
        }
        public string Age
        {
            get { return _age; }
            set
            {
                if (!value.Any(char.IsLetter))
                    _age = value;
                else
                    _age = "";
            }
        }
        public string Email {  get; set; }
        public string Phone {  get; set; }
        public string Address {  get; set; }
        public string Degree {  get; set; }
        public string Year {  get; set; }
        public string University {  get; set; }
        public string Company {  get; set; }
        public string Role {  get; set; }
        public string Exp {  get; set; }
        public string Gender { get; set; }
        public string Summary { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public string SkillsStr
        {
            get { return Skills != null && Skills.Count > 0 ? string.Join(", ", Skills) : "";  }
        }
    }
}
