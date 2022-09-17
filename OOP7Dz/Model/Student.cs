using OOP7Dz.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7Dz.Model
{
    public class Student : Person,Skill
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public void printSkill()
        {
            Console.WriteLine("Меня зовут " + base.Name + " Навыков нет, я только учусь");
        }
    }
   
}