using OOP7Dz.Entity;
using OOP7Dz.View;
namespace OOP7Dz.Model
{
    public class Teacher : Person, Skill
    {
        private Lesson lesson;

        public Lesson Lesson { get => lesson; set => lesson = value; }

        public Teacher(string name, int age, Lesson lesson) : base(name, age)
        {
            this.lesson = lesson;
        }

        public void printSkill()
        {
            
            Console.WriteLine("Меня зовут " + base.Name + ". Мой придмет " + Print.PrintLesson(this.lesson));
        }

    }
}
