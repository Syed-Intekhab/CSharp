// Create a Skill class and store a list of skills in it using a List<string>.
using System;
using System.Collections.Generic;

namespace SkillList{
    class Skill{
        public List<string> Skills { get; set; }
        
        public Skill(){
            Skills = new List<string>();
        }
        
        public void AddSkill(string skill){
            Skills.Add(skill);
        }
        
        public void displaySkills(){
            Console.WriteLine("Skills: ");
            foreach(string skill in Skills){
                Console.WriteLine(skill);
            }
        }
    }
    
    class Program{
        static void Main(String[] args){
            Skill mySkills = new Skill();
            
            mySkills.AddSkill("Coding");
            mySkills.AddSkill("Reading");
            mySkills.AddSkill("Learning");
            
            mySkills.displaySkills();
        }
    }
}