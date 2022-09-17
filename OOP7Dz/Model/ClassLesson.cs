using OOP7Dz.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7Dz.Model
{
    internal class ClassLesson
    {
        private Teacher teacher;
        private Lesson lesson;
        private List<Student> students;

        public ClassLesson(Teacher teacher, Lesson lesson, List<Student> students)
        {
            this.teacher = teacher;
            this.lesson = lesson;
            this.students = students;
        }

        public Teacher Teacher { get => teacher; set => teacher = value; }
        public Lesson Lesson { get => lesson; set => lesson = value; }
        public List<Student> Students { get => students; set => students = value; }
               

    }
}
